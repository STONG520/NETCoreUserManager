using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PhoneWEBAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int userMoney { get; set; }
    }
}
