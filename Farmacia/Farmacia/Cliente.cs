/*
 * Creado por SharpDevelop.
 * Usuario: andru
 * Fecha: 22/3/2021
 * Hora: 16:22
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Farmacia
{
	/// <summary>
	/// Description of Cliente.
	/// </summary>
	public class Cliente
	{
		private int nit;
		private string nombre;
		private string fecha;
		private float precio;
		private string Obs;
		
		public Cliente()
		{
			this.nit = 0;
			this.nombre = "";
			this.fecha = "";
			this.precio = 0;
			this.Obs = "";
		}
		
		public int getNit()
		{
			return nit;
		}
		public void setNit(int n)
		{
			this.nit = n;
		}
		public string getNombre()
		{
			return nombre;
		}
		public void setNombre(string nom)
		{
			this.nombre = nom;
		}
		public string getFecha()
		{
			return fecha;
		}
		public void setFecha(string fecha)
		{
			this.fecha = fecha;
		}
		public float getPrecio()
		{
			return precio;
		}
		public void setPrecio(float precio)
		{
			this.precio = precio;
		}
		public string getObs()
		{
			return Obs;
		}
		public void setObs(string obs)
		{
			this.Obs = obs;
		}
		
		//a) ++; Registro de clientes
		
		public static Cliente operator ++(Cliente c1)
		{
			Console.Write("NIT : ");
			c1.setNit(Int32.Parse(Console.ReadLine()));
			Console.Write("Nombre del cliente: ");
			c1.setNombre(Console.ReadLine());
			Console.Write("Fecha de compra: ");
			c1.setFecha(Console.ReadLine());
			Console.Write("Precio: ");
			c1.setPrecio(float.Parse(Console.ReadLine()));
			Console.Write("Observaciones:  ");
			c1.setObs(Console.ReadLine());
			return(c1);
		}
		
		//b) --; Mostrar al cliente
		
		public static Cliente operator --(Cliente c1)
		{
			Console.WriteLine("SISTEMA FARMACIAS UNIDAS");
			Console.WriteLine("------------------------");
			Console.WriteLine("NIT : " + c1.getNit());
			Console.WriteLine("Nombre del cliente: " + c1.getNombre());
			Console.WriteLine("Fecha de compra: " + c1.getFecha());
			Console.WriteLine("Precio: " + c1.getPrecio());
			Console.WriteLine("Observaciones:  " + c1.getObs());
			return(c1);
		}
		//c)true; si devolvio un medicamento
		public static bool operator true(Cliente c1)
		{
			return(c1.getObs().Equals("si"));
		}
		
		//d)false; no devolvio un medicamento
		public static bool operator false(Cliente c1)
		{
			return(c1.getObs().Equals("no"));
		}
		
		//e) *; Devuelve un valor booleano, que cliente pago un mayor precio
		public static bool operator *(Cliente c1, Cliente c2)
		{
			if (c1.getPrecio().CompareTo(c2.getPrecio()) > 0)
				return true;
			else
				return false;
		}
		
		//f)/; Descuento del 7% al cliente que pagó un mayor precio
		public static Cliente operator /(Cliente c1, Cliente c2)
		{
			Cliente c3 = new Cliente();
			if (c1 * c2) {
				c1.setPrecio(c1.getPrecio() - c1.getPrecio() * 7 / 100);
				c3 = c1;
			} else {
				c2.setPrecio(c2.getPrecio() - c2.getPrecio() * 7 / 100);
				c3 = c2;
			}
			return c3;
		}
		
		//g)+; Devuelve la suma total en la compra de medicamentos
		public static float operator +(Cliente c1, Cliente c2)
		{
			return (c1.getPrecio() + c2.getPrecio());
		}
		//Parcial: operador binario que verifique si el nombre de dos clientes son iguales
		public static Cliente operator -(Cliente c1, Cliente c2)
		{
			if(c1.getNombre() == c2.getNombre()){
				Console.WriteLine("Si tienen los mismos nombres");
				return c1;
			}
				Console.WriteLine("No tienen los mismos nombres");
				return c1;
		}
	
	}
}
