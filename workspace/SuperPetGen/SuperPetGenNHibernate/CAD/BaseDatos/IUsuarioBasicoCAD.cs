
using System;
using SuperPetGenNHibernate.EN.BaseDatos;

namespace SuperPetGenNHibernate.CAD.BaseDatos
{
public partial interface IUsuarioBasicoCAD
{
UsuarioBasicoEN ReadOIDDefault (string Email
                                );

void ModifyDefault (UsuarioBasicoEN usuarioBasico);

System.Collections.Generic.IList<UsuarioBasicoEN> ReadAllDefault (int first, int size);





string New_ (UsuarioBasicoEN usuarioBasico);

void Modify (UsuarioBasicoEN usuarioBasico);


void Destroy (string Email
              );
}
}
