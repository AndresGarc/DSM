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
    public class AdministradorController : BasicController
    {
        // GET: Administrador
        public ActionResult Index()
        {
            SessionInitialize();
            IEnumerable<Administrador> admins = new AssemblerAdministrador().ConvertListENToModel(new AdministradorCAD(session).ReadAllDefault(0, -1));
            SessionClose();
            return View(admins);
        }

        // GET: Administrador/Details/5
        public ActionResult Details(int id)
        {
            SessionInitialize();
            Administrador admin = new AssemblerAdministrador().ConvertENToModelUI(new AdministradorCAD(session).ReadOIDDefault(id));
            SessionClose();
            return View(admin);
        }

        // GET: Administrador/Create
        public ActionResult Create()
        {
            Administrador admin = new Administrador();
            return View(admin);
        }

        // POST: Administrador/Create
        [HttpPost]
        public ActionResult Create(Administrador admin)
        {
            try
            {
                new AdministradorCEN().New_(admin.Email, admin.NombreUsuario, admin.Password, false);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Administrador/Edit/5
        public ActionResult Edit(int id)
        {
            SessionInitialize();
            Administrador admin = new AssemblerAdministrador().ConvertENToModelUI(new AdministradorCAD(session).ReadOIDDefault(id));
            SessionClose();
            return View(admin);
        }

        // POST: Administrador/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Administrador admin)
        {
            try
            {
                new AdministradorCEN().Modify(admin.Id, admin.Email, admin.NombreUsuario, admin.Password, admin.Logged);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Administrador/Delete/5
        public ActionResult Delete(int id)
        {
            SessionInitialize();
            Administrador admin = new AssemblerAdministrador().ConvertENToModelUI(new AdministradorCAD(session).ReadOIDDefault(id));
            SessionClose();
            return View(admin);
        }

        // POST: Administrador/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Administrador admin)
        {
            try
            {
                new AdministradorCEN().Destroy(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
