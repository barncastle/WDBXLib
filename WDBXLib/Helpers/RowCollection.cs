using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WDBXLib.Helpers
{
	public class RowCollection<T> : IList<T> where T : class
	{
		private readonly PropertyInfo _primarykey;
		private readonly List<T> _rows;
		private readonly List<int> _keys;

		public RowCollection(PropertyInfo primarykey)
		{
			_primarykey = primarykey;
			_rows = new List<T>();
			_keys = new List<int>();
		}


		public T this[int index]
		{
			get => _rows[index];
			set
			{
				int id = GetId(value);
				FixKeys(id);

				if (_keys.Any(x => _keys.IndexOf(id) != index))
					throw new ArgumentException("An item with the same key has already been added.");

				_rows[index] = value;
				_keys[index] = id;
			}
		}

		public int Count => _rows.Count;

		public int NextKey => _keys.Max() + 1;

		public bool HasDuplicateKeys => _rows.GroupBy(x => GetId(x)).Any(g => g.Count() > 1);

		public bool IsReadOnly => false;


		public void Add(T item)
		{
			if (!CanAdd(item))
				throw new ArgumentException("An item with the same key has already been added.");

			if (GetId(item) <= 0)
				_primarykey.SetValue(item, NextKey);

			_rows.Add(item);
			_keys.Add(GetId(item));
		}

		public void AddRange(IEnumerable<T> collection)
		{
			if (collection.Any(x => !CanAdd(x)))
				throw new ArgumentException("An item with the same key has already been added.");

			_rows.AddRange(collection);
			_keys.AddRange(collection.Select(x => GetId(x)));
		}

		public void Clear()
		{
			_rows.Clear();
			_keys.Clear();
		}

		public bool Contains(T item) => _rows.Contains(item);

		public bool ContainsKey(int id) => _keys.Contains(id);

		public void CopyTo(T[] array, int arrayIndex) => _rows.CopyTo(array, arrayIndex);

		public bool Exists(Predicate<T> match) => _rows.Exists(match);

		public T Find(Predicate<T> match) => _rows.Find(match);

		public List<T> FindAll(Predicate<T> match) => _rows.FindAll(match);

		public T FindByKey(int id)
		{
			int index = _keys.IndexOf(id);
			return index < 0 ? null : _rows[index];
		}

		public int FindIndex(Predicate<T> match) => _rows.FindIndex(match);

		public T FindLast(Predicate<T> match) => _rows.FindLast(match);

		public int FindLastIndex(Predicate<T> match) => _rows.FindLastIndex(match);

		public IEnumerator<T> GetEnumerator() => _rows.GetEnumerator();

		public List<T> GetRange(int index, int count) => _rows.GetRange(index, count);

		public int IndexOf(T item) => _rows.IndexOf(item);

		public void Insert(int index, T item)
		{
			if (!CanAdd(item))
				throw new ArgumentException("An item with the same key has already been added.");

			_rows.Insert(index, item);
			_keys.Insert(index, GetId(item));
		}

		public void InsertRange(int index, IEnumerable<T> collection)
		{
			if (collection.Any(x => !CanAdd(x)))
				throw new ArgumentException("An item with the same key has already been added.");

			_rows.InsertRange(index, collection);
			_keys.InsertRange(index, collection.Select(x => GetId(x)));
		}

		public bool Remove(T item)
		{
			_keys.RemoveAll(x => x == GetId(item));
			return _rows.Remove(item);
		}

		public void RemoveAt(int index)
		{
			_keys.RemoveAt(index);
			_rows.RemoveAt(index);
		}

		public void RemoveByKey(int key)
		{
			int index = _keys.IndexOf(key);
			if (index >= 0)
			{
				_rows.RemoveAt(index);
				_keys.Remove(key);
			}
		}

		public void RemoveRange(int index, int count)
		{
			_rows.RemoveRange(index, count);
			_keys.RemoveRange(index, count);
		}

		public T[] ToArray() => _rows.ToArray();

		public bool TrueForAll(Predicate<T> match) => _rows.TrueForAll(match);


		IEnumerator IEnumerable.GetEnumerator() => _rows.GetEnumerator();


		private bool CanAdd(T item)
		{
			FixKeys(GetId(item));
			return !_keys.Contains(GetId(item));
		}

		private int GetId(T item) => (int)_primarykey.GetValue(item);

		private void FixKeys(int value)
		{
			int index = _keys.IndexOf(value);
			if (index > -1)
				_keys[index] = GetId(_rows[index]);
		}
	}
}
