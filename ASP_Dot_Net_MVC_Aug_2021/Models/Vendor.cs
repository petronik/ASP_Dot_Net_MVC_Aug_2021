﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Dot_Net_MVC_Aug_2021.Models
{
    public class Vendor
    {
        [Key]
        public int V_code { get; set; }

        [Required]
        public string V_name { get; set; }

        public string V_contact { get; set; }

        public int V_AreaCode { get; set; }

        public string V_phone { get; set; }

        public string V_state { get; set; }

        public string V_order { get; set; }
    }
}
