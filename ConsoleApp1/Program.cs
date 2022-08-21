using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Tutorial see https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords
namespace ConsoleApp1
{
    class BaseClass
    {
        // for step 4 add the virtual modifier
        public void Method1()
        {
            Console.WriteLine("Base - Method1");
        }

        // Step 2 - uncomment Method2, uncomment calling in Main. Addition of the Method2 method in BaseClass causes a warning.
        //public void Method2()
        //{
        //    Console.WriteLine("Base - Method2");
        //}
    }

    class DerivedClass : BaseClass
    {
        // Step 3 - add the new modifier. The new keyword preserves the relationships that produce output in step 2, but it suppresses the warning.
        public void Method2()
        {
            Console.WriteLine("Derived - Method2");
        }

        // Step 4 - uncomment Method1, add the virtual modifier to base Method1
        //public override void Method1()
        //{
        //    Console.WriteLine("Derived - Method1");
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseBase = new BaseClass();
            DerivedClass derivedDerived = new DerivedClass();
            BaseClass baseDerived = new DerivedClass();

            // Step 1 - run the project
            baseBase.Method1();            // Base - Method1  
            derivedDerived.Method1();            // Base - Method1  
            derivedDerived.Method2();            // Derived - Method2
            baseDerived.Method1();          // Base - Method1    // Derived - Method1 (after step 4). 
            #region The use of the override modifier enables bcdc to access the DerivedClass's Method1.
            // Typically, that is the desired behavior in inheritance hierarchies. 
            // You want objects that have values that are created from the derived class to use the methods that are defined in the derived class. 
            // You achieve that behavior by using override to extend the base class method.
            #endregion


            // uncomment for step 2
            //baseBase.Method2();          // Base - Method2
            //baseDerived.Method2();        // Base - Method2

            Console.ReadKey();
        }
    }
}
