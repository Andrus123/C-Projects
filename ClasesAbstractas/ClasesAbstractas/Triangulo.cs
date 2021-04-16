/*
 * Creado por SharpDevelop.
 * Usuario: andru
 * Fecha: 15/4/2021
 * Hora: 22:43
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ClasesAbstractas
{
	/// <summary>
	/// Description of Triangulo.
	/// </summary>
	public class Triangulo : Figura
	{
		private double b;
		private double a;
		public Triangulo()
		{
			this.b = 7;
			this.a = 9;
			this.color = "azul";
		}
		public Triangulo(string color, double b, double a)
		{
			this.b = b;
			this.a = a;
			this.color = color;
		}
		public void Mostrar(){
			Console.WriteLine("\n Objeto Triangulo");
			base.Mostrar();
			Console.WriteLine("Base: " +this.b +" Altura: "+this.a);
		}
		//Override para implementacion de metodo abstracto
		public override void Area(){
			Console.WriteLine("Area de Triangulo");
			Console.WriteLine((this.b*this.a)/2);
		}
		public override double Perimetro(){
			
		}
	}
}
