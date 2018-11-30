
using System;
using SuperPetGenNHibernate.EN.BaseDatos;

namespace SuperPetGenNHibernate.CAD.BaseDatos
{
public partial interface ICategoriaCAD
{
CategoriaEN ReadOIDDefault (int id
                            );

void ModifyDefault (CategoriaEN categoria);

System.Collections.Generic.IList<CategoriaEN> ReadAllDefault (int first, int size);



int New_ (CategoriaEN categoria);

void Modify (CategoriaEN categoria);


void Destroy (int id
              );


System.Collections.Generic.IList<CategoriaEN> MuestraCategorias (int first, int size);


CategoriaEN MuestraCategoriaPorOID (int id
                                    );


void CrearSubcategoria (int p_Categoria_OID, int p_subcategoria_OID);
}
}
