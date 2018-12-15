
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


/*PROTECTED REGION ID(usingBaseDatosGenNHibernate.CEN.BaseDatos_Usuario_desactivate) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace BaseDatosGenNHibernate.CEN.BaseDatos
{
public partial class UsuarioCEN
{
public void Desactivate (int p_oid)
{
        /*PROTECTED REGION ID(BaseDatosGenNHibernate.CEN.BaseDatos_Usuario_desactivate) ENABLED START*/

        UsuarioEN en = _IUsuarioCAD.ReadOIDDefault (p_oid);

        en.Activo = false;
        _IUsuarioCAD.Modify (en);

        /*PROTECTED REGION END*/
}
}
}
