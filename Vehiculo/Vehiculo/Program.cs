/*
 * Creado por SharpDevelop.
 * Usuario: Andrés Aquin
 * Fecha: 29/4/2021
 * Hora: 22:31
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Vehiculo
{
	class Program
	{
		public static void Main(string[] args)
		{
			//a) Instanciar un Vehiculo y mostrar datos
			Vehiculo v1 = new Vehiculo();
			v1.Mostrar();
			//b) Verificar si la carroceria es del color x
			v1.Verfcolor("azul");
			//c) Determinar el precio total de los neumaticos
			v1.precioTotal();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}