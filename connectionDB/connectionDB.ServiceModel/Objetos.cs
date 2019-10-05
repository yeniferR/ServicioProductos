using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace connectionDB.ServiceModel
{


	//[DataContract]

    public class DatosProductos
	{
	// // [DataMember]
	//	public string ID { get; set; }
	////	[DataMember]
	//	public string NOMBRE { get; set; }
	////	[DataMember]
	//	public string Caracteristicas { get; set; }
	////	[DataMember]
	//	public string Fecha { get; set; }

	}

	public class TipoProductos
	{
		//[DataMember]
		public List<DatosProductos> ProductosNuevos { get; set; }
	}
}
