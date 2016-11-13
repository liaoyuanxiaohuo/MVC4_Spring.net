using IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class UserInfoService : IUserInfoService
    {
        public string ShowMvcMsg()
        {
            return "Hello Spring.Net MVC4";
        }
    }
}
