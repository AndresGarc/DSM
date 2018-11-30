
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


/*PROTECTED REGION ID(usingBaseDatosGenNHibernate.CEN.BaseDatos_Producto_cambiarDestacado) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace BaseDatosGenNHibernate.CEN.BaseDatos
{
public partial class ProductoCEN
{
public void CambiarDestacado (int p_oid)
{
        /*PROTECTED REGION ID(BaseDatosGenNHibernate.CEN.BaseDatos_Producto_cambiarDestacado) ENABLED START*/


        ProductoEN en = _IProductoCAD.ReadOIDDefault (p_oid);

        if (en.Destacado == false) {
                en.Destacado = true;
        }
        else{
                en.Destacado = false;
        }
        _IProductoCAD.Modify (en);

        /*PROTECTED REGION END*/
}
}
}
