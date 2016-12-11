using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6pt2
{
    class MyStack:Buffer
    {
        int position;
        int[] array;
        int value;


        public MyStack(int[] array, int position, int value)
        {
            this.array = array;
            this.position = position;
            this.value = value;
        }
        // конструктор


        public override bool IsFull()
        {
            return position < 0;
        }

        public override bool IsEmpty()
        {
            return position == 5;
        }

        public void Push(int value)
        {
            if (position < 0) { Console.WriteLine("Stek is full "); }
            array[position] = value;
            position--;
        }

        public int Pop()
        {
            if (position == 5) { Console.WriteLine("Stek is empty "); return -1; }

            return array[++position];

        }

        public int Peek()
        {
            int temp3 = 0;
            if (position == 5) { Console.WriteLine("Stek is empty "); return -1; }
            if (position < 0) { Console.WriteLine("Stek is full "); return array[0]; }
            temp3 = position + 1;
            return array[temp3];
        }

    }
}
