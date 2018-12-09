using System;
using System.Collections.Generic;
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








        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}