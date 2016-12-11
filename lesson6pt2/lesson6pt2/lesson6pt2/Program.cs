using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            int position = 5;
            int count = 6;
            int countQ = 6;
            int[] arrayS = new int[count];
            int[] arrayQ = new int[countQ];
            string actiontype;
            int actiontypeint = 0;
            int value2 = 0;
            //************************************************
            int head = 0;
            int tail = 0;
            

            Console.WriteLine("MyStack");
            Console.WriteLine("Please put number of action that you need");
            Console.WriteLine("1 -  IsEmpy");
            Console.WriteLine("2 -  IsFull");
            Console.WriteLine("3 -  Peek");
            Console.WriteLine("4 -  Push");
            Console.WriteLine("5 -  Pop");
            Console.WriteLine("PLEASE NOTE:  Stuck include 6 elements");

            Console.WriteLine("MyQueue");
            Console.WriteLine("Please put number of action that you need");
            Console.WriteLine("6 -  IsEmpy");
            Console.WriteLine("7 -  IsFull");
            Console.WriteLine("8 -  Dequeue");
            Console.WriteLine("9 -  Enqueue");

            Console.WriteLine("PLEASE NOTE:  Queue include 6 elements");

            //******************************************************
            Buffer buf1 = new Buffer();
            MyStack bb1 = new MyStack(arrayS, position, value2);
            MyQueue qb1 = new MyQueue(arrayQ, head, tail);

            //******************************************************





            for (;;)
            {
                Console.WriteLine("put your number");
                actiontype = Console.ReadLine();
                actiontypeint = Convert.ToInt32(actiontype);
                switch (actiontypeint)
                {
                    case 1:
                        Console.WriteLine(Convert.ToString(bb1.IsEmpty()));
                        break;

                    case 2:
                        Console.WriteLine(Convert.ToString(bb1.IsFull()));
                        break;

                    case 3:
                        Console.WriteLine("Current value in stuck is:");
                        Console.WriteLine(Convert.ToString(bb1.Peek()));
                        break;

                    case 4:
                        Console.WriteLine("put your value to stuck");
                        bb1.Push(Convert.ToInt32(Console.ReadLine()));
                        break;
                    case 5:
                        Console.WriteLine("your took from stuck");
                        Console.WriteLine(Convert.ToString(bb1.Pop()));
                        break;

                    case 6:
                        Console.WriteLine(Convert.ToString(qb1.IsEmpty()));
                        break;

                    case 7:
                        Console.WriteLine(Convert.ToString(qb1.IsFull()));
                        break;

                    case 8:
                        Console.WriteLine("Current value in Queue is:");
                        Console.WriteLine(Convert.ToString(qb1.Dequeue()));
                        break;

                    case 9:
                        Console.WriteLine("put your value to Queue");
                        qb1.Enqueue(Convert.ToInt32(Console.ReadLine()));
                        break;






                }



            }

        }
    }
}
