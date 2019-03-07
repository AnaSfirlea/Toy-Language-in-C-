using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyLanguageCS.DataStructures
{
	class MyDictionary<K,V> : MyIDictionary<K,V>
	{
		private Dictionary<K, V> dictionary;


		public MyDictionary()
		{
			this.dictionary = new Dictionary<K, V>();

		}

		public ICollection<V> values()
		{
			return dictionary.Values;
		}

		public ICollection<K> keys()
		{
			return dictionary.Keys;
		}

		public bool empty()
		{
			if (dictionary.Count() == 0)
				return true;
			return false;
		}
		public V getValue(K key)
		{
			V val = this.get(0); 
			ICollection <K> keys = dictionary.Keys;
			for (int i = 0; i < keys.Count(); i++)
			{
				if (Equals(keys.ElementAt(i),key))
				{
					val = this.get(i);
					break;
				}
			}
			return val;
		}
		public V get(int idx)
		{
			return dictionary.ElementAt(idx).Value;
		}
		public bool containsVal(V val)
		{
			return dictionary.ContainsValue(val);
		}
		public bool isDefined(K key)
		{
			return this.dictionary.ContainsKey(key);
		}
		public void remove(K key)
		{
			dictionary.Remove(key);
		}

		public void put(K key, V value)
		{
			if (this.isDefined(key))
				dictionary.Remove(key);

			dictionary.Add(key, value);
		}

		public int size()
		{
			return dictionary.Count();
		}


		public override string ToString()
		{
			string res = "";
			for (int i = 0; i < this.dictionary.Count(); i++)
			{
				res += "\n";
				res += this.dictionary.ElementAt(i).Key;
				res += "=";
				res += this.dictionary.ElementAt(i).Value;
			}
			return res;
		}
	}
}
