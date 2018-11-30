

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using SuperPetGenNHibernate.Exceptions;

using SuperPetGenNHibernate.EN.BaseDatos;
using SuperPetGenNHibernate.CAD.BaseDatos;


namespace SuperPetGenNHibernate.CEN.BaseDatos
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

public int New_ (int p_Numero, int p_Cantidad, int p_producto, int p_pedido)
{
        LineaPedidoEN lineaPedidoEN = null;
        int oid;

        //Initialized LineaPedidoEN
        lineaPedidoEN = new LineaPedidoEN ();
        lineaPedidoEN.Numero = p_Numero;

        lineaPedidoEN.Cantidad = p_Cantidad;


        if (p_producto != -1) {
                // El argumento p_producto -> Property producto es oid = false
                // Lista de oids Numero
                lineaPedidoEN.Producto = new SuperPetGenNHibernate.EN.BaseDatos.ProductoEN ();
                lineaPedidoEN.Producto.Id = p_producto;
        }


        if (p_pedido != -1) {
                // El argumento p_pedido -> Property pedido es oid = false
                // Lista de oids Numero
                lineaPedidoEN.Pedido = new SuperPetGenNHibernate.EN.BaseDatos.PedidoEN ();
                lineaPedidoEN.Pedido.Id = p_pedido;
        }

        //Call to LineaPedidoCAD

        oid = _ILineaPedidoCAD.New_ (lineaPedidoEN);
        return oid;
}

public void Modify (int p_LineaPedido_OID, int p_Cantidad)
{
        LineaPedidoEN lineaPedidoEN = null;

        //Initialized LineaPedidoEN
        lineaPedidoEN = new LineaPedidoEN ();
        lineaPedidoEN.Numero = p_LineaPedido_OID;
        lineaPedidoEN.Cantidad = p_Cantidad;
        //Call to LineaPedidoCAD

        _ILineaPedidoCAD.Modify (lineaPedidoEN);
}

public void Destroy (int Numero
                     )
{
        _ILineaPedidoCAD.Destroy (Numero);
}

public System.Collections.Generic.IList<LineaPedidoEN> MuestraLineaPedidos (int first, int size)
{
        System.Collections.Generic.IList<LineaPedidoEN> list = null;

        list = _ILineaPedidoCAD.MuestraLineaPedidos (first, size);
        return list;
}
public LineaPedidoEN MuestraLineaPedidoPorOID (int Numero
                                               )
{
        LineaPedidoEN lineaPedidoEN = null;

        lineaPedidoEN = _ILineaPedidoCAD.MuestraLineaPedidoPorOID (Numero);
        return lineaPedidoEN;
}
}
}
