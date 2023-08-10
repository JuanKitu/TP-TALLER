using System;
using System.Linq;
using TallerFinal.DAL;
using TallerFinal.DAL.EntityFramework;


namespace TallerFinal
{
   public class Bitacora
   {
      private IRepositorioOperaciones iRepOperaciones;

      public Bitacora()
      {
         iRepOperaciones = new RepositorioRegistroDeOperaciones();
      }

      /// <summary>
      /// Registra operación en la base de datos guardando la descripción y el tiempo que se tardó en operar
      /// </summary>
      /// <param name="pDniCliente">DNI del cliente para el cual se realizó la operación</param>
      /// <param name="pDescripcion">Descripción de la operación</param>
      /// <param name="pTiempo">Tiempo que llevó realizar la operación</param>
      /// <param name="pFallida">Verdadero si la operación resultó fallida</param>
      public void RegistrarOperacion(string pDniCliente, string pDescripcion, TimeSpan pTiempo, bool pFallida)
      {
         try
         {
               var nuevaOperacion = new Dominio.Operacion(pDniCliente, pDescripcion, pTiempo, pFallida);
               iRepOperaciones.Agregar(nuevaOperacion);
         }
         catch (Exception)
         {
               throw new DAL.Excepciones.ErrorAlRegistrarOperacion();
         }
         finally
         {
               GuardarCambios();
         }
      }

      public void GuardarCambios()
      {
         try
         {
               iRepOperaciones.GuardarCambios();
         }
         catch (Exception)
         {
               throw new DAL.Excepciones.ErrorAlGuardarRegistroOperaciones();
         }
      }
   }


}
