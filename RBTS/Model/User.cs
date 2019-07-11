using System;
using System.ComponentModel.DataAnnotations;

namespace RBTS.Model
{
    public class User
    {
          [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public DateTime? Dob { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
         
    }
}