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
	/// Description of Figura.
	/// </summary>
	public abstract class Figura
	{
		protected string color;
		
		public string Color{
			get{
				return color;
			}
		}
		
		public void Mostrar(){
			//Console.WriteLine("\n OBJ.FIGURA");
			Console.WriteLine("[ Color: " + this.color + " ]");
		}
		//definicion de metodos abrstractos
		public abstract void Area();
		
		public abstract double Perimetro();
		
		public abstract void compFigura(Figura X);
	}
}
