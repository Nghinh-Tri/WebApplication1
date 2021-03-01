using ESMS.Data.Configurations;
using ESMS.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication1.EF
{
    public class ESMSDbContext : DbContext
    {
        public ESMSDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Certification> Certifications { get; set; }
    }
}