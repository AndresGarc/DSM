using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BaseDatosGenNHibernate.EN.BaseDatos;
using BaseDatosGenNHibernate.Utils;

namespace SuperPet.Models
{
    public class AssemblerAdministrador
    {
        public Administrador ConvertENToModelUI(AdministradorEN en)
        {
            Administrador admin = new Administrador();
            admin.Id = en.Id;
            admin.Email = en.Email;
            admin.NombreUsuario = en.NombreUsu;
            //admin.Password = Util.Decode(en.Password);
            admin.Password = en.Password;
            admin.Logged = en.Logged;

            return admin;
        }

        public IList<Administrador> ConvertListENToModel(IList<AdministradorEN> ens)
        {
            IList<Administrador> admins = new List<Administrador>();
            foreach (AdministradorEN en in ens)
            {
                admins.Add(ConvertENToModelUI(en));
            }
            return admins;
        }
    }
}