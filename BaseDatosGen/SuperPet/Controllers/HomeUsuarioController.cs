﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseDatosGenNHibernate.CEN.BaseDatos;
using BaseDatosGenNHibernate.EN.BaseDatos;
using BaseDatosGenNHibernate.CAD.BaseDatos;
using SuperPet.Models;
using MvcApplication1.Models;
namespace SuperPet.Controllers
{
    public class HomeUsuarioController : BasicController
    {
        // GET: HomeUsuario
        public ActionResult Index()
        {
            SessionInitialize();
            SliderCAD sliCAD = new SliderCAD(session);
            SliderCEN sliCEN = new SliderCEN(sliCAD);
            IList<SliderEN> listSliEN = sliCEN.MuestraSliders(0, -1);
            IEnumerable<Slider> lista = new AssemblerSlider().ConvertListENToModel(listSliEN).ToList();
            SessionClose();
            SessionInitialize();
            ProductoCAD cadArt = new ProductoCAD(session);
            CategoriaCAD cadCat = new CategoriaCAD(session);
            ProductoCEN cen = new ProductoCEN(cadArt);
            IList<ProductoEN> listProdEn = cen.MuestraProductos(0, -1); //DameProductosPorCat(id); Falta implementar este hql
            IEnumerable<Producto> listProds = new AssemblerProducto().ConvertListENToModel(listProdEn).ToList();
            //CategoriaEN catEN = cadCat.ReadOIDDefault(id);
            SessionClose();
            SessionInitialize();
            IEnumerable<Producto> listprods2 = new AssemblerProducto().ConvertListENToModel(new ProductoCEN(new ProductoCAD(session)).GetTopVentas()); //GetProductosByNombre(Convert.ToString(form["prod"]), 0, -1));
            SessionClose();
            var tuple2 = Tuple.Create(lista, listProds, listprods2);
            
            return View(tuple2);
        }

        // GET: HomeUsuario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeUsuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeUsuario/Create
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

        // GET: HomeUsuario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeUsuario/Edit/5
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

        // GET: HomeUsuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeUsuario/Delete/5
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
