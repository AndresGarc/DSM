using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseDatosGenNHibernate.CEN.BaseDatos;
using BaseDatosGenNHibernate.EN.BaseDatos;
using BaseDatosGenNHibernate.CAD.BaseDatos;
using SuperPet.Models;

namespace SuperPet.Controllers
{
    public class UsuarioController : BasicController
    {
        // GET: Usuario
        public ActionResult Index()
        {
            SessionInitialize();
            IEnumerable<Usuario> users = new AssemblerUsuario().ConvertListENToModel(new UsuarioCAD(session).ReadAllDefault(0, -1));
            SessionClose();
            return View(users);
        }

        // POST: Usuario/Index/
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            try
            {
                IEnumerable<Usuario> users = new AssemblerUsuario().ConvertListENToModel(new UsuarioCEN().GetUsuarioByNombre(Convert.ToString(form["user"]), 0, -1));

                return View(users);
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            SessionInitialize();
            Usuario user = new AssemblerUsuario().ConvertENToModelUI(new UsuarioCAD(session).ReadOIDDefault(id));
            SessionClose();
            return View(user);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
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

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Usuario/Edit/5
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

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuario/Delete/5
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

        // GET: Usuario/Desactivar/5
        public ActionResult Desactivar(int id)
        {
            SessionInitialize();
            Usuario user = new AssemblerUsuario().ConvertENToModelUI(new UsuarioCAD(session).ReadOIDDefault(id));
            SessionClose();
            return View(user);
        }

        // POST: Usuario/Desactivar/5
        [HttpPost]
        public ActionResult Desactivar(int id, Usuario user)
        {
            try
            {
                new UsuarioCEN().CambiarEstado(id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
