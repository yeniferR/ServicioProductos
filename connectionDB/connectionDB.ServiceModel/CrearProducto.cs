using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;

namespace connectionDB.ServiceModel
{
	

	[Api("ingresando productos")]
	[Route("/Productos/Registro de productos", "GET")]

	public class CrearProducto
	{
		public int Result { get; set; }
        public string Result2 { get; set; }
        public string Result3 { get; set; }
        public string Result4 { get; set; }
        public string Result5 { get; set; }
        public string Result6 { get; set; }
        public int Result7 { get; set; }
        public int Result8 { get; set; }
        public int Result9 { get; set; }
    }
}