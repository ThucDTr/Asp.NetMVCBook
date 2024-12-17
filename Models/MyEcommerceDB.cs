using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspMVCEcomerce.Models;
using AspMVCEcomerce.Models.contact;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspMVCEcomerce.Models
{
    public class MyEcommerceDB : IdentityDbContext<AppUser>
    {
        public MyEcommerceDB(DbContextOptions<MyEcommerceDB> options) : base(options){

        }

        public DbSet<Contact> Contacts { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach(var entityType in modelBuilder.Model.GetEntityTypes()){
                var table = entityType.GetTableName();
                if(table.StartsWith("AspNet")){
                    entityType.SetTableName(table.Substring(6));
                }
            }
        }

    }
}