using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace csT
{
    class Program
    {
        static void Main(string[] args)
        {

            //Value K
            int _k = Convert.ToInt32(Console.ReadLine());;

            //size array
            int _array_size = Convert.ToInt32(Console.ReadLine());;

            int[] _array = new int[_array_size];

            int _array_item;


            //Array elements 
            for (int i = 0; i < _array_size; i++)
            {
                _array_item = Convert.ToInt32(Console.ReadLine());
                _array[i] = _array_item;
            }


            //Classe new instance
            csT.Cls01 App = new csT.Cls01();


            //Output array
            Console.WriteLine(App.TMInputArray(_array, _k));

            Console.ReadLine();

        }
    }
}
