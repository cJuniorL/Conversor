using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CódigosNuméricos.Modelo
{
    public class Johnson
    {
        public Dictionary<String, String> dicValores { get; } = new Dictionary<string, string>();
        public Johnson()
        {
            dicValores.Add("0", "00000");
            dicValores.Add("1", "00001");
            dicValores.Add("2", "00011");
            dicValores.Add("3", "00111");
            dicValores.Add("4", "01111");
            dicValores.Add("5", "11111");
            dicValores.Add("6", "11110");
            dicValores.Add("7", "11100");
            dicValores.Add("8", "11000");
            dicValores.Add("9", "10000");
        }
    }
}
