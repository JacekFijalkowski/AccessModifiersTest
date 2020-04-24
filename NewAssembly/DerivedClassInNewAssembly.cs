using AccessModifiersTest;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewAssembly
{
    class DerivedClassInNewAssembly : TestData
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
