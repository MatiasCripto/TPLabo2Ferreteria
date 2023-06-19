
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;



namespace Entidades
{
    public class ArchivosExportar
    {
        string SaveFile()
        {
            Console.WriteLine("Seleccione la ubicación para guardar el archivo:");
            string path = Console.ReadLine();

            // Verificar si la ubicación especificada es válida
            if (string.IsNullOrWhiteSpace(path))
            {
                Console.WriteLine("La ubicación especificada no es válida.");
                return null;
            }

            // Agregar la extensión correspondiente según el tipo de archivo
            if (path.EndsWith(".csv") || path.EndsWith(".json"))
            {
                return path;
            }
            else if (path.EndsWith(".csv"))
            {
                return path + ".csv";
            }
            else if (path.EndsWith(".json"))
            {
                return path + ".json";
            }
            else
            {
                Console.WriteLine("La extensión del archivo no es válida.");
                return null;
            }
        }

    }
}
