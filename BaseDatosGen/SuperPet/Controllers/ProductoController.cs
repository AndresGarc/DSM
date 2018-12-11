﻿using BaseDatosGenNHibernate.CAD.BaseDatos;
using BaseDatosGenNHibernate.CEN.BaseDatos;
using BaseDatosGenNHibernate.EN.BaseDatos;
using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace SuperPet.Controllers
{
    public class ProductoController : BasicController
    {
        // GET: Producto

        //[Authorize] quien este autorizado podrá acceder 
        //GARANTIZAR 100%
        //[AllowAnonymous] -> asegura que una persona anónima puede acceder
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
            Producto prod = null;
            SessionInitialize();
            ProductoEN prodEN = new ProductoCAD(session).ReadOIDDefault(id);
            prod = new AssemblerProducto().ConvertENToModelUI(prodEN);
            SessionClose();
            return View(prod);
        }

        // GET: Producto/Create
        public ActionResult Create(/*int id*/)//ahi iria el id de la categoria del articulo que queremos crear
        {
            int id = 32769;
            Producto prod = new Producto();
            prod.IdCategoria = id;
            return View(prod);
        }

        // POST: Producto/Create
        [HttpPost]
        /*public ActionResult Create(FormCollection collection)
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
        }*/
        public ActionResult Create(Producto prod, HttpPostedFileBase file)
        {
            string fileName = "", path = "";
            // Verify that the user selected a file
            if (file != null && file.ContentLength > 0)
            {
                // extract only the fielname
                fileName = Path.GetFileName(file.FileName);
                // store the file inside ~/App_Data/uploads folder
                path = Path.Combine(Server.MapPath("~/Images/Uploads"), fileName);
                //string pathDef = path.Replace(@"\\", @"\");
                file.SaveAs(path);
            }

            try
            {
                fileName = "/Images/Uploads/" + fileName;
                ProductoCEN cen = new ProductoCEN();
                cen.New_(prod.Nombre, fileName/*prod.Imagen*/, prod.Precio, prod.Stock, prod.IdCategoria, prod.ValoracionMedia,prod.Destacado,prod.Oferta);

                // return RedirectToAction("PorCategoria", new { id = prod.IdCategoria });
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
            Producto prod = null;
            SessionInitialize();
            ProductoEN prodEN = new ProductoCAD(session).ReadOIDDefault(id);
            prod = new AssemblerProducto().ConvertENToModelUI(prodEN);
            SessionClose();
            return View(prod);
        }

        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit(Producto prod, HttpPostedFileBase file)
        {
            string fileName = "", path = "";
            // Verify that the user selected a file
            if (file != null && file.ContentLength > 0)
            {
                // extract only the fielname
                fileName = Path.GetFileName(file.FileName);
                // store the file inside ~/App_Data/uploads folder
                path = Path.Combine(Server.MapPath("~/Images/Uploads"), fileName);
                //string pathDef = path.Replace(@"\\", @"\");
                file.SaveAs(path);
            }
            try
            {
                fileName = "/Images/Uploads/" + fileName;
                ProductoCEN cen = new ProductoCEN();
                cen.Modify(prod.id, prod.Nombre, fileName, prod.Precio, prod.Stock,prod.ValoracionMedia,prod.Destacado,prod.Oferta);

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
            try
            {
                // TODO: Add delete logic here
                int idCategoria = -1;
                SessionInitialize();
                ProductoCAD prodCAD = new ProductoCAD(session);
                ProductoCEN cen = new ProductoCEN(prodCAD);
                ProductoEN prodEN = cen.MuestraProductoPorOID(id);
                Producto prod = new AssemblerProducto().ConvertENToModelUI(prodEN);
                idCategoria = prod.IdCategoria;
                SessionClose();

                new ProductoCEN().Destroy(id);


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
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
