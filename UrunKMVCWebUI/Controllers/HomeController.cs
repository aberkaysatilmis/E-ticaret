using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UrunKMVCWebUI.Entity;
using UrunKMVCWebUI.Models;

namespace UrunKMVCWebUI.Controllers
{
    public class HomeController : Controller
    {

        DataContext _context=new DataContext();

        DataInitializer dbTst = new DataInitializer();

        


        // GET: Home
        public ActionResult Index()
        {
            var urunler = _context.Products.Where(i => i.IsHome && i.IsApproved).
                Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image==null?"default.img":i.Image,
                    CategoryId = i.CategoryId
                })
                .ToList();

           return View(urunler);
        }
        public ActionResult Details(int id)
        {
            return View(_context.Products.Where(i => i.Id == id).FirstOrDefault());
        }
        public ActionResult List()
        {
            var urunler = _context.Products.Where(i => i.IsApproved).
                Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image == null? "default.img" : i.Image,
                    CategoryId = i.CategoryId
                })
                .ToList();

            return View(urunler);
        }
    }
}