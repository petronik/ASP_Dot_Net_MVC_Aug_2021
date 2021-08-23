using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Dot_Net_MVC_Aug_2021.ViewModel
{
    public class SaveProductsInOrderVM
    {
        public List<ProductVM> Products { get; set; }
        public int OrderId { get; set; }
    }
}
