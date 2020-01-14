using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // defining array with size 5. add values later on
             int[] intArray1 = new int[5];

             // defining array with size 5 and adding values at the same time
             int[] intArray2 = new int[5] { 1, 2, 3, 4, 5 };

             // defining array with 5 elements which indicates the size of an array
             int[] intArray3 = { 3, 2, 5, 4, 1 };

             //sort in descending order
             Array.Sort(intArray3);
             Array.Reverse(intArray3);            
             foreach (int value in intArray3)
                 Console.Write(value + " ");
             Console.WriteLine();

             //late initialisation
             string[] strArray1, strArray2;

             //late initialisation requires the "new" keyword
             strArray1 = new string[5]{ "1st Element",
                 "2nd Element",
                 "3rd Element",
                 "4th Element",
                 "5th Element"
                           };

             strArray2 = new string[]{ "1st Element",
                 "2nd Element",
                 "3rd Element",
                 "4th Element",
                 "5th Element"
                           };

             //Returns the highest index of the specified dimension.
             Console.WriteLine(strArray1.GetLength(0));

             //Returns the value at the specified index.
             Console.WriteLine(strArray1.GetValue(2));

             //sort in ascending order using LINQ
             strArray2 = strArray2.OrderBy(c => c).ToArray();

             // print all elements of array 
             foreach (string value in strArray2)
             {
                 Console.Write(value + " ");
             }
             Console.WriteLine();

             //sort in descending order using LINQ
             strArray2 = strArray2.OrderByDescending(c => c).ToArray();

             // print all elements of array 
             foreach (string value in strArray2)
             {
                 Console.Write(value + " ");
             }
             Console.WriteLine();

             //creating array that starts at a custom index, other than 0
             Array array = Array.CreateInstance(typeof(int), new int[] { 5 }, new int[] { 2 });

             array.SetValue(1, 2);
             array.SetValue(2, 3);
             array.SetValue(3, 4);
             array.SetValue(4, 5);
             array.SetValue(5, 6);

             for (int i = 2; i <=array.Length+1; i++)
                 Console.WriteLine("Array value {0} at position {1}", array.GetValue(i), i);

             //2 dimesnisonal arrays
             int[,] intArray = new int[3, 2]{
                                             {1, 2},
                                             {3, 4},
                                             {5, 6}
                                            };

             Console.WriteLine(intArray[0, 0]); //Output: 1
             Console.WriteLine(intArray[1, 0]); // 3
             Console.WriteLine(intArray[2, 1]); // 6

             //jagged arrays always store one or more arrays
             int[][] intJaggedArray = new int[2][];

             intJaggedArray[0] = new int[3] { 1, 2, 3 };
             intJaggedArray[1] = new int[2] { 4, 5 };

             Console.WriteLine(intJaggedArray[0][0]); // 1
             Console.WriteLine(intJaggedArray[0][2]); // 3
             Console.WriteLine(intJaggedArray[1][1]); // 5

             //jagged array with multi-dimensional arrays
             int[][,] integerJaggedArray = new int[3][,];
             integerJaggedArray[0] = new int[3, 2] { { 1, 2 }, 
                                                     { 3, 4 }, 
                                                     { 5, 6 } 
                                                    };

             integerJaggedArray[1] = new int[2, 2] { 
                                                     { 3, 4 }, 
                                                     { 5, 6 } 
                                                    };

             integerJaggedArray[2] = new int[2, 2];

             Console.WriteLine(integerJaggedArray[0][1, 1]); // 4
             Console.WriteLine(integerJaggedArray[1][1, 0]); // 5
             Console.WriteLine(integerJaggedArray[1][1, 1]); // 6
             Console.WriteLine(integerJaggedArray[2][1, 1]); //0

             Console.WriteLine();

             List<object> myList = new List<object>();
             myList.Add(5); //boxing (implicit)
             myList.Add("name");
             for(int i=0; i<myList.Count; i++)
                 Console.WriteLine(myList[i]); 

            int[] myArray = { 1, 4, 3, 2 };
            Console.WriteLine(array.GetValue(2));
            Console.WriteLine("Lower bound: " + myArray.GetLowerBound(1).ToString());
            Array.Sort(myArray);
            Console.WriteLine("MyArray:");
            for(int q = 0; q<myArray.Length; q++)
                Console.Write(myArray.GetValue(q) + " ");
            Console.WriteLine();
            Array.Reverse(myArray);
            for (int i = 0; i < myArray.Length; i++)
                Console.Write(myArray.GetValue(i) + " ");

        }
    }
}
