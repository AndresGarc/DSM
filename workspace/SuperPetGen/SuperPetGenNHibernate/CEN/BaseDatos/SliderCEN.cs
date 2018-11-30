

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
 *      Definition of the class SliderCEN
 *
 */
public partial class SliderCEN
{
private ISliderCAD _ISliderCAD;

public SliderCEN()
{
        this._ISliderCAD = new SliderCAD ();
}

public SliderCEN(ISliderCAD _ISliderCAD)
{
        this._ISliderCAD = _ISliderCAD;
}

public ISliderCAD get_ISliderCAD ()
{
        return this._ISliderCAD;
}

public int New_ (string p_imagen1, string p_imagen2, string p_imagen3, string p_imagen4)
{
        SliderEN sliderEN = null;
        int oid;

        //Initialized SliderEN
        sliderEN = new SliderEN ();
        sliderEN.Imagen1 = p_imagen1;

        sliderEN.Imagen2 = p_imagen2;

        sliderEN.Imagen3 = p_imagen3;

        sliderEN.Imagen4 = p_imagen4;

        //Call to SliderCAD

        oid = _ISliderCAD.New_ (sliderEN);
        return oid;
}

public void Modify (int p_Slider_OID, string p_imagen1, string p_imagen2, string p_imagen3, string p_imagen4)
{
        SliderEN sliderEN = null;

        //Initialized SliderEN
        sliderEN = new SliderEN ();
        sliderEN.Id = p_Slider_OID;
        sliderEN.Imagen1 = p_imagen1;
        sliderEN.Imagen2 = p_imagen2;
        sliderEN.Imagen3 = p_imagen3;
        sliderEN.Imagen4 = p_imagen4;
        //Call to SliderCAD

        _ISliderCAD.Modify (sliderEN);
}

public void Destroy (int id
                     )
{
        _ISliderCAD.Destroy (id);
}

public SliderEN MuestraSliderPorOID (int id
                                     )
{
        SliderEN sliderEN = null;

        sliderEN = _ISliderCAD.MuestraSliderPorOID (id);
        return sliderEN;
}

public System.Collections.Generic.IList<SliderEN> MuestraSliders (int first, int size)
{
        System.Collections.Generic.IList<SliderEN> list = null;

        list = _ISliderCAD.MuestraSliders (first, size);
        return list;
}
}
}
