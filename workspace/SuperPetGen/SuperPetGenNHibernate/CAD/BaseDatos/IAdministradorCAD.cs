
using System;
using SuperPetGenNHibernate.EN.BaseDatos;

namespace SuperPetGenNHibernate.CAD.BaseDatos
{
public partial interface IAdministradorCAD
{
AdministradorEN ReadOIDDefault (string Email
                                );

void ModifyDefault (AdministradorEN administrador);

System.Collections.Generic.IList<AdministradorEN> ReadAllDefault (int first, int size);



string New_ (AdministradorEN administrador);

void Modify (AdministradorEN administrador);


void Destroy (string Email
              );
}
}
