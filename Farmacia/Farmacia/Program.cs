/*
 * Creado por SharpDevelop.
 * Usuario: andru
 * Fecha: 22/3/2021
 * Hora: 16:20
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Farmacia
{
	class Program
	{
		public static void Main(string[] args)
		{
			Cliente c1 = new Cliente();
			Cliente c2 = new Cliente();
			Cliente c3 = new Cliente();
			
			Console.WriteLine("Cliente 1");
			c1++;
			c1--;
			Console.WriteLine("Cliente 2");
			c2++;
			c2--;
			
			if (c1) {
				Console.WriteLine("CLiente 1, devolvio el medicamento");
			} else {
				Console.WriteLine("Cliente 1, no devolvio el medicamento");
			}
			if (c1 * c2) {
				Console.WriteLine("El cliente 1 " + c1.getNombre() + " cancelo:  " + c1.getPrecio());
			} else {
				Console.WriteLine("El cliente 2 " + c2.getNombre() + " cancelo:  " + c2.getPrecio());
			}
			
			Console.WriteLine("Descuento del 7% al cliente que pago un mayor precio");
			c3 = c1 / c2;
			c3--;
			
			Console.WriteLine("Precio total: " + (c1 + c2));
			//Crear la clase Factura y sobrecargar los operadores ++(registrar cliente) y --(mostrar cliente)
			Factura f1 = new Factura();
			f1++;
			f1--;
			
			Console.WriteLine("Comprobando si los clientes tienen el mismo nombre");
			c3 = c1 - c2;
			
			Console.ReadLine();
				
		}
	}
}