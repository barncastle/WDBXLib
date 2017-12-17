using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using WDBXLib.Attributes;
using WDBXLib.Extensions;
using WDBXLib.Helpers;
using WDBXLib.Reader;
using WDBXLib.Reader.FileTypes;

namespace WDBXLib.Storage
{
	public class DBEntry<T> where T : class
	{
		public readonly DBHeader Header;
		public readonly string FilePath;
		public readonly RowCollection<T> Rows;
		public readonly PropertyInfo PrimaryKey;

		public PropertyInfo[] TableStructure => Header.TableStructure;
		public IReadOnlyCollection<uint> Padding;
		public readonly uint Build;

		public DBEntry(DBHeader header, string filepath, uint build)
		{
			this.Header = header;
			this.FilePath = filepath;

			Header.TableStructure = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
			this.PrimaryKey = this.TableStructure.FirstOrDefault(x => x.GetAttribute<DBKeyAttribute>() != null);

			if (PrimaryKey == null)
				throw new Exception("Primary Key must not be null.");

			if (PrimaryKey.PropertyType != typeof(int))
				throw new Exception("Primary Key must be an int.");

			this.Rows = new RowCollection<T>(this.PrimaryKey);
			this.Padding = this.TableStructure.Select(x => x.GetAttribute<DBFieldAttribute>()?.Padding ?? 0).ToArray();
			this.Build = build;
		}

		/// <summary>
		/// Generates a Bit map for all columns as the Blizzard one combines array columns
		/// </summary>
		/// <returns></returns>
		public FieldStructureEntry[] GetBits()
		{
			FieldStructureEntry[] bits = new FieldStructureEntry[TableStructure.Length];
			if (!Header.IsTypeOf<WDB5>())
				return bits;

			int c = 0, f = 0;
			for (int i = 0; i < TableStructure.Length; i++)
			{
				var dbField = TableStructure[i].GetCustomAttribute<DBFieldAttribute>();
				if (dbField != null && dbField.Bits > -1)
				{
					bits[c] = new FieldStructureEntry(dbField.Bits, 0, (byte)Convert.ChangeType((dbField.DefaultValue ?? 0xFF), TypeCode.Byte));
				}
				else
				{
					FieldStructureEntry field = Header.FieldStructure[f];
					bits[c] = new FieldStructureEntry(field?.Bits ?? 0, 0, field?.CommonDataType ?? 0xFF);
					f++;
				}
				
				c++;
			}

			return bits;
		}


		#region Special Data
		/// <summary>
		/// Gets the Min and Max ids
		/// </summary>
		/// <returns></returns>
		public Tuple<int, int> MinMax()
		{
			int min = int.MaxValue;
			int max = int.MinValue;

			foreach (T dr in Rows)
			{
				int val = (int)PrimaryKey.GetValue(dr);
				min = Math.Min(min, val);
				max = Math.Max(max, val);
			}

			return new Tuple<int, int>(min, max);
		}

		/// <summary>
		/// Gets a list of Ids
		/// </summary>
		/// <returns></returns>
		public IEnumerable<int> GetPrimaryKeys()
		{
			for (int i = 0; i < Rows.Count; i++)
				yield return (int)PrimaryKey.GetValue(Rows[i]);
		}

		/// <summary>
		/// Produces a list of unique rows (excludes key values)
		/// </summary>
		/// <returns></returns>
		public IEnumerable<T> GetUniqueRows()
		{
			DBRowComparer<T> comparer = new DBRowComparer<T>(PrimaryKey);
			return Rows.AsEnumerable().Distinct(comparer);
		}

		/// <summary>
		/// Generates a map of unqiue rows and grouped count
		/// </summary>
		/// <returns></returns>
		public IEnumerable<KeyValuePair<T, int[]>> GetCopyRows()
		{
			DBRowComparer<T> comparer = new DBRowComparer<T>(PrimaryKey);

			return Rows.AsEnumerable().GroupBy(r => r, comparer)
									  .Where(g => g.Count() > 1)
									  .Select(g => new KeyValuePair<T, int[]>(
										  g.Key,
										  g.Where(r => r != g.Key).Select(r => (int)comparer.PrimaryKey.GetValue(r)).ToArray()
									  ));
		}

		/// <summary>
		/// Extracts the id and the total length of strings for each row
		/// </summary>
		/// <returns></returns>
		public Dictionary<int, short> GetStringLengths()
		{
			Dictionary<int, short> result = new Dictionary<int, short>();
			IEnumerable<PropertyInfo> cols = TableStructure.Where(x => x.PropertyType == typeof(string));

			foreach (T row in Rows)
			{
				short total = 0;
				foreach (var c in cols)
				{
					short len = (short)Encoding.UTF8.GetByteCount(c.GetValue(row).ToString());
					total += (short)(len > 0 ? len + 1 : 0);
				}
				result.Add((int)PrimaryKey.GetValue(row), total);
			}

			return result;
		}
		#endregion

	}
}
