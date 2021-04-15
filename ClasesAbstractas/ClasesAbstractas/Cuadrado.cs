/*
 * Creado por SharpDevelop.
 * Usuario: andru
 * Fecha: 15/4/2021
 * Hora: 10:29
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ClasesAbstractas
{
	/// <summary>
	/// Description of Cuadrado.
	/// </summary>
	public class Cuadrado : Figura
	{
		private double lado;
		public Cuadrado()
		{
			this.lado = 4;
			this.color = "verde";
		}
		public Cuadrado(string color, double lado)
		{
			this.lado = lado;
			this.color = color;
		}
		public void Mostrar(){
			Console.WriteLine("\n Obj.Cuadrado");
			base.Mostrar();
			Console.WriteLine("[ Lado: " + this.lado + " ]");
		}
		
		//override para indicar de que se implementa un metodo abstracto
		public override void Area(){
			Console.WriteLine("\nArea de Cuadrado");
			Console.WriteLine((this.lado*this.lado));
		}
		public override double Perimetro(){
			return((double)this.lado*4);
		}
		public override void compFigura(Figura X){
			if(X.Color == this.color)
				Console.WriteLine("Mismo Color");
			else
				Console.WriteLine("Distinto Color");
		}
	}
}
