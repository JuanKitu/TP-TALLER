using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TallerFinal.Dominio
{
   public class Operacion
   {
      private string dniCliente;
      private String descripcion;
      private TimeSpan tiempo;
      private bool fallida;

       // Propiedades
       [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id
      {
         get; set;
      }

      public string DNICliente
      {
         get { return dniCliente; }
         set { dniCliente = value; }
      }

      public String Descripcion
      {
         get { return descripcion; }
         set { descripcion = value; }
      }


      public TimeSpan Tiempo
      {
         get { return tiempo; }
         set { tiempo = value; }
      }

      /// <summary>
      /// Verdadero si esta operación resultó fallida
      /// </summary>
      public bool Fallida
      {
         get { return fallida; }
         set { fallida = value;  }
      }

      // Constructor
      public Operacion(string pDNICliente, string pDescripcion, TimeSpan pTiempo, bool pFallida)
      {
         this.DNICliente = pDNICliente;
         this.Descripcion = pDescripcion;
         this.Tiempo = pTiempo;
         this.Fallida = pFallida;
      }

      public Operacion() { }
   }
}
