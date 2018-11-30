
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using SuperPetGenNHibernate.Exceptions;
using SuperPetGenNHibernate.EN.BaseDatos;
using SuperPetGenNHibernate.CAD.BaseDatos;


/*PROTECTED REGION ID(usingSuperPetGenNHibernate.CEN.BaseDatos_Slider_cambiarImagen) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace SuperPetGenNHibernate.CEN.BaseDatos
{
public partial class SliderCEN
{
        public void CambiarImagen(int p_oid, int img_pos, string img_url)
        {
            /*PROTECTED REGION ID(BaseDatosGenNHibernate.CEN.BaseDatos_Slider_cambiarImagen) ENABLED START*/

            SliderEN slider = _ISliderCAD.MuestraSliderPorOID(p_oid);

            switch (img_pos)
            {
                case 0:
                    slider.Imagen1 = img_url;
                    break;
                case 1:
                    slider.Imagen2 = img_url;
                    break;
                case 2:
                    slider.Imagen3 = img_url;
                    break;
                case 3:
                    slider.Imagen4 = img_url;
                    break;
            }

            _ISliderCAD.Modify(slider);

            /*PROTECTED REGION END*/
        }
    }
}
