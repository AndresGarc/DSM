
using System;
using BaseDatosGenNHibernate.EN.BaseDatos;

namespace BaseDatosGenNHibernate.CAD.BaseDatos
{
public partial interface IDirEnvioCAD
{
DirEnvioEN ReadOIDDefault (int id
                           );

void ModifyDefault (DirEnvioEN dirEnvio);

System.Collections.Generic.IList<DirEnvioEN> ReadAllDefault (int first, int size);



int New_ (DirEnvioEN dirEnvio);

void Modify (DirEnvioEN dirEnvio);


void Destroy (int id
              );


DirEnvioEN MuestraDireccionPorOID (int id
                                   );


System.Collections.Generic.IList<DirEnvioEN> MuestraDirecciones (int first, int size);


System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.DirEnvioEN> GetDirEnvioByPedido (int p_pedido, int first, int size);
}
}
