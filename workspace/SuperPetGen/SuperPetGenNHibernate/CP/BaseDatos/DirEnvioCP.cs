
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using SuperPetGenNHibernate.Exceptions;
using SuperPetGenNHibernate.EN.BaseDatos;
using SuperPetGenNHibernate.CAD.BaseDatos;
using SuperPetGenNHibernate.CEN.BaseDatos;



namespace SuperPetGenNHibernate.CP.BaseDatos
{
public partial class DirEnvioCP : BasicCP
{
public DirEnvioCP() : base ()
{
}

public DirEnvioCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
