using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logica.Datos
{
    public abstract class ParserBase<T>
    {

        //private readonly string filePath;

        //protected ParserBase(string fileName)
        //{
        //    string directoryPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
        //    Directory.CreateDirectory(directoryPath);
        //    filePath = Path.Combine(directoryPath, fileName);
        //}

        //public void Guardar(List<T> lista)
        //{
        //    // Lógica para guardar los datos en el archivo
        //    using (StreamWriter writer = new StreamWriter(filePath))
        //    {
        //        foreach (T item in lista)
        //        {
        //            string linea = ConvertToLine(item); // Implementa el método ConvertToLine en la clase ParserBase<T>
        //            writer.WriteLine(linea);
        //        }
        //    }
        //}

        //public List<T> Leer()
        //{
        //    List<T> lista = new List<T>();

        //    // Lógica para leer los datos del archivo
        //    using (StreamReader reader = new StreamReader(filePath))
        //    {
        //        string linea;
        //        while ((linea = reader.ReadLine()) != null)
        //        {
        //            T item = ParseLine(linea); // Implementa el método ParseLine en la clase ParserBase<T>
        //            if (item != null)
        //                lista.Add(item);
        //        }
        //    }

        //    return lista;
        //}

        //public void Eliminar(T item)
        //{
        //    // Lógica para eliminar un elemento de la lista y actualizar el archivo
        //    List<T> lista = Leer();
        //    lista.Remove(item);
        //    Guardar(lista);
        //}

        //public void Modificar(T item)
        //{
        //    // Lógica para modificar un elemento de la lista y actualizar el archivo
        //    List<T> lista = Leer();
        //    //int index = lista.FindIndex(x => x.Id == item.Id);
        //    if (index != -1)
        //    {
        //        lista[index] = item;
        //        Guardar(lista);
        //    }
        //}

        //protected abstract string ConvertToLine(T item);

        //protected abstract T ParseLine(string linea);
    }
}

