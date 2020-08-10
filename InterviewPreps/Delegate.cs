
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPreps
{
    public delegate string Delegate(string message);
    public class DelegateClass
    {
        public static void Method1(string message)
        {
            Console.WriteLine(message);
        }

    }

}

