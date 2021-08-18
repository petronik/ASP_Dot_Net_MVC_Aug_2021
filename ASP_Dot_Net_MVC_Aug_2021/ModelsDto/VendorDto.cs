using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Dot_Net_MVC_Aug_2021.ModelsDto
{
    public class VendorDto
    {
        [DisplayName("Id")]
        public int V_code { get; set; }

        [DisplayName("Name")]
        [Required]
        public string V_name { get; set; }

        [DisplayName("Contact")]
        public string V_contact { get; set; }

        [DisplayName("Area Code")]
        public int V_AreaCode { get; set; }

        [DisplayName("Phone #")]
        public string V_phone { get; set; }

        [DisplayName("State")]
        public string V_state { get; set; }

        //[DisplayName("Order (Y/N)")]
        //public string V_order { get; set; }
    }
}
