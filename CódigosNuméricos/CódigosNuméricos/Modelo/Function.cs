using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CódigosNuméricos.Modelo
{
    static public class Function
    {
        static public string codificar(string valor, Dictionary<String, String> dicValores)
        {
            string codigo = null;
            for (int i = 0; i < valor.Length; i++)
                codigo += dicValores[Convert.ToString(valor[i])] + "   ";
            return codigo;
        }

        static public string decodificar(string valor, Dictionary<String, String> dicValores, int tamanho)
        {
            string codigo = null;
            valor = valor.Replace(" ", "");
            for (int i = 0; i < valor.Length; i += tamanho)
            {
                try
                {
                    codigo += dicValores.FirstOrDefault(x => x.Value == valor.Substring(i, tamanho)).Key;
                }
                catch
                {
                    MessageBox.Show("Não foi possivel decodificar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            return codigo;
        }


    }
}
 