using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CollegeAPI.Models.DBConnection
{
    public class UserAuthenticationContext : IdentityDbContext<UserRgister,IdentityRole,string>
    {
        public UserAuthenticationContext(DbContextOptions options): base(options)
        {

        }
    }
}
