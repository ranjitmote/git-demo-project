using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using RBTS.Model;

namespace RBTS.Repository
{
    public partial class User
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
