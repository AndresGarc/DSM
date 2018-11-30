

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using EjemploViernesGenNHibernate.Exceptions;

using EjemploViernesGenNHibernate.EN.EjemploViernes;
using EjemploViernesGenNHibernate.CAD.EjemploViernes;


namespace EjemploViernesGenNHibernate.CEN.EjemploViernes
{
/*
 *      Definition of the class LineaPedidoCEN
 *
 */
public partial class LineaPedidoCEN
{
private ILineaPedidoCAD _ILineaPedidoCAD;

public LineaPedidoCEN()
{
        this._ILineaPedidoCAD = new LineaPedidoCAD ();
}

public LineaPedidoCEN(ILineaPedidoCAD _ILineaPedidoCAD)
{
        this._ILineaPedidoCAD = _ILineaPedidoCAD;
}

public ILineaPedidoCAD get_ILineaPedidoCAD ()
{
        return this._ILineaPedidoCAD;
}

public int New_ (int p_cantidad, double p_pedido, int p_pedido_0)
{
        LineaPedidoEN lineaPedidoEN = null;
        int oid;

        //Initialized LineaPedidoEN
        lineaPedidoEN = new LineaPedidoEN ();
        lineaPedidoEN.Cantidad = p_cantidad;

        lineaPedidoEN.Pedido = p_pedido;


        if (p_pedido_0 != -1) {
                // El argumento p_pedido_0 -> Property pedido_0 es oid = false
                // Lista de oids id
                lineaPedidoEN.Pedido_0 = new EjemploViernesGenNHibernate.EN.EjemploViernes.PedidoEN ();
                lineaPedidoEN.Pedido_0.Id = p_pedido_0;
        }

        //Call to LineaPedidoCAD

        oid = _ILineaPedidoCAD.New_ (lineaPedidoEN);
        return oid;
}

public void Modify (int p_LineaPedido_OID, int p_cantidad, double p_pedido)
{
        LineaPedidoEN lineaPedidoEN = null;

        //Initialized LineaPedidoEN
        lineaPedidoEN = new LineaPedidoEN ();
        lineaPedidoEN.Id = p_LineaPedido_OID;
        lineaPedidoEN.Cantidad = p_cantidad;
        lineaPedidoEN.Pedido = p_pedido;
        //Call to LineaPedidoCAD

        _ILineaPedidoCAD.Modify (lineaPedidoEN);
}

public void Destroy (int id
                     )
{
        _ILineaPedidoCAD.Destroy (id);
}
}
}
