using ASP_Dot_Net_MVC_Aug_2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Dot_Net_MVC_Aug_2021.Data.Interfaces
{
    public interface IVendorRepo
    {
        IEnumerable<Vendor> GetAllVendors();
        void CreateVendor(Vendor input);
    }
}
