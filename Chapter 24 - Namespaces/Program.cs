using System; // Importing Namespace 'System'

namespace first_namespace
{
    class namespace_c1
    {
        public void func()
        {
            System.Console.WriteLine("Inside first_space");
        }
    }
}

namespace second_space
{
    class namespace_c1
    {
        public void func()
        {
            System.Console.WriteLine("Inside second_space");
        }
    }
}

class TestClass
{
    public static void Main(string[] args)
    {
        first_namespace.namespace_c1 fc = new first_namespace.namespace_c1();
        second_space.namespace_c1 sc = new second_space.namespace_c1();

        fc.func();
        sc.func();
    }
}
// pg 184, 185