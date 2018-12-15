
using System;
using BaseDatosGenNHibernate.EN.BaseDatos;

namespace BaseDatosGenNHibernate.CAD.BaseDatos
{
public partial interface IUsuarioBasicoCAD
{
UsuarioBasicoEN ReadOIDDefault (int id
                                );

void ModifyDefault (UsuarioBasicoEN usuarioBasico);

System.Collections.Generic.IList<UsuarioBasicoEN> ReadAllDefault (int first, int size);





int New_ (UsuarioBasicoEN usuarioBasico);

void Modify (UsuarioBasicoEN usuarioBasico);


void Destroy (int id
              );
}
}
