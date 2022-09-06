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
                Console.WriteLine("Задаём первоначальный массив из строк:" );
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
                
                void SecondArray(string[] array1, string[] array2)
				{
					int count = 0;
                    Console.WriteLine("Вывод строк, длина которых <= 3 символа:" );
					for (int i = 0; i < array1.Length; i++)
  				    {
  					    if(array1[i].Length <= 3)
  					    {
  					     array2[count] = array1[i];
  					    count++;
  					    }
                    }
                }
            }
            //void Exercise();
        }
    }
}