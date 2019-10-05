using ServiceStack;
using connectionDB.APi;
using connectionDB.ServiceModel;
using System.Data;

namespace connectionDB.ServiceInterface
{
	public class DatosProductosServices : Service
	{
		

		public object Any(CrearProducto request)
		{
			Datos c = new Datos();
			c.Db = Globals.GlobalConnection;
			string mensaje = "";
			var r = c.envioProductos( request.Result, request.Result2, request.Result3, request.Result4, request.Result5, request.Result6, request.Result7, request.Result8, request.Result9, out mensaje);
			if (r.Tables.Count >0)
			{
                TipoProductos ti = new TipoProductos();
				ti.ProductosNuevos = r.Tables[0].ToList<DatosProductos>();

				return "DATOS INGRESADOS";
			}
			else
			{
				return new ServiceModel.ErrorResponse
				{

					Message = "No hay datos"
				};
			}
			
		}

	}



}