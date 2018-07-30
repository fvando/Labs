using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csT
{
    public class Cls01
    {

        public string TMInputArray(int[] InputDados, int k)
        {

            string Output = string.Empty;
            List<string> Output2 = new List<string>();

            for (int i = 0; i < InputDados.Count() - 1; i++)
            {
                for (int j = i + 1; j < InputDados.Count(); j++)
                {
                    int n1 = InputDados[i];
                    int n2 = InputDados[j];

                    if ((n1 + n2) == k)
                    {
                        Output2.Add("(" + n1 + "," + n2 + ")");
                    }

                }
            }

            //Output2.Reverse();

            //foreach (var item in Output2)
            //{
            //    if (Output == "")
            //    {
            //        Output = item;
            //    }
            //    else
            //    {
            //        Output += "," + item;
            //    }

            //}

            return Output;
        }


    }
}
