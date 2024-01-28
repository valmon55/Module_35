using ASP.SocialNetwork.Models.DAL;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.SocialNetwork.Data
{
    public class SocialNetworkDBContext: IdentityDbContext<User>
    {
        public SocialNetworkDBContext(DbContextOptions<SocialNetworkDBContext> options) : base(options)
        { 
            Database.EnsureCreated();
        }
    }
}
