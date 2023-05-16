﻿using Logica.Datos;
using Logica.Parsers;
using Logica.Productos;
using Logica.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Sistema
{
    public class Sistema
    {
       
        public static void AltaProducto(Articulo producto, PersonalInterno usuario)
        {
            //validaciones
            if (usuario.Role != Enumerados.Role.Administrador)
            {
                throw new Exception("No tiene permiso suficiente");
            }
            BaseDeDatos.BaseDatosProductos.Add(producto);
        }
        public static void GuardarProducto(Articulo producto)
        {
            producto.Id = Articulo.NexId;
            ParserProductos.CrearProducto(producto.Id, producto.Nombre, producto.Precio, producto.Stock);
        }
    }
}
