using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ElicitInc.Models.Response
{
    public class ElicitAddRequest
    {
        [Required]
        public string TypeName { get; set; }
        [Required]
        public string Details { get; set; }

    }
}