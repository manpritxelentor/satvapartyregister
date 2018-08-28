using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SatvaPartyRegister.Presentation.Web.Helpers
{
    public class ApiResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccessStatusCode { get; set; }
        public List<ErrorResponse> ErrorMessages { get; set; }
    }

    public class ApiResponse<T> : ApiResponse
        where T : class
    {

        public T ResponseObject { get; set; }
    }

    public class ErrorResponse
    {
        public string Property { get; set; }
        public string Errors { get; set; }
    }
}
