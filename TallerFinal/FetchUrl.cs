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
   public static class FetchUrl : IWebApiClient
   {
      public static dynamic GetObject(string url)
      {
         // Se crea el request http
         HttpWebRequest mRequest = (HttpWebRequest)WebRequest.Create(url);
         try
         {
            // Se ejecuta la consulta
            WebResponse mResponse = mRequest.GetResponse();

            // Se obtiene los datos de respuesta
            using (Stream responseStream = mResponse.GetResponseStream())
            {
               StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

               // Se parsea la respuesta y se serializa a JSON a un objeto dynamic
               return JsonConvert.DeserializeObject(reader.ReadToEnd());
            }
         }
         catch (WebException ex)
         {
            WebResponse mErrorResponse = ex.Response;
            try
            {
               using (Stream mResponseStream = mErrorResponse.GetResponseStream())
               {
                  StreamReader mReader = new StreamReader(mResponseStream, Encoding.GetEncoding("utf-8"));
                  String mErrorText = mReader.ReadToEnd();

                  Console.WriteLine("Error: {0}", mErrorText);
               }
            }
            catch (Exception)
            {
               throw new DAL.Excepciones.ErrorDeConexion();
            }
            throw new DAL.Excepciones.ErrorDeConexion();
         }
      }
   }
}