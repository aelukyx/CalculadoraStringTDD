using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace CalculadoraString
{

    public class CalculaSuma
    {

        public string CalculadoraString(string CadenaNumeros)
        {

            if (CadenaNumeros == "")
            {
                return "0";
            }

            else
            {

                List<int> list = new List<int>();

                Regex delimitador = new Regex(",");
                string[] subNumero = delimitador.Split(CadenaNumeros);
                foreach (string Numerito in subNumero)
                {
                    if (Convert.ToInt32(Numerito) >= 0 && Convert.ToInt32(Numerito) < 1000)
                    {
                        list.Add(Convert.ToInt32(Numerito));
                    }

                    if (Convert.ToInt32(Numerito) < 0)
                    {
                        throw new InvalidDataException();
                    }
                }

                return Convert.ToString(list.Sum());
            }

        }
    }
}