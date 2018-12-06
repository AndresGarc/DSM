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
            IEnumerable<Categoria> listCats = new AssemblerCategoria().ConvertListENToModel(listCatsEN).ToList();
            SessionClose();
            return View(listCats);
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
            return View(cathij); //PASO POR PARAMETRO A LA VISTA CREATESUB ESE OBJETO CATEGORIA 
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
                catCen.CrearSupercategoria(hijo.id, padre.id);
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
                int idsup = cat.idSuperCategoria;
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
