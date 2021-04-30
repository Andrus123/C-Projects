/*
 * Creado por SharpDevelop.
 * Usuario: Andrés Aquin
 * Fecha: 30/4/2021
 * Hora: 11:28
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Vector
{
	class Program
	{
		public static void Main(string[] args)
		{
			Vector v1 = new Vector();
			v1.mostrar();
			//a)sobrecargar ++ para sumar elementos del vector
			v1++;
			//b)sobrecargar == para sumar elementos del rango ingresado
			Console.WriteLine(v1==2);
			//c)sobrecargar -- para sumar del rango (a,b)
			v1--;
			//d)sobrecargar ! para ordenar el vector
			Console.WriteLine(!v1);
			v1.mostrar();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}