
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using SuperPetGenNHibernate.Exceptions;
using SuperPetGenNHibernate.EN.BaseDatos;
using SuperPetGenNHibernate.CAD.BaseDatos;


/*PROTECTED REGION ID(usingSuperPetGenNHibernate.CEN.BaseDatos_Usuario_cambiarEstado) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace SuperPetGenNHibernate.CEN.BaseDatos
{
public partial class UsuarioCEN
{
        public void CambiarEstado(string p_oid)
        {
            /*PROTECTED REGION ID(BaseDatosGenNHibernate.CEN.BaseDatos_Administrador_cambiarEstado) ENABLED START*/

            UsuarioEN en = _IUsuarioCAD.ReadOIDDefault(p_oid);
            if (en.Activo == false)
            {
                en.Activo = true;
            }
            else
            {
                en.Activo = false;
            }
            _IUsuarioCAD.Modify(en);

            /*PROTECTED REGION END*/
        }
    }
}
