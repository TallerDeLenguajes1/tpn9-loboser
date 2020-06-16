using System;
using System.IO;
using OrganizarArchivos;

namespace OrganizarArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string directorio = @"C:\Repogit\tp9\OrganizarArchivos\OrganizarArchivos\bin\Debug\Prueba\";

            SoporteParaConfiguracion.CrearArchivo(directorio);
            string path = SoporteParaConfiguracion.LeerConfiguracion(directorio);

            DirectoryInfo InformacionDelDirectorio = new DirectoryInfo(@"c:\Repogit\tp9\OrganizarArchivos\OrganizarArchivos\bin\Debug");
            foreach (var archivo in InformacionDelDirectorio.GetFiles())
            {
                Console.WriteLine("LISTA DE ARCHIVOS\n");
                Console.WriteLine(archivo.Name);
                if (archivo.Name.Contains(".mp3") || archivo.Name.Contains(".txt"))
                {
                    string direc = @"c:\Repogit\tp9\OrganizarArchivos\OrganizarArchivos\bin\Debug\" + archivo.Name;
                    string destino = path + archivo.Name;
                    if (!File.Exists(destino))
                    {
                        File.Move(direc, destino);
                    }
                }
            }
        }
    }
}
