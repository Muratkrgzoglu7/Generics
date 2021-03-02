using System;
using System.Collections.Generic;

namespace Generics

{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> sehirler1 = new List<string>();
			sehirler1.Add("Ankara");
			sehirler1.Add("Ankara");
			sehirler1.Add("Ankara");
			sehirler1.Add("Ankara");
			Console.WriteLine(sehirler1.Count);
		
			

			MyList<string> sehirler2 = new MyList<string>();
			sehirler2.Add("elazığ");
			sehirler2.Add("Ankara");
			sehirler2.Add("Ankara");
			sehirler2.Add("Ankara");
			Console.WriteLine(sehirler2.Count);
			
		}
		
		class MyList<T>
		{
			T[] _arrays;
			T[] _tempArrays;
			public MyList()
			{
				_arrays = new T[0];
			}
			public void Add(T item)
			{
				_tempArrays = _arrays;
				_arrays = new T[_arrays.Length + 1];
				for (int i = 0; i < _tempArrays.Length; i++)
				{
					_arrays[i] = _tempArrays[i];
					_arrays[_tempArrays.Length - 1] = item;
				}
				
			}
		

			public int Count
			{
				get { return _arrays.Length; }
				
			}

		}
		

	}
}
