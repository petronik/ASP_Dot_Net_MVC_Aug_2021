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
        [DisplayName("Code")]
        [Key]
        public string P_Code { get; set; }

        [DisplayName("Description")]
        public string P_descript { get; set; }

        [DisplayName("Date")]
        [Column(TypeName = "Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime P_InDate { get; set; }

        [DisplayName("QOH")]
        public int P_QOH { get; set; }

        [DisplayName("Min")]
        public int P_Min { get; set; }

        [DisplayName("Price")]
        public double P_Price { get; set; }

        [DisplayName("Discount")]
        public double P_Discount { get; set; }
        
        [DisplayName("Vendor")]
        [ForeignKey("Vendor")]
        public int? V_code { get; set; }
        public Vendor Vendor { get; set; }
    }
}
