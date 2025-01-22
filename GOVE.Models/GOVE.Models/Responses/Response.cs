using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOVE.Models.Responses;

public class Response
{
    public class GoveResponse
    {
        public Status? Status { get; set; }
        public Error? Error { get; set; }

        public object? Message { get; set; }
        public int? Id { get; set; }
    }

    public class Error
    {
        public string? ErrorMessage { get; set; }
    }
    public enum Status
    {
        Success,
        Error
    }

}
