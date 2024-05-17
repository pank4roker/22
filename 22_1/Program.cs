using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.change = "не изменено";
            ClassTaker(myClass);
            Console.WriteLine($"{myClass.change}");
            MyStruct myStruct = new MyStruct();
            myStruct.change = "не изменено";
            StruktTaker(myStruct);
            Console.WriteLine($"{myStruct.change}");
            Console.ReadKey();


        }
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }

    }
}
