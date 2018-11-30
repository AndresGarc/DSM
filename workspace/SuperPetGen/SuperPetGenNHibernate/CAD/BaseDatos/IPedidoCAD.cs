
using System;
using SuperPetGenNHibernate.EN.BaseDatos;

namespace SuperPetGenNHibernate.CAD.BaseDatos
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


System.Collections.Generic.IList<PedidoEN> MuestraPedidos (int first, int size);


PedidoEN MuestraPedidoPorOID (int id
                              );



void AddDirEnvio (int p_Pedido_OID, System.Collections.Generic.IList<int> p_dirEnvio_OIDs);

void AddMetodoPago (int p_Pedido_OID, int p_metodoPago_OID);
}
}
