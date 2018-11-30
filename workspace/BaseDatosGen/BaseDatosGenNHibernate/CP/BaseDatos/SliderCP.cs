
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using BaseDatosGenNHibernate.Exceptions;
using BaseDatosGenNHibernate.EN.BaseDatos;
using BaseDatosGenNHibernate.CAD.BaseDatos;
using BaseDatosGenNHibernate.CEN.BaseDatos;



namespace BaseDatosGenNHibernate.CP.BaseDatos
{
public partial class SliderCP : BasicCP
{
public SliderCP() : base ()
{
}

public SliderCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
