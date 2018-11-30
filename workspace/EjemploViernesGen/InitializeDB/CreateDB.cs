
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using EjemploViernesGenNHibernate.EN.EjemploViernes;
using EjemploViernesGenNHibernate.CEN.EjemploViernes;
using EjemploViernesGenNHibernate.CAD.EjemploViernes;
using EjemploViernesGenNHibernate.Enumerated.EjemploViernes;

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


                ClienteCEN cliCEN = new ClienteCEN ();
                string idCliente = cliCEN.Nuevo ("11111111A", "Juan Perez", DateTime.Today, 1);

                CLienteVIPCEN cliVIP = new CLienteVIPCEN ();
                cliVIP.New_ ("222222B", "Pedro Juan", DateTime.Today, 2, 1);

                PedidoCEN pedCEN = new PedidoCEN ();

                int idPedido = pedCEN.New_ ("Pedido 1", idCliente, EstadoPEdidoEnum.pendiente);


                LineaPedidoCEN linCEN = new LineaPedidoCEN ();
                linCEN.New_ (1, 23, idPedido);
                linCEN.New_ (2, 33, idPedido);
                linCEN.New_ (3, 53, idPedido);
                linCEN.New_ (4, 453, idPedido);

                PedidoEN enPedido = pedCEN.get_IPedidoCAD ().ReadOIDDefault (idPedido);

                System.Console.WriteLine ("El estado del pedido antes: " + enPedido.Estado);

                pedCEN.Enviar (idPedido);

                enPedido = pedCEN.get_IPedidoCAD ().ReadOIDDefault (idPedido);

                System.Console.WriteLine ("El estado del pedido despues: " + enPedido.Estado);

                DirEnvioCEN dirCEN = new DirEnvioCEN ();
                dirCEN.New_ ("Langreo 6", 03502, "Benidorm", "Alicante");
                dirCEN.New_ ("PatatasVerdes", 03550, "Vila", "Alicante");


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
