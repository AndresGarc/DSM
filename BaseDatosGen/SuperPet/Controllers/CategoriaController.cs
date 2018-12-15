using BaseDatosGenNHibernate.CAD.BaseDatos;
using BaseDatosGenNHibernate.CEN.BaseDatos;
using BaseDatosGenNHibernate.EN.BaseDatos;
using SuperPet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperPet.Controllers
{
    public class CategoriaController : BasicController
    {
        // GET: Categoria
        public ActionResult Index() //INDICE: QUIERO VER UNA LISTA CON LAS CATEGORIAS 
        {
            SessionInitialize();
            CategoriaCAD catCad = new CategoriaCAD(session);
            CategoriaCEN catCen = new CategoriaCEN(catCad);
            IList<CategoriaEN> listCatsEN = catCen.MuestraCategorias(0, -1);
            IList<CategoriaEN> listconSup = new List<CategoriaEN>();
            foreach (CategoriaEN cosaCats in listCatsEN)
            {
                if (cosaCats.Supercategoria != null)
                {
                    listconSup.Add(cosaCats);
                }
            }
            IEnumerable<Categoria> listCats = new AssemblerCategoria().ConvertListENToModel(listconSup).ToList();
            SessionClose();
            return View(listCats);
        }

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            try
            {
                SessionInitialize();
                IEnumerable<Categoria> cats = new AssemblerCategoria().ConvertListENToModel(new CategoriaCEN(new CategoriaCAD(session)).GetSubcategoriasByNombre(Convert.ToString(form["supcateg"])));
                SessionClose();

                return View(cats);
            }
            catch
            {
                return View();
            }
        }

        // GET: Categoria/Details/5 -> ver los detalles de las categorias
        public ActionResult Details(int id)
        {
            SessionInitialize();
            CategoriaEN catEN = new CategoriaCAD(session).MuestraCategoriaPorOID(id);
            Categoria cat = new AssemblerCategoria().ConvertENToModelUI(catEN);
            SessionClose();
            return View(cat);
        }

        //CREAR CATEGORIAS

        // GET: Categoria/Create
        public ActionResult Create()
        {
            Categoria cat = new Categoria();
            return View(cat);
        }

        // POST: Categoria/Create
        [HttpPost]
        public ActionResult Create(Categoria cat)
        {
            try
            {
                SessionInitialize();
                CategoriaCAD catCad = new CategoriaCAD();
                CategoriaCEN catCen = new CategoriaCEN(catCad);
                catCen.New_(cat.NombreCat);
                SessionClose();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //CREAR SUPERCATEGORIAS
        //  GET: Categoria/CreateSup
        public ActionResult CreateSup()
        {
            Categoria cathij = new Categoria();
            Categoria catpad = new Categoria();
            return View(cathij.NombreCat,catpad.NombreCat); //PASO POR PARAMETRO A LA VISTA CREATESUB ESE OBJETO CATEGORIA 
        }

        // POST: Categoria/CreateSup -> no funca
        [HttpPost]
        public ActionResult CreateSup(Categoria hijo, Categoria padre)
        {
            try
            {
                // TODO: Add insert logic here
                SessionInitialize();

                CategoriaCAD catCad = new CategoriaCAD();
                CategoriaCEN catCen = new CategoriaCEN(catCad);
                int idcat=catCen.New_(hijo.NombreCat);
                bool a = true;
                int idSupCat=0;

                CategoriaCAD catCad2 = new CategoriaCAD();
                CategoriaCEN catCen2 = new CategoriaCEN(catCad2);
                IList<CategoriaEN> listCatsEN = catCen2.MuestraCategorias(0, -1);
                IList<CategoriaEN> listconSup = new List<CategoriaEN>();
                foreach (CategoriaEN cosaCats in listCatsEN)
                {
                    if (cosaCats.Supercategoria != null)
                    {
                        if (cosaCats.Supercategoria.Nombre== hijo.NombreSupcat) {
                            a = false;
                            idSupCat = cosaCats.Supercategoria.Id;
                        }
                    }
                }


                if (a == true)
                {
                    idSupCat = catCen.New_(hijo.NombreSupcat);
                }


                //int idSupCat=catCen.New_(hijo.NombreSupcat);
                catCen.CrearSupercategoria(idcat, idSupCat);

                
                /*
                IList<int> subcas = new List<int>();
                int id_sub = hijosEN.Id;
                subcas.Add(id_sub);

                int id_cat = padreEN.Id;
                */
                //catCad.CrearSubcategoria(id_cat,subcas);
                SessionClose();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categoria/Edit/5
        public ActionResult Edit(int id)
        {
            SessionInitialize();
            CategoriaEN catEn = new CategoriaCAD(session).MuestraCategoriaPorOID(id);
            Categoria cat = new AssemblerCategoria().ConvertENToModelUI(catEn);
           
            SessionClose();
            return View(cat);
        }

        // POST: Categoria/Edit/5
        [HttpPost]
        public ActionResult Edit(Categoria cat, FormCollection collection)
        {
            try
            {
                SessionInitialize();
                CategoriaCAD catCAD = new CategoriaCAD();
                CategoriaCEN catCEN = new CategoriaCEN(catCAD);
                catCEN.Modify(cat.id, cat.NombreCat);


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
                        if (cosaCats.Supercategoria.Nombre == cat.NombreSupcat)
                        {
                            a = false;
                            idSupCat = cosaCats.Supercategoria.Id;
                        }
                    }
                }


                if (a == true)
                {
                    idSupCat = catCEN.New_(cat.NombreSupcat);
                }


                //int idSupCat=catCen.New_(hijo.NombreSupcat);
                catCEN.CrearSupercategoria(cat.id, idSupCat);


                //int idsup = cat.idSuperCategoria;
                //PRUEBA MODIFICAR LA CATEGORIA TAMBIEN
                /* if (cat.NombreCat != null)
                 {
                     catCEN.CrearSupercategoria(cat.id,idsup);
                 }*/
                SessionClose();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categoria/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                SessionInitialize();
                CategoriaCAD catCad = new CategoriaCAD();
                CategoriaCEN catCen = new CategoriaCEN(catCad);
                CategoriaEN catEN = new CategoriaCAD(session).MuestraCategoriaPorOID(id);
                Categoria cat = new AssemblerCategoria().ConvertENToModelUI(catEN);

                SessionClose();

                catCen.Destroy(cat.id);
                return RedirectToAction("Index");

            }
            catch
            {

                return View();
            }
           }

        // POST: Categoria/Delete/5
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
