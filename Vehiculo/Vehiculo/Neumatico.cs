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
	/// Description of Neumatico.
	/// </summary>
	public class Neumatico
	{
		private String marca;
		private int nroAro;
		private double precio;
		public Neumatico()
		{
			this.marca = "Michellin";
			this.nroAro = 14;
			this.precio = 270.40;
		}
		public Neumatico(string marca, int nroAro, double precio)
		{
			this.marca = marca;
			this.nroAro = nroAro;
			this.precio = precio;
		}
		public void Mostrar(){
			Console.WriteLine("Marca: " + marca);
			Console.WriteLine("N° de Aro: " + nroAro);
			Console.WriteLine("Precio: " + precio);
		}
		public string Marca{
			get {return marca;}
			set {marca = value;}
		}
		public int NroAro{
			get {return nroAro;}
			set {nroAro = value;}
		}
		public double Precio{
			get {return precio;}
			set {precio = value;}
		}
		
	}
}
