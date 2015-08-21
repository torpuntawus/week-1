using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        static void Main(string[] args)
        {
            BubbleSortFunction s = new BubbleSortFunction();
            int[] a = s.inputFunc();
            s.processFunc(a);
            s.outputFunc(a);
            Console.ReadKey();
        }

         public int[] inputFunc()
         {
             int num; 

             Console.WriteLine("Input how many integers: ");
             num = Convert.ToInt32(Console.ReadLine());

             int[] a = new int[num];
             for (int i = 0; i < num; i++)
             {
                 a[i] = Convert.ToInt32(Console.ReadLine());
             }
             return a;
        }
        
        public void processFunc(int[] a)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i != a.Length - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        int temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                        flag = true;
                    }
                }
            }
        }

        public void outputFunc(int[] a)
        {
            for (int i = 0; i != a.Length; i++)
            {
                Console.Write(a[i]);
                Console.Write(" ");
            }
        }
    }
}
