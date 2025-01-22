using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOVE.Models.Constants
{
    public class Constants
    {
        public const string APP_SECRET = "wSGnVqSnc@4iNj2Qe^S-8ZnvEHQ-UyGS~y)[;yhJdt'#ox<vG%Mp8Gn{EZyG#Db";
        public const string APP_SCOPE = "amsApiRequestScope";
        public const string APP_CLIENT_ID = "A25A96F4D2E6193E5D28F52176622";
        public const string IdentityServerConfigurationKey = "IdentityServerUrl";
        public const string Passphrase = "Al!5(iV3@aij%9hT";
        public const string LeadIdString = "{LEAD_ID}";
        public static class ApiResource
        {
            public const string Role = "role";
            public const string Admin = "admin";
            public const string User = "user";
            public const string UserApi = "userManagementApi";
            public const string ApiResourceSecret = "C8EF369FEAD9FF58A847244243A6B";
            public const string UserApiScope = "userApiScope";
            public const string UserApiResouceDisplayName = "User API";
        }

        public static class Characters
        {
            /// <summary>
            /// The constant for ampersand character.
            /// </summary>
            public const char Ampersand = '@';

            /// <summary>
            /// The constant for backslash character.
            /// </summary>
            public const char Backslash = '\\';

            /// <summary>
            /// The constant for colon character.
            /// </summary>
            public const char Colon = ':';

            /// <summary>
            /// The constant for comma character.
            /// </summary>
            public const char Comma = ',';

            /// <summary>
            /// The constant for forward slash character.
            /// </summary>
            public const char ForwardSlash = '/';

            /// <summary>
            /// The constant for period character.
            /// </summary>
            public const char Period = '.';

            /// <summary>
            /// The constant for pipe character.
            /// </summary>
            public const char Pipe = '|';

            /// <summary>
            /// The constant for round bracket close character.
            /// </summary>
            public const char RoundBracketClose = ')';

            /// <summary>
            /// The constant for round bracket open character.
            /// </summary>
            public const char RoundBracketOpen = '(';

            /// <summary>
            /// The constant for space character.
            /// </summary>
            public const char Space = ' ';

            /// <summary>
            /// The constant for square bracket close character.
            /// </summary>
            public const char SquareBracketClose = ']';

            /// <summary>
            /// The constant for square bracket open character.
            /// </summary>
            public const char SquareBracketOpen = '[';

            /// <summary>
            /// The constant for question mark character.
            /// </summary>
            public const char QuestionMark = '?';

            /// <summary>
            /// The constant for asterisk mark character.
            /// </summary>
            public const char Asterisk = '*';

            /// <summary>
            /// The constant for carat mark character.
            /// </summary>
            public const char Carat = '^';

            /// <summary>
            /// The constant for double quote character.
            /// </summary>
            public const char DoubleQuote = '"';

            /// <summary>
            /// The constant for equals character.
            /// </summary>
            public const char Equality = '=';
        }
        public static class ServiceKey
        {
            /// <summary>
            /// Contains keys for different file exporters used in the application.
            /// </summary>
            public static class FileExporter
            {
                /// <summary>
                /// The key for the Excel file exporter service.
                /// </summary>
                public const string Excel = "excel";
            }
        }
        public static class Web
        {
            /// <summary>
            /// Contains constants related to authorization.
            /// </summary>
            public static class Authorization
            {
                /// <summary>
                /// The name of the request header that provides authorization info.
                /// </summary>
                public const string RequestHeaderAuthorizationKey = "Authorization";

                /// <summary>
                /// The authorization type to use.
                /// </summary>
                public const string Type = "Bearer";

                /// <summary>
                /// Contains constants for claim types.
                /// </summary>
                public static class ClaimType
                {
                    /// <summary>
                    /// The claim type for client ID.
                    /// </summary>
                    public const string ClientId = "clientId";

                    /// <summary>
                    /// The claim type for email.
                    /// </summary>
                    public const string Email = "email";

                    /// <summary>
                    /// The claim type for first name.
                    /// </summary>
                    public const string FirstName = "firstName";

                    /// <summary>
                    /// The claim type for last name.
                    /// </summary>
                    public const string LastName = "lastName";

                    /// <summary>
                    /// The claim type for login name.
                    /// </summary>
                    public const string LoginName = "loginName";

                    /// <summary>
                    /// The claim type for params.
                    /// </summary>
                    public const string Params = "params";

                    /// <summary>
                    /// The claim type for SAM account name.
                    /// </summary>
                    public const string ParamsSamAccountName = "SAM-Account-Name";

                    /// <summary>
                    /// The claim type for staff ID.
                    /// </summary>
                    public const string StaffId = "staffId";
                }
            }
            public static class ContentType
            {
                /// <summary>
                /// The content type for JSON data format.
                /// </summary>
                /// <remarks>
                /// This constant is used to set the 'Content-Type' header of HTTP requests and responses to 'application/json'.
                /// This indicates that the body of the request or response is formatted as JSON.
                /// </remarks>
                public const string Json = "application/json";

                /// <summary>
                /// The content type for Office Excel data format.
                /// </summary>
                /// <remarks>
                /// This constant is used to set the 'Content-Type' header of HTTP requests and responses to 'application/vnd.openxmlformats-officedocument.spreadsheetml.sheet'.
                /// This indicates that the body of the request or response is formatted as an Office Excel document.
                /// </remarks>
                public const string OfficeExcel = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            }
        }

        public static class SqlColumnNames
        {
            public const string CompanyID = "Company_ID";
            public const string CompanyCode = "Company_Code";
            public const string CompanyName = "Company_Name";
            public const string CompanyAddress = "Company_Address";
            public const string City = "City";
            public const string State = "State";
            public const string Country = "Country";
            public const string ZipCode = "Zip_Code";
            public const string ConstitutionalStatusId = "Constitutional_Status_Id";
            public const string CDCEOHeadName = "CD_CEO_Head_Name";
            public const string CDTelephoneNumber = "CD_Telephone_Number";
            public const string CDMobileNumber = "CD_Mobile_Number";
            public const string CDEmailID = "CD_Email_ID";
            public const string CDWebsite = "CD_Website";
            public const string CDSysAdminUserCode = "CD_Sys_Admin_User_Code";
            public const string CDSysAdminUserPassword = "CD_Sys_Admin_User_Password";
            public const string ODCommunicationAddress = "OD_Communication_Address";
            public const string ODAddress1 = "OD_Address1";
            public const string ODCity = "OD_City";
            public const string ODState = "OD_State";
            public const string ODCountry = "OD_Country";
            public const string ODZipCode = "OD_Zip_Code";
            public const string ODDateOfIncorporation = "OD_Date_Of_Incorporation";
            public const string ODRegLicNumber = "OD_Reg_Lic_Number";
            public const string ODValidityOfRegLicNumber = "OD_Validity_Of_Reg_Lic_Number";
            public const string OD_Income_Tax_PAN_Number = "OD_Income_Tax_PAN_Number";
            public const string Currency = "Currency";
            public const string OD_Remarks = "OD_Remarks";
            public const string Active = "Active";
            public const string GST_Number = "GST_Number";
            public const string Constitutional_Status = "Constitutional_Status";

            public const string ModuleName = "Module_Name";
            public const string ProgramCode = "Program_Code";
            public const string ProspectCode = "Prospect_Code";
            public const string ProspectId = "Prospect_ID";
            public const string ProspectDate = "Prospect_Date";
            public const string LocationId = "Location_ID";
            public const string LocationDescription = "Location_Description";
            public const string ProspectName = "Prospect_Name";
            public const string ProspectTypeId = "Prospect_Type_ID";
            public const string GenderId = "Gender_ID";
            public const string GenderName = "Gender_Name";
            public const string DateofBirth = "Prospect_DateofBirth";
            public const string MobileNumber = "Mobile_Number";
            public const string MobileNumberr = "Mobile Number";

            public const string AlternateMobileNumber = "Alternate_MobileNumber";
            public const string Website = "Website";

            public const string UserName = "User_Name";

            public const string UserID = "User_ID";
            public const string UserCode = "User_Code";
            public const string Gender_Id = "GenderID";
            public const string Password = "Password";
            public const string DOJ = "Doj";
            public const string Email = "Email_ID";
            public const string EmergencycontactNumber = "EmergencyContact_Number";
            public const string Designation = "Designation";
            public const string UserLevelID = "User_LevelID";
            public const string UserLevel = "User_Level";
            public const string ReportingNextlevel = "Reporting_HigherLevel";

            public const string FatherName = "Fathername";
            public const string MotherName = "Mothername";
            public const string SpouseName = "SpouseName";
            public const string MaritialID = "Maritial_Status_ID";
            public const string AadharNumber = "AadharNumber";
            public const string PanNumber = "PanNumber";
            public const string Address = "Address";
            public const string UserImagepath = "UserImage";

            public const string DoB = "DateofBirth";
        }
        public static class Messages
        {
            
            public const string INVALID_USER = "The User with the Login Combnation does not exist. Please check and retry later.";
       
            public const string NO_RECORDS_FOUND = "No Record exists for the submitted details.Please correct your search and try again.";
        }
    }
}
