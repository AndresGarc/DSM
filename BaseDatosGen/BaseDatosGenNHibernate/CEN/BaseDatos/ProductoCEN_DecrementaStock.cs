
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


/*PROTECTED REGION ID(usingBaseDatosGenNHibernate.CEN.BaseDatos_Producto_decrementaStock) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace BaseDatosGenNHibernate.CEN.BaseDatos
{
public partial class ProductoCEN
{
public void DecrementaStock (int p_oid, int num)
{
        /*PROTECTED REGION ID(BaseDatosGenNHibernate.CEN.BaseDatos_Producto_decrementaStock) ENABLED START*/

        ProductoEN product = _IProductoCAD.MuestraProductoPorOID (p_oid);

        if (num > 0) {
                product.Stock = product.Stock - num;
                if (product.Stock >= 0)
                        _IProductoCAD.Modify (product);
        }

        /*PROTECTED REGION END*/
}
}
}
