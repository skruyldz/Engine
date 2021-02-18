using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SompoEngine.WebUI.Models
{
    public enum StatusValue
    {
        [Display(Name = "Olumlu")]
        Success = 1,

        [Display(Name = "Bilgi")]
        Information = 2,

        [Display(Name = "Olumsuz")]
        Rejected = 3
    }
}
