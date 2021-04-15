/*
 * Creado por SharpDevelop.
 * Usuario: andru
 * Fecha: 30/3/2021
 * Hora: 17:25
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Juego
{
	/// <summary>
	/// Description of Juego.
	/// </summary>
	public class Juego
	{
		private string nombre;
		private string categoria;
		private double version;
		private int añoCreacion;
		
		public Juego()
		{
			this.nombre = "";
			this.categoria = "";
			this.version = 0;
			this.añoCreacion = 0;
		}
		
		public Juego(string nom, string cat, double v, int añoC)
		{
			this.nombre = nom;
			this.categoria = cat;
			this.version = v;
			this.añoCreacion = añoC;
		}
		
		public string getNombre()
		{
			return nombre;
		}
		public void setNombre(string nom)
		{
			this.nombre = nom;
		}
		public string getCategoria()
		{
			return categoria;
		}
		public void setCategoria(string cat)
		{
			this.categoria = cat;
		}
		public double getVersion()
		{
			return version;
		}
		public void setVersion(double v)
		{
			this.version = v;
		}
		public int getAñoCreacion()
		{
			return añoCreacion;
		}
		public void setAñoCreacion(int añoC)
		{
			this.añoCreacion = añoC;
		}
		
		public void leer()
		{
			Console.WriteLine("Ingrese el nombre del juego");
			this.nombre = Leer.Cadena();
			Console.WriteLine("Ingrese la categoría :");
			this.categoria = Leer.Cadena();
			Console.WriteLine("Ingrese la versión :");
			this.version = Leer.Double();
			Console.WriteLine("Ingrese el año de lanzamiento :");
			this.añoCreacion = Leer.Integer();
		}
		
		public void Mostrar()
		{
			Console.WriteLine(this.getNombre());
			Console.WriteLine(this.getCategoria());
			Console.WriteLine(this.getVersion());
			Console.WriteLine(this.getAñoCreacion());
		}
		
		public void Mostrar(Juego x)
		{
			Console.WriteLine("Opcion 1: Nombre ");
			Console.WriteLine("Opcion 2: Categoría");
			Console.WriteLine("Opcion 3: Versión ");
			Console.WriteLine("Opcion 4: Año de Lanzamiento ");
			Console.WriteLine("Ingrese el dato que quiere ver del juego: ");
			int n = Leer.Integer();
			if (n == 1) {
				Console.WriteLine(x.getNombre());
			}
			if (n == 2) {
				Console.WriteLine(x.getCategoria());
			}
			if (n == 3) {
				Console.WriteLine(x.getVersion());
			}
			if (n == 4) {
				Console.WriteLine(x.getAñoCreacion());
			}
			Console.WriteLine("JUEGO: "+ nombre);
		}
		
		
		public void Verificar(Juego x)
		{
			Console.WriteLine("Ingrese el año que se quiere comparar");
			int k = Leer.Integer();
			if (x.getAñoCreacion().Equals(k)) {
				Console.WriteLine("Este juego sí salio el año " + k);
			} else {
				Console.WriteLine("Este juego no salió el año " + k + " salió en el año " + x.getAñoCreacion());
			}
		}
		public void Verificar(Juego x, int p){
			
			if (x.getAñoCreacion().Equals(p)) {
				Console.WriteLine("Este juego sí es del año pasado");
			} else {
				Console.WriteLine("Este juego no salió el año pasado, salió en el año " + x.getAñoCreacion());
			}
		}
		
		public void Reciente(Juego x, Juego y, Juego z){
			x.leer(); 	x.Mostrar();
			y.leer();	y.Mostrar();
			z.leer();	z.Mostrar();
			int max = x.getAñoCreacion();
			string maxn= x.getNombre();
			if(y.getAñoCreacion()>max){
				max = y.getAñoCreacion();
				maxn = y.getNombre();
			}
			if(z.getAñoCreacion()>max){
				max = z.getAñoCreacion();
				maxn = z.getNombre();
			}
			Console.WriteLine("El juego más reciente es "+ maxn +" que salió el año "+ max);
		}
		
		//Sobrecarga de operadores
		
		public static Juego operator ++(Juego j1)
		{
			Console.WriteLine("Verificar mediante Sobrecarga de operadores");
			Console.WriteLine("Opcion 1: Nombre ");
			Console.WriteLine("Opcion 2: Categoría");
			Console.WriteLine("Opcion 3: Versión ");
			Console.WriteLine("Opcion 4: Año de Lanzamiento ");
			Console.WriteLine("Ingrese el dato que quiere ver del juego: ");
			int n = Leer.Integer();
			if (n == 1) {
				Console.WriteLine(j1.getNombre());
			}
			if (n == 2) {
				Console.WriteLine(j1.getCategoria());
			}
			if (n == 3) {
				Console.WriteLine(j1.getVersion());
			}
			if (n == 4) {
				Console.WriteLine(j1.getAñoCreacion());
			}
			Console.WriteLine("JUEGO: "+ j1.getNombre());
			return(j1);
		}
		
	}
}
