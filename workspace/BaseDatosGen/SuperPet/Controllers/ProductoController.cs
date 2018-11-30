using BaseDatosGenNHibernate.CAD.BaseDatos;
using BaseDatosGenNHibernate.CEN.BaseDatos;
using BaseDatosGenNHibernate.EN.BaseDatos;
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
        public ActionResult Index()
        {
            //EJEMPLO CON EL CEN
            ProductoCEN prodCen = new ProductoCEN();
            IEnumerable<ProductoEN> listProds = prodCen.MuestraProductos(0,-1).ToList();

            return View(listProds);
        }

        // GET: Producto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Producto/Create
        public ActionResult Create() //SI NO PEDIMOS PARAMETROS NOS LLEVARIA A ESTE CREATE
        {
            ProductoEN prodEN = new ProductoEN();
            
            return View(prodEN); //LO ENVIAMOS VACIO PARA QUE ESA VISTA RELLENE EL PRODUCTO
        }

        // POST: Producto/Create
        [HttpPost]
        public ActionResult Create(ProductoEN prodEN) 
        {
            try
            {
                // TODO: Add insert logic here
                SessionInitialize();
                ProductoCAD proCad = new ProductoCAD();
                proCad.New_(prodEN);
                SessionClose();
                return RedirectToAction("Index"); //ME DEVUELE A EL INDICE DE PRODUCTO
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
