
using System;
using EjemploViernesGenNHibernate.EN.EjemploViernes;

namespace EjemploViernesGenNHibernate.CAD.EjemploViernes
{
public partial interface IDirEnvioCAD
{
DirEnvioEN ReadOIDDefault (int id
                           );

void ModifyDefault (DirEnvioEN dirEnvio);

System.Collections.Generic.IList<DirEnvioEN> ReadAllDefault (int first, int size);



int New_ (DirEnvioEN dirEnvio);

void Modify (DirEnvioEN dirEnvio);


void Destroy (int id
              );
}
}
