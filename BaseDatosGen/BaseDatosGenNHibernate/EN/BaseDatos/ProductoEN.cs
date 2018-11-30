
using System;
// Definición clase ProductoEN
namespace BaseDatosGenNHibernate.EN.BaseDatos
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
private double precio;



/**
 *	Atributo stock
 */
private int stock;



/**
 *	Atributo categoria
 */
private BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN categoria;



/**
 *	Atributo comentario
 */
private System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ComentarioEN> comentario;



/**
 *	Atributo valoracion
 */
private System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ValoracionEN> valoracion;



/**
 *	Atributo lineaPedido
 */
private System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.LineaPedidoEN> lineaPedido;



/**
 *	Atributo valoracionMedia
 */
private double valoracionMedia;



/**
 *	Atributo usuarioFavorito
 */
private System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN> usuarioFavorito;



/**
 *	Atributo productoDescripcion
 */
private System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoDescripcionEN> productoDescripcion;



/**
 *	Atributo destacado
 */
private bool destacado;



/**
 *	Atributo oferta
 */
private double oferta;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string URLFoto {
        get { return uRLFoto; } set { uRLFoto = value;  }
}



public virtual double Precio {
        get { return precio; } set { precio = value;  }
}



public virtual int Stock {
        get { return stock; } set { stock = value;  }
}



public virtual BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN Categoria {
        get { return categoria; } set { categoria = value;  }
}



public virtual System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ComentarioEN> Comentario {
        get { return comentario; } set { comentario = value;  }
}



public virtual System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ValoracionEN> Valoracion {
        get { return valoracion; } set { valoracion = value;  }
}



public virtual System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.LineaPedidoEN> LineaPedido {
        get { return lineaPedido; } set { lineaPedido = value;  }
}



public virtual double ValoracionMedia {
        get { return valoracionMedia; } set { valoracionMedia = value;  }
}



public virtual System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN> UsuarioFavorito {
        get { return usuarioFavorito; } set { usuarioFavorito = value;  }
}



public virtual System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoDescripcionEN> ProductoDescripcion {
        get { return productoDescripcion; } set { productoDescripcion = value;  }
}



public virtual bool Destacado {
        get { return destacado; } set { destacado = value;  }
}



public virtual double Oferta {
        get { return oferta; } set { oferta = value;  }
}





public ProductoEN()
{
        comentario = new System.Collections.Generic.List<BaseDatosGenNHibernate.EN.BaseDatos.ComentarioEN>();
        valoracion = new System.Collections.Generic.List<BaseDatosGenNHibernate.EN.BaseDatos.ValoracionEN>();
        lineaPedido = new System.Collections.Generic.List<BaseDatosGenNHibernate.EN.BaseDatos.LineaPedidoEN>();
        usuarioFavorito = new System.Collections.Generic.List<BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN>();
        productoDescripcion = new System.Collections.Generic.List<BaseDatosGenNHibernate.EN.BaseDatos.ProductoDescripcionEN>();
}



public ProductoEN(int id, string nombre, string uRLFoto, double precio, int stock, BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN categoria, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ComentarioEN> comentario, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ValoracionEN> valoracion, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.LineaPedidoEN> lineaPedido, double valoracionMedia, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN> usuarioFavorito, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoDescripcionEN> productoDescripcion, bool destacado, double oferta
                  )
{
        this.init (Id, nombre, uRLFoto, precio, stock, categoria, comentario, valoracion, lineaPedido, valoracionMedia, usuarioFavorito, productoDescripcion, destacado, oferta);
}


public ProductoEN(ProductoEN producto)
{
        this.init (Id, producto.Nombre, producto.URLFoto, producto.Precio, producto.Stock, producto.Categoria, producto.Comentario, producto.Valoracion, producto.LineaPedido, producto.ValoracionMedia, producto.UsuarioFavorito, producto.ProductoDescripcion, producto.Destacado, producto.Oferta);
}

private void init (int id
                   , string nombre, string uRLFoto, double precio, int stock, BaseDatosGenNHibernate.EN.BaseDatos.CategoriaEN categoria, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ComentarioEN> comentario, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ValoracionEN> valoracion, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.LineaPedidoEN> lineaPedido, double valoracionMedia, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.UsuarioEN> usuarioFavorito, System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.ProductoDescripcionEN> productoDescripcion, bool destacado, double oferta)
{
        this.Id = id;


        this.Nombre = nombre;

        this.URLFoto = uRLFoto;

        this.Precio = precio;

        this.Stock = stock;

        this.Categoria = categoria;

        this.Comentario = comentario;

        this.Valoracion = valoracion;

        this.LineaPedido = lineaPedido;

        this.ValoracionMedia = valoracionMedia;

        this.UsuarioFavorito = usuarioFavorito;

        this.ProductoDescripcion = productoDescripcion;

        this.Destacado = destacado;

        this.Oferta = oferta;
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
