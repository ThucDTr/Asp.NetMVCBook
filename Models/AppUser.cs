using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AspMVCEcomerce.Controllers;
using Microsoft.AspNetCore.Identity;

namespace AspMVCEcomerce.Models
{
    public class AppUser : IdentityUser
    {

        [Column(TypeName = "nvarchar")]
        [StringLength(400)]
        public string HomeAdress { set; get; }

        [DataType(DataType.Date)]
        public DateTime? BirthDate { set; get; }
    }
}