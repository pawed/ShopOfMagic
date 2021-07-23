using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ShopWebApi.Models.DTO
{
    public class CommonResponseWrapper
    {
        public static CommonResponseWrapper Create(HttpStatusCode statusCode, object result = null, string errorMessage = null)
        {
            return new CommonResponseWrapper(statusCode, result, errorMessage);
        }

        public string Version => "1.2.3";

        public int StatusCode { get; set; }
        public string RequestId { get; }

        public string ErrorMessage { get; set; }

        public object Result { get; set; }

        protected CommonResponseWrapper(HttpStatusCode statusCode, object result = null, string errorMessage = null)
        {
            RequestId = Guid.NewGuid().ToString();
            StatusCode = (int)statusCode;
            Result = result;
            ErrorMessage = errorMessage;
        }
    }
}
