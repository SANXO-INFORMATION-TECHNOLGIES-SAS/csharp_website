public class Producto{
		/*
			En los comentarios defino los detalles de mis objetos.
		*/
		//#Attributos#
		/*propiedades*/
		private int _id;
		private string _nombre;
		private string _descripcion;
		
		/*Carácterísticas*/
		//// Definicion de propiedades publicas
		////
		public int Id {
			get{return _id; }
			set{
				/*validate(Id);*/
				_id=Id;
				}
		}
		public string Nombre{
			get{return _nombre; }
			set{_nombre=Nombre;}
		}
		public string Descripcion{
			get{return _descripcion; }
			set{_descripcion=Descripcion;}
		}
		/*constructor*/
		Producto(){
			Id=0;
			Nombre="";
			Descripcion="";
		}
		/*Metodos de clase*/
		public override string  ToString(){
			string Msj= "Mensaje de detalle";
			return "Nombre: "+_nombre+" \n Descripción:"+Descripcion+Msj;
		}
		/*Operacion o funciones*/
		public int GetId(){
			return Id;
		}

	//Tener en cuenta que es web, este metodo debe cambiar.
	public static void Main(){
	    
	    Producto p = new Producto();
	    System.Console.WriteLine(p.GetId());
	    p.Nombre="Luis";
	    System.Console.WriteLine(p.ToString());
	    
	}
	