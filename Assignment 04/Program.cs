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



            #endregion

            #region Question 22 Write a program in C# Sharp to count the frequency of each element of an array.
            /*int[] arr = new int[] { 1, 4, 3, 2, 2, 5, 1, 6, 7, 8, 1, 6 };
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine($"The number: {arr[i]} its Frequency: {count}");
            }*/


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

            #region Question 28 Write a Program to Print One Dimensional Array in Reverse Order
            /*int[] arr = new int[] { 1, -4, 3, -2, 2, -56, 1, 6, 7, 8, 1, 6, 22, 9, 540, 590 };
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }*/
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


            #region Question 4
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

            #region Question 5
            static void ChangeChar(ref String name, int index, Char x)
            {
                name
    

        }



            #endregion
        }
    }
}
