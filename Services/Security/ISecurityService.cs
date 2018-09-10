using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace flyer_expo_api.Services.Security
{
    public interface ISecurityService
    {
        string GetUserDetails();
        string UserDetails { get; set; }

        int mobileno { get; set; }
    }
}
