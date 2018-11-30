
using System;
using BaseDatosGenNHibernate.EN.BaseDatos;

namespace BaseDatosGenNHibernate.CAD.BaseDatos
{
public partial interface ILineaPedidoCAD
{
LineaPedidoEN ReadOIDDefault (int Numero
                              );

void ModifyDefault (LineaPedidoEN lineaPedido);

System.Collections.Generic.IList<LineaPedidoEN> ReadAllDefault (int first, int size);



int New_ (LineaPedidoEN lineaPedido);

void Modify (LineaPedidoEN lineaPedido);


void Destroy (int Numero
              );


System.Collections.Generic.IList<LineaPedidoEN> MuestraLineaPedidos (int first, int size);


LineaPedidoEN MuestraLineaPedidoPorOID (int Numero
                                        );
}
}
