

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using BaseDatosGenNHibernate.Exceptions;

using BaseDatosGenNHibernate.EN.BaseDatos;
using BaseDatosGenNHibernate.CAD.BaseDatos;


namespace BaseDatosGenNHibernate.CEN.BaseDatos
{
/*
 *      Definition of the class ValoracionCEN
 *
 */
public partial class ValoracionCEN
{
private IValoracionCAD _IValoracionCAD;

public ValoracionCEN()
{
        this._IValoracionCAD = new ValoracionCAD ();
}

public ValoracionCEN(IValoracionCAD _IValoracionCAD)
{
        this._IValoracionCAD = _IValoracionCAD;
}

public IValoracionCAD get_IValoracionCAD ()
{
        return this._IValoracionCAD;
}

public int New_ (double p_Valor, int p_usuario, int p_producto)
{
        ValoracionEN valoracionEN = null;
        int oid;

        //Initialized ValoracionEN
        valoracionEN = new ValoracionEN ();
        valoracionEN.Valor = p_Valor;


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                valoracionEN.Usuario = new BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN ();
                valoracionEN.Usuario.Id = p_usuario;
        }


        if (p_producto != -1) {
                // El argumento p_producto -> Property producto es oid = false
                // Lista de oids id
                valoracionEN.Producto = new BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN ();
                valoracionEN.Producto.Id = p_producto;
        }

        //Call to ValoracionCAD

        oid = _IValoracionCAD.New_ (valoracionEN);
        return oid;
}

public void Modify (int p_Valoracion_OID, double p_Valor)
{
        ValoracionEN valoracionEN = null;

        //Initialized ValoracionEN
        valoracionEN = new ValoracionEN ();
        valoracionEN.Id = p_Valoracion_OID;
        valoracionEN.Valor = p_Valor;
        //Call to ValoracionCAD

        _IValoracionCAD.Modify (valoracionEN);
}

public System.Collections.Generic.IList<ValoracionEN> MuestraValoraciones (int first, int size)
{
        System.Collections.Generic.IList<ValoracionEN> list = null;

        list = _IValoracionCAD.MuestraValoraciones (first, size);
        return list;
}
public ValoracionEN MuestraValoracionesPorOID (int id
                                               )
{
        ValoracionEN valoracionEN = null;

        valoracionEN = _IValoracionCAD.MuestraValoracionesPorOID (id);
        return valoracionEN;
}

public void Destroy (int id
                     )
{
        _IValoracionCAD.Destroy (id);
}

public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ValoracionEN> GetAllValoracionesByProducto (int p_producto, int first, int size)
{
        return _IValoracionCAD.GetAllValoracionesByProducto (p_producto, first, size);
}
}
}
