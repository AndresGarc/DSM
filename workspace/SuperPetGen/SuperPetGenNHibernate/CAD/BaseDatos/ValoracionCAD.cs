
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
 * Clase Valoracion:
 *
 */

namespace SuperPetGenNHibernate.CAD.BaseDatos
{
public partial class ValoracionCAD : BasicCAD, IValoracionCAD
{
public ValoracionCAD() : base ()
{
}

public ValoracionCAD(ISession sessionAux) : base (sessionAux)
{
}



public ValoracionEN ReadOIDDefault (int id
                                    )
{
        ValoracionEN valoracionEN = null;

        try
        {
                SessionInitializeTransaction ();
                valoracionEN = (ValoracionEN)session.Get (typeof(ValoracionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return valoracionEN;
}

public System.Collections.Generic.IList<ValoracionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ValoracionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ValoracionEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ValoracionEN>();
                        else
                                result = session.CreateCriteria (typeof(ValoracionEN)).List<ValoracionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ValoracionEN valoracion)
{
        try
        {
                SessionInitializeTransaction ();
                ValoracionEN valoracionEN = (ValoracionEN)session.Load (typeof(ValoracionEN), valoracion.Id);

                valoracionEN.Valor = valoracion.Valor;



                session.Update (valoracionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ValoracionEN valoracion)
{
        try
        {
                SessionInitializeTransaction ();
                if (valoracion.Usuario != null) {
                        // Argumento OID y no colección.
                        valoracion.Usuario = (SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN)session.Load (typeof(SuperPetGenNHibernate.EN.BaseDatos.UsuarioEN), valoracion.Usuario.Email);

                        valoracion.Usuario.Valoracion
                        .Add (valoracion);
                }
                if (valoracion.Producto != null) {
                        // Argumento OID y no colección.
                        valoracion.Producto = (SuperPetGenNHibernate.EN.BaseDatos.ProductoEN)session.Load (typeof(SuperPetGenNHibernate.EN.BaseDatos.ProductoEN), valoracion.Producto.Id);

                        valoracion.Producto.Valoracion
                        .Add (valoracion);
                }

                session.Save (valoracion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return valoracion.Id;
}

public void Modify (ValoracionEN valoracion)
{
        try
        {
                SessionInitializeTransaction ();
                ValoracionEN valoracionEN = (ValoracionEN)session.Load (typeof(ValoracionEN), valoracion.Id);

                valoracionEN.Valor = valoracion.Valor;

                session.Update (valoracionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public System.Collections.Generic.IList<ValoracionEN> MuestraValoraciones (int first, int size)
{
        System.Collections.Generic.IList<ValoracionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ValoracionEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ValoracionEN>();
                else
                        result = session.CreateCriteria (typeof(ValoracionEN)).List<ValoracionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

//Sin e: MuestraValoracionesPorOID
//Con e: ValoracionEN
public ValoracionEN MuestraValoracionesPorOID (int id
                                               )
{
        ValoracionEN valoracionEN = null;

        try
        {
                SessionInitializeTransaction ();
                valoracionEN = (ValoracionEN)session.Get (typeof(ValoracionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return valoracionEN;
}

public void Destroy (int id
                     )
{
        try
        {
                SessionInitializeTransaction ();
                ValoracionEN valoracionEN = (ValoracionEN)session.Load (typeof(ValoracionEN), id);
                session.Delete (valoracionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in ValoracionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
