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
        public ActionResult Index(string titulo, string categoria, string min, string max)
        {
            IList<Producto> salida = new List<Producto>();
            if (String.IsNullOrEmpty(titulo) == false)
            {
                SessionInitialize();
                salida = new AssemblerProducto().ConvertListENToModel(new ProductoCEN(new ProductoCAD(session)).GetProductosByNombre(titulo, 0, -1));
                SessionClose();
            }

            if (String.IsNullOrEmpty(min) == false || String.IsNullOrEmpty(max) == false)
            {
                if (String.IsNullOrEmpty(min))
                    min ="0";
                if (String.IsNullOrEmpty(max))
                    max = "99999999999";
                if (salida.Count <= 0)
                {
                    SessionInitialize();
                    salida = new AssemblerProducto().ConvertListENToModel(new ProductoCEN(new ProductoCAD(session)).GetProductosByPrecios(Convert.ToDouble(min), Convert.ToDouble(max)));
                    SessionClose();
                }
                else
                {
                    IList<Producto> aux = new List<Producto>();
                    foreach (var item in salida)
                    {
                        if(item.Precio>= Convert.ToDouble(min) && item.Precio<= Convert.ToDouble(max))
                        {
                            aux.Add(item);
                        }
                    }
                    salida = aux;
                }
            }
            if (String.IsNullOrEmpty(categoria) == false && categoria!="0")
            {
                if (salida.Count <= 0)
                {
                    SessionInitialize();
                    salida = new AssemblerProducto().ConvertListENToModel(new ProductoCEN(new ProductoCAD(session)).GetProductosByCategoriaId(Convert.ToInt32(categoria),0,-1));
                    SessionClose();
                }
                else
                {
                    IList<Producto> aux = new List<Producto>();
                    foreach (var item in salida)
                    {
                        if(item.IdCategoria == Convert.ToInt32(categoria))
                        {
                            aux.Add(item);
                        }
                    }
                    salida = aux;
                }
            }

            return View(salida);
        }
        
    }
}
