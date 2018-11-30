
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
 * Clase UsuarioBasico:
 *
 */

namespace SuperPetGenNHibernate.CAD.BaseDatos
{
public partial class UsuarioBasicoCAD : BasicCAD, IUsuarioBasicoCAD
{
public UsuarioBasicoCAD() : base ()
{
}

public UsuarioBasicoCAD(ISession sessionAux) : base (sessionAux)
{
}



public UsuarioBasicoEN ReadOIDDefault (string Email
                                       )
{
        UsuarioBasicoEN usuarioBasicoEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioBasicoEN = (UsuarioBasicoEN)session.Get (typeof(UsuarioBasicoEN), Email);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioBasicoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioBasicoEN;
}

public System.Collections.Generic.IList<UsuarioBasicoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<UsuarioBasicoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(UsuarioBasicoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<UsuarioBasicoEN>();
                        else
                                result = session.CreateCriteria (typeof(UsuarioBasicoEN)).List<UsuarioBasicoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioBasicoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (UsuarioBasicoEN usuarioBasico)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioBasicoEN usuarioBasicoEN = (UsuarioBasicoEN)session.Load (typeof(UsuarioBasicoEN), usuarioBasico.Email);

                usuarioBasicoEN.NombreUsu = usuarioBasico.NombreUsu;


                usuarioBasicoEN.Password = usuarioBasico.Password;


                usuarioBasicoEN.Logged = usuarioBasico.Logged;

                session.Update (usuarioBasicoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioBasicoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public string New_ (UsuarioBasicoEN usuarioBasico)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (usuarioBasico);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioBasicoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioBasico.Email;
}

public void Modify (UsuarioBasicoEN usuarioBasico)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioBasicoEN usuarioBasicoEN = (UsuarioBasicoEN)session.Load (typeof(UsuarioBasicoEN), usuarioBasico.Email);

                usuarioBasicoEN.NombreUsu = usuarioBasico.NombreUsu;


                usuarioBasicoEN.Password = usuarioBasico.Password;


                usuarioBasicoEN.Logged = usuarioBasico.Logged;

                session.Update (usuarioBasicoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioBasicoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (string Email
                     )
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioBasicoEN usuarioBasicoEN = (UsuarioBasicoEN)session.Load (typeof(UsuarioBasicoEN), Email);
                session.Delete (usuarioBasicoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is SuperPetGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new SuperPetGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioBasicoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
