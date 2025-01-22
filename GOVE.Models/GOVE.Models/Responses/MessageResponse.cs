using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GOVE.Models.Responses;

[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
public class MessageResponse : BaseResponse
{
    public MessageResponse()
    {
    }

    public MessageResponse(HttpStatusCode statusCode, string message) : base(statusCode, message)
    {
    }
    [JsonProperty(FieldName.IsRequestValid, Order = FieldOrder.IsRequestValid,
        Required = Required.Default)]
    public bool IsRequestValid => Error.ValidationErrors != null && Error.ValidationErrors.Count == 0;

    [JsonProperty(FieldName.Request, Order = FieldOrder.Request, Required = Required.Default)]
    public object? Request { get; set; }

    [JsonIgnore]
    public Type? RequestType { get; set; }

    private struct FieldName
    {
        internal const string IsRequestValid = "isRequestValid";
        internal const string Request = "request";
    }

    private struct FieldOrder
    {
        internal const int IsRequestValid = 2000;
        internal const int Request = 2001;
    }
}
