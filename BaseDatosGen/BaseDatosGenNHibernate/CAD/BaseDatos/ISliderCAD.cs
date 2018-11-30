
using System;
using BaseDatosGenNHibernate.EN.BaseDatos;

namespace BaseDatosGenNHibernate.CAD.BaseDatos
{
public partial interface ISliderCAD
{
SliderEN ReadOIDDefault (int id
                         );

void ModifyDefault (SliderEN slider);

System.Collections.Generic.IList<SliderEN> ReadAllDefault (int first, int size);



int New_ (SliderEN slider);

void Modify (SliderEN slider);


void Destroy (int id
              );


SliderEN MuestraSliderPorOID (int id
                              );


System.Collections.Generic.IList<SliderEN> MuestraSliders (int first, int size);
}
}
