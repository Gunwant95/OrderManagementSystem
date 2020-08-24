using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp_0608.Models
{
    public class Students
    {
        public int ID { get; set; }
        [Required(ErrorMessage="Name is required")]
        [MaxLength(12)]
        public string Name { get; set; }

        [Required(ErrorMessage ="Email address is required")]
        [EmailAddress(ErrorMessage ="Email address is invalid")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Contact is required")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-.]?([0-9]{3})[-.]?([0-9]{4})$",ErrorMessage ="Not a valid phone number")]
        public string contact { get; set; }
    }
}