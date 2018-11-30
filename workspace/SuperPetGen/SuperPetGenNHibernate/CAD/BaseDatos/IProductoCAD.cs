
using System;
using SuperPetGenNHibernate.EN.BaseDatos;

namespace SuperPetGenNHibernate.CAD.BaseDatos
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
}
}
