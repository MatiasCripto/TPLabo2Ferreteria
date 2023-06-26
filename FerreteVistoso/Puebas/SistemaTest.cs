using Logica.Movimientos;
using Logica.Sistema;
using Logica.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Logica.Sistema.Sistema;

namespace Puebas
{
    [TestClass]
    public class SistemaTest
    {

        private List<Persona> usuarios;

        [TestInitialize]
        public void Setup()
        {
            // Configurar los usuarios para la prueba
            usuarios = new List<Persona>
            {
            new PersonalInterno("jonatan", "Johnny87","1234", Logica.Enumerados.Role.Administrador),
            new PersonalInterno("alejandro", "Ale22","1234", Logica.Enumerados.Role.Empleado),
            new PersonalInterno("ana", "Aninav22", "1234", Logica.Enumerados.Role.Empleado)
            };
        }

        [TestMethod]
        public void IniciarSesion_UsuarioYContraseñaCorrectos_DebeDevolverTrue()
        {
            // Arrange
            string usuario = "Johnny87";
            string contraseña = "1234";

            // Act
            bool resultado = Sistema.IniciarSesion(usuario, contraseña);

            // Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void IniciarSesion_UsuarioIncorrecto_DebeDevolverFalse()
        {
            // Arrange
            string usuario = "josefina"; // Usuario no existente
            string contraseña = "1122";

            // Act
            bool resultado = Sistema.IniciarSesion(usuario, contraseña);

            // Assert
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void IniciarSesion_ContraseñaIncorrecta_DebeDevolverFalse()
        {
            // Arrange
            string usuario = "jonatan";
            string contraseña = "2211"; // Contraseña incorrecta

            // Act
            bool resultado = Sistema.IniciarSesion(usuario, contraseña);

            // Assert
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void IniciarSesion_UsuarioYContraseñaIncorrectos_DebeDevolverFalse()
        {
            // Arrange
            string usuario = "josecito"; // Usuario no existente
            string contraseña = "1233"; // Contraseña incorrecta

            // Act
            bool resultado = Sistema.IniciarSesion(usuario, contraseña);

            // Assert
            Assert.IsFalse(resultado);
        }
    }
}

