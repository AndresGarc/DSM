
using System;
using SuperPetGenNHibernate.EN.BaseDatos;

namespace SuperPetGenNHibernate.CAD.BaseDatos
{
public partial interface IUsuarioCAD
{
UsuarioEN ReadOIDDefault (string Email
                          );

void ModifyDefault (UsuarioEN usuario);

System.Collections.Generic.IList<UsuarioEN> ReadAllDefault (int first, int size);



string New_ (UsuarioEN usuario);

void Modify (UsuarioEN usuario);


void Destroy (string Email
              );


System.Collections.Generic.IList<UsuarioEN> MuestraUsuarios (int first, int size);



UsuarioEN MuestraUsuarioPorOID (string Email
                                );
}
}
