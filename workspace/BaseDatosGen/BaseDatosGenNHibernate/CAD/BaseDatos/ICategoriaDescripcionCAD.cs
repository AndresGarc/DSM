
using System;
using BaseDatosGenNHibernate.EN.BaseDatos;

namespace BaseDatosGenNHibernate.CAD.BaseDatos
{
public partial interface ICategoriaDescripcionCAD
{
CategoriaDescripcionEN ReadOIDDefault (int id
                                       );

void ModifyDefault (CategoriaDescripcionEN categoriaDescripcion);

System.Collections.Generic.IList<CategoriaDescripcionEN> ReadAllDefault (int first, int size);



int New_ (CategoriaDescripcionEN categoriaDescripcion);

void Modify (CategoriaDescripcionEN categoriaDescripcion);


void Destroy (int id
              );


CategoriaDescripcionEN MuestraCategoriaDescripcionPorOID (int id
                                                          );


System.Collections.Generic.IList<CategoriaDescripcionEN> MuestraCategoriaDescripcion (int first, int size);
}
}
