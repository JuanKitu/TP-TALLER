using System;
using System.Linq;
using TallerFinal.DAL;
using TallerFinal.DAL.EntityFramework;


namespace TallerFinal
{
   public class Bitacora
   {
      private IRepositorioOperaciones iRepOperaciones;
      private int iUltimoIDOperacion;

      public Bitacora()
      {
         iRepOperaciones = new RepositorioRegistroDeOperaciones();
         // Lo obtengo y lo guardo en una variable para no hacer esta operación costosa cada vez que quiero averiguar el último ID
         if (iRepOperaciones.Count() > 0)
         {
               iUltimoIDOperacion = iRepOperaciones.ObtenerTodos().Max(e => e.Id);
         }
         else
         {
               iUltimoIDOperacion = 0;
         }
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
               int nuevoIdOperacion = iUltimoIDOperacion + 1;
               var nuevaOperacion = new Dominio.Operacion(nuevoIdOperacion, pDniCliente, pDescripcion, pTiempo, pFallida);
               iRepOperaciones.Agregar(nuevaOperacion);
               // Se hace de esta forma para que no se incremente el ultimoID si llega a fallar la linea de arriba
               iUltimoIDOperacion = nuevoIdOperacion;
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
