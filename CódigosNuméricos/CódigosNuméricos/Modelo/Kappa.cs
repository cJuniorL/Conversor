using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CódigosNuméricos.Modelo
{
    public class Kappa
    {
        public Dictionary<String, String> dicValores { get; } = new Dictionary<string, string>();
        public Kappa()
        {
            dicValores.Add("0", "11111");
            dicValores.Add("1", "11110");
            dicValores.Add("2", "01111");
            dicValores.Add("3", "11100");
            dicValores.Add("4", "00111");
            dicValores.Add("5", "11000");
            dicValores.Add("6", "00011");
            dicValores.Add("7", "10000");
            dicValores.Add("8", "00001");
            dicValores.Add("9", "00000");
        }
    }
}
