/*
 * Creado por SharpDevelop.
 * Usuario: andru
 * Fecha: 4/4/2021
 * Hora: 17:19
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Biblioteca
{
	/// <summary>
	/// Description of Biblioteca.
	/// </summary>
	public class Biblioteca
	{
		private string nombre;
		private string bibliotecario;
		private int num_lib;
		private string[,] libro = new string[10,4];
		
		public Biblioteca()
		{
			this.nombre = "BIBLIOTECA CENTRAR";
			this.bibliotecario = "Jordan Peterson";
			this.num_lib = 6;
			     //título:  						autor:    				género    				código
			libro[0,0] = "Superintelligence"; libro[0,1] = "Nick Bostrom"; libro[0,2] = "Tecnologia"; libro[0,3] = "TCH345";
			libro[1,0] = "Principles"; 		  libro[1,1] = "Ray Dalio";    libro[1,2] = "Negocios";   libro[1,3] = "BSN346";
			libro[2,0] = "Sapiens"; 		  libro[2,1] = "Yuval Harari"; libro[2,2] = "Historia";   libro[2,3] = "HST214";
			libro[3,0] = "Clean Code"; 		  libro[3,1] = "Robert Martin";libro[3,2] = "Tecnologia"; libro[3,3] = "TCH356";
			libro[4,0] = "Guerra y Paz"; 	  libro[4,1] = "Leon Tolstoi"; libro[4,2] = "Historia";   libro[4,3] = "HST347";
			libro[5,0] = "Anna Karenina"; 	  libro[5,1] = "Leon Tolstoi"; libro[5,2] = "Novela";     libro[5,3] = "NVL125";
		}
		public Biblioteca(String Bib, int nl)
		{
		this.nombre = Bib;
			this.bibliotecario = "";
			this.num_lib = nl;
			for(int i = 0; i < 10; i++){
				for(int j = 0; j<4; j++){
					libro[i,j] = "";
				}
			}
		}
		
		//Leer
		public void leer()
		{
			Console.WriteLine("Biblioteca: ");
			this.nombre = Leer.Cadena();
			Console.WriteLine("Bibliotecario: ");
			this.bibliotecario = Leer.Cadena();
			Console.WriteLine("Cantidad de libros: ");
			this.num_lib = Leer.Integer();
			for (int i=0; i<getNumlibros(); i++){
				for(int j = 0; j<4;j++){
					if(j == 0){
						Console.WriteLine("Título: ");
					}
					if(j == 1){
						Console.WriteLine("Autor: ");
					}
					if(j == 2){
						Console.WriteLine("Género: ");
					}
					if(j == 3){
						Console.WriteLine("Código: ");
					}
					libro[i,j] = Leer.Cadena();
				}
			}
		}
		//Mostrar
		public void Mostrar()
		{
			Console.WriteLine("BIBLIOTECA: " +getNombre());
			Console.WriteLine("Bibliotecario: " +getBibliotecario());
			Console.WriteLine("Cantidad de libros: " +getNumlibros());
			Console.WriteLine("Titulo:    Autor:     Género:     Código:");
			for(int i=0; i<getNumlibros();i++){
				Console.WriteLine(getLibro(i,0)+"  "+getLibro(i,1)+" "+getLibro(i,2)+" "+getLibro(i,3));
			}
		}
		
		
		//Getters y Setters
		public string getNombre(){
			return nombre;
		}
		public void setNombre(string nombre){
			this.nombre = nombre;
		}
		public string getBibliotecario(){
			return bibliotecario;
		}
		public void setBibliotecario(string bibliotecario){
			this.bibliotecario = bibliotecario;
		}
		public int getNumlibros(){
			return num_lib;
		}
		public void setNumlibros(int numlibros){
			this.num_lib = numlibros;
		}
		public String[,] getLibro(){
			return libro;
		}
		public String getLibro(int i, int j){
			return libro[i,j];
		}
		public void setLibro(String[,] libro){
			this.libro = libro;
		}
		public void setLibro(int i, int j, String l){
			this.libro[i,j] = l;
		}
		//Ordenar
		public void Ordenar()
		{	string aux="";
			for(int i=0;i<getNumlibros();i++){
				for(int j=0;j<4;j++)
					if(int.Parse(getLibro(i,j))>int.Parse(getLibro(i+1,j))){
					aux = libro[i,j];
					libro[i,j]= libro[i+1,j];
					libro[i+1,j] = aux;
				}
			}
		}
	}
}
