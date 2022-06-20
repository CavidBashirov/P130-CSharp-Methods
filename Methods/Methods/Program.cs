using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {



            //string[] names = { "Orxan", "Emil", "Seid", "Cavidan" };
            //bool isStudent = true;
            //StudentNames(names, isStudent);

            //Sum(6, 8);


            //var sum = SumAges(33,23);

            //sum += 10;

            //Console.WriteLine(sum);

            //string name = "Orxan";
            //string surname = "Akbarov";
            //int age = 26;

            //string fullName = FullName(name, surname,age);

            //Console.WriteLine(fullName);

            //int[] ages = { 33, 44, 57, 88, 104, 18 };

            //foreach (int item in ages)
            //{
            //    if (IsOld(item))
            //    {
            //        Console.WriteLine("Old");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Young");
            //    }


            //}



            //Test1("sadasdas");
            //Test1(55);
            //Test1(true);

            //SumNums(6,5,1);

            SumNumbers(3, 10);

            var result = Sum(4, 18);

            Console.WriteLine(result + 6);


        }


       
        static void SumNumbers(int n, int m)
        {
            int sum = 0;

            for (int i = n; i <= m; i++)
            {
                if(i%2 == 1)
                {
                    sum += i;
                }
            }


            Console.WriteLine(sum);
        }

        
        static int Sum(int n, int m)
        {
            int sum = 0;

            for (int i = n; i <= m; i++)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                }
            }

            return sum;

            
        }


        //static void SumNums(int m, int n = 5, int t = 88)
        //{
        //    Console.WriteLine(m+n+t);
        //}



        //static void Test1(bool isMarried)
        //{
        //    Console.WriteLine("Evlidir");
        //}

        //static void Test1(int num1)
        //{
        //    Console.WriteLine("Reqemdir");
        //}

        //static void Test1(string isMarried)
        //{
        //    Console.WriteLine("Duzgundur");
        //}

        //static string FullName(string name, string surname, int age)
        //{
        //    //return name + " " + surname;

        //    var result = $"Fullname:  {name} {surname} - Age: {age}";

        //    return result;
        //}

        //static bool IsOld(int age)
        //{
        //    if (age > 45)
        //    {
        //        return true;
        //    }

        //    return false;

        //}

        //static bool IsOld(int age) => age > 45 ? true : false;




        //static void Sum(int m, int n)
        //{
        //    var sum = m + n;
        //    Console.WriteLine(sum);
        //}

        //static void StudentNames(string[] names, bool isStudent)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        if (isStudent)
        //        {
        //            Console.WriteLine(i + "-" + names[i]);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Not student");
        //        }

        //    }

        //}

        //static int SumAges(int age1, int age2)
        //{
        //    return age1 + age2;
        //}




    }
}
