using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseDatosGenNHibernate.EN.BaseDatos;


namespace SuperPet.Models
{
    public class AssemblerComentario
    {

        public Comentario ConvertENToModelUI(ComentarioEN en)
        {
            Comentario com = new Comentario();
            com.id = en.Id;
            com.idProducto = en.Producto.Id;
            com.idUsuario = en.Usuario.Id;
            com.Fecha = DateTime.Parse(en.Fecha.ToString());
            com.TextoComentario = en.Texto;
            com.NombreUsuario = en.Usuario.Nombre;

            return com;

        }

        public IList<Comentario> ConvertListENToModel(IList<ComentarioEN> ens)
        {
            IList<Comentario> coms = new List<Comentario>();
            foreach (ComentarioEN com in ens)
            {
                coms.Add(ConvertENToModelUI(com));
            }
            return coms;
        }
    }
}