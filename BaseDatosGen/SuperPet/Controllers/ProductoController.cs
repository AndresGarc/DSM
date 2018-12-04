using BaseDatosGenNHibernate.CAD.BaseDatos;
using BaseDatosGenNHibernate.CEN.BaseDatos;
using BaseDatosGenNHibernate.EN.BaseDatos;
using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperPet.Controllers
{
    public class ProductoController : BasicController
    {
        // GET: Producto
        public ActionResult Index(/*int id*/)
        {
            
            SessionInitialize();
            ProductoCAD cadArt = new ProductoCAD(session);
            CategoriaCAD cadCat = new CategoriaCAD(session);
            ProductoCEN cen = new ProductoCEN(cadArt);
            IList<ProductoEN> listProdEn = cen.MuestraProductos(0,-1); //DameProductosPorCat(id); Falta implementar este hql
            IEnumerable<Producto> listProds = new AssemblerProducto().ConvertListENToModel(listProdEn).ToList();
            //CategoriaEN catEN = cadCat.ReadOIDDefault(id);
            SessionClose();
            return View(listProds);
        }

        // GET: Producto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Producto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Producto/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Producto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
