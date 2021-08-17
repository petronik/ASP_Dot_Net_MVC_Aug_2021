using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP_Dot_Net_MVC_Aug_2021.Data.Interfaces;
using ASP_Dot_Net_MVC_Aug_2021.Models;

namespace ASP_Dot_Net_MVC_Aug_2021.Controllers
{
    public class VendorController : Controller
    {
        private readonly IVendorRepo _vendorRepo;

        public VendorController(IVendorRepo vendorRepo)
        {
            _vendorRepo = vendorRepo;
        }
        public IActionResult Index()
        {
            return View(_vendorRepo.GetAllVendors());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Vendor input)
        {
            _vendorRepo.CreateVendor(input);
            _vendorRepo.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            var v = _vendorRepo.GetVendorById(id);
            return View(v);
        }

        [HttpPost]
        public ActionResult Edit(Vendor vendor)
        {
            _vendorRepo.UpdateVendor(vendor);

            return RedirectToAction(nameof(Index));
        }
    }
}
