using System;
using Microsoft.AspNetCore.Identity;

namespace CreateMigrations.Infrastructure.Identity.Models
{
    public class ApplicationRole(string name) : IdentityRole<Guid>(name)
    {
    }
}
