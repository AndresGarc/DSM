
using System;
using EjemploViernesGenNHibernate.EN.EjemploViernes;

namespace EjemploViernesGenNHibernate.CAD.EjemploViernes
{
public partial interface ICLienteVIPCAD
{
CLienteVIPEN ReadOIDDefault (string DNI
                             );

void ModifyDefault (CLienteVIPEN cLienteVIP);

System.Collections.Generic.IList<CLienteVIPEN> ReadAllDefault (int first, int size);



string New_ (CLienteVIPEN cLienteVIP);

void Modify (CLienteVIPEN cLienteVIP);


void Destroy (string DNI
              );
}
}
