using System;

namespace StaticVarApplication
{
    class StaticVar
    {
        public static int num;

        public void count()
        {
            num++;
        }

        public int getNum()
        {
            return num;
        }

        public static int getStaticNum()
        {
            return num;
        }
    }

    class StaticTester
    {
        static void Main(string[] args) 
        {
            StaticVar s1 = new StaticVar();
            StaticVar s2 = new StaticVar();

            s1.count();
            s1.count();
            s1.count();
            s2.count();
            s2.count();
            s2.count();
            Console.WriteLine("Variable num for s1: {0}", s1.getNum());
            Console.WriteLine("Variable num for s2: {0}", s2.getNum());
            Console.WriteLine("Variable num for all Classes: {0}", StaticVar.getStaticNum());
        }
    }
}
// pg 152 - 154
// pg 154, 155