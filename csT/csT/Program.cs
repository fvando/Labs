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

            int _k = 0;

            _k = Convert.ToInt32(Console.ReadLine());


            int[] res;

            int _elements_size = 0;

            _elements_size = Convert.ToInt32(Console.ReadLine());

            int[] _elements = new int[_elements_size];

            int _elements_item;

            for (int _elements_i = 0; _elements_i < _elements_size; _elements_i++)
            {
                _elements_item = Convert.ToInt32(Console.ReadLine());
                _elements[_elements_i] = _elements_item;
            }

            csT.Cls01 App = new csT.Cls01();

            Console.WriteLine(App.TMInputArray(_elements, _k));

            Console.ReadLine();

        }
    }
}
