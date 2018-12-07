using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BaseDatosGenNHibernate.EN.BaseDatos;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;


namespace SuperPet.Models
{
    public class AssemblerSlider
    {
        public Slider ConvertENToModelUI(SliderEN en)
        {
            Slider sly = new Slider();
            sly.Id = en.Id;
            sly.Imagen1 = en.Imagen1;
            sly.Imagen2 = en.Imagen2;
            sly.Imagen3 = en.Imagen3;
            sly.Imagen4 = en.Imagen4;
            return sly;


        }
        public IList<Slider> ConvertListENToModel(IList<SliderEN> ens)
        {
            IList<Slider> sli = new List<Slider>();
            foreach (SliderEN en in ens)
            {
                sli.Add(ConvertENToModelUI(en));
            }
            return sli;
        }

    }

}