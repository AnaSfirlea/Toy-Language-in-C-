using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyLanguageCS.DataStructures
{
	interface MyIDictionary<K,V>
	{
		ICollection<V> values();
		ICollection<K> keys();
		bool empty();
		V get(int idx);
		void remove(K key);
		void put(K key, V value);
		int size();
		bool isDefined(K key);
		bool containsVal(V val);
		V getValue(K key);
	}
}
