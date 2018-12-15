
using System;
using BaseDatosGenNHibernate.EN.BaseDatos;

namespace BaseDatosGenNHibernate.CAD.BaseDatos
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


void CrearSupercategoria (int p_Categoria_OID, int p_supercategoria_OID);

System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN> GetSubcategorias (int p_categoria, int first, int size);


System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN> GetSubcategoriasByNombre (string p_nombre);


System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN> GetSupercategoriasByNombre (string p_nombre);
}
}
