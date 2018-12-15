
using System;
using BaseDatosGenNHibernate.EN.BaseDatos;

namespace BaseDatosGenNHibernate.CAD.BaseDatos
{
public partial interface IAdministradorCAD
{
AdministradorEN ReadOIDDefault (int id
                                );

void ModifyDefault (AdministradorEN administrador);

System.Collections.Generic.IList<AdministradorEN> ReadAllDefault (int first, int size);



int New_ (AdministradorEN administrador);

void Modify (AdministradorEN administrador);


void Destroy (int id
              );
}
}
