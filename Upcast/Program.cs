using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcast
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass instance = new DerivedClass();
            instance.field1 = 1;
            instance.field2 = 2;
            instance.field3 = 3;
            instance.field4 = 4;
            instance.field5 = 5;

            //Upcast

            BaseClass newinstace = (BaseClass)instance; // Upcast  ^
                                                        //         l
            Console.WriteLine(newinstace.field1);
            Console.WriteLine(newinstace.field2);
            Console.WriteLine(newinstace.field3);
            Console.WriteLine(new string('-',50));
            Console.WriteLine("Baseclass ID    {0}", newinstace.GetHashCode());
            Console.WriteLine("Derivedclass ID  {0}", instance.GetHashCode());

            Console.ReadKey();
        }
    }
}
