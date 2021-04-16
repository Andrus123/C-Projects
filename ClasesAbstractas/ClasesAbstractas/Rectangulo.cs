/*
 * Creado por SharpDevelop.
 * Usuario: andru
 * Fecha: 15/4/2021
 * Hora: 10:42
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ClasesAbstractas
{
	/// <summary>
	/// Description of Rectangulo.
	/// </summary>
	public class Rectangulo : Figura
	{
		private double b;
		private double a;
		
		public Rectangulo()
		{
			this.b = 5;
			this.a = 3;
			this.color = "amarillo";
		}
		public Rectangulo(string color, double b, double a)
		{
			this.b = b;
			this.a = a;
			this.color = color;
		}
		public void Mostrar(){
			Console.WriteLine("\n Objeto Rectangulo");
			base.Mostrar();
			Console.WriteLine("{Base: "+ this.b+ " Altura: " +this.a+"}");
		}
		//override para indicar de que se implementa un metodo abstracto
		public override void Area(){
			Console.WriteLine("\nArea de Rectangulo");
			Console.WriteLine((this.b*this.a));
		}
		public override double Perimetro(){
			return((double)(2*this.b)+(2*this.a));
		}
		public override void compFigura(Figura X){
			if(X.Color == this.color)
				Console.WriteLine("Mismo Color");
			else
				Console.WriteLine("Distinto Color");
		}
	}
}
