using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class GoogleSecurityService : ISecurityService
    {
        //private readonly IUserRepository userRepo;

        public void ChangePassword(Guid userID, string newPassword)
        {
            ///....verify userid
        }
    }
}