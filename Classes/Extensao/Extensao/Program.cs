using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

// Define an interface named IMyInterface.
namespace DefineIMyInterface
{
    public interface IMyInterface
    {
        // Any class that implements IMyInterface must define a method
        // that matches the following signature.
        void MethodB();
    }
}

// Define extension methods for IMyInterface.
namespace Extensao
{
    using System;
    using DefineIMyInterface;

    // The following extension methods can be accessed by instances of any
    // class that implements IMyInterface.
    public static class Extension
    {

        public static void WriteJSON(this DataSet ds, string fileName)
        {
            //_ds
            //...
        }

        public static string ToUrl(this string str)
        {
            return str = "http://" + str;
        }


        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }


        //Extensão, "adicionando" MethodA na interface IMyInterface com parametro int
        public static void MethodA(this IMyInterface myInterface, int i) 
        {
            Console.WriteLine
                ("Extension.MethodA(this IMyInterface myInterface, int i)");
        }

        //Extensão, "adicionando" MethodA na interface IMyInterface com parametro string
        public static void MethodA(this IMyInterface myInterface, string s)
        {
            Console.WriteLine
                ("Extension.MethodA(this IMyInterface myInterface, string s)");
        }

        public static void MethodB(this IMyInterface myInterface)
        {
            Console.WriteLine
                ("Extension.MethodB(this IMyInterface myInterface)");
        }
    }
}

// Define three classes that implement IMyInterface, and then use them to test
// the extension methods.
namespace ExtensionMethodsDemo1
{
    using System;
    using Extensao;
    using DefineIMyInterface;

    class A : IMyInterface
    {
        public void MethodB() { Console.WriteLine("A.MethodB()"); }
    }

    class B : IMyInterface
    {
        public void MethodB() { Console.WriteLine("B.MethodB()"); }
        public void MethodA(int i) { Console.WriteLine("B.MethodA(int i)"); }
    }

    class C : IMyInterface
    {
        public void MethodB() { Console.WriteLine("C.MethodB()"); }
        public void MethodA(object obj)
        {
            Console.WriteLine("C.MethodA(object obj)");
        }
    }

    class ExtMethodDemo
    {
        static void Main(string[] args)
        {



            //////EXEMPLO 1 
            string s = "Hello Extension Methods";
            int i = s.WordCount();
            Console.WriteLine(i);

            //////EXEMPLO 2
            string url = "www.google.com";
            Console.WriteLine(url.ToUrl());
        


            //////EXEMPLO 3

            //Declare uma intancia das classes A,B,C 
            A a = new A();
            B b = new B();
            C c = new C();


            // A não contem MethodA, então cada chamada de MethodA resolverá

            a.MethodA(1);           // Extension.MethodA(IMyInterface, int)
            a.MethodA("hello");     // Extension.MethodA(IMyInterface, string)

            //
            a.MethodB();            // A.MethodB()

            // B contem metodo MethodA(int i) que condiz com a chamada
            // method calls.
            b.MethodA(1);           // B.MethodA(int)
            b.MethodB();            // B.MethodB()

            // B nao contem um com string mas a class Extensions sim MethodA(this IMyInterface myInterface, string s) que foi utilizado como extensao

            b.MethodA("hello");     // Extension.MethodA(IMyInterface, string)

            // C contem um de cada

            c.MethodA(1);           // C.MethodA(object)
            c.MethodA("hello");     // C.MethodA(object)
            c.MethodB();            // C.MethodB()
        }
    }
}
/* Output:
    Extension.MethodA(this IMyInterface myInterface, int i)
    Extension.MethodA(this IMyInterface myInterface, string s)
    A.MethodB()
    B.MethodA(int i)
    B.MethodB()
    Extension.MethodA(this IMyInterface myInterface, string s)
    C.MethodA(object obj)
    C.MethodA(object obj)
    C.MethodB()
 */