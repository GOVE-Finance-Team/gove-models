using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GOVE.Models.Responses;

public sealed class ErrorResponse
{
    public ErrorResponse(string message, Exception innerException) : this(message, innerException, null!)
    {
    }
    public ErrorResponse(string message, Exception innerException, ErrorResponse innerError)
    {
        Message = message;
        Exception = innerException;
        InnerError = innerError;
    }
    public ErrorResponse() : this(String.Empty, null!)
    {
    }

    public ErrorResponse(string message) : this(message, null!)
    {
    }
    [JsonExtensionData]
    [JsonProperty(FieldName.AdditionalData, Order = FieldOrder.AdditionalData,
        Required = Required.Default)]

    public Dictionary<string, object> AdditionalData { get; set; } = default!;

    [JsonIgnore]
    [JsonProperty(FieldName.Exception, Order = FieldOrder.Exception, Required = Required.Default)]
    public Exception Exception { get; set; }
    [JsonProperty(FieldName.InnerError, Order = FieldOrder.InnerError, Required = Required.Default)]
    public ErrorResponse InnerError { get; set; }

    [JsonProperty(FieldName.Message, Order = FieldOrder.Message, Required = Required.Default)]
    public string Message { get; set; }

    [JsonProperty(FieldName.ValidationErrors, Order = FieldOrder.ValidationErrors,
        Required = Required.Default)]
    public Dictionary<string, string[]> ValidationErrors { get; set; } = default!;

    private struct FieldName
    {
        internal const string AdditionalData = "additionalData";
        internal const string Exception = "exception";
        internal const string InnerError = "innerError";
        internal const string Message = "message";
        internal const string ValidationErrors = "validationErrors";
    }

    private struct FieldOrder
    {
        internal const int AdditionalData = 9000;
        internal const int Exception = 1000;
        internal const int InnerError = 5000;
        internal const int Message = 2;
        internal const int ValidationErrors = 10;
    }
}
