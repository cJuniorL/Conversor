using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CódigosNuméricos.Modelo
{
    public class BCD8421
    {
        public Dictionary<String, String> dicValores { get; } = new Dictionary<string, string>(); 
        public BCD8421()
        {
            //passei aki
            dicValores.Add("0", "0000");
            dicValores.Add("1", "0001");
            dicValores.Add("2", "0010");
            dicValores.Add("3", "0011");
            dicValores.Add("4", "0100");
            dicValores.Add("5", "0101");
            dicValores.Add("6", "0110");
            dicValores.Add("7", "0111");
            dicValores.Add("8", "1000");
            dicValores.Add("9", "1001");
        }
        
    }
}