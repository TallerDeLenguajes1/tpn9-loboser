using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OrganizarArchivos
{
    public static class SoporteParaConfiguracion
    {
        public static void CrearArchivo(string directorio)
        {
            string destinoDat = directorio + "destino.dat";

            if (!File.Exists(destinoDat)){
                FileStream Archivo = File.Create(destinoDat);
            }
            File.WriteAllText(destinoDat, directorio);
        }
        public static string LeerConfiguracion(string directorio)
        {
            string destinoDat = directorio + "destino.dat";

            FileStream Archivo = new FileStream(destinoDat, FileMode.Open);
            StreamReader Leer = new StreamReader(Archivo);
            string path = Leer.ReadLine();
            Archivo.Position = 0;
            Archivo.Close();
            return path;
        }
    }
}