using ASP_Dot_Net_MVC_Aug_2021.Data;
using ASP_Dot_Net_MVC_Aug_2021.Data.Interfaces;
using ASP_Dot_Net_MVC_Aug_2021.Models;
using ASP_Dot_Net_MVC_Aug_2021.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Dot_Net_MVC_Aug_2021.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepo _orderRepo;
        private readonly IProductRepo _productRepo;
        private readonly IOrderProductsRepo _orderProductsRepo;
        private readonly Mapper _mapper = new Mapper();

        public OrderController(IOrderRepo orderRepo, 
            IProductRepo productRepo, IOrderProductsRepo orderProductsRepo)
        {
            _orderRepo = orderRepo;
            _productRepo = productRepo;
            _orderProductsRepo = orderProductsRepo;
        }

        // GET: OrderController
        public ActionResult Index()
        {
            var orders = _orderRepo.GetAllOrders().Select(o => _mapper.Map(o));
            return View(orders);
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public ActionResult GetProductsByOrderId(int id)
        {
            var orderProduct = _orderProductsRepo.GetAllOrderProducts();
            var products = _productRepo.GetAllProducts()
                .Select(p =>
                    new ProductVM {
                        Id = p.P_Code,
                        Description = p.P_descript,
                        Price = p.P_Price,
                        IsActive =
                        orderProduct
                            .Where(op => op.ProductId == p.P_Code &&
                                op.OrderId == id)
                            .FirstOrDefault() == null ? false : true
                    }
                )
                .ToList();

            SaveProductsInOrderVM pvm = new SaveProductsInOrderVM { 
                Products = products,
                OrderId = id
            };

            return PartialView(pvm);
        }

        public ActionResult SaveProducts(SaveProductsInOrderVM obj)
        {
            _orderProductsRepo.RemoveRange(obj.OrderId);

            var rangeToAdd = obj.Products
                .Where(p => p.IsActive)
                .Select(op => new OrderProducts
                {
                    OrderId = obj.OrderId,
                    ProductId = op.Id
                });

            _orderProductsRepo.AddRange(rangeToAdd);
            _orderProductsRepo.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
