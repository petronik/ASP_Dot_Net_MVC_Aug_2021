using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Dot_Net_MVC_Aug_2021.ModelsDto
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        [DisplayName("Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]

        public DateTime Date { get; set; }
    }
}
