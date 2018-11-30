
using System;
using BaseDatosGenNHibernate.EN.BaseDatos;

namespace BaseDatosGenNHibernate.CAD.BaseDatos
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



void AddDirEnvio (int p_Pedido_OID, int p_dirEnvio_OID);

void AddMetodoPago (int p_Pedido_OID, int p_metodoPago_OID);

System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.PedidoEN> GetAllPedidosByUsuario (string p_usuario, int first, int size);
}
}
