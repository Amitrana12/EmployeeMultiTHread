/*using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace employeePayRollUsingThread
{
    class MultithreadTest
    {
        static void Main(string[] args)
        {
            DateTime startDateTime = DateTime.Now;
            Thread tets1 = new Thread(getvalue);
            Thread tets2 = new Thread(getsubvalue);
            tets1.Start();
            tets2.Start();
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration without thread: " + (stopDateTime - startDateTime));
        }

        private static int add(int a ,int b)
        {
            return a + b;
        }
        private static int sub(int a, int b)
        {
            return a - b;
        }

        public static void getvalue()
        {
            for (int i = 0; i < 100; i++)
            {
               *//* if (i == 5) {
                    Thread.Sleep(10000);
                }*//*
                Console.WriteLine("First {0}",add(i, i+5));

            }
            
        }
        public static void getsubvalue()
        {
            for (int i = 0; i < 100; i++)
            {
               *//* if (i == 5)
                {
                    Thread.Sleep(10000);
                }*//*
                Console.WriteLine("second {0}", sub(i, i + 5));

            }
            
        }
    }
}
*/