using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class AccountController
    {
        private readonly ISecurityService securityService;
        // readonly keyword is the const for complex types, 
        // const is used for simple types like int, string, double
        // if changing to Googles security service we'd have to change 
        // private readonly SecurityService securityService; to
        // private readonly GoogleSecurityService securityService;


        public AccountController()
        {
            //securityService = new SecurityService();
            // if changing to Googles security service we'd have to change 
            // securityService = new SecurityService(); to
            // securityService = new GoogleSecurityService();
            // So that code doesn't have to change to work with different security services(login with facebook)
            // use the following.
            this.securityService = securityService;
        }

        public void ChangeUserPassword(Guid userID, string newPassword)
        {
            this.securityService.ChangePassword(userID, newPassword);
        }
    }
}
