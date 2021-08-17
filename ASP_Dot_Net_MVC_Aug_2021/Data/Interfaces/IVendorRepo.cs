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
        Vendor GetVendorById(int id);
        void CreateVendor(Vendor input);
        void UpdateVendor(Vendor input);
        bool SaveChanges();
    }
}
