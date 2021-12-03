using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAPI.Models.DBConnection
{
    public class UserRgister : IdentityUser
    {
        public DateTime? CretedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
