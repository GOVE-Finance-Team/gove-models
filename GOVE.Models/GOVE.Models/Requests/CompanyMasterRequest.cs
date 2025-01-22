using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOVE.Models.Requests
{
    public class CompanyMasterRequest
    {
        [JsonProperty(PropertyName = "companyId", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public long? CompanyId { get; set; }

        /// <summary>
        /// Company Code.
        /// </summary>
        [JsonProperty(PropertyName = "companycode", NullValueHandling = NullValueHandling.Ignore, Required = Required.Default)]
        public string? Company_Code { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyAddress { get; set; }
        public string? City { get; set; }
        public string State { get; set; }
        public string? Country { get; set; }
        public string? ZipCode { get; set; }
        public string? ConstitutionalStatusId { get; set;}
        public string? CDCEOHeadName { get; set; }
        public string? CDTelephoneNumber { get; set; }
        public string? CDMobileNumber { get; set; }
        public string? CDEmailID {  get; set; }

        public string? CDWebsite {  get; set; }
        public string? CDSysAdminUserCode { get; set; }
        public string? CDSysAdminUserPassword {  get; set; }
        public string? ODCommunicationAddress { get; set; }
        public string? ODAddress1 { get; set; }
        public string? ODCity { get; set; }
        public string? ODState { get; set; }
        public string? ODCountry { get; set; }
        public string? ODZipCode { get; set; }
        public string? ODDateOfIncorporation { get; set; }
        public string? ODRegLicNumber { get; set; }
        public string? ODValidityOfRegLicNumber { get; set; }

        public string? OD_Income_Tax_PAN_Number { get; set; }

        public string? Currency {  get; set; }

        public string? OD_Remarks { get; set; }
        public string? Active { get; set; }
        public string? GST_Number { get; set; }
        public string? Constitutional_Status { get; set; }
    }
}
