using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class InsertionSorter:Sorter
    {
        int[] Array;

        public InsertionSorter(int[] Array)
        {
            this.Array = Array;
        }  // конструктор


        public void Sort()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                int temp = Array[i]; //запомним i-ый элемент
                int j = i - 1;//будем идти начиная с i-1 элемента
                while (j >= 0 && Array[j] > temp)
                // пока не достигли начала массива
                // или не нашли элемент больше i-1-го
                // который храниться в переменной temp
                {
                    swap(Array,j + 1, j);

                    //проталкиваем элемент вверх
                    j--;
                }
                Array[j + 1] = temp;
                // возвращаем i-1 элемент
            }


        }

    }
}
