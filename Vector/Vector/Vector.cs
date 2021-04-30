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
	/// <summary>
	/// Description of Vector.
	/// </summary>
	public class Vector
	{
		private int n;
		private int[] v = new int[30];
		public Vector()
		{
			this.n = 5;
			this.v[0]=5;
			this.v[1]=10;
			this.v[2]=12;
			this.v[3]=7;
			this.v[4]=20;
		}
		public int getN()
		{
			return n;
		}
		public void setN(int n)
		{
			this.n = n;
		}
		
		public void llenar()
		{
			Console.WriteLine("Cantidad de datos del Vector: ");
			this.n = int.Parse(Console.ReadLine());
			for(int i=0; i<n;i++){
				v[i] = int.Parse(Console.ReadLine());
			}
		}
		public void mostrar()
		{
			for(int i=0;i<n;i++){
				Console.WriteLine(v[i]);
			}
		}
		
		public static Vector operator ++(Vector v){
			int suma = 0;
			for(int i=0; i<v.n;i++){
				suma = suma + v.v[i];
			}
			Console.WriteLine("Suma total del vector: "+suma);
			return(v);
		}
		public static Vector operator ==(Vector x, int r){
			int total = 0;
			for(int i=0; i<r;i++){
				total = total + x.v[i];
			}
			Console.WriteLine("Total del Rango: "+total);
			return(x);
		}
		public static Vector operator !=(Vector x, int r){
			return(x);
		}
		public static Vector operator --(Vector y){
			Console.WriteLine("Ingrese el rango x-y");
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			int suma= 0;
			for(int i=a;i<b;i++){
				suma = suma + y.v[i];
			}
			Console.WriteLine("Suma del Rango: "+a+"-"+b+" ="+suma);
			return(y);
		}
		public static Vector operator !(Vector x){
			int aux = 0;
			for(int i=0;i<x.n-1;i++){
				for(int j=i+1;j<x.n; j++){
					if(x.v[i]>x.v[j]){
						aux = x.v[i];
						x.v[i] = x.v[j];
						x.v[j] = aux;
					}
				}
			}
			return(x);
		}
		
	}
}
