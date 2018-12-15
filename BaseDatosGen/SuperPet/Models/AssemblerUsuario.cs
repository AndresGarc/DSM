using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseDatosGenNHibernate.EN.BaseDatos;
using BaseDatosGenNHibernate.Utils;

namespace SuperPet.Models
{
    public class AssemblerUsuario
    {
        public Usuario ConvertENToModelUI(UsuarioEN en)
        {
            Usuario user = new Usuario();
            user.Id = en.Id;
            user.Email = en.Email;
            user.NombreUsuario = en.NombreUsu;
            //user.Password = Util.Decode(en.Password);
            user.Password = en.Password;
            user.Logged = en.Logged;
            user.Nombre = en.Nombre;
            user.Apellidos = en.Apellidos;
            user.Nacimiento = DateTime.Parse(en.FNacimiento.ToString());
            user.Telefono = en.Telefono;
            user.Activo = en.Activo;

            return user;
        }

        public IList<Usuario> ConvertListENToModel(IList<UsuarioEN> ens)
        {
            IList<Usuario> users = new List<Usuario>();
            foreach (UsuarioEN en in ens)
            {
                users.Add(ConvertENToModelUI(en));
            }
            return users;
        }
    }
}