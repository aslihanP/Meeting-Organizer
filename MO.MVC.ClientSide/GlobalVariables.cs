using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;

namespace MO.MVC.ClientSide
{
    public static class GlobalVariables
    {
        /// <summary>
        /// WebAPI verilerini çektiğimz class
        /// </summary>

        public static HttpClient WebApiClient = new HttpClient();
        static GlobalVariables()
        {
            WebApiClient.BaseAddress = new Uri("http://localhost:62870/api/");
            WebApiClient.DefaultRequestHeaders.Clear();
            WebApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}