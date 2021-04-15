/*
 * Creado por SharpDevelop.
 * Usuario: andru
 * Fecha: 26/3/2021
 * Hora: 16:12
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Farmacia
{
	/// <summary>
	/// Description of Factura.
	/// </summary>
	public class Factura
	{
		private Cliente c1;
		private int num;
		private string[] detalle;
		
		public Factura()
		{
			num = 20;
			c1 = new Cliente();
			detalle = new string[num];
		}
		
		public int getNum()
		{
			return this.num;
		}
		
		public void setNum(int n)
		{
			this.num = n;
		}
		public string getDetalle(int i)
		{
			return this.detalle[i];
		}
		public void setDetalle(int i, string medicamento)
		{
			this.detalle[i] = medicamento;
		}
		
		public static Factura operator ++(Factura f1)
		{
			Console.WriteLine("SISTEMA 'FARMACIAS UNIDAS'");
			f1.c1++;
			Console.Write("Cantidad: ");
			f1.setNum(Int32.Parse(Console.ReadLine()));
			for (int i = 1; i <= f1.getNum(); i++) {
				Console.WriteLine("Nombre del medicamento: ");
				f1.setDetalle(i, Console.ReadLine());
			}
			return f1;
		}
		
		public static Factura operator --(Factura f1)
		{
			Console.WriteLine("SISTEMA 'FARMACIAS UNIDAS'");
			f1.c1--;
			for (int i = 1; i <= f1.getNum(); i++) {
				Console.WriteLine(f1.getDetalle(i));
			}
			return f1;
		}
	}
}
