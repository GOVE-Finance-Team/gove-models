using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GOVE.Models.Exceptions;

public class GoveException : Exception
{
    public GoveException() => StatusCode = HttpStatusCode.InternalServerError;
    public GoveException(HttpStatusCode statusCode) => StatusCode = statusCode;
    public GoveException(string? message) : base(message) => StatusCode = HttpStatusCode.InternalServerError;
    public GoveException(HttpStatusCode statusCode, string? message) : base(message) => StatusCode = statusCode;
    public GoveException(string? message, Exception? innerException) : base(message, innerException) => StatusCode = HttpStatusCode.InternalServerError;
    public GoveException(HttpStatusCode statusCode, string? message, Exception? innerException) : base(message, innerException) =>
        StatusCode = statusCode;
    [JsonIgnore]
    [JsonProperty(FieldName.StatusCode, Order = FieldOrder.StatusCode, Required = Required.Default)]
    public HttpStatusCode StatusCode { get; set; }
    private struct FieldName
    {
        internal const string StatusCode = "statusCode";
    }

    private struct FieldOrder
    {
        internal const int StatusCode = 1;
    }
}
