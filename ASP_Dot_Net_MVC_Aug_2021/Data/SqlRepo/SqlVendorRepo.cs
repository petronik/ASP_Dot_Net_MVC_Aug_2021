using ASP_Dot_Net_MVC_Aug_2021.Data.Interfaces;
using ASP_Dot_Net_MVC_Aug_2021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Dot_Net_MVC_Aug_2021.Data.SqlRepo
{
    public class SqlVendorRepo : IVendorRepo
    {
        private readonly AppDbContext _context;
        public SqlVendorRepo(AppDbContext context)
        {
            _context = context;
        }
        public void CreateVendor(Vendor input)
        {
            if (input == null)
                throw new ArgumentException(nameof(input));

            _context.Vendors.Add(input);
        }

        public IEnumerable<Vendor> GetAllVendors()
        {
            return _context.Vendors.ToList();
        }

        public Vendor GetVendorById(int id)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges() >= 0;
        }

        public void UpdateVendor(Vendor input)
        {
            throw new NotImplementedException();
        }
    }
}
