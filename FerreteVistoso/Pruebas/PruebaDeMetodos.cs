

using Datos;
using Logica.Productos;

namespace Pruebas
{
    [TestClass]
    public class PruebaDeMetodos
    {

        [TestMethod]
        public static void PruebaGuardarProductoEnDB()
        {
            // Crear el producto
            Articulo producto = new Articulo("NombreProducto", 10.99m, 100, 0);

            // Crear una instancia de ArticuloDB
            ArticuloDB articuloDB = new ArticuloDB();

            // Verificar si el producto ya existe en la base de datos
            bool productoExistente = articuloDB.VerificarExistenciaProductoEnDB(producto.Nombre);

            // Si el producto ya existe, mostrar un mensaje de error
            if (productoExistente)
            {
                Assert.Fail("Error al guardar el producto: El producto ya existe en la base de datos antes de guardarlo");
            }

            // Guardar el producto en la base de datos
            articuloDB.Agregar(producto);

            // Verificar nuevamente si el producto existe en la base de datos después de guardarlo
            productoExistente = articuloDB.VerificarExistenciaProductoEnDB(producto.Nombre);

            // Verificar que el producto se haya guardado correctamente
            Assert.IsTrue(productoExistente, "El producto no se guardó correctamente en la base de datos");
        }


    }
}