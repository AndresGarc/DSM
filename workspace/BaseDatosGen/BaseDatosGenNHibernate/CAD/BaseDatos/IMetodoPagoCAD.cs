
using System;
using BaseDatosGenNHibernate.EN.BaseDatos;

namespace BaseDatosGenNHibernate.CAD.BaseDatos
{
public partial interface IMetodoPagoCAD
{
MetodoPagoEN ReadOIDDefault (int id
                             );

void ModifyDefault (MetodoPagoEN metodoPago);

System.Collections.Generic.IList<MetodoPagoEN> ReadAllDefault (int first, int size);



int New_ (MetodoPagoEN metodoPago);

void Modify (MetodoPagoEN metodoPago);


void Destroy (int id
              );


MetodoPagoEN MuestraMetodoPagoPorOID (int id
                                      );


System.Collections.Generic.IList<MetodoPagoEN> MuestraMetodoPagos (int first, int size);


System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.MetodoPagoEN> GetMetodoPagoByPedido (int p_pedido, int first, int size);
}
}
