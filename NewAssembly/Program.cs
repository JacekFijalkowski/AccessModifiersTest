using AccessModifiersTest;
using System;

namespace NewAssembly
{
    class Program
    {
        static void Main(string[] args)
        {
            TestData testData = new TestData();
            Console.WriteLine(testData.publicInt);
            Console.WriteLine(testData.internalInt);
            Console.WriteLine(testData.protectedInt);
            Console.WriteLine(testData.privateInt);
            Console.WriteLine(testData.privateProtectedInt);
            Console.WriteLine(testData.protectedInternalInt);
        }
    }

    
    



}
