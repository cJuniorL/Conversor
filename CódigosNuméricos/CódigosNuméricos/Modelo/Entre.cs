using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CódigosNuméricos.Modelo
{
    public class Entre
    {
        public Dictionary<String, String> dicValores { get; } = new Dictionary<string, string>();
        public Entre()
        {
            dicValores.Add("0", "00011");
            dicValores.Add("1", "00101");
            dicValores.Add("2", "00110");
            dicValores.Add("3", "01001");
            dicValores.Add("4", "01010");
            dicValores.Add("5", "01100");
            dicValores.Add("6", "10001");
            dicValores.Add("7", "10010");
            dicValores.Add("8", "10100");
            dicValores.Add("9", "11000");
        }
    }
}
