using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using connectionDB.API;

namespace connectionDB.ServiceModel
{
	public class Datos
	{
		//public const string connectionString = "User Id=giscaribe;Password=gisdesar;Data Source=desarrollo;Pooling=False;Statement Cache Size=20;Self Tuning=false;Persist Security Info=True;";
		public const string connectionString = "User Id=system;Password=mierda30;Data Source=desarrollo;Pooling=False;Statement Cache Size=20;Self Tuning=false;Persist Security Info=True;";
		public virtual OracleConnection Db { get; set; }

		

		public DataSet envioProductos(int idProducto,string nombreProducto, string caracProductos, string fechaProducto, string correoProducto, string paisProducto, int precioProducto,int unidaDispo,int unidadVendida, out string mensaje)
		{
			mensaje = "";
			DataSet resultado = new DataSet();
			Helper.OpenDb(Db);
			using (OracleCommand command = (OracleCommand)Db.CreateCommand())
			{
				Helper.OpenDb(Db);

				command.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter { ParameterName = "idProducto", Value = idProducto });
                command.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter { ParameterName = "nombreProducto", Value = nombreProducto });
                command.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter { ParameterName = "caracProductos", Value = caracProductos });
                command.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter { ParameterName = "fechaProducto", Value = fechaProducto });
                command.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter { ParameterName = "correoProducto", Value = correoProducto });
                command.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter { ParameterName = "paisProducto", Value = paisProducto });
                command.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter { ParameterName = "precioProducto", Value = precioProducto });
                command.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter { ParameterName = "unidaDispo", Value = unidaDispo });
                command.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter { ParameterName = "unidadVendida", Value = unidadVendida });
                //command.Parameters.Add(new Oracle.ManagedDataAccess.Client.OracleParameter { ParameterName = "resultado", Value = Oracle.ManagedDataAccess.Types.OracleRefCursor.Null });
                //command.Parameters[1].Direction = System.Data.ParameterDirection.Output;

				command.CommandType = CommandType.StoredProcedure;
				command.CommandText = "Connectiondb.insertProducto";
				try
				{
					OracleDataReader r = (OracleDataReader)command.ExecuteReader(CommandBehavior.CloseConnection);
					DataTable data = new DataTable();
					do
					{
						
						data = new DataTable();
						data.Load(r);
						resultado.Tables.Add(data);

					} while (!r.IsClosed);
				}
				catch(Exception ex)
				{
					mensaje = ex.Message;
					return resultado = null;

				}
				return resultado;
			}

			
		}



	 } // final corchete
}
