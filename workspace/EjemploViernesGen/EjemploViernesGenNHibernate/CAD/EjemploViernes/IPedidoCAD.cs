
using System;
using EjemploViernesGenNHibernate.EN.EjemploViernes;

namespace EjemploViernesGenNHibernate.CAD.EjemploViernes
{
public partial interface IPedidoCAD
{
PedidoEN ReadOIDDefault (int id
                         );

void ModifyDefault (PedidoEN pedido);

System.Collections.Generic.IList<PedidoEN> ReadAllDefault (int first, int size);



int New_ (PedidoEN pedido);

void Modify (PedidoEN pedido);


void Destroy (int id
              );



void AnyDir (int p_Pedido_OID, System.Collections.Generic.IList<int> p_dirEnvio_OIDs);

void ElimDir (int p_Pedido_OID, System.Collections.Generic.IList<int> p_dirEnvio_OIDs);
}
}
