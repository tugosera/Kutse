using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kutse.Models
{
    public class Guest
    {
        [Required(ErrorMessage = "Sissesta nimi")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Sissesta email")]
        [RegularExpression(@".+\@.+\..+", ErrorMessage = "Valesti sissestatud email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Sissesta telefoni number")]
        [RegularExpression(@"\+372.+", ErrorMessage = "Numbri alguses peab olema +372")]
        public string Phone {  get; set; }
        [Required(ErrorMessage = "Sissesta oma valik")]

        public bool? WillAttend { get; set; }

    }
}