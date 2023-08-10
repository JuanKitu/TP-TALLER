using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoservicioUnitTest
{
   [TestClass]
   public class Tests
   {
      private static string[] dniClientes = new string[] { "12345678", "12345679", "12345680" };
      private static string claveClientes = "1234";

      [TestMethod]
      [ExpectedException(typeof(TallerFinal.DAL.Excepciones.ClienteNoEncontrado))]
      public void IngresarInvalido()
      {
         TallerFinal.Program.Ingresar("dniInvalido", "claveInvalida");
      }

      [TestMethod]
      public void IngresarValido()
      {
         var cliente = TallerFinal.Program.Ingresar("12345678", "1234");

         Assert.AreEqual("Juan Amador", cliente.Nombre);
      }

      [TestMethod]
      public void BlanqueoDePin()
      {
         var cliente = TallerFinal.Program.Ingresar("12345678", "1234");

         var productos = TallerFinal.Program.ObtenerProductos(cliente.Dni);

         TallerFinal.Program.BlanquearPin("12345678", productos[0].Numero);
      }

      [TestMethod]
      public void SaldoCC()
      {
         foreach (var dni in dniClientes)
         {
            var saldo = TallerFinal.Program.SaldoCC(dni);

            Assert.IsNotNull(saldo);
         }
      }

      [TestMethod]
      public void UltimosMovimientos()
      {
         foreach (var dni in dniClientes)
         {
            // Solo pedirlos para ver si hay excepciones
            TallerFinal.Program.UltimosMovimientos(dni);
         }
      }
   }
}
