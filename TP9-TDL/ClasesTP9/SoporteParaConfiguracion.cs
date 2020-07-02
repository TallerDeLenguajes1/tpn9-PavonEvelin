using System;
using System.IO;

namespace Helpers
{
    public static class SoporteParaConfiguracion
    {
        public static void CrearArchivoDeConfiguracion(string ruta)
        {
            BinaryWriter escritorBin = new BinaryWriter(File.Open(ruta + @"\destino.dat", FileMode.OpenOrCreate));
            escritorBin.Write(ruta);
            escritorBin.Close();
        }

        public static string LeerConfiguracion(string ruta)
        {
            BinaryReader lectorBin = new BinaryReader(File.Open(ruta + @"\destino.dat", FileMode.Open));
            string contenido = lectorBin.ReadString();
            lectorBin.Close();
            return contenido;
        }
    }
}
