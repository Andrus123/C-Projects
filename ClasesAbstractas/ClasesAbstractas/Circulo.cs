/*
 * Creado por SharpDevelop.
 * Usuario: andru
 * Fecha: 16/4/2021
 * Hora: 22:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ClasesAbstractas
{
	/// <summary>
	/// Description of Circulo.
	/// </summary>
	public class Circulo : Figura
	{
		private const double pi = 3.1416;
		private double diametro;
		public Circulo()
		{
			this.diametro = 7.5;
		}
		public Circulo(string color, double d)
		{
			this.diametro = d;
			this.color = color;
		}
		public void Mostrar(){
			Console.WriteLine("\n Objeto Circulo");
			base.Mostrar();
			Console.WriteLine("Diametro: "+this.diametro+"= Circunferencia: "+(this.diametro*pi));
		}
		//Override para implementacion de metodo abstracto
		public override void Area(){
			Console.WriteLine("Area de Circulo");
			double radio = this.diametro/2;
			Console.WriteLine(pi*(radio*radio));
		}
		public override double Perimetro(){
			return((double)this.diametro*pi);
		}
		public override void compFigura(Figura X){
			if(X.Color==this.color)
				Console.WriteLine("Mismo Color");
			else
				Console.WriteLine("Diferente Color");
		}
	}
}
