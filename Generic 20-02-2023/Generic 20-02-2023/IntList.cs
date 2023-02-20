using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_20_02_2023
{
    internal class IntList
    {

        public int[] Arr = new int[0];


        public void Add(int value)
        {
            Array.Resize(ref Arr, Arr.Length + 1);
            Arr[Arr.Length - 1] = value;
        }


        public void Remove(int index)
        {
            if (index < 0 || index >= Arr.Length)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = 0; i < Arr.Length-1; i++)
            {
                var temp = Arr[index];
                Arr[index] = Arr[i + 1];
                Arr[i + 1] = temp;

            }
            Array.Resize(ref Arr, Arr.Length - 1);



        }
    }
}
