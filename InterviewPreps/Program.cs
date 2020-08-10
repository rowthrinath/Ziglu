using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace InterviewPreps
{

    class User
    {
        protected string Name;
        protected string Location;
        protected int Age;
        protected void GetUserDetails()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
            Console.WriteLine("Age: {0}", Age);
        }
    }
     class Program : User
    {
        static void Main(string[] args)
        {

            BaseClass baseClass;
            baseClass = new BaseClass1();
            baseClass.AbstractMethod();
            baseClass = new BaseClass2();
            baseClass.AbstractMethod();


            InterfaceClass _interface = new InterfaceClass();
            _interface.Show();

            Delegate _delegate = new Delegate();
         

          

            //Given an array of ints, write a C# method to total all the values that are even numbers.

            static long TotalAllEvenNumbers1(int[] intArray)
            {
                return intArray.Where(i => i % 2 == 0).Sum(i => (long)i);
            }

            static long TotalAllEvenNumbers2(int[] intArray)
            {
                return (from i in intArray where i % 2 == 0 select (long)i).Sum();
            }

            Console.WriteLine(TotalAllEvenNumbers1(new int[] { 2, 2, 2, 2, 2 }));
            Console.WriteLine(TotalAllEvenNumbers1(new int[] { 6, 6, 6, 6, 6, 6 }));

            //What is Jagged Arrays? Read from a jaggedarray

            int[][] jaggedarray3 =
                {
            new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 },
            new int[] { 9, 8, 7, 6, 5 },
            new int[] { 1, 2 }
        };
            for (int n = 0; n < jaggedarray3.Length; n++)
            {
                Console.WriteLine("Row({0}): ",n);

                for(int k=0; k<jaggedarray3[n].Length; k++)
                {
                    Console.WriteLine("{0}", jaggedarray3[n][k]);
                }
            }

            //Array List
            
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Rowth");
            arrayList.Add(40);
            arrayList.Add("Male");
            arrayList.Add(DateTime.Now.AddYears(-40));

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //Protected class

            //User u = new User();
            //Program p = new Program();
            //// Complier Error
            //// protected members can only accessible with derived classes
            ////u.Name = "Suresh Dasari";
            //p.Name = "Rowthrinath Natarajan";
            //p.Location = "London";
            //p.Age = 32;
            //p.GetUserDetails();
            //Console.WriteLine("\nPress Enter Key to Exit..");
            //Console.ReadLine();

       // Example: Adding or Apending Strings in StringBuilder
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello ");
            sb.AppendLine("World!");
            sb.AppendLine("Hello C#");
            Console.WriteLine(sb);

        //Example: AppendFormat()
            StringBuilder sbAmout = new StringBuilder("Your total amount is ");
            sbAmout.AppendFormat("{0:C} ", 25);
            Console.WriteLine(sbAmout);

        //Example: Insert()
        StringBuilder sb1 = new StringBuilder("Hello World!");
            sb1.Insert(5, " C#");
            Console.WriteLine(sb1); //output: Hello C# World!

        //Example: Remove()
            //StringBuilder sb2 = new StringBuilder("Hello World!", 50);
            //sb2.Remove(6, 7);
            //Console.WriteLine(sb2); //output: Hello

        //Example: Replace()
            StringBuilder sb3 = new StringBuilder("Hello World!");
            sb3.Replace("World", "C#");
            Console.WriteLine(sb3);//output: Hello C#!

            //What's the difference between the System.Array.CopyTo() and System.Array.Clone() ?


        }
    }
}
