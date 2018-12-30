using System;
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
    public class BusquedaUsuarioController : BasicController
    {
        // GET: HomeUsuario
        public ActionResult Index(string titulo, string precio)
        {
            IList<Producto> salida = new List<Producto>();
                if (String.IsNullOrEmpty(titulo) == false)
                {
                    SessionInitialize();
                    salida = new AssemblerProducto().ConvertListENToModel(new ProductoCEN(new ProductoCAD(session)).GetProductosByNombre(titulo, 0, -1));
                    SessionClose();
                }
                /*
                if (form["precio"] != null)
                {
                    SessionInitialize();
                    IList<Producto> buscarPrecio = new AssemblerProducto().ConvertListENToModel(new ProductoCEN(new ProductoCAD(session)).GetProductosByPrecios(Convert.ToDouble(form["precio"]),Convert.ToDouble(form["precio"])));
                    SessionClose();
                }
                */

            return View(salida);
        }
        
    }
}
