using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace AOBMockService.WebAPI.Web.Common
{
    public class JsonHelper
    {
        public static HttpResponseMessage GetHttpResponseMessage(string message)
        {
            var httpResponseMessage = new HttpResponseMessage();
            httpResponseMessage.Content = new StringContent(message);
            httpResponseMessage.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            return httpResponseMessage;
        }

    }
}