using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Tasks;

namespace GOVE.Models.Exceptions;

public sealed class RestException : GoveException
{
    public RestException(HttpStatusCode statusCode) : base(statusCode) => StatusCode = statusCode;
    public RestException(HttpStatusCode statusCode, string? message, string? responseData = null) : base(statusCode, message) =>
        ResponseData = responseData;
    public RestException(HttpStatusCode statusCode, string message, string? responseData, Exception innerException) : base(statusCode, message,
        innerException) => ResponseData = responseData;

    public string? ResponseData { get; set; }
}
