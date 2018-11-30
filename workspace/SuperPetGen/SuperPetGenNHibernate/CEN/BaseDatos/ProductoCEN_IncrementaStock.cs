
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


/*PROTECTED REGION ID(usingSuperPetGenNHibernate.CEN.BaseDatos_Producto_incrementaStock) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace SuperPetGenNHibernate.CEN.BaseDatos
{
public partial class ProductoCEN
{
        public void IncrementaStock(int p_oid)
        {
            /*PROTECTED REGION ID(BaseDatosGenNHibernate.CEN.BaseDatos_Producto_incrementaStock) ENABLED START*/

            ProductoEN product = _IProductoCAD.MuestraProductoPorOID(p_oid);
            product.Stock++;
            _IProductoCAD.Modify(product);

            /*PROTECTED REGION END*/
        }
    }
}
