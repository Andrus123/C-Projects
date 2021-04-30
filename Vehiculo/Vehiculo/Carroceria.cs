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
	/// Description of Carroceria.
	/// </summary>
	public class Carroceria
	{
		private int nroVentanas;
		private String color;
		private int nroPuertas;
		public Carroceria()
		{
			this.nroVentanas = 6;
			this.color = "verde";
			this.nroPuertas = 4;
		}
		public void Mostrar(){
			Console.WriteLine("\nColor: " + color);
			Console.WriteLine("N° de ventanas: " + nroVentanas);
			Console.WriteLine("N° de puertas: " + nroPuertas);
		}
		public int NroVentanas {
			get {return nroVentanas;}
			set {nroVentanas = value;}
		}
		public int NroPuertas {
			get {return nroPuertas;}
			set {nroPuertas = value;}
		}
		public string Color {
			get {return color;}
			set {color = value;}
		}
	}
}
