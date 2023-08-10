using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using Autoservicio.IO;
using Newtonsoft.Json;

namespace TallerFinal
{
   class ServiciosConBitacora
   {
      private Bitacora iBitacora;

      public ServiciosConBitacora()
      {
         try
         {
            iBitacora = new Bitacora();
         }
         catch (Exception exc)
         {
            // No tirar excepción ya que el registrar operaciones en la bitácora es algo
            // Que no debería parar el flujo de la aplicación en caso de errores
            Console.WriteLine("Excepción al crear bitácora. Codigo de error: " + exc.HResult.ToString());
         }
      }

      private void RegistrarOperacion(string pDni, string pDescripcion, Stopwatch pTimer, bool pFallida)
      {
         pTimer.Stop();
         try
         {
            iBitacora.RegistrarOperacion(pDni, pDescripcion, pTimer.Elapsed, pFallida);
         }
         catch (Exception exc)
         {
            // Las excepciones del registro de operaciones no paran el flujo de la aplicación
            // Es por eso que no volvemos a hacer un throw aquí
            Console.WriteLine("Excepción al registrar operación. Codigo de error: " + exc.HResult.ToString());
         }
      }
   }
}