using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class BubbleSorter:Sorter
    {
        int[] Array;

        public BubbleSorter(int[] Array)
        {
            this.Array = Array;
        }  // конструктор


        public void Sort()
        {
            for (int kz = 1; kz < Array.Length; kz++)
            {
                for (int k = 0; k < Array.Length - 1; k++)
                {
                    if (Array[k] < Array[k + 1]) { }
                    else
                    {
                        swap(Array,k, k + 1);
                    }

                }

            }
        }

    }
}
