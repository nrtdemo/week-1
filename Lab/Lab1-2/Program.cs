using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        public int[] input()
        {
            int count;
            Console.Write("How many number: ");
            count = Convert.ToInt32(Console.ReadLine());

            int[] num = new int[count];
            for (int i = 0; i < count; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            return num;
        }
        public void process(int[] input)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i != input.Length - 1; i++)
                {
                    if (input[i] < input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        flag = true;
                    }
                }
            }
        }
        public void output(int[] input)
        {
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
        }
        static void Main(string[] args)
        {
            BubbleSortFunction BS = new BubbleSortFunction();

            // input
            //int[] input = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };
            int[] arrinput = BS.input();

            // process
            BS.process(arrinput);

            // output
            BS.output(arrinput);

            Console.ReadKey();
        }
    }
}
