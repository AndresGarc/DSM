
using System;
using EjemploViernesGenNHibernate.EN.EjemploViernes;

namespace EjemploViernesGenNHibernate.CAD.EjemploViernes
{
public partial interface IClienteCAD
{
ClienteEN ReadOIDDefault (string DNI
                          );

void ModifyDefault (ClienteEN cliente);

System.Collections.Generic.IList<ClienteEN> ReadAllDefault (int first, int size);



string Nuevo (ClienteEN cliente);

void Modify (ClienteEN cliente);


void Destroy (string DNI
              );


ClienteEN MostrarClienteOID (string DNI
                             );


System.Collections.Generic.IList<ClienteEN> MostrarClientes (int first, int size);
}
}
