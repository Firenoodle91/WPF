using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 31263번
            // 641

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int Length = a / 3;

            int[] c = new int[a];

            int f = 0;

            for (int i = 0; i < Length; i++)
            {
                int d = int.Parse(b.ToString().Substring((i * 3), 3));
                if (d <= 641)
                {
                    c[i] = f++;
                }
                else
                {

                }
            }




            #endregion

            #region 1330번
            /*
            string a = Console.ReadLine();
            string[] b = a.Split();

            int c = int.Parse(b[0]);
            int d = int.Parse(b[1]);

            if (c > d)
                Console.WriteLine(">");
            else if (c < d)
                Console.WriteLine("<");
            else
                Console.WriteLine("=");
            */
            #endregion

            #region 10926번
            /*
            string a = Console.ReadLine();
            Console.WriteLine(a + "??!");
            */
            #endregion

            #region 10869번
            /*
            string a = Console.ReadLine();
            string[] b = a.Split();

            int c = int.Parse(b[0]);
            int d = int.Parse(b[1]);

            Console.WriteLine(c + d);
            Console.WriteLine(c - d);
            Console.WriteLine(c * d);
            Console.WriteLine(c / d);
            Console.WriteLine(c % d);
            */
            #endregion

            #region 10998번
            /*
            string a = Console.ReadLine();
            string[] b = a.Split();

            int c = int.Parse(b[0]);
            int d = int.Parse(b[1]);

            Console.WriteLine(c*d);
            */
            #endregion

            #region 1000번
            /*
            string a = Console.ReadLine();
            string[] b = a.Split();

            int c = int.Parse(b[0]);
            int d = int.Parse(b[1]);

            Console.WriteLine(c + d);

            /*
            string a = Console.ReadLine();

            //string a = Console.Read();
            //string a = Console.ReadLine();

            Console.Write(a);
            Console.WriteLine(a);


            //string A = Console.ReadLine();

            //string[] D = A.Split();

            //int a;
            //int b;
            //int c;

            //a = int.Parse(D[0]);
            //b = int.Parse(D[1]);
            //Console.Write(a + b);

            Console.ReadLine();
            */
            #endregion
        }
    }
}
