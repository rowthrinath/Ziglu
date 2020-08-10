using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPreps
{
    public class Product
    {
        public Product()
        {
        }

        public Product(string name, int newID)
        {
            ItemName = name;
            ItemID = newID;
        }

        public string ItemName { get; set; }
        public int ItemID { get; set; }



        public static int ChangeByReference(ref Product itemRef)
        {
            // Change the address that is stored in the itemRef parameter.
            itemRef = new Product("Stapler", 99999);

            // You can change the value of one of the properties of
            // itemRef. The change happens to item in Main as well.
           return itemRef.ItemID = 12345;
        }

        public static int ModifyProductsByReference()
        {
            // Declare an instance of Product and display its initial values.
            Product item = new Product("Fasteners", 54321);
            System.Console.WriteLine("Original values in Main.  Name: {0}, ID: {1}\n",
                item.ItemName, item.ItemID);

            // Pass the product instance to ChangeByReference.
        return    ChangeByReference(ref item);
            System.Console.WriteLine("Back in Main.  Name: {0}, ID: {1}\n",
                item.ItemName, item.ItemID);
        }
    }
}