
using System;
using BaseDatosGenNHibernate.EN.BaseDatos;

namespace BaseDatosGenNHibernate.CAD.BaseDatos
{
public partial interface IProductoDescripcionCAD
{
ProductoDescripcionEN ReadOIDDefault (int id
                                      );

void ModifyDefault (ProductoDescripcionEN productoDescripcion);

System.Collections.Generic.IList<ProductoDescripcionEN> ReadAllDefault (int first, int size);



int New_ (ProductoDescripcionEN productoDescripcion);

void Modify (ProductoDescripcionEN productoDescripcion);


void Destroy (int id
              );


ProductoDescripcionEN MuestraProductoDescripcionPorOID (int id
                                                        );


System.Collections.Generic.IList<ProductoDescripcionEN> MuestraProductoDescripcion (int first, int size);
}
}
