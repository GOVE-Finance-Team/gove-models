using GOVE.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics.CodeAnalysis;

namespace GOVE.Models.Exceptions;

public sealed class MessageHandlerException : GoveException
{
    private const string DefaultErrorMessage = "Exception in message handler.";
    public MessageHandlerException(MessageResponse response) : base(response.StatusCode, DefaultErrorMessage) => Response = response;
    public MessageResponse Response { get; set; }
}
