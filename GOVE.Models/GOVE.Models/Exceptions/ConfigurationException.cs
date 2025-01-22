using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Tasks;

namespace GOVE.Models.Exceptions;

public sealed class ConfigurationException : GoveException
{
    public ConfigurationException() : base(HttpStatusCode.UnprocessableEntity)
    {
    }
    public ConfigurationException(string message) : base(HttpStatusCode.UnprocessableEntity, message)
    {
    }

    public ConfigurationException(string propertyName, string message) : base(HttpStatusCode.UnprocessableEntity, message)
    {
    }

    public ConfigurationException(string message, Exception innerException) : base(HttpStatusCode.UnprocessableEntity, message, innerException)
    {
    }
    public ConfigurationException(string propertyName, string message, Exception innerException) : base(HttpStatusCode.UnprocessableEntity, message,
        innerException)
    {
    }
}
