using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Sum of odd numbers from array
            //int[] arr = { 1, 4, 5, 7, 8, 9, 10 };


            //var result = SumOfOddNums(arr);

            //result += 2;

            //Console.WriteLine(result);
            #endregion

            #region Check Number Type
            CheckNumberType(1);
            #endregion


        }


        #region Check Number Type
        static void CheckNumberType(int num)
        {
            int count = 0;

            if (num <= 1)
            {
                Console.WriteLine("Please add correct number");
                return;
            }


            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }

            if (count > 2)
            {
                Console.WriteLine("Composite");
            }
            else
            {
                Console.WriteLine("Primary");
            }





        }
        #endregion



        #region Sum of odd numbers from array
        static int SumOfOddNums(int[] numbers)
        {
            int sum = 0;

            //foreach (var item in numbers)
            //{
            //    if(IsOdd(item))
            //    {
            //        sum += item;
            //    }
            //}

            for (int i = 0; i < numbers.Length; i++)
            {
                if (IsOdd(numbers[i]))
                {
                    sum += numbers[i];
                }
            }

            return sum;

        }


        static bool IsOdd(int num)
        {
            if (num % 2 == 1)
                return true;

            return false;
        }
        #endregion







    }
}
