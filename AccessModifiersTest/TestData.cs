using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiersTest
{
    public class TestData
    {
        public int publicInt = 42;

        internal int internalInt = 42;

        protected int protectedInt = 42;

        private int privateInt = 42;

        private protected int privateProtectedInt = 42;

        protected internal int protectedInternalInt = 42;

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
