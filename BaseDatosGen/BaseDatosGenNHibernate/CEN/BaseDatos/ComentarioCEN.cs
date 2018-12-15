

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
 *      Definition of the class ComentarioCEN
 *
 */
public partial class ComentarioCEN
{
private IComentarioCAD _IComentarioCAD;

public ComentarioCEN()
{
        this._IComentarioCAD = new ComentarioCAD ();
}

public ComentarioCEN(IComentarioCAD _IComentarioCAD)
{
        this._IComentarioCAD = _IComentarioCAD;
}

public IComentarioCAD get_IComentarioCAD ()
{
        return this._IComentarioCAD;
}

public int New_ (string p_Texto, Nullable<DateTime> p_Fecha, int p_usuario, int p_producto)
{
        ComentarioEN comentarioEN = null;
        int oid;

        //Initialized ComentarioEN
        comentarioEN = new ComentarioEN ();
        comentarioEN.Texto = p_Texto;

        comentarioEN.Fecha = p_Fecha;


        if (p_usuario != -1) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                comentarioEN.Usuario = new BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN ();
                comentarioEN.Usuario.Id = p_usuario;
        }


        if (p_producto != -1) {
                // El argumento p_producto -> Property producto es oid = false
                // Lista de oids id
                comentarioEN.Producto = new BaseDatosGenNHibernate.EN.BaseDatos.ProductoEN ();
                comentarioEN.Producto.Id = p_producto;
        }

        //Call to ComentarioCAD

        oid = _IComentarioCAD.New_ (comentarioEN);
        return oid;
}

public void Modify (int p_Comentario_OID, string p_Texto, Nullable<DateTime> p_Fecha)
{
        ComentarioEN comentarioEN = null;

        //Initialized ComentarioEN
        comentarioEN = new ComentarioEN ();
        comentarioEN.Id = p_Comentario_OID;
        comentarioEN.Texto = p_Texto;
        comentarioEN.Fecha = p_Fecha;
        //Call to ComentarioCAD

        _IComentarioCAD.Modify (comentarioEN);
}

public void Destroy (int id
                     )
{
        _IComentarioCAD.Destroy (id);
}

public System.Collections.Generic.IList<ComentarioEN> MuestraComentarios (int first, int size)
{
        System.Collections.Generic.IList<ComentarioEN> list = null;

        list = _IComentarioCAD.MuestraComentarios (first, size);
        return list;
}
public ComentarioEN MuestraComentarioPorOID (int id
                                             )
{
        ComentarioEN comentarioEN = null;

        comentarioEN = _IComentarioCAD.MuestraComentarioPorOID (id);
        return comentarioEN;
}

public System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ComentarioEN> GetAllComentariosByProducto (int p_producto, int first, int size)
{
        return _IComentarioCAD.GetAllComentariosByProducto (p_producto, first, size);
}
}
}
