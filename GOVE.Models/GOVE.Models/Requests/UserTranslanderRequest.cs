using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOVE.Models.Requests
{
    public class UserTranslanderRequest
    {
        [JsonProperty(PropertyName = "userId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? UserId { get; set; }

        [JsonProperty(PropertyName = "companyId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? CompanyId { get; set; }
    }
}
