using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using GOVE.Models.Responses;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GOVE.Models.Responses;

public class BaseResponse
{

    public BaseResponse() : this(HttpStatusCode.OK, System.String.Empty)
    {
    }

    public BaseResponse(HttpStatusCode statusCode) : this(statusCode, System.String.Empty)
    {
    }
    public BaseResponse(HttpStatusCode statusCode, string message)
    {
        StatusCode = statusCode;
        Error = new ErrorResponse(message);
    }

    [JsonProperty(FieldName.Error, Order = FieldOrder.Error, Required = Required.Default)]
    public ErrorResponse Error { get; set; }

    [JsonIgnore]
    public bool IsSuccessStatusCode => StatusCode is >= HttpStatusCode.OK and <= (HttpStatusCode)299;

    [JsonIgnore]
    [JsonProperty(FieldName.StatusCode, Order = FieldOrder.StatusCode, Required = Required.Default)]
    public HttpStatusCode StatusCode { get; set; }

    private struct FieldName
    {
        internal const string Error = "error";
        internal const string StatusCode = "statusCode";
    }

    private struct FieldOrder
    {
        internal const int Error = 9000;
        internal const int StatusCode = 1;
    }
}
