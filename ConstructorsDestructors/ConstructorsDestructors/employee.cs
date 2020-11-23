using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorsDestructors
{
    class employee
    {
       
        public employee()
        {
            Console.WriteLine("Constructor invoked");

        }
        ~employee()
        {
            Console.WriteLine("Destructor Invoked");
        }
    }
}
