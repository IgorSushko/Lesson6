using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Sorter
    {
       
       

        protected void swap(int[]Array,int digita, int digitb)
        {
            int temp1 = 0;
            
            temp1 = Array[digita];
            Array[digita] = Array[digitb];
            Array[digitb] = temp1;

        }

        public void Print(int[]Array)
        {
            for (int j = 0; j < Array.Length; j++)
            {

                Console.WriteLine(" digit " + "  " + j + "   " + Array[j]);

            }
        }





    }
}
