
using System;
using BaseDatosGenNHibernate.EN.BaseDatos;

namespace BaseDatosGenNHibernate.CAD.BaseDatos
{
public partial interface IEnvioCAD
{
EnvioEN ReadOIDDefault (int id
                        );

void ModifyDefault (EnvioEN envio);

System.Collections.Generic.IList<EnvioEN> ReadAllDefault (int first, int size);



int New_ (EnvioEN envio);

void Modify (EnvioEN envio);


void Destroy (int id
              );


System.Collections.Generic.IList<BaseDatosGenNHibernate.EN.BaseDatos.EnvioEN> GetEnvioByPedido (int p_pedido, int first, int size);
}
}
