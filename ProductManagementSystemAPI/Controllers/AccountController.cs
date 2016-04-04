using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using ProductManagementSystemData;
using ProductManagementSystemAPI.Models;
using System.Web.Routing;
using System.Web.Http.Description;
using System.Web.Security;
using System.Data.Entity.Validation;

namespace ProductManagementSystemAPI.Controllers
{
    public class AccountController : ApiController
    {
        public IFormsAuthenticationService FormsService { get; set; }
        public IMembershipService MembershipService { get; set; }
        
        protected AccountController()
        {
            if (FormsService == null) { FormsService = new FormsAuthenticationService(); }
            if (MembershipService == null) { MembershipService = new AccountMembershipService(); }            
        }

        [Route("ValidateUser/{username}/{password}")]
        [ResponseType(typeof(bool))]
        [HttpGet]
        public IHttpActionResult Login(string username, string password)
        {
            bool Isvalid = false;
            try
            {                 
                if (MembershipService.ValidateUser(username, password))
                {
                    Isvalid = true;
                }                    
            }                          
            catch (Exception ex)
            {
               
            }            
            return Ok(Isvalid);
        }

        [Route("RegisterUser")]     
        [HttpPost]
        public IHttpActionResult Login([FromBody] tblUserMaster userDetails)
        {
            bool Isvalid = false;
            try
            {
                MembershipCreateStatus registrationStatus= MembershipService.CreateUser(userDetails.EmailId, userDetails.Password, userDetails.EmailId);
                if (registrationStatus.ToString() == "Success") {
                    try
                    {
                        userDetails.UserId = MyMembership.Getuser_id(userDetails.EmailId);
                        using (PMSEntities pms = new PMSEntities()) {
                            userDetails.IsActive = true;                            
                            pms.tblUserMasters.Add(userDetails);
                            pms.SaveChanges();
                        }                                        
                    }
                    catch (Exception e)
                    {                        
                        throw e;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Ok(Isvalid);
        }

        private static string ErrorCodeToString(MembershipCreateStatus createStatus)
        {
            // See http://go.microsoft.com/fwlink/?LinkID=177550 for
            // a full list of status codes.
            switch (createStatus)
            {
                case MembershipCreateStatus.DuplicateUserName:
                    return "User name already exists. Please enter a different user name.";

                case MembershipCreateStatus.DuplicateEmail:
                    return "A user name for that e-mail address already exists. Please enter a different e-mail address.";

                case MembershipCreateStatus.InvalidPassword:
                    return "Invalid Password. Password must contain at least 8 characters, including UPPER/lowercase and special character.";

                case MembershipCreateStatus.InvalidEmail:
                    return "The e-mail address provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidAnswer:
                    return "The password retrieval answer provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidQuestion:
                    return "The password retrieval question provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidUserName:
                    return "The user name provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.ProviderError:
                    return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                case MembershipCreateStatus.UserRejected:
                    return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                default:
                    return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
            }
        }

    }
}
