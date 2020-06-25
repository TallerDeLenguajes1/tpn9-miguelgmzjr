using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using Helpers;

namespace TP9
{
    class Program
    {
        static void Main(string[] args)
        {
            string Ruta = @"c:/RepositorioGit/tpn9-miguelgmzjr/TPN9/";
            SoporteParaConfiguracion.CrearArchivoDeConfiguracion(Ruta);

            
            string RutaGuardada = SoporteParaConfiguracion.LeerConfiguracion(); //Leo ruta que esta dentro del archivo de config.


            string dir = @"c:/RepositorioGit/tpn9-miguelgmzjr/bin/debug";
            List<string> ListadeArchivos = Directory.GetFiles(dir).ToList();


            foreach (string Archivo in ListadeArchivos)
            {
                Console.WriteLine(Archivo);
                
                FileInfo file = new FileInfo(Archivo);
                if ((file.Extension == ".mp3") || (file.Extension == ".txt"))
                {
                    string NuevoDestino = RutaGuardada + file.Name;
                    File.Move(Archivo, NuevoDestino);
                }
            }






            //////////////////Punto 2////////////////////////////77
            

            
            string directorio = System.Environment.CurrentDirectory;

            Console.WriteLine("Ingrese una frase a convertir: ");
            string Frase = Console.ReadLine();

            
            string FraseMorse = Helpers.ConversorDeMorse.TextoAMorse(Frase.ToUpper());
            
            string archivo = @"c:\RepositorioGit\tpn9-miguelgmzjr\Morse\TextoMorse_" + DateTime.Now.ToString("dd-MM-yyyy-HH.mm.ss") + ".txt";
            if (!File.Exists(archivo))
            {
                var file = File.Create(archivo);
                file.Close();
            }
            File.WriteAllText(archivo, FraseMorse); //Agrego al archivo la frase en morse


            
            string CadenaenMorse = File.ReadAllText(archivo);
            string FraseTexto = Helpers.ConversorDeMorse.MorseATexto(CadenaenMorse);
            Console.WriteLine("\nCODIGO MORSE: " + CadenaenMorse);
            Console.WriteLine("CODIGO MORSE TRADUCIDO: " + FraseTexto);

            //Guardo archivo
            archivo = @"c:\RepositorioGit\tpn9-miguelgmzjr\Morse\MorseTexto_" + DateTime.Now.ToString("dd-MM-yyyy-HH.mm.ss") + ".txt";
            if (!File.Exists(archivo))
            {
                var file = File.Create(archivo);
                file.Close();
            }
            File.WriteAllText(archivo, FraseTexto);

            Console.ReadKey();









        }
    }
}
