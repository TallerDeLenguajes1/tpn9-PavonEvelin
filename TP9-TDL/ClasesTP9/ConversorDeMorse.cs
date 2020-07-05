using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace Helpers
{
    public static class ConversorDeMorse
    {
        static Dictionary<string, string> DiccionarioMorse = new Dictionary<string, string>()
        {
            {"a", ".-"}, {"b", "-..."}, {"c", "-.-."}, {"d", "-.."}, {"e", "."},
            {"f", "..-." }, {"g", "--."}, {"h", "...."}, {"i", ".."}, {"j", ".---"},
            {"k", "-.-" }, {"l", ".-.."}, {"m", "--"}, {"n", "-."}, {"ñ", "--.--"},
            {"o", "---"}, {"p", ".--."}, {"q", "--.-"}, {"r", "-.-"}, {"s", "..."},
            {"t", "-"}, {"u", "..-"}, {"v", "...-"}, {"w", ".--"}, {"x", "-..-"},
            {"y", "-.--"}, {"z","--.."}, {"1", ".----"}, {"2", "..---"}, {"3", "...--"},
            {"4", "....-"}, {"5", "....."}, {"6", "-...."}, {"7", "--..."}, {"8", "---.."},
            {"9", "----."}, {"0", "-----"}, {" ", "/"}
        };

        public static string MorseATexto(string codigoMorse)
        {
            string texto = "";
            string[] Morse = codigoMorse.Split(" ");
            foreach (string simbolo in Morse) // recorro cada simbolo del arreglo Morse
            {
                foreach (KeyValuePair<string, string> elementoDicc in DiccionarioMorse)//los elementos del dicc. se recuperan como objetos KeyValuePair
                {                                                                     //recorro cada elemento del diccionario.  
                    if (elementoDicc.Value == simbolo)
                    {
                        texto += elementoDicc.Key; // concateno el simbolo en letra o numero al string texto
                    }
                }
            }
            return texto;
        }

        public static string TextoAMorse(string texto)
        {
            string codigoMorse = "";
            texto = texto.ToLower();
            foreach (char letra in texto)
            {
                foreach (KeyValuePair<string, string> elementoDicc in DiccionarioMorse)
                {
                    if (elementoDicc.Key == letra.ToString())
                    {
                        codigoMorse += elementoDicc.Value + " ";
                    }
                }

            }
            return codigoMorse;
        }
    }
}
