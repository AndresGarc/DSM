
using System;
using BaseDatosGenNHibernate.EN.BaseDatos;

namespace BaseDatosGenNHibernate.CAD.BaseDatos
{
public partial interface IUsuarioCAD
{
UsuarioEN ReadOIDDefault (int id
                          );

void ModifyDefault (UsuarioEN usuario);

System.Collections.Generic.IList<UsuarioEN> ReadAllDefault (int first, int size);



int New_ (UsuarioEN usuario);

void Modify (UsuarioEN usuario);


void Destroy (int id
              );


System.Collections.Generic.IList<UsuarioEN> MuestraUsuarios (int first, int size);



UsuarioEN MuestraUsuarioPorOID (int id
                                );



System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN> GetUsuarioByNombre (string p_nombre, int first, int size);


void AddFavoritos (int p_Usuario_OID, System.Collections.Generic.IList<int> p_favoritos_OIDs);

void QuitarFavoritos (int p_Usuario_OID, System.Collections.Generic.IList<int> p_favoritos_OIDs);
}
}
