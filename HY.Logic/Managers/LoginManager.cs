using System;
using System.Collections.Generic;
using System.Text;

namespace HY.Logic.Managers
{
    public class LoginManager : HYManager
    {
        private static string loginRequiredEntities = "Account";

        public LoginManager() : base("LoginManager", loginRequiredEntities)
        {

        }
    }
}
