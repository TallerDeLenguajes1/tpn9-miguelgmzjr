using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Helpers
{   
        public static class SoporteParaConfiguracion
        {
            public static void CrearArchivoDeConfiguracion(string RutaArchivo)
            {
                string NuevoArchivo = "destino.dat";

                if (!File.Exists(NuevoArchivo))
                {
                    File.Create(NuevoArchivo);
                }
                File.WriteAllText(NuevoArchivo, RutaArchivo);  
            }

            public static string LeerConfiguracion()
            {
                string NuevoArchivo = "destino.dat";

                string RutaArchivo = File.ReadAllText(NuevoArchivo);

                return RutaArchivo;
            }
        }
}
