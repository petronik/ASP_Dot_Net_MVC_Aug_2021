using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Dot_Net_MVC_Aug_2021.Data.Interfaces;
using ASP_Dot_Net_MVC_Aug_2021.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using ASP_Dot_Net_MVC_Aug_2021.Data;
using ASP_Dot_Net_MVC_Aug_2021.ModelsDto;

namespace ASP_Dot_Net_MVC_Aug_2021.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepo _productRepo;
        private readonly IVendorRepo _vendorRepo;
        private readonly Mapper _mapper = new Mapper();

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
                                    V_name = "no vendor"
                                };
                    return p;
                })
                .Select(p => _mapper.Map(p))
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

        public ActionResult Create()
        {
            var list = _vendorRepo.GetAllVendors()
                .Select(v => _mapper.Map(v))
                .ToList();

            list.Add(new VendorDto() { V_code = -1, V_name = " - Select Vendor" });
            list.Sort((foo1, foo2) => foo1.V_code.CompareTo(foo2.V_code));
            //list.Reverse();
            ViewBag.Vendors = 
                new SelectList(list,
                "V_code", "V_name");

            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductDto product)
        {
            if (ModelState.IsValid)
            {
                _productRepo.CreateProduct(_mapper.Map(product));
                _productRepo.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        public ActionResult Edit(string id)
        {
            var list = _vendorRepo.GetAllVendors()
                .Select(v => _mapper.Map(v))
                .ToList();
            ViewBag.Vendors =
                new SelectList(list,
                "V_code", "V_name");

            var prod = _mapper.Map( _productRepo.GetProductById(id) );

            return View(prod);
        }

        [HttpPost]
        [Route("Product/Edit")]
        public ActionResult Edit(ProductDto input)
        {
            _productRepo.UpdateProduct( _mapper.Map( input ) );
            _productRepo.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
