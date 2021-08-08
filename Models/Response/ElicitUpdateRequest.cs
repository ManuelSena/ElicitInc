using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ElicitInc.Models.Response
{
    public class ElicitUpdateRequest : ElicitAddRequest
    {
        [Required]
        public int Id { get; set; }
    }
}