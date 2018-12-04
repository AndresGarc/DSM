/*using BaseDatosGenNHibernate.CAD.BaseDatos;
using BaseDatosGenNHibernate.CEN.BaseDatos;
using BaseDatosGenNHibernate.EN.BaseDatos;
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
            CategoriaCEN catCen = new CategoriaCEN();
            IEnumerable<CategoriaEN> listCats = catCen.MuestraCategorias(0, -1).ToList();

            return View(listCats);
        }

        // GET: Categoria/Details/5 -> ver los detalles de las categorias
        public ActionResult Details(int id)
        {
            SessionInitialize();
            CategoriaEN catEN = new CategoriaCAD(session).MuestraCategoriaPorOID(id);
            SessionClose();
            return View(catEN);
        }

        //CREAR CATEGORIAS

        // GET: Categoria/Create
        public ActionResult Create()
        {
            CategoriaEN catEN = new CategoriaEN();

            return View(catEN);
        }

        // POST: Categoria/Create
        [HttpPost]
        public ActionResult Create(CategoriaEN catEN)
        {
            try
            {
                // TODO: Add insert logic here
                SessionInitialize();
                CategoriaCAD catCad = new CategoriaCAD();
                catCad.New_(catEN);
                SessionClose();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //CREAR SUBCATEGORIAS
        //  GET: Categoria/CreateSub
        public ActionResult CreateSub()
        {
            CategoriaEN catEN = new CategoriaEN();
            return View(catEN);
        }

        // POST: Categoria/CreateSub -> no funca
        [HttpPost]
        public ActionResult CreateSub(CategoriaEN hijosEN, CategoriaEN padreEN)
        {
            try
            {
                // TODO: Add insert logic here
                SessionInitialize();
                CategoriaCAD catCad = new CategoriaCAD();

                IList<int> subcas = new List<int>();
                int id_sub = hijosEN.Id;
                subcas.Add(id_sub);

                int id_cat = padreEN.Id;

                catCad.CrearSubcategoria(id_cat,subcas);
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
            return View();
        }

        // POST: Categoria/Edit/5
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

        // GET: Categoria/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
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
*/