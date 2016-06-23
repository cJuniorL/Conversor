using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CódigosNuméricos.Modelo
{
    public class Excess3
    {
        public Dictionary<String, String> dicValores { get; } = new Dictionary<String, String>();

        public Excess3() {
            dicValores.Add("0", "0011");
            dicValores.Add("1", "0100");
            dicValores.Add("2", "0101");
            dicValores.Add("3", "0110");
            dicValores.Add("4", "0111");
            dicValores.Add("5", "1000");
            dicValores.Add("6", "1001");
            dicValores.Add("7", "1010");
            dicValores.Add("8", "1011");
            dicValores.Add("9", "1100");
        }
           
    }
}
