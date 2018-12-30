
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using BaseDatosGenNHibernate.EN.BaseDatos;
using BaseDatosGenNHibernate.CEN.BaseDatos;
using BaseDatosGenNHibernate.CAD.BaseDatos;

/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\sqlexpress; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
        try
        {
                // Insert the initilizations of entities using the CEN classes

                UsuarioBasicoCEN usuBCen = new UsuarioBasicoCEN ();

                UsuarioCEN usuCen = new UsuarioCEN ();
                int usuario1 = usuCen.New_ ("padre@gmail", "pepito86", "asd512", false, "Pepe", "Garcia Antonyez", 655542, DateTime.Parse ("10-11-1964"), true);
                int usuario2 = usuCen.New_ ("madre@hotmail", "mairalamejor", "yuuhv4215", true, "Maira", "Morales", 6542123, DateTime.Parse ("10-07-1965"), true);
                int usuario3 = usuCen.New_ ("hijo@outlook", "xxxlucasxxx", "74564684231", true, "Lucas", "Garcia Morales", 644787, DateTime.Parse ("10-11-2000"), true);


                usuBCen.Login (usuario1, "asd512");
                usuBCen.Logout (usuario2);
                //CONTRASE�A ERRONEA
                usuBCen.Login (usuario2, "tupadre");

                usuCen.Desactivate (usuario1);


                AdministradorCEN adCen = new AdministradorCEN ();
                usuCen.CambiarEstado (usuario1);
                adCen.New_ ("lordprotector@gmail", "Controlador", "5as4d2a6sd", true);


                CategoriaCEN cat = new CategoriaCEN ();
                int idCat = cat.New_("Perros");
                int idCat2 = cat.New_("Gatos");
                int idCat3 = cat.New_("Peces");
                int idCat4 = cat.New_("Pájaros");
                int idCat5 = cat.New_("Reptiles");
                int idCat6 = cat.New_("Roedores");
                int idCat7 = cat.New_("Ofertas");

                int idCat11 = cat.New_("Comida");
                int idCat12 = cat.New_("Higiene");
                int idCat13 = cat.New_("Accesorios");
                cat.CrearSupercategoria(idCat11, idCat);
                cat.CrearSupercategoria(idCat12, idCat);
                cat.CrearSupercategoria(idCat13, idCat);

                int idCat21 = cat.New_("Comida");
                int idCat22 = cat.New_("Higiene");
                int idCat23 = cat.New_("Accesorios");
                cat.CrearSupercategoria(idCat21, idCat2);
                cat.CrearSupercategoria(idCat22, idCat2);
                cat.CrearSupercategoria(idCat23, idCat2);

                int idCat31 = cat.New_("Comida");
                int idCat32 = cat.New_("Higiene");
                int idCat33 = cat.New_("Accesorios");
                cat.CrearSupercategoria(idCat31, idCat3);
                cat.CrearSupercategoria(idCat32, idCat3);
                cat.CrearSupercategoria(idCat33, idCat3);

                int idCat41 = cat.New_("Comida");
                int idCat42 = cat.New_("Higiene");
                int idCat43 = cat.New_("Accesorios");
                cat.CrearSupercategoria(idCat41, idCat4);
                cat.CrearSupercategoria(idCat42, idCat4);
                cat.CrearSupercategoria(idCat43, idCat4);

                int idCat51 = cat.New_("Comida");
                int idCat52 = cat.New_("Higiene");
                int idCat53 = cat.New_("Accesorios");
                cat.CrearSupercategoria(idCat51, idCat5);
                cat.CrearSupercategoria(idCat52, idCat5);
                cat.CrearSupercategoria(idCat53, idCat5);

                int idCat61 = cat.New_("Comida");
                int idCat62 = cat.New_("Higiene");
                int idCat63 = cat.New_("Accesorios");
                cat.CrearSupercategoria(idCat61, idCat6);
                cat.CrearSupercategoria(idCat62, idCat6);
                cat.CrearSupercategoria(idCat63, idCat6);

                /*
                int idCat = cat.New_ ("Perro");
                int idCat2 = cat.New_ ("Accesorios");
                // int idCat3 = cat.New_("Perro", "Accesorios");
                int idCat4 = cat.New_ ("Comida");
                int idCat5 = cat.New_ ("Pajaro");
                int idCat6 = cat.New_ ("Accesorios");
                
                List<int> subcats = new List<int>();
                subcats.Add (idCat2);
                subcats.Add (idCat4);

                cat.CrearSupercategoria (idCat2, idCat); //HALLO PRESINDETE
                cat.CrearSupercategoria (idCat4, idCat);
                cat.CrearSupercategoria (idCat6, idCat5);
                */

                //METER OFERTA WE
                ProductoCEN proCEN = new ProductoCEN ();
                int idProducto = proCEN.New_ ("Correa", "url", 35.00, 6, idCat2, 7, false, 0);
                int idProducto2 = proCEN.New_ ("MeatDogo", "url", 35, 6, idCat4, 7, false, 0.5);
                int idProducto3 = proCEN.New_ ("CheeseCan", "url", 35, 6, idCat4, 7, true, 0);
                int idProducto4 = proCEN.New_ ("Cresta para Loros", "url", 35, 6, idCat6, 7, false, 0);
                int idProducto5 = proCEN.New_ ("Chaqueta punk para gorriones", "url", 35, 6, idCat6, 7, true, 0);


                //COMPROBAR QUE FUNCIONAN LOS INCREMENTAR Y DECREMENTAR STOCK DE LOS PRODUCTOS
                //GUARDAMOS LOS ATRIBUTOS DE UN PRODUCTO EN UN OBJETO
                ProductoEN stockprod = proCEN.get_IProductoCAD ().MuestraProductoPorOID (idProducto);
                System.Console.WriteLine ("El stock del producto antes: " + stockprod.Stock);
                //PARA ACCEDER A LOS METODOS TENEMOS QUE HABLAR CON EL OBJETO XCEN
                proCEN.IncrementaStock (idProducto, 80);
                //INCREMENTA
                stockprod = proCEN.get_IProductoCAD ().MuestraProductoPorOID (idProducto);
                System.Console.WriteLine ("El stock del producto ahora: " + stockprod.Stock);
                //DECREMENTA
                proCEN.DecrementaStock (idProducto, 50);
                stockprod = proCEN.get_IProductoCAD ().MuestraProductoPorOID (idProducto);
                System.Console.WriteLine ("El stock del producto ahora: " + stockprod.Stock);


                ProductoDescripcionCEN descProCEN = new ProductoDescripcionCEN ();
                descProCEN.New_ ("Correa negra extensible de piel de leon prusiano", BaseDatosGenNHibernate.Enumerated.BaseDatos.IdiomaEnum.Castellano, idProducto);
                descProCEN.New_ ("Black velt, black like mo bamba", BaseDatosGenNHibernate.Enumerated.BaseDatos.IdiomaEnum.Inglés, idProducto);
                descProCEN.New_ ("Cresta rosa de 24cm per al teu lloro", BaseDatosGenNHibernate.Enumerated.BaseDatos.IdiomaEnum.Valenciano, idProducto4);


                ComentarioCEN comentCEN = new ComentarioCEN ();
                comentCEN.New_ ("La verdad es que esta correa es super buena!, no danya el cuello del animal y la textura de la correa es increible!", DateTime.Parse ("04-11-2018"), usuario1, idProducto);
                // comentCEN.New_("Decepcionante, no merecen nada la pena los 30 euros de cresta para mi loro", DateTime.Now, new DateTime(), usuario3, idProducto4);

                //DESPUES DE HACER LA CP
                BaseDatosGenNHibernate.CP.BaseDatos.UsuarioCP valorar = new BaseDatosGenNHibernate.CP.BaseDatos.UsuarioCP ();
                valorar.RealizarValoracion (usuario1, idProducto4, 8.9);

                ValoracionCEN valCen = new ValoracionCEN ();
                IList<ValoracionEN> val = valCen.MuestraValoraciones (0, -1);
                Console.WriteLine ();
                foreach (ValoracionEN vals in val) {
                        Console.WriteLine (vals.Id);
                        // Console.WriteLine(vals.Producto);
                        // Console.WriteLine(vals.Usuario);
                        Console.WriteLine (vals.Valor);
                }

                /*
                 * ValoracionCEN valCEN = new ValoracionCEN ();
                 * valCEN.New_ (5, usuario2, idProducto3);
                 * valCEN.New_ (8, usuario1, idProducto5);
                 */

                SliderCEN sliderCEN = new SliderCEN ();
                int slid = sliderCEN.New_ ("url1", "url2", "url3", "url4");
                //CAMBIAR UNA IMAGEN
                // SliderEN imgnueva = sliderCEN.get_ISliderCAD().MuestraSliderPorOID(slid);
                sliderCEN.CambiarImagen (slid, 2, "url5");

                PedidoCEN pedidoCEN = new PedidoCEN ();
                int pedCEN1 = pedidoCEN.New_ (DateTime.Now, BaseDatosGenNHibernate.Enumerated.BaseDatos.EstadoPedidoEnum.Pendiente, usuario1, usuario1);
                int pedCen2 = pedidoCEN.New_ (DateTime.Now, BaseDatosGenNHibernate.Enumerated.BaseDatos.EstadoPedidoEnum.Pendiente, usuario1, usuario1);
                int pedCen3 = pedidoCEN.New_ (DateTime.Now, BaseDatosGenNHibernate.Enumerated.BaseDatos.EstadoPedidoEnum.Pendiente, usuario2, usuario2);

                LineaPedidoCEN linPedCEN = new LineaPedidoCEN ();
                int linPed1 = linPedCEN.New_ (2, idProducto2, pedCEN1);
                int linPed2 = linPedCEN.New_ (6, idProducto5, pedCEN1);
                int linPed3 = linPedCEN.New_ (6, idProducto4, pedCen2);
                int linPed4 = linPedCEN.New_ (3, idProducto3, pedCen3);
                int linPed5 = linPedCEN.New_ (20, idProducto2, pedCen3);


                DirEnvioCEN dirCEN = new DirEnvioCEN ();
                int dir1 = dirCEN.New_ ("C/tupadre", 03502, "Benidorm", "Alicante", usuario1);

                MetodoPagoCEN metCEN = new MetodoPagoCEN ();
                int metodo1 = metCEN.New_ (BaseDatosGenNHibernate.Enumerated.BaseDatos.TipoPagoEnum.PayPal, usuario1);
                int metodo2 = metCEN.New_ (BaseDatosGenNHibernate.Enumerated.BaseDatos.TipoPagoEnum.ContraReembolso, usuario1);

                //METODO DE PAGO
                BaseDatosGenNHibernate.CP.BaseDatos.PedidoCP pago = new BaseDatosGenNHibernate.CP.BaseDatos.PedidoCP ();
                pago.PagarPedido (pedCEN1, dir1, metodo1);
                pago.PagarPedido (pedCen2, dir1, metodo2);
                pago.PagarPedido (pedCen3, dir1, metodo1);

                pago.EnviarPedido (new DateTime (2018, 12, 4), pedCEN1);
                pago.EnviarPedido (new DateTime (2018, 12, 4), pedCen2);


                //CREAR LISTAS DE FAVORITOS - ELIMINAR
                List<int> favs = new List<int>();
                favs.Add (idProducto3);
                favs.Add (idProducto);
                favs.Add (idProducto2);

                List<int> favs2 = new List<int>();
                favs2.Add (idProducto3);
                favs2.Add (idProducto);

                usuCen.AddFavoritos (usuario1, favs);
                usuCen.AddFavoritos (usuario2, favs2);

                usuCen.QuitarFavoritos (usuario2, favs2);


                //RECIBIR PEDIDOS
                BaseDatosGenNHibernate.CP.BaseDatos.PedidoCP recibir = new BaseDatosGenNHibernate.CP.BaseDatos.PedidoCP ();
                recibir.RecibirPedido (pedCen2);

                //RECHAZAR PEDIDOS
                BaseDatosGenNHibernate.CP.BaseDatos.PedidoCP rechazar = new BaseDatosGenNHibernate.CP.BaseDatos.PedidoCP ();
                rechazar.RechazarPedido (pedCEN1);

                //CAMBIAR LA OFERTA
                proCEN.CambiarOferta (idProducto2, 0.7);
                //CAMBIAR EL DESTACADO
                proCEN.CambiarDestacado (idProducto5);



                //COMPROBAR LAS HQL

                /*UsuarioEN soyusu = usuCen.MuestraUsuarioPorOID ("padre@gmail");
                 * System.Console.WriteLine("El id del usuario 1" + soyusu.Nombre);
                 */
                ProductoEN producto1 = proCEN.MuestraProductoPorOID (idProducto);
                ProductoEN producto2 = proCEN.MuestraProductoPorOID (idProducto2);
                ProductoEN producto3 = proCEN.MuestraProductoPorOID (idProducto3);



                //getAllComentarioByProducto / LISTA /  --> comprobadito papa
                IList<ComentarioEN> comentarios = new List<ComentarioEN>();
                comentarios = comentCEN.GetAllComentariosByProducto (producto1.Id, 0, 100);
                Console.WriteLine ();
                foreach (ComentarioEN cosas in comentarios) {
                        Console.WriteLine (cosas.Texto);
                }

                //getDirEnvioByPedido / LISTA / --> comprobadito papa
                IList<DirEnvioEN> direcc = new List<DirEnvioEN>();
                direcc = dirCEN.GetDirEnvioByPedido (pedCEN1, 0, 100);
                Console.WriteLine ();
                foreach (DirEnvioEN cosasdir in direcc) {
                        Console.WriteLine (cosasdir.Id);
                }

                //getAllValoracionesByProducto / LISTA / --> comprobadito papa
                IList<ValoracionEN> valorame = new List<ValoracionEN>();
                ValoracionCEN valCEN = new ValoracionCEN ();
                valorame = valCEN.GetAllValoracionesByProducto (idProducto3, 0, 100);
                Console.WriteLine ();
                foreach (ValoracionEN cosasval in valorame) {
                        Console.WriteLine (cosasval.Valor);
                }

                //getMetodoPagoByPedido / LISTA / --> comprobadito papa
                IList<MetodoPagoEN> metodito = new List<MetodoPagoEN>();
                metodito = metCEN.GetMetodoPagoByPedido (pedCEN1, 0, 100);
                Console.WriteLine ();
                foreach (MetodoPagoEN cosasmetodo in metodito) {
                        Console.WriteLine (cosasmetodo.TipoPago);
                }

                //getEnvioByPedido  / LISTA / --> comprobadito papa
                IList<EnvioEN> enviito = new List<EnvioEN>();
                EnvioCEN envCEN = new EnvioCEN ();
                enviito = envCEN.GetEnvioByPedido (pedCEN1, 0, 100);
                Console.WriteLine ();
                foreach (EnvioEN cosasenvio in enviito) {
                        Console.WriteLine (cosasenvio.Estado);
                }

                //getSubcategorias  / LISTA / --> comprobadito o sea me saca el nombre de las subcategorias y el id
                IList<CategoriaEN> subcas = new List<CategoriaEN>();
                subcas = cat.GetSubcategorias (idCat, 0, 100);
                Console.WriteLine ();
                foreach (CategoriaEN cosassubs in subcas) {
                        Console.WriteLine (cosassubs.Id);
                        Console.WriteLine (cosassubs.Nombre);
                }

                //getUsuarioByNombre / LISTA / --> YEAH MISTER WHITE
                IList<UsuarioEN> usus = new List<UsuarioEN>();
                usus = usuCen.GetUsuarioByNombre ("Pepe", 0, 100);
                Console.WriteLine ();
                foreach (UsuarioEN cosasusus in usus) {
                        Console.WriteLine (cosasusus.Email);
                        Console.WriteLine (cosasusus.Nombre);
                }

                //getAllPedidosByUsuario   / LISTA / --> YEAH MISTER WHITE
                IList<PedidoEN> pedsUsus = new List<PedidoEN>();
                pedsUsus = pedidoCEN.GetAllPedidosByUsuario (usuario1, 0, 100);
                int num = 1;
                Console.WriteLine ();

                foreach (PedidoEN cosaspedsus in pedsUsus) {
                        Console.WriteLine ("Soy el pedido del usuario " + num);
                        Console.WriteLine (cosaspedsus.Id);
                        Console.WriteLine (cosaspedsus.Estado);
                        //Console.WriteLine (cosaspedsus.LineaPedido); NO FUNCA
                        //   Console.WriteLine(cosaspedsus.MetodoPago.TipoPago); TU TAMPOCO
                        Console.WriteLine (cosaspedsus.UsuarioPedido.Nombre);

                        Console.WriteLine ();
                        num++;
                }

                //GETFacturasByPedido / LISTA / --> YEAH MISTER WHITE
                IList<FacturaEN> facturas = new List<FacturaEN>();
                FacturaCEN facCen = new FacturaCEN ();
                facturas = facCen.GetFacturaByPedido (pedCEN1, 0, 100);
                foreach (FacturaEN cosasfacs in facturas) {
                        Console.WriteLine ("Factura: " + cosasfacs.Id);
                        Console.WriteLine ("Pedido: " + cosasfacs.Pedido.Id);
                        Console.WriteLine ("Dineros: " + cosasfacs.PrecioTotal + " euros");
                }

                //HQL PRODUCTOS
                Console.WriteLine ("HQL DE PRODUCTOS");
                Console.WriteLine ();

                //getProductosByNombre
                IList<ProductoEN> prodsNom = new List<ProductoEN>();
                prodsNom = proCEN.GetProductosByNombre ("Correa", 0, 100);
                Console.WriteLine ();
                foreach (ProductoEN cosasprodNom in prodsNom) {
                        Console.WriteLine (cosasprodNom.Id);
                }

                //getProductosByPedido
                IList<ProductoEN> prodsPed = new List<ProductoEN>();
                prodsPed = proCEN.GetAllProductosByPedido (pedCEN1, 0, 100);
                Console.WriteLine ();
                foreach (ProductoEN cosasprodPed in prodsPed) {
                        Console.WriteLine (cosasprodPed.Id);
                        Console.WriteLine (cosasprodPed.Nombre);
                        Console.WriteLine ();
                }

                //getProductosVendidos --> esto esta mal
                /*  IList<ProductoEN> prodsVen = new List<ProductoEN>();
                 * prodsVen = proCEN.GetProductosVendidos2 (idProducto2,0, 100);
                 * Console.WriteLine ()^;*/
                /*
                 * foreach (ProductoEN cosasprodVen in prodsVen)
                 * {
                 *  Console.WriteLine(cosasprodVen);
                 *  Console.WriteLine();
                 * }*/

                //getProductosNuevos / LISTA / --> funsiona relindo
                IList<ProductoEN> prodsNue = new List<ProductoEN>();
                prodsNue = proCEN.GetProductosNuevos (0, 100);
                int numerico = 1;
                Console.WriteLine ();
                Console.WriteLine ("Ultimos Productos");
                foreach (ProductoEN cosasprodNue in prodsNue) {
                        Console.WriteLine ("Soy el producto numero" + numerico);
                        Console.WriteLine (cosasprodNue.Id);
                        Console.WriteLine (cosasprodNue.Nombre);
                        Console.WriteLine ();
                        numerico++;
                }


                //getProductosDestacados / LISTA / -> funsiona relindo
                IList<ProductoEN> prodsDes = new List<ProductoEN>();
                prodsDes = proCEN.GetProductosDestacados (0, 100);
                Console.WriteLine ();
                foreach (ProductoEN cosasprodDes in prodsDes) {
                        Console.WriteLine (cosasprodDes.Nombre);
                        Console.WriteLine (cosasprodDes.Precio);
                        Console.WriteLine ();
                }


                //getProductosConOferta / LISTA / -> funsiona relindo
                IList<ProductoEN> prodsOfer = new List<ProductoEN>();
                prodsOfer = proCEN.GetProductoConOferta (0, 100);
                foreach (ProductoEN cosasprodOfer in prodsOfer) {
                        Console.WriteLine (cosasprodOfer.Nombre);
                        Console.WriteLine (cosasprodOfer.Precio);
                        Console.WriteLine ();
                }

                //getFavoritos / LISTA / -> funsiona relindamente
                IList<ProductoEN> profavs = new List<ProductoEN>();
                profavs = proCEN.GetFavoritos (usuario1, 0, 100);
                Console.WriteLine ("FAVORITINGOS");
                foreach (ProductoEN cosasprodfavs in profavs) {
                        Console.WriteLine (cosasprodfavs.Nombre);
                        Console.WriteLine (cosasprodfavs.Precio);
                        //Console.WriteLine(cosasprodfavs);

                        Console.WriteLine ();
                }

                //getProductosCompradosByUsuario
                IList<ProductoEN> prodComprao = new List<ProductoEN>();
                prodComprao = proCEN.GetProductosCompradosByUsuario (usuario1, 0, 100);
                Console.WriteLine ("Productos comprados por el usuario 1");
                Console.WriteLine ();
                foreach (ProductoEN cosasprocompra in prodComprao) {
                        Console.WriteLine (cosasprocompra.Nombre);
                        Console.WriteLine (cosasprocompra.Precio);
                }


                /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
