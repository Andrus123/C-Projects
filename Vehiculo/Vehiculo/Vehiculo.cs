/*
 * Creado por SharpDevelop.
 * Usuario: Andrés Aquin
 * Fecha: 29/4/2021
 * Hora: 22:45
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Vehiculo
{
	/// <summary>
	/// Description of Vehiculo.
	/// </summary>
	public class Vehiculo
	{
		private String marca;
		private String placa;
		private Carroceria c; //1:1 uno a uno
		private int nroNeumaticos; //1:n uno a muchos
		private Neumatico[] n= new Neumatico[20]; 
		public Vehiculo()
		{
			this.marca = "TESLA";
			this.placa = "BIT-256";
			this.c = new Carroceria(); //Instanciando la parte
			this.nroNeumaticos = 4;
			this.n[0] = new Neumatico("goodyear", 15, 750.70);
			this.n[1] = new Neumatico("goodyear", 15, 750.70);
			this.n[2] = new Neumatico("goodyear", 15, 750.70);
			this.n[3] = new Neumatico("goodyear", 15, 750.70);
		}
		public void Mostrar(){
			Console.WriteLine("\nDatos del Vehiculo: ");
			Console.WriteLine("Marca: "+ this.marca);
			Console.WriteLine("Placa: "+ this.placa);
			this.c.Mostrar();
			Console.WriteLine("N° de neumaticos: "+ this.nroNeumaticos);
			for(int i=0; i<this.nroNeumaticos; i++){
				this.n[i].Mostrar();
			}
		}
		public void Verfcolor(string x){
			if(this.c.Color == x){
				Console.WriteLine("Si es de color: "+ x);
			}else{
				Console.WriteLine("No es de color: "+x+" es de color "+this.c.Color);
			}
		}
		
		public void precioTotal(){
			double total = 0;
			for(int i=0; i<this.nroNeumaticos;i++){
				total = total + this.n[i].Precio;
			}
			Console.WriteLine("Suma total de neumaticos: "+ total);
		}
	}
}
