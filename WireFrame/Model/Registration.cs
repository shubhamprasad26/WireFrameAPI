using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WireFrame.Model
{
    public class Registration
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
        public bool isUser { get; set; }
        public int contactNo { get; set; }
        public string Address { get; set; }
    }
}
