using Helpers;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Punto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta, rutaAux, nuevaRuta;
            ruta = @"C:\RepoGit\tpn9-PavonEvelin\TP9-TDL\Punto 1";
   
            SoporteParaConfiguracion.CrearArchivoDeConfiguracion(ruta);

            rutaAux = @"C:\RepoGit\tpn9-PavonEvelin\TP9-TDL\Punto 1\bin\Debug";
            List<string> nombresDeArchivos = Directory.GetFiles(rutaAux).ToList();// enlista los nombres de los archivos de un directorio (con sus rutas)

            nuevaRuta = SoporteParaConfiguracion.LeerConfiguracion(ruta);
            //Console.WriteLine("nuevaRuta: {0}", nuevaRuta);

            foreach (string nombre in nombresDeArchivos)
            {
                Console.WriteLine(nombre);
                string extension = Path.GetExtension(nombre);// devuelve la extension de una ruta
                string fileName = Path.GetFileName(nombre);// devuelve el nombre de un archivo sin su ruta
                //Console.WriteLine(fileName);
                
                if(extension == ".mp3" || extension == ".txt")
                {
                    File.Move(nombre, nuevaRuta + @"\" + fileName);
                }
            }
        }
    }
}