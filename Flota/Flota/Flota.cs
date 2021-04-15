/*
 * Creado por SharpDevelop.
 * Usuario: andru
 * Fecha: 31/3/2021
 * Hora: 15:33
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Flota
{
	/// <summary>
	/// Description of Flota.
	/// </summary>
	public class Flota
	{
		private string placa;
		private int capacidad;
		private int nroPasajeros;
		private string[,] pasajero = new string[50, 4];
		
		//2 constructores Flota
		public Flota()
		{
			this.placa = "TUP901";
			this.capacidad = 50;
			this.nroPasajeros = 3;
							// Nombre  Edad  Genero  Asiento
			this.pasajero[0, 0] = "Alexis Troche";    this.pasajero[0, 1] = "26";  this.pasajero[0, 2] = "Masculino"; this.pasajero[0, 3] = "2";
			this.pasajero[1, 0] = "Laura Bella";      this.pasajero[1, 1] = "25";  this.pasajero[1, 2] = "Femenino";  this.pasajero[1, 3] = "3";
			this.pasajero[2, 0] = "Adriana Rodriguez";this.pasajero[2, 1] = "21";  this.pasajero[2, 2] = "Femenino";  this.pasajero[2, 3] = "7";
		}
		public Flota(string placa, int cap)
		{
			this.placa = placa;
			this.capacidad = cap;
			this.nroPasajeros = 3;
			for (int i = 0; i < 50; i++) {
				for (int j = 0; j < 3; j++) {
					pasajero[i, j] = "";
				}
			}
		}
		//Leer
		public void leer()
		{
			Console.WriteLine("PLACA: ");
			this.placa = Leer.Cadena();
			Console.WriteLine("CAPACIDAD: ");
			this.capacidad = Leer.Integer();
			Console.WriteLine("CANTIDAD DE PASAJEROS: ");
			this.nroPasajeros = Leer.Integer();
			for (int i = 0; i < getNroPasajeros(); i++) {
				for (int j = 0; j < 4; j++) {
					if (j == 0) {
						Console.WriteLine("Nombre: ");
					}
					if (j == 1) {
						Console.WriteLine("Edad: ");
					}
					if (j == 2) {
						Console.WriteLine("Genero: ");
					}
					if (j == 3) {
						Console.WriteLine("Asiento: ");
					}
					pasajero[i, j] = Leer.Cadena();
				}
			}
		}
		//Mostrar
		public void Mostrar()
		{
			Console.WriteLine("PLACA : " + getPlaca());
			Console.WriteLine("CAPACIDAD : " + getCapacidad());
			Console.WriteLine("CANTIDAD DE PASAJEROS : " + getNroPasajeros());
			Console.WriteLine("Nombre:             Edad:     Genero:    Asiento:   ");
			for (int i = 0; i < getNroPasajeros(); i++) {
				Console.WriteLine(getPasajero(i, 0) + "       " + getPasajero(i, 1) + "     " + getPasajero(i, 2) + "      " + getPasajero(i, 3));
			}
		}
		
		//Getters y Setters
		public string getPlaca()
		{
			return placa;
		}
		public void setPlaca(string placa)
		{
			this.placa = placa;
		}
		public int getCapacidad()
		{
			return capacidad;
		}
		public void setCapacidad(int cap)
		{
			this.capacidad = cap;
		}
		public int getNroPasajeros()
		{
			return nroPasajeros;
		}
		public void setNroPasajeros(int nroP)
		{
			this.nroPasajeros = nroP;
		}
		public String[,] getPasajero()
		{
			return pasajero;
		}
		public String getPasajero(int i, int j)
		{
			return pasajero[i, j];
		}
		public void setPasajero(String[,] pasajero)
		{
			this.pasajero = pasajero;
		}
		public void setPasajero(int i, int j, String p)
		{
			this.pasajero[i, j] = p;
		}
		//a) Mostrar la placa de la flota donde se encuentra el pasajero de nombre X
		public void Mostrar(string x)
		{
			bool sw = true;
			for (int i = 0; i < getNroPasajeros(); i++) {
				if (x == pasajero[i, 0]) {
					Console.WriteLine("PLACA DEL BUS: " + getPlaca());
					sw = false;
				}
			}
			if (sw)
				Console.WriteLine("El Pasajero de nombre " + x + " no está registrado este bus");
		}
		//b) Mostrar los pasajeros mayores de edad
		public void Mostrar(int x)
		{
			for (int i = 0; i < getNroPasajeros(); i++) {
				if (int.Parse(pasajero[i, 1]) > x) {
					Console.WriteLine(getPasajero(i, 0) + " " + getPasajero(i, 1) + " " + getPasajero(i, 2) + " " + getPasajero(i, 3));
				}
			}
		}
		//c) Sean dos flotas mostrar aquella flota que tenga la mayor cantidad de pasajeros
		public void Mostrar(Flota f1, Flota f2)
		{
			if (f1.getNroPasajeros() > f2.getNroPasajeros()) {
				Console.WriteLine("El bus con más pasajeros es : " + f1.getPlaca() + " con " + f1.getNroPasajeros() + " pasajeros");
			} else {
				Console.WriteLine("El bus con más pasajeros es : " + f2.getPlaca() + " con " + f2.getNroPasajeros() + " pasajeros");
			}
		}
		//d) Alexis tiene una extraña obsesión donde desea que los hombres estén en asientos pares
		//y las mujeres en asientos impares, dime si Alexis será feliz en su viaje D:
		public void ParImpar()
		{	
			Console.WriteLine("En el bus con placa: "+ getPlaca());
			int cf = 0;
			int cm = 0;
			for (int i = 0; i < getNroPasajeros(); i++) {
				if (pasajero[i, 2] == "Femenino" && int.Parse(pasajero[i,3]) % 2 != 0) {
					cf++;
				}
				if (pasajero[i,2] == "Masculino" && int.Parse(pasajero[i,3]) % 2 == 0){
					cm++;
				}
			}
			if (cm + cf == getNroPasajeros()){
				Console.WriteLine("En este bus, Alexis podrá viajar feliz :D");
			}
			else{
				Console.WriteLine("Por lo menos hay un pasajero que no cumple con las exigencias de Alexis, por lo que viajará mal D:");
			}
		}
		//e) Alexis quiere un bus con puras mujeres
		public void ParImpar(string x)
		{
			int cf = 0;
			for (int i = 0; i< getNroPasajeros(); i++){
				if (pasajero[i,2] == x){
					cf++;
				}
			}
			if (cf == getNroPasajeros()){
				Console.WriteLine("En este bus solo irán pasajeros del genero: " + x + " por lo que Alexis viajará felíz");
			}
			else{
				Console.WriteLine("En este bus irán pasajeros de ambos géneros, por lo que Alexis viajará triste");
			}
				
		}
		//SOBRECARGA DE OPERADORES
		public static Flota operator ++(Flota x)
		{
			Console.WriteLine("PLACA : " + x.getPlaca());
			Console.WriteLine("CAPACIDAD : " + x.getCapacidad());
			Console.WriteLine("CANTIDAD DE PASAJEROS : " + x.getNroPasajeros());
			Console.WriteLine("Nombre:             Edad:     Genero:    Asiento:   ");
			for (int i = 0; i < x.getNroPasajeros(); i++) {
				Console.WriteLine(x.getPasajero(i, 0) + "       " + x.getPasajero(i, 1) + "     " + x.getPasajero(i, 2) + "      " + x.getPasajero(i, 3));
			}
			return x;
		}
		
		public static bool operator > (Flota f1, Flota f2)
		{
			if (f1.nroPasajeros > f2.nroPasajeros)
				return true;
				return false;
		}
		public static bool operator < (Flota f1, Flota f2)
		{
			return true;
		}
	}
}
