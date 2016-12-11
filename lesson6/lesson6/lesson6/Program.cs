using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            string arraySizeStr;
            int arraySize = 0;
            string valueStr;
            int valueArray = 0;


            Console.WriteLine("Program Sorting ");
            Console.WriteLine("Please put number of digit in array");
            arraySizeStr = Console.ReadLine();
            arraySize = Convert.ToInt32(arraySizeStr);
            int[] array = new int[arraySize];
            //**********************************************
            // заполняем массив

            for (int i = 0; i < arraySize; i++)
            {

                Console.WriteLine("Put your digit " + "  " + i);
                valueStr = Console.ReadLine();
                valueArray = Convert.ToInt32(valueStr);
                array[i] = valueArray;
            }

            //*****************************************************
            // вызываем клас сортировк пузырьком.
            Sorter bb1 = new Sorter();
            InsertionSorter ib1 = new InsertionSorter(array);
            BubbleSorter jb1 = new BubbleSorter(array);



            //bb1.Sort();
            ib1.Sort();
            //*****************************************************
            // Выведем массив

            //bb1.Print();
            ib1.Print(array);
            //*********************************************************
            Console.ReadLine();
        }
    }
}
