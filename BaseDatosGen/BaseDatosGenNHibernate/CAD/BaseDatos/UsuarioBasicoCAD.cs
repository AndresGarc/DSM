
using System;
using System.Text;
using BaseDatosGenNHibernate.CEN.BaseDatos;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using BaseDatosGenNHibernate.EN.BaseDatos;
using BaseDatosGenNHibernate.Exceptions;


/*
 * Clase UsuarioBasico:
 *
 */

namespace BaseDatosGenNHibernate.CAD.BaseDatos
{
public partial class UsuarioBasicoCAD : BasicCAD, IUsuarioBasicoCAD
{
public UsuarioBasicoCAD() : base ()
{
}

public UsuarioBasicoCAD(ISession sessionAux) : base (sessionAux)
{
}



public UsuarioBasicoEN ReadOIDDefault (int id
                                       )
{
        UsuarioBasicoEN usuarioBasicoEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioBasicoEN = (UsuarioBasicoEN)session.Get (typeof(UsuarioBasicoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioBasicoCAD.", ex);
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
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioBasicoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (UsuarioBasicoEN usuarioBasico)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioBasicoEN usuarioBasicoEN = (UsuarioBasicoEN)session.Load (typeof(UsuarioBasicoEN), usuarioBasico.Id);

                usuarioBasicoEN.Email = usuarioBasico.Email;


                usuarioBasicoEN.NombreUsu = usuarioBasico.NombreUsu;


                usuarioBasicoEN.Password = usuarioBasico.Password;


                usuarioBasicoEN.Logged = usuarioBasico.Logged;

                session.Update (usuarioBasicoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioBasicoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (UsuarioBasicoEN usuarioBasico)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (usuarioBasico);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioBasicoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioBasico.Id;
}

public void Modify (UsuarioBasicoEN usuarioBasico)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioBasicoEN usuarioBasicoEN = (UsuarioBasicoEN)session.Load (typeof(UsuarioBasicoEN), usuarioBasico.Id);

                usuarioBasicoEN.Email = usuarioBasico.Email;


                usuarioBasicoEN.NombreUsu = usuarioBasico.NombreUsu;


                usuarioBasicoEN.Password = usuarioBasico.Password;


                usuarioBasicoEN.Logged = usuarioBasico.Logged;

                session.Update (usuarioBasicoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioBasicoCAD.", ex);
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
                UsuarioBasicoEN usuarioBasicoEN = (UsuarioBasicoEN)session.Load (typeof(UsuarioBasicoEN), id);
                session.Delete (usuarioBasicoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioBasicoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
