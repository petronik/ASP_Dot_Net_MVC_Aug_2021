using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Dot_Net_MVC_Aug_2021.Models
{
    public class Product
    {
        [Key]
        public string P_Code { get; set; }

        public string P_descript { get; set; }

        [Column(TypeName = "Date")]
        public DateTime P_InDate { get; set; }

        public int P_QOH { get; set; }

        public int P_Min { get; set; }

        public double P_Price { get; set; }

        public double P_Discount { get; set; }
        
        [ForeignKey("Vendor")]
        public int? V_code { get; set; }
        public Vendor Vendor { get; set; }
    }
}
