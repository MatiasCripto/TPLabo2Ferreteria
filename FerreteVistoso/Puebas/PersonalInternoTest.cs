using Logica.Productos;
using Logica.Sistema;
using Logica.Usuarios;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Puebas
{
    [TestClass]
    public class PersonalInternoTests
    {
        [TestMethod]
        public void ObtenerUsuarioLogueado_ReturnsUsuarioLogueado()
        {
            // Arrange
            PersonalInterno usuarioLogueado = new PersonalInterno("jonatan", "Johnny87", "1234", Logica.Enumerados.Role.Administrador);
            Sistema.UsuarioActual(usuarioLogueado); // Configura el usuario logueado en la variable estática

            // Act
            PersonalInterno resultado = Sistema.ObtenerUsuarioLogueado();

            // Assert
            Assert.AreEqual(usuarioLogueado, resultado);
        }

    }

}