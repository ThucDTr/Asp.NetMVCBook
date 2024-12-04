using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspMVCEcomerce.Models;
using Microsoft.EntityFrameworkCore;

namespace AspMVCEcomerce.Models
{
    public class MyEcommerceDB : DbContext
    {
        public MyEcommerceDB(DbContextOptions<MyEcommerceDB> options) : base(options){

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // foreach(var entityType in modelBuilder.Model.GetEntityTypes()){
            //     var table = entityType.GetTableName();
            //     if(table.StartsWith("AspNet")){
            //         entityType.SetTableName(table.Substring(6));
            //     }
            // }
        }

    }
}