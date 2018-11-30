
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


/*PROTECTED REGION ID(usingBaseDatosGenNHibernate.CEN.BaseDatos_Producto_cambiarOferta) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace BaseDatosGenNHibernate.CEN.BaseDatos
{
public partial class ProductoCEN
{
public void CambiarOferta (int p_oid, double ofertacion)
{
        /*PROTECTED REGION ID(BaseDatosGenNHibernate.CEN.BaseDatos_Producto_cambiarOferta) ENABLED START*/

        // Write here your custom code...

        ProductoEN en = _IProductoCAD.ReadOIDDefault (p_oid);

        if (ofertacion >= 0) {
                en.Oferta = ofertacion;

                _IProductoCAD.Modify (en);
        }

        /*PROTECTED REGION END*/
}
}
}
