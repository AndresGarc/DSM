
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
 * Clase Slider:
 *
 */

namespace BaseDatosGenNHibernate.CAD.BaseDatos
{
public partial class SliderCAD : BasicCAD, ISliderCAD
{
public SliderCAD() : base ()
{
}

public SliderCAD(ISession sessionAux) : base (sessionAux)
{
}



public SliderEN ReadOIDDefault (int id
                                )
{
        SliderEN sliderEN = null;

        try
        {
                SessionInitializeTransaction ();
                sliderEN = (SliderEN)session.Get (typeof(SliderEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in SliderCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return sliderEN;
}

public System.Collections.Generic.IList<SliderEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<SliderEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(SliderEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<SliderEN>();
                        else
                                result = session.CreateCriteria (typeof(SliderEN)).List<SliderEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in SliderCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (SliderEN slider)
{
        try
        {
                SessionInitializeTransaction ();
                SliderEN sliderEN = (SliderEN)session.Load (typeof(SliderEN), slider.Id);

                sliderEN.Imagen1 = slider.Imagen1;


                sliderEN.Imagen2 = slider.Imagen2;


                sliderEN.Imagen3 = slider.Imagen3;


                sliderEN.Imagen4 = slider.Imagen4;

                session.Update (sliderEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in SliderCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (SliderEN slider)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (slider);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in SliderCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return slider.Id;
}

public void Modify (SliderEN slider)
{
        try
        {
                SessionInitializeTransaction ();
                SliderEN sliderEN = (SliderEN)session.Load (typeof(SliderEN), slider.Id);

                sliderEN.Imagen1 = slider.Imagen1;


                sliderEN.Imagen2 = slider.Imagen2;


                sliderEN.Imagen3 = slider.Imagen3;


                sliderEN.Imagen4 = slider.Imagen4;

                session.Update (sliderEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in SliderCAD.", ex);
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
                SliderEN sliderEN = (SliderEN)session.Load (typeof(SliderEN), id);
                session.Delete (sliderEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in SliderCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: MuestraSliderPorOID
//Con e: SliderEN
public SliderEN MuestraSliderPorOID (int id
                                     )
{
        SliderEN sliderEN = null;

        try
        {
                SessionInitializeTransaction ();
                sliderEN = (SliderEN)session.Get (typeof(SliderEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in SliderCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return sliderEN;
}

public System.Collections.Generic.IList<SliderEN> MuestraSliders (int first, int size)
{
        System.Collections.Generic.IList<SliderEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(SliderEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<SliderEN>();
                else
                        result = session.CreateCriteria (typeof(SliderEN)).List<SliderEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BaseDatosGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BaseDatosGenNHibernate.Exceptions.DataLayerException ("Error in SliderCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
