using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseDatosGenNHibernate.EN.BaseDatos;

namespace MvcApplication1.Models
{
    public class AssemblerProducto
    {
        public Producto ConvertENToModelUI(ProductoEN en)
        {
            Producto prod = new Producto();
            prod.id = en.Id;
        //    prod.Descripcion = en.ProductoDescripcion; //no se si funciona asi o hay que elegir un idioma y eso
            prod.Nombre = en.Nombre;
            prod.Precio = en.Precio;
            prod.Stock = en.Stock;
            prod.Imagen = en.URLFoto;
            prod.IdCategoria = en.Categoria.Id;
            prod.NombreCategoria = en.Categoria.Nombre;
           // prod.Subcategoria = en.Categoria.Subcategoria;
            prod.Destacado = en.Destacado;
            prod.Oferta = en.Oferta;
            prod.ValoracionMedia = en.ValoracionMedia;
            IList<ProductoDescripcionEN> lista = en.ProductoDescripcion;
            foreach (ProductoDescripcionEN pro in lista)
            {
                if (pro.Idioma == BaseDatosGenNHibernate.Enumerated.BaseDatos.IdiomaEnum.Castellano)//en vez de poner uno a mano seria con la cookie y lo de la internacionalizacion para elegir idioma
                    prod.Descripcion = pro.Texto;
            }

            //ver cuales del resto que aparecen en ProductoEN tengo que poner y como. valoracionmedia lo calcula una cp y no se si tengo que ponerlo
            //aqui o no por lo de que al crear me sale para anyadir el valor y no tiene que meterlo el admin


            //FALTA PONER LO DE SUPERCATEGORIA, PUEDE ESTAR MAL INICIALIZADO EN CREATEDB
            if (en.Categoria.Supercategoria !=null) { //ANDRES: SI NO PONES ESTO, SI HAY ALGUNA SIN SUPER CATEGORIA REVIENTA
                prod.IdSupercategoria = en.Categoria.Supercategoria.Id;
                prod.NombreSupercategoria = en.Categoria.Supercategoria.Nombre;
            } else
            {
                prod.IdSupercategoria = 0;
                prod.NombreSupercategoria = " ";
            }
            return prod;


        }
        public IList<Producto> ConvertListENToModel (IList<ProductoEN> ens){
            IList<Producto> arts = new List<Producto>();
            foreach (ProductoEN en in ens)
            {
                arts.Add(ConvertENToModelUI(en));
            }
            return arts;
        }
        
    }
}