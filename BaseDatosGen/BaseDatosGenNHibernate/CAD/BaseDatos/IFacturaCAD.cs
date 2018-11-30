
using System;
using BaseDatosGenNHibernate.EN.BaseDatos;

namespace BaseDatosGenNHibernate.CAD.BaseDatos
{
public partial interface IFacturaCAD
{
FacturaEN ReadOIDDefault (int id
                          );

void ModifyDefault (FacturaEN factura);

System.Collections.Generic.IList<FacturaEN> ReadAllDefault (int first, int size);



int New_ (FacturaEN factura);

void Modify (FacturaEN factura);


void Destroy (int id
              );


FacturaEN MuestraFacturaPorOID (int id
                                );


System.Collections.Generic.IList<FacturaEN> MuestraFacturas (int first, int size);


System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.FacturaEN> GetFacturaByPedido (int p_pedido, int first, int size);
}
}
