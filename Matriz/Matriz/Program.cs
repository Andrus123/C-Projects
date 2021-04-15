/*
 * Created by SharpDevelop.
 * User: andru
 * Date: 15/3/2021
 * Time: 16:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Matriz
{
	class Program
	{
		public static void Main(string[] args)
		{
			Matriz m1 = new Matriz();
			Console.WriteLine("Datos de la matriz m1");
			m1.cargar();
			Console.WriteLine("Matriz m1");
			m1.mostrar();
			
			Console.WriteLine("Datos de la matriz m1");
			Matriz m2 = new Matriz();
			m2.cargar();
			Console.WriteLine("Matriz m2");
			m2.mostrar();
			Matriz m3;
			m3 = m1 + m2;
			Console.WriteLine("Resultado de la suma de m1 y m2");
			m3.mostrar();
			Console.ReadKey();
			
		}
	}
}