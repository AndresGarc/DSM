using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseDatosGenNHibernate.CEN.BaseDatos;
using BaseDatosGenNHibernate.EN.BaseDatos;

namespace SuperPet.Models
{
    public class AssemblerCategoria
    {
        public Categoria ConvertENToModelUI(CategoriaEN en)
        {

            Categoria cat = new Categoria();
            cat.id = en.Id;
            cat.NombreCat = en.Nombre;

            // CategoriaCEN catCen = new CategoriaCEN();
            if (en.Supercategoria != null)
            {
                CategoriaEN superEN = en.Supercategoria;
                string nombreSupCat = superEN.Nombre;
                cat.NombreSupcat = nombreSupCat;
            }
            else
            {
                cat.NombreSupcat = " ";
            }
            return cat;
        }

        public IList<Categoria> ConvertListENToModel(IList<CategoriaEN> ens)
        {
            IList<Categoria> arts = new List<Categoria>();
            foreach (CategoriaEN en in ens)
            {
                arts.Add(ConvertENToModelUI(en));
            }
            return arts;
        }
    }
}