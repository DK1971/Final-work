using System;
using System.Linq;

namespace Exercise
{
    class Program
	{
		static void Main(string[] args)
		{	
 			void Exercise()
			{
                Console.WriteLine("Задан первоначальный массив из строк:" );
				string[] array1 = { "123", "zero", "one", "2", "two", "three", ":-)", "four"};
				string[] array2 = new string [array1.Length];

                void PrintArray (string[]array)
				{
					for (int i = 0; i < array.Length; i++)
					{
						Console.Write(array[i] + " ");
					}
					Console.WriteLine();
				}		
            }
        
        //void Exercise();
        }
    }
}