using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new MyClass { MyProperty1 = 100, MyProperty2 = 500 } );
        }

        
    }

    public class MyClass
    {
        public int MyProperty1 { get; set; }

        public int MyProperty2 { get; set; }

        public override string ToString()
        {
            return $"P1 - {MyProperty1}  P2 - {MyProperty2}";
        }

    }
}
