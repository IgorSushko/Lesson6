using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6pt2
{
    class MyQueue:Buffer
    {
        int[] array;
        int head;
        int tail;
        int count = 0; //количество елементов в очереди


        public MyQueue(int[] array, int head, int tail)
        {
            this.array = array;
            this.head = head;
            this.tail = tail;
        }
        // конструктор




        public override bool IsEmpty()
        {

            return count == 0;
        }

        public override bool IsFull()
        {
            return count == array.Length;
        }

        public void Enqueue(int value)
        {
            //int i=0;
            //i = head;
            if (head < array.Length && count < array.Length)
            {
                array[head] = value;
                head++;
                count++;
            }

            else
            {
                head = 0;
                if (count == array.Length) { Console.WriteLine("Queue is full"); return; }
                array[head] = value;
                head++;
                count++;
                

            }

            Console.WriteLine("head---" + head);
            Console.WriteLine("elements in queue---" + count);
            Console.WriteLine("*******************************");
        }

        public int Dequeue()
        {
            int k = tail;

            if (count == 0) { Console.WriteLine("Queue is empty "); return -1; };
            tail++;
            count--;
            Console.WriteLine("tail---" + tail);
            Console.WriteLine("elements in queue---" + count);

            return array[k];
        }
    }
}
