
using System;
using SuperPetGenNHibernate.EN.BaseDatos;

namespace SuperPetGenNHibernate.CAD.BaseDatos
{
public partial interface IValoracionCAD
{
ValoracionEN ReadOIDDefault (int id
                             );

void ModifyDefault (ValoracionEN valoracion);

System.Collections.Generic.IList<ValoracionEN> ReadAllDefault (int first, int size);



int New_ (ValoracionEN valoracion);

void Modify (ValoracionEN valoracion);


System.Collections.Generic.IList<ValoracionEN> MuestraValoraciones (int first, int size);


ValoracionEN MuestraValoracionesPorOID (int id
                                        );


void Destroy (int id
              );
}
}
