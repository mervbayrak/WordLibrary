using System;
using System.Web;
using System.Collections.Generic;
using System.Text;

namespace WordLibrary.Core.CrossCuttingConcers.Security.Web
{
    public class AuthenticationHelper
    {
        public static void CreateAutCookie(Guid id, string userName, string email, DateTime expiration,string[] roles,
            bool rememberMe, string firstName, string lastName)
        {
            //var authTicket= new FormsAuthenticationTicket()
        }
    }
}
