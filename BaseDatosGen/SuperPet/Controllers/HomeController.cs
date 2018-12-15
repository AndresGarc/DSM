using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseDatosGenNHibernate.CAD.BaseDatos;
using BaseDatosGenNHibernate.CEN.BaseDatos;
using BaseDatosGenNHibernate.EN.BaseDatos;
using MvcApplication1.Models;

namespace SuperPet.Controllers
{
    public class HomeController : BasicController
    {
        public ActionResult Index() //Productos Agotados
        {
            SessionInitialize();
            ProductoCAD cadArt = new ProductoCAD(session);
            CategoriaCAD cadCat = new CategoriaCAD(session);
            ProductoCEN cen = new ProductoCEN(cadArt);
            IList<ProductoEN> listProdEn = cen.MuestraProductos(0, -1); //DameProductosPorCat(id); Falta implementar este hql
            IList<ProductoEN> listAgotados = new List<ProductoEN>();
            foreach (ProductoEN cosaProds in listProdEn)
            {
                if (cosaProds.Stock == 0)
                {
                    listAgotados.Add(cosaProds);
                }
            }

            IEnumerable<Producto> listProds = new AssemblerProducto().ConvertListENToModel(listAgotados).ToList();
            //CategoriaEN catEN = cadCat.ReadOIDDefault(id);
            SessionClose();
            return View(listProds);
        }

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            try
            {
                SessionInitialize();
                IEnumerable<Producto> listprods = new AssemblerProducto().ConvertListENToModel(new ProductoCEN(new ProductoCAD(session)).GetProductosByNombreStock(Convert.ToString(form["prod"])));
                SessionClose();

                return View(listprods);
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            Producto prod = null;
            SessionInitialize();
            ProductoEN prodEN = new ProductoCAD(session).ReadOIDDefault(id);
            prod = new AssemblerProducto().ConvertENToModelUI(prodEN);
            SessionClose();
            return View(prod);
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
                ProductoCEN cenf = new ProductoCEN();


                CategoriaCAD catCad = new CategoriaCAD();
                CategoriaCEN catCen = new CategoriaCEN(catCad);

                bool b = true;
                int idcat = 0;


                IList<CategoriaEN> listCatsEN2 = catCen.MuestraCategorias(0, -1);
                IList<CategoriaEN> listcon = new List<CategoriaEN>();
                foreach (CategoriaEN cosaCats in listCatsEN2)
                {

                    if (cosaCats.Nombre == prod.NombreCategoria)
                    {
                        if (cosaCats.Supercategoria != null)
                        {
                            if (cosaCats.Supercategoria.Nombre == prod.NombreSupercategoria)
                            {
                                b = false;
                                idcat = cosaCats.Id;
                            }
                        }
                    }

                }


                if (b == true)
                {
                    idcat = catCen.New_(prod.NombreCategoria);
                }



                bool a = true;
                int idSupCat = 0;

                CategoriaCAD catCad2 = new CategoriaCAD();
                CategoriaCEN catCen2 = new CategoriaCEN(catCad2);
                IList<CategoriaEN> listCatsEN = catCen2.MuestraCategorias(0, -1);
                IList<CategoriaEN> listconSup = new List<CategoriaEN>();
                foreach (CategoriaEN cosaCats in listCatsEN)
                {
                    if (cosaCats.Supercategoria != null)
                    {
                        if (cosaCats.Supercategoria.Nombre == prod.NombreSupercategoria)
                        {
                            a = false;
                            idSupCat = cosaCats.Supercategoria.Id;
                        }
                    }
                }


                if (a == true)
                {
                    idSupCat = catCen.New_(prod.NombreSupercategoria);
                }


                //int idSupCat=catCen.New_(hijo.NombreSupcat);
                catCen.CrearSupercategoria(idcat, idSupCat);

                //prod.IdCategoria =idcat;

                cenf.Modify(prod.id, prod.Nombre, fileName, prod.Precio, prod.Stock, prod.ValoracionMedia, prod.Destacado, prod.Oferta);
                cenf.CambiarCategoria(prod.id, idcat);
                ProductoDescripcionCEN cend = new ProductoDescripcionCEN();

                cend.New_(prod.Descripcion, BaseDatosGenNHibernate.Enumerated.BaseDatos.IdiomaEnum.Castellano, prod.id);

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