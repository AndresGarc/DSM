
using System;
using EjemploViernesGenNHibernate.EN.EjemploViernes;

namespace EjemploViernesGenNHibernate.CAD.EjemploViernes
{
public partial interface ILineaPedidoCAD
{
LineaPedidoEN ReadOIDDefault (int id
                              );

void ModifyDefault (LineaPedidoEN lineaPedido);

System.Collections.Generic.IList<LineaPedidoEN> ReadAllDefault (int first, int size);



int New_ (LineaPedidoEN lineaPedido);

void Modify (LineaPedidoEN lineaPedido);


void Destroy (int id
              );
}
}
