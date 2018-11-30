
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using BaseDatosGenNHibernate.Exceptions;
using BaseDatosGenNHibernate.EN.BaseDatos;
using BaseDatosGenNHibernate.CAD.BaseDatos;


/*PROTECTED REGION ID(usingBaseDatosGenNHibernate.CEN.BaseDatos_UsuarioBasico_login) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace BaseDatosGenNHibernate.CEN.BaseDatos
{
public partial class UsuarioBasicoCEN
{
public bool Login (string p_UsuarioBasico_OID, string p_pass)
{
        /*PROTECTED REGION ID(BaseDatosGenNHibernate.CEN.BaseDatos_UsuarioBasico_login) ENABLED START*/
        bool result = false;
        UsuarioBasicoEN en = _IUsuarioBasicoCAD.ReadOIDDefault (p_UsuarioBasico_OID);

        if (en != null && en.Password.Equals (Utils.Util.GetEncondeMD5 (p_pass))) {
                result = en.Logged = true;
                _IUsuarioBasicoCAD.Modify (en);
        }

        return result;
        /*PROTECTED REGION END*/
}
}
}
