
using System;
using BaseDatosGenNHibernate.EN.BaseDatos;

namespace BaseDatosGenNHibernate.CAD.BaseDatos
{
public partial interface IProductoCAD
{
ProductoEN ReadOIDDefault (int id
                           );

void ModifyDefault (ProductoEN producto);

System.Collections.Generic.IList<ProductoEN> ReadAllDefault (int first, int size);



int New_ (ProductoEN producto);

void Modify (ProductoEN producto);


void Destroy (int id
              );


System.Collections.Generic.IList<ProductoEN> MuestraProductos (int first, int size);


ProductoEN MuestraProductoPorOID (int id
                                  );




System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductosByNombre (string p_nombre, int first, int size);


System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetAllProductosByPedido (int p_pedido, int first, int size);


System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductosVendidos (int first, int size);


System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductosNuevos (int first, int size);


System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductosDestacados (int first, int size);




System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductoConOferta (int first, int size);


System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetFavoritos (int p_usuario, int first, int size);


System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductosCompradosByUsuario (int p_usuario, int first, int size);


void CambiarCategoria (int p_Producto_OID, int p_categoria_OID);

System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductosByNombreStock (string p_nombre);


System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductosByPrecios (double? precio1, double ? precio2);


System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductosByCategoria (string nombre);


System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetProductosBySuperCategoria (string nombre);


System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN> GetTopVentas ();
}
}
