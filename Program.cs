using System;
namespace tempp
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1;
            char opt;
            int v2;
            int ans=0;
            Console.WriteLine("enter first value");
            v1 =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("enter Optater");
            opt = Convert.ToChar( Console.ReadLine());
            Console.WriteLine("enter Second value");
            v2 = Convert.ToInt32(Console.ReadLine());

            switch (opt)
            {
                case '+':
                    ans = v1 + v2;
                    break;
                case '-':
                    ans = v1 - v2;
                    break;
                case '*':
                    ans = v1 - v2;
                    break;
                case '/':
                    ans = v1 - v2;
                    break;

            }
            Console.WriteLine(" Ans = "+ans);
            Console.ReadKey();

        }
    }
}
