/*
 * Creado por SharpDevelop.
 * Usuario: andru
 * Fecha: 4/4/2021
 * Hora: 17:14
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Biblioteca
{
	class Program
	{
		public static void Main(string[] args)
		{
			Biblioteca b1 = new Biblioteca();
			b1.Mostrar();
			b1.Ordenar();
			b1.Mostrar();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}