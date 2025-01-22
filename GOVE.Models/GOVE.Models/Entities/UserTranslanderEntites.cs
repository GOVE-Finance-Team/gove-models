using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOVE.Models.Entities
{
    public class UserTranslanderEntites
    {
        [JsonProperty(PropertyName = "companyId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? CompanyId { get; set; }



        /// <summary>
        /// UserCode.
        /// </summary>
        [JsonProperty(PropertyName = "userCode", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? UserCode { get; set; }

        /// <summary>
        /// User_ID.
        /// </summary>
        [JsonProperty(PropertyName = "userID", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public int? UserID { get; set; }

        /// <summary>
        /// UserName
        /// </summary>
        [JsonProperty(PropertyName = "userName", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? UserName { get; set; }


        /// <summary>
        /// mobileNumber.
        /// </summary>
        [JsonProperty(PropertyName = "mobileNumber", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? MobileNumber { get; set; }


        /// <summary>
        /// EmailID.
        /// </summary>
        [JsonProperty(PropertyName = "emailID", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? EmailID { get; set; }

        /// <summary>
        /// Designation.
        /// </summary>
        [JsonProperty(PropertyName = "designation", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Designation { get; set; }


        /// <summary>
        /// UserLevelID.
        /// </summary>
        [JsonProperty(PropertyName = "userLevel", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Userlevel { get; set; }
    }
}
