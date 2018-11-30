
using System;
using SuperPetGenNHibernate.EN.BaseDatos;

namespace SuperPetGenNHibernate.CAD.BaseDatos
{
public partial interface IEnvioCAD
{
EnvioEN ReadOIDDefault (int id
                        );

void ModifyDefault (EnvioEN envio);

System.Collections.Generic.IList<EnvioEN> ReadAllDefault (int first, int size);



int New_ (EnvioEN envio);

void Modify (EnvioEN envio);


void Destroy (int id
              );
}
}
