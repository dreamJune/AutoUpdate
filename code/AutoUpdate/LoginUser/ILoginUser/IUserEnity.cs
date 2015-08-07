using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILoginUser
{
    public abstract class IUserEnity
    {
        public string UserId { get; set; }
        public string Password { get; set; }
        public string LocalIp { get; set; }
        public string UserName { get; set; }

    }
}
