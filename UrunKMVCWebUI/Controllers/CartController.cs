using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UrunKMVCWebUI.Entity;
using UrunKMVCWebUI.Models;

namespace UrunKMVCWebUI.Controllers
{
    public class CartController : Controller
    {

        private DataContext db = new DataContext();
        // GET: Cart
        public ActionResult Index()
        {
            return View(GetCart());
        }

        public ActionResult AddToCart(int Id)
        {
            var product =db.Products.FirstOrDefault(i=>i.Id == Id);

            if (product != null)
            {
                GetCart().AddProduct(product, 1);
            }

            return RedirectToAction("Index");
        }

        public ActionResult RemoveFromCart(int Id)
        {
            var product = db.Products.FirstOrDefault(i => i.Id == Id);

            if (product != null)
            {
                GetCart().DeleteProduct(product);
            }

            return RedirectToAction("Index");
        }

        public Cart GetCart()
        {
            var cart = (Cart)Session["Cart"];   
            //Session : Her kullanıcıya özel oluşturulan depodur.

            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"]=cart;
            }
            return cart;
        }

    }
}