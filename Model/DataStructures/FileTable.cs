using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyLanguageCS.DataStructures
{
	class FileTable<K,V> : IFileTable<K,V>
	{
		private Dictionary<K, V> filetable;


		public FileTable()
		{
			this.filetable = new Dictionary<K, V>();

		}

		public ICollection<V> values()
		{
			return filetable.Values;
		}

		public ICollection<K> keys()
		{
			return filetable.Keys;
		}

		public bool empty()
		{
			if (filetable.Count() == 0)
				return true;
			return false;
		}

		public V getValue(K key)
		{
			V val = this.get(0);
			ICollection<K> keys = filetable.Keys;
			for (int i = 0; i < keys.Count(); i++)
			{
				if (Equals(keys.ElementAt(i), key))
				{
					val = this.get(i);
					break;
				}
			}
			return val;
		}
		public V get(int idx)
		{
			return filetable.ElementAt(idx).Value;
		}

		public bool isDefined(K key)
		{
			return this.filetable.ContainsKey(key);
		}
		public void remove(K key)
		{
			filetable.Remove(key);
		}

		public void put(K key, V value)
		{
			 filetable.Add(key, value);
		}

		public int size()
		{
			return filetable.Count();
		}

		
		public override string ToString()
		{
			string res = "";
			for(int i=0;i<this.filetable.Count();i++)
			{
				res += "\n";
				res += this.filetable.ElementAt(i).Key;
				res += "=";
				res += this.filetable.ElementAt(i).Value;
			}
			return res;
		}
	}
}
