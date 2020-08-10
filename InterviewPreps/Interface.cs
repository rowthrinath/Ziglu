using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPreps
{
    interface Interface
    {
        void Show();
    }

    class InterfaceClass : Interface
    {
        public void Show()
        {
            Console.WriteLine("This is an interface definition");
        }
    }


}
