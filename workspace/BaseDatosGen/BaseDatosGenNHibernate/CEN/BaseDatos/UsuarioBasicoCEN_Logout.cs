
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


/*PROTECTED REGION ID(usingBaseDatosGenNHibernate.CEN.BaseDatos_UsuarioBasico_logout) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace BaseDatosGenNHibernate.CEN.BaseDatos
{
public partial class UsuarioBasicoCEN
{
public void Logout (string p_oid)
{
        /*PROTECTED REGION ID(BaseDatosGenNHibernate.CEN.BaseDatos_UsuarioBasico_logout) ENABLED START*/

        UsuarioBasicoEN en = _IUsuarioBasicoCAD.ReadOIDDefault (p_oid);

        en.Logged = false;
        _IUsuarioBasicoCAD.Modify (en);

        /*PROTECTED REGION END*/
}
}
}
