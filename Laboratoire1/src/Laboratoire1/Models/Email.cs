using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratoire1.Models
{
    public class Email
    {
        [Required]
        public string from { get; set; }
        [Required]
        public string to { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string subject { get; set; }
        [Required]
        public string content { get; set; }
    }
}
