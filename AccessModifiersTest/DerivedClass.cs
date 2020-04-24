using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiersTest
{
    public class DerivedClass : TestData
    {
        void testAccess()
        {
            Console.WriteLine(publicInt);
            Console.WriteLine(internalInt);
            Console.WriteLine(protectedInt);
            Console.WriteLine(privateInt);
            Console.WriteLine(privateProtectedInt);
            Console.WriteLine(protectedInternalInt);
        }
    }
}
