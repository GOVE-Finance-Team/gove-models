using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace GOVE.Models.Exceptions;

public sealed class ValidationException : GoveException
{
    public ValidationException(ValidationResult validationResult)
    {
        ValidationErrors = validationResult.Errors.Where(x => x != null).GroupBy(x => x.PropertyName, x => x.ErrorMessage,
            (propertyName, errorMessages) => new { Key = propertyName, Values = errorMessages.Distinct().ToArray() }).ToDictionary(x => x.Key, x => x.Values);
    }

    public ValidationException(Dictionary<string, string[]> errors)
       : base(HttpStatusCode.BadRequest, "Validation Failure - One or more validation errors occurred")
       => ValidationErrors = errors;

    public Dictionary<string, string[]> ValidationErrors { get; }
}
