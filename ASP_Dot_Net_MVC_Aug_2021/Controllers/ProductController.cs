using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Dot_Net_MVC_Aug_2021.Data.Interfaces;
using ASP_Dot_Net_MVC_Aug_2021.Models;

namespace ASP_Dot_Net_MVC_Aug_2021.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepo _productRepo;
        private readonly IVendorRepo _vendorRepo;

        public ProductController(IProductRepo prodRepo, 
            IVendorRepo vendorRepo)
        {
            _productRepo = prodRepo;
            _vendorRepo = vendorRepo;
        }
        public IActionResult Index()
        {
            var vendors = _vendorRepo.GetAllVendors();
            var list = _productRepo.GetAllProducts()
                .Select(p => {
                    p.Vendor = vendors
                                .Where(v => v.V_code == p.V_code)
                                .FirstOrDefault() ?? new Vendor { 
                                    V_name = "n/a"
                                };
                    return p;
                })
                .ToList();
            
            
            return View(list);
        }

        public IEnumerable<string> GetProductsByVendorId(int? id)
        {
            var res = _productRepo.GetAllProducts()
                .Where(p => p.V_code == id)
                .Select(p => p.P_descript + "\t$" + p.P_Price + "<br>");

            if(res == null || res.Count() == 0)
            {
                return new List<string> { "No Product found "};
            }

            return res;
        }
    }
}
