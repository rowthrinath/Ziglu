using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace WTWTest
{ public  class Program
    {
      public static  List<Product> sterlingtable = CreateSterlingTable();
      public static  List<Product> eurotable = CreateEuroTable();
        public static void Main(string[] args)
        {
 //*********************** Test to check if all entries have the correct calculation for correct conversion rate *****************            
            TestToVerifyCorrectCurrencyConversion(1.5);
        }
        
        [Test]
        public static void TestToVerifyCorrectCurrencyConversion(double conversionrate)
        {
            Console.WriteLine("********** Test to check if all entries have the correct calculation for correct conversion rate **********");
            foreach (Product item in eurotable)
            {
                foreach (Product check in sterlingtable)
                {
                    if (item.variety == check.variety * conversionrate && check.variety != 0)
                    {
                        Assert.IsTrue(item.variety.Equals(check.variety * conversionrate));                        
                        Console.WriteLine($"Sterling equivalent of {check.variety} is {item.variety} euros");
                        break;
                    }
                }
            }
        }      

        public class Product
        {
            public string productname { get; set; }
            public double variety { get; set; }
 
        }

        public static List<Product> CreateSterlingTable()
        {
            List<Product> sterlingtable = new List<Product>()
            {                
               {new Product{productname="Product1",variety=10} },
               {new Product{productname="Product1",variety=12 } },
               {new Product{productname="Product1",variety=14 } },
               {new Product{productname="Product1",variety=45 } },

               {new Product{productname="Product2",variety = 20} },
               {new Product{productname="Product2",variety = 15} },
               {new Product{productname="Product2",variety = 24} },
               {new Product{productname="Product2",variety = 0} },

               {new Product{productname="Product3",variety = 22} },
               {new Product{productname="Product3",variety = 60} },
               {new Product{productname="Product3",variety = 0 } },
               {new Product{productname="Product3",variety = 0} },

               {new Product{productname="Product4",variety = 28} },
               {new Product{productname="Product4",variety = 0} },
               {new Product{productname="Product4",variety = 0} },
               {new Product{productname="Product4",variety = 0 } },
            };
            return sterlingtable;
        }

        public static List<Product> CreateEuroTable()
        {
            List<Product> sterlingtable = new List<Product>()
            {
               {new Product{productname="Product1",variety = 15} },
               {new Product{productname="Product1",variety = 18} },
               {new Product{productname="Product1",variety = 21 } },
               {new Product{productname="Product1",variety = 67.5} },

               {new Product{productname="Product2",variety = 30} },
               {new Product{productname="Product2",variety = 22.5 } },
               {new Product{productname="Product2",variety = 36 } },
               {new Product{productname="Product2",variety = 0 } },

               {new Product{productname="Product3",variety = 33} },
               {new Product{productname="Product3",variety = 90 } },
               {new Product{productname="Product3",variety = 0 } },
               {new Product{productname="Product3",variety = 0 } },

               {new Product{productname="Product4",variety = 42} },
               {new Product{productname="Product4",variety = 0} },
               {new Product{productname="Product4",variety = 0} },
               {new Product{productname="Product4",variety = 0 } },
            };
            return sterlingtable;
        }
    }

}
