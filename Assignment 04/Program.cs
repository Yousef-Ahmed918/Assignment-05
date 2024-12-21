using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace Assignment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 19 . Write a program that prints an identity matrix using for loop
            /*Console.Write("Enter the array size: ");
            int.TryParse(Console.ReadLine(), out int size);
            int[,] arr = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        arr[i, j] = 1;
                    }
                    else
                    {
                        arr[i, j] = 0;
                    }
                }
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine(" ");
            }*/
            #endregion

            #region Question 20 Write a program in C# Sharp to find the sum of all elements of the array.
            /*int[,] arr = new int[,] { { 10, 20, 50, 60 }, { 2, 4, 6, 8 }, { 5, 15, 25, 35 } };
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sum += arr[i, j];
                }
            }
            Console.WriteLine($"The sum of the array elements:{sum}");*/
            #endregion

            #region Question 21 Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            /*Console.Write("Enter the size of the two arrays: ");
            int.TryParse(Console.ReadLine(), out int size);
            int[] arr1 = new int[size];
            int[] arr2 = new int[size];
            int[] arr3 = new int[size * 2];
            Console.WriteLine("Enter array 1 in ascending order: ");
            for (int i = 0; i < size; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter array 2 in ascending order: ");
            for (int i = 0; i < size; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            Array.Copy(arr1, arr3, size);
            Array.ConstrainedCopy(arr2,0,arr3,size,size);
            Array.Sort(arr3);
            foreach(int i in arr3)
            {
                Console.WriteLine(i);
            }*/

            #endregion

            #region Question 22 Write a program in C# Sharp to count the frequency of each element of an array.
            //int[] arr = new int[] { 1, 4, 3, 2, 2, 5, 1, 6, 7, 8, 1, 6 };
            //Array.Sort(arr);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int count = 0;
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine($"The number: {arr[i]} its Frequency: {count}");
            //}


            #endregion

            #region Question 23 Write a program in C# Sharp to find maximum and minimum element in an array
            /*int[] arr = new int[] { 1, -4, 3, -2, 2, -56, 1, 6, 7, 8, 1, 6, 22, 9 };
            int max = arr[0];
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"The max value is: {max} and the min value: {min} in this array");*/

            #endregion

            #region Question 24 Write a program in C# Sharp to find the second largest element in an array.
            /*int[] arr = new int[] { 1, -4, 3, -2, 2, -56, 1, 6, 7, 8, 1, 6, 22, 9, 540, 590 };
            int max = arr[0];
            int secondmax = arr[1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > secondmax && arr[i] != max)
                {
                    secondmax = arr[i];
                }
            }

            Console.WriteLine($"The Second max value is {secondmax} in this array");*/

            #endregion

            #region Question 25 write a program find the longest distance between Two equal cells.
            //Console.WriteLine("Enter the array size: ");
            //int.TryParse(Console.ReadLine(), out int size);
            //int[] arr= new int[size];
            //for(int i = 0; i < size; i++)
            //{
            //    arr[i]=int.Parse(Console.ReadLine());
            //}
            //int maxdis= 0;
            //for (int i = 0; i < arr.Length; i++)
            //{

            //    for (int j = 0; j < size; j++) {
            //        if (arr[i] == arr[j])
            //        {
            //            if(maxdis<(j-i))
            //            maxdis = (j - i)-1;
            //        }
            //            }

            //}
            //Console.WriteLine(maxdis);
            #endregion

            #region Question 26 Given a list of space separated words, reverse the order of the words.
            //string phrase=Console.ReadLine();
            //string[] sub = phrase.Split(" ");
            //string [] reverse=new string[sub.Length];
            //for (int i =0; i <sub.Length; i++)
            //{
            //    reverse[i]=(sub[sub.Length-1-i]);
            //}
            //string result=string.Join(" ",reverse);     
            //Console.Write(result);
            #endregion

            #region Question 27 Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.
            //int size=int.Parse(Console.ReadLine());
            //string[,] words = new string[size, size];
            //string[,] names = new string[size, size];
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        words[i, j] = Console.ReadLine();
            //    }
            //}
            //Array.Copy(words,names,words.Length);
            //foreach (String s in names)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion

            #region Question 28 Write a Program to Print One Dimensional Array in Reverse Order
            /*int[] arr = new int[] { 1, -4, 3, -2, 2, -56, 1, 6, 7, 8, 1, 6, 22, 9, 540, 590 };
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }*/
            #endregion

            #region Question 1 explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            //the diffrence between the passing by value and passing by refernces that 
            //in passing by references the varible it self is sent to the function 
            //where the result of the function change the value of the variables in the main 
            //and when passing by value it can be considered that a copy of the variables sent to the 
            //function and the result of the function doesnt change the value of the variables in the main
            //Ex
            //static void byvalue (int x, int y)
            //{
            //    int temp = x; 
            //    x=y; 
            //    y=temp;
            //}

            //static void byreferences(ref int x,ref int y)
            //{
            //    int temp = x;
            //    x = y;
            //    y = temp;
            //}

            //int a = 10,b=20;
            //byvalue(a,b);
            //Console.WriteLine("by value");
            //Console.WriteLine($"a value: {a} b value: {b}");
            //Console.WriteLine("by references");
            //byreferences(ref a,ref b);
            //Console.WriteLine($"a value: {a} b value: {b}");
            #endregion

            #region Question 2 Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

            /*tatic int sum(int num)
            {
                int sum = 0;
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                return sum;
            }
            Console.Write(sum(257));*/
            #endregion

            #region Question 3 Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not .
            /*static bool IsPrime(int num)
            {
                int count = 0;
                for (int i = 2; i <= num / 2; i++)
                {

                    if (num % i == 0)
                    {
                        count++;
                    }

                }
                if (count == 0 && num != 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            Console.WriteLine(IsPrime(1));*/

            #endregion


            #region Question 4 Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter .
            /*static int Factorial(int num)
            {


                int fac = 1;
                for (int i = 1; i <= num; i++)
                {
                    fac *= i;
                }
                return fac;
            }
            int.TryParse(Console.ReadLine(), out int num);
            Console.WriteLine(Factorial(num));*/
            #endregion

            #region Question 5 Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter .
            //static string ChangeChar(ref string name, int index, Char x)
            //{
            //    StringBuilder sb = new StringBuilder(name);
            //    sb[index-1] = x;
            //    return sb.ToString();
            //}
            //string name ="My name is youssef";
            //name=ChangeChar(ref name,2,'x');
            //Console.WriteLine(name);
            #endregion




        }
    }
            
}
