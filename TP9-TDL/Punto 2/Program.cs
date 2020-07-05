using Helpers;
using System;
using System.IO;

namespace Punto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una frase");
            string texto = Console.ReadLine();
            string codigoMorse = ConversorDeMorse.TextoAMorse(texto);
            string ruta = @"C:\RepoGit\tpn9-PavonEvelin\TP9-TDL\Punto 2\Morse";

            string fecha = DateTime.Now.ToString("dd-MM-yy");
            if (!Directory.Exists(ruta))
            {
                Directory.CreateDirectory(ruta);
            }
            string ruta2 = ruta + @"\morse_" + fecha + ".txt";
            File.WriteAllText(ruta2, codigoMorse);


            string codigomorse = File.ReadAllText(ruta2);
            texto = ConversorDeMorse.MorseATexto(codigomorse);
            ruta2 = ruta + @"\morse2_" + fecha + ".txt";
            File.WriteAllText(ruta2, texto);
            Console.WriteLine("La cadena convertida es: {0}", texto);
        }
        

    }
}
