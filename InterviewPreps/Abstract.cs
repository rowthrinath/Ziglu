using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPreps
{
    public abstract class BaseClass

    {
        public abstract void AbstractMethod();

    }

    public class BaseClass1 : BaseClass
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Implementation of abstraction BaseClass1");
        }
    }

    public class BaseClass2 : BaseClass
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Implementation of abstraction BaseClass2");
        }
    }
}
