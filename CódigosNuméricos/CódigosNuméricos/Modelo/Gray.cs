using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CódigosNuméricos.Modelo
{
    public class Gray
    {
        public Dictionary<String, String> dicValores { get; } = new Dictionary<string, string>();
        public Gray()
        {
            dicValores.Add("0", "0000");
            dicValores.Add("1", "0001");
            dicValores.Add("2", "0011");
            dicValores.Add("3", "0010");
            dicValores.Add("4", "0110");
            dicValores.Add("5", "0111");
            dicValores.Add("6", "0101");
            dicValores.Add("7", "0100");
            dicValores.Add("8", "1100");
            dicValores.Add("9", "1101");
        }
    }
}
