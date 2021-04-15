/*
 * Creado por SharpDevelop.
 * Usuario: andru
 * Fecha: 15/3/2021
 * Hora: 16:41
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Matriz
{
	/// <summary>
	/// Description of Matriz.
	/// </summary>
	public class Matriz
	{
		private int[,] v;
		private int n;
		public Matriz()
		{
			n = 3;
			v = new int[n, n];
		}
		public void cargar()
		{
			for (int i = 0; i < n; i++) {
				for (int j = 0; j < n; j++) {
					Console.WriteLine("Elemento en la posición: " + i + "," + j + ":  ");
					v[i, j] = int.Parse(Console.ReadLine());
				}
			}
		}
//fin del metodo cargar
		
		public void mostrar()
			{
			for (int i = 0; i < n; i++) {
				for (int j = 0; j < n; j++) {
					Console.Write(v[i, j] + " ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
//fin del metodo mostrar
		
		public static Matriz operator +(Matriz m1, Matriz m2)
		{
			Matriz o1 = new Matriz();
			for (int i = 0; i < o1.n; i++) {
				for (int j = 0; j < o1.n; j++) {
					o1.v[i, j] = m1.v[i, j] + m2.v[i, j];
				}
			}
			return(o1);
		}
	}
}
