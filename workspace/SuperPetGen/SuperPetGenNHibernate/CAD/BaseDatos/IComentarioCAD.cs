
using System;
using SuperPetGenNHibernate.EN.BaseDatos;

namespace SuperPetGenNHibernate.CAD.BaseDatos
{
public partial interface IComentarioCAD
{
ComentarioEN ReadOIDDefault (int id
                             );

void ModifyDefault (ComentarioEN comentario);

System.Collections.Generic.IList<ComentarioEN> ReadAllDefault (int first, int size);



int New_ (ComentarioEN comentario);

void Modify (ComentarioEN comentario);


void Destroy (int id
              );


System.Collections.Generic.IList<ComentarioEN> MuestraComentarios (int first, int size);


ComentarioEN MuestraComentarioPorOID (int id
                                      );
}
}
