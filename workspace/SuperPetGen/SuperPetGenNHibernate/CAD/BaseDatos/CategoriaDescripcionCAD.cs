
using System;
using System.Text;
using SuperPetGenNHibernate.CEN.BaseDatos;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using SuperPetGenNHibernate.EN.BaseDatos;
using SuperPetGenNHibernate.Exceptions;


/*
 * Clase CategoriaDescripcion:
 *
 */

namespace SuperPetGenNHibernate.CAD.BaseDatos
{
public partial class CategoriaDescripcionCAD : BasicCAD, ICategoriaDescripcionCAD
{
public CategoriaDescripcionCAD() : base ()
{
}

public CategoriaDescripcionCAD(ISession sessionAux) : base (sessionAux)
{
}



public CategoriaDescripcionEN ReadOIDDefault (int id
                                              )
{
        CategoriaDescripcionEN categoriaDescripcionEN = null;

        try
        {
                SessionInitializeTransaction ();
                categoriaDescripcionEN = (CategoriaDescripcionEN)session.Get (typeof(CategoriaDescripcionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in CategoriaDescripcionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return categoriaDescripcionEN;
}

public System.Collections.Generic.IList<CategoriaDescripcionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<CategoriaDescripcionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(CategoriaDescripcionEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<CategoriaDescripcionEN>();
                        else
                                result = session.CreateCriteria (typeof(CategoriaDescripcionEN)).List<CategoriaDescripcionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in CategoriaDescripcionCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (CategoriaDescripcionEN categoriaDescripcion)
{
        try
        {
                SessionInitializeTransaction ();
                CategoriaDescripcionEN categoriaDescripcionEN = (CategoriaDescripcionEN)session.Load (typeof(CategoriaDescripcionEN), categoriaDescripcion.Id);

                categoriaDescripcionEN.Texto = categoriaDescripcion.Texto;


                categoriaDescripcionEN.Idioma = categoriaDescripcion.Idioma;


                session.Update (categoriaDescripcionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in CategoriaDescripcionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (CategoriaDescripcionEN categoriaDescripcion)
{
        try
        {
                SessionInitializeTransaction ();
                if (categoriaDescripcion.Categoria != null) {
                        // Argumento OID y no colección.
                        categoriaDescripcion.Categoria = (SuperPetGenNHibernate.EN.BaseDatos.CategoriaEN)session.Load (typeof(SuperPetGenNHibernate.EN.BaseDatos.CategoriaEN), categoriaDescripcion.Categoria.Id);

                        categoriaDescripcion.Categoria.CategoriaDescripcion
                        .Add (categoriaDescripcion);
                }

                session.Save (categoriaDescripcion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in CategoriaDescripcionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return categoriaDescripcion.Id;
}

public void Modify (CategoriaDescripcionEN categoriaDescripcion)
{
        try
        {
                SessionInitializeTransaction ();
                CategoriaDescripcionEN categoriaDescripcionEN = (CategoriaDescripcionEN)session.Load (typeof(CategoriaDescripcionEN), categoriaDescripcion.Id);

                categoriaDescripcionEN.Texto = categoriaDescripcion.Texto;


                categoriaDescripcionEN.Idioma = categoriaDescripcion.Idioma;

                session.Update (categoriaDescripcionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in CategoriaDescripcionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id
                     )
{
        try
        {
                SessionInitializeTransaction ();
                CategoriaDescripcionEN categoriaDescripcionEN = (CategoriaDescripcionEN)session.Load (typeof(CategoriaDescripcionEN), id);
                session.Delete (categoriaDescripcionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in CategoriaDescripcionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: MuestraCategoriaDescripcionPorOID
//Con e: CategoriaDescripcionEN
public CategoriaDescripcionEN MuestraCategoriaDescripcionPorOID (int id
                                                                 )
{
        CategoriaDescripcionEN categoriaDescripcionEN = null;

        try
        {
                SessionInitializeTransaction ();
                categoriaDescripcionEN = (CategoriaDescripcionEN)session.Get (typeof(CategoriaDescripcionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in CategoriaDescripcionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return categoriaDescripcionEN;
}

public System.Collections.Generic.IList<CategoriaDescripcionEN> MuestraCategoriaDescripcion (int first, int size)
{
        System.Collections.Generic.IList<CategoriaDescripcionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(CategoriaDescripcionEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<CategoriaDescripcionEN>();
                else
                        result = session.CreateCriteria (typeof(CategoriaDescripcionEN)).List<CategoriaDescripcionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in CategoriaDescripcionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
