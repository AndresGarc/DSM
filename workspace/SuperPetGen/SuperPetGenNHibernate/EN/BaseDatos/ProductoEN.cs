
using System;
// Definición clase ProductoEN
namespace SuperPetGenNHibernate.EN.BaseDatos
{
public partial class ProductoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo uRLFoto
 */
private string uRLFoto;



/**
 *	Atributo precio
 */
private float precio;



/**
 *	Atributo stock
 */
private int stock;



/**
 *	Atributo categoria
 */
private SuperPetGenNHibernate.EN.BaseDatos.CategoriaEN categoria;



/**
 *	Atributo comentario
 */
private System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ComentarioEN> comentario;



/**
 *	Atributo usuario
 */
private System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN> usuario;



/**
 *	Atributo valoracion
 */
private System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ValoracionEN> valoracion;



/**
 *	Atributo lineaPedido
 */
private System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.LineaPedidoEN> lineaPedido;



/**
 *	Atributo valoracionMedia
 */
private float valoracionMedia;



/**
 *	Atributo productoDescripcion
 */
private System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ProductoDescripcionEN> productoDescripcion;



/**
 *	Atributo usuario_0
 */
private System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN> usuario_0;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string URLFoto {
        get { return uRLFoto; } set { uRLFoto = value;  }
}



public virtual float Precio {
        get { return precio; } set { precio = value;  }
}



public virtual int Stock {
        get { return stock; } set { stock = value;  }
}



public virtual SuperPetGenNHibernate.EN.BaseDatos.CategoriaEN Categoria {
        get { return categoria; } set { categoria = value;  }
}



public virtual System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ComentarioEN> Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN> Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ValoracionEN> Valoracion {
        get { return valoracion; } set { valoracion = value;  }
}



public virtual System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.LineaPedidoEN> LineaPedido {
        get { return lineaPedido; } set { lineaPedido = value;  }
}



public virtual float ValoracionMedia {
        get { return valoracionMedia; } set { valoracionMedia = value;  }
}



public virtual System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ProductoDescripcionEN> ProductoDescripcion {
        get { return productoDescripcion; } set { productoDescripcion = value;  }
}



public virtual System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN> Usuario_0 {
        get { return usuario_0; } set { usuario_0 = value;  }
}





public ProductoEN()
{
        comentario = new System.Collections.Generic.List<SuperPetGenNHibernate.EN.BaseDatos.ComentarioEN>();
        usuario = new System.Collections.Generic.List<SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN>();
        valoracion = new System.Collections.Generic.List<SuperPetGenNHibernate.EN.BaseDatos.ValoracionEN>();
        lineaPedido = new System.Collections.Generic.List<SuperPetGenNHibernate.EN.BaseDatos.LineaPedidoEN>();
        productoDescripcion = new System.Collections.Generic.List<SuperPetGenNHibernate.EN.BaseDatos.ProductoDescripcionEN>();
        usuario_0 = new System.Collections.Generic.List<SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN>();
}



public ProductoEN(int id, string nombre, string uRLFoto, float precio, int stock, SuperPetGenNHibernate.EN.BaseDatos.CategoriaEN categoria, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ComentarioEN> comentario, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN> usuario, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ValoracionEN> valoracion, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.LineaPedidoEN> lineaPedido, float valoracionMedia, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ProductoDescripcionEN> productoDescripcion, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN> usuario_0
                  )
{
        this.init (Id, nombre, uRLFoto, precio, stock, categoria, comentario, usuario, valoracion, lineaPedido, valoracionMedia, productoDescripcion, usuario_0);
}


public ProductoEN(ProductoEN producto)
{
        this.init (Id, producto.Nombre, producto.URLFoto, producto.Precio, producto.Stock, producto.Categoria, producto.Comentario, producto.Usuario, producto.Valoracion, producto.LineaPedido, producto.ValoracionMedia, producto.ProductoDescripcion, producto.Usuario_0);
}

private void init (int id
                   , string nombre, string uRLFoto, float precio, int stock, SuperPetGenNHibernate.EN.BaseDatos.CategoriaEN categoria, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ComentarioEN> comentario, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN> usuario, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ValoracionEN> valoracion, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.LineaPedidoEN> lineaPedido, float valoracionMedia, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.ProductoDescripcionEN> productoDescripcion, System.Collections.Generic.IList<SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN> usuario_0)
{
        this.Id = id;


        this.Nombre = nombre;

        this.URLFoto = uRLFoto;

        this.Precio = precio;

        this.Stock = stock;

        this.Categoria = categoria;

        this.Comentario = comentario;

        this.Usuario = usuario;

        this.Valoracion = valoracion;

        this.LineaPedido = lineaPedido;

        this.ValoracionMedia = valoracionMedia;

        this.ProductoDescripcion = productoDescripcion;

        this.Usuario_0 = usuario_0;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ProductoEN t = obj as ProductoEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
