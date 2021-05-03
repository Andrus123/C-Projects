/*
 * Creado por SharpDevelop.
 * Usuario: Andrés Aquin
 * Fecha: 30/4/2021
 * Hora: 21:05
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Multimedia
{
	class Program
	{
		public static void Main(string[] args)
		{
			Mp4 m1 = new Mp4();
			Mp4 m2 = new Mp4();
			Mp4 m3 = new Mp4();
			m1.mostrar("Canciones","Videos");
			//a)Sobrecargar un método para borrar una canción por nombre, por artista y por nombre y peso
			Console.WriteLine("\nBorrar una cancion por el nombre: ");
			m1.borrarCancion("So Many Details");
			m1.mostrar("Canciones","");
			Console.WriteLine("\nBorrar una cancion por el artista");
			m2.borrarCancion("Julian Casablancas");
			m2.mostrar("Canciones","");
			Console.WriteLine("\nBorrar una cancion por el nombre y peso");
			m3.borrarCancion("Paper Planes","3150Kb");
			m3.mostrar("Canciones","");
			//b)Sobrecarga de operador + para añadir una cancion
			Console.WriteLine(+m1);
			m1.mostrar("Canciones","");
			//c)Sobrecarga de operador - para añadir un video
			Console.WriteLine(-m1);
			m1.mostrar("Canciones","Videos");
			//d)Mostrar la capacidad disponible del mp4, tomando en cuenta
			//  las canciones y videos con los que cuenta
			m1.Espacio(m1);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}