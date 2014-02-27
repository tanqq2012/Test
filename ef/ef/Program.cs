using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.Unity;

namespace ef
{
    interface ITest
    {
        void Test();
    }

    class TestA : ITest
    {
        public void Test() { Console.WriteLine("A"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();

         






           
        }
    }
}
