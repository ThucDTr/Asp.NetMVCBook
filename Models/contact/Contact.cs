using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspMVCEcomerce.Models.contact
{
    public class Contact
    {
        [Key]
        public int Id { set; get; }

        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        [Required(ErrorMessage = "Phai Nhap ten")]
        public string FullName { set; get; }

        [Required(ErrorMessage = "Phai Nhap Email")]
        [EmailAddress(ErrorMessage = "email khong dung dinh dang")]
        public string Email { set; get; }

        public DateTime DateSent { set; get; }

        public string Message { set; get; }

        [StringLength(10)]
        [Phone(ErrorMessage = "Khong phai sdt")]
        public string Phone { set; get; }
    }
}