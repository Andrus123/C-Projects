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
	/// <summary>
	/// Description of Mp4.
	/// </summary>
	public class Mp4
	{
		private String marca;
		private double capacidadGb;
		private int nroCanciones;
		private String[,] cancion = new String[20, 3];
		private int nroVideos;
		private String[,] video = new string[20, 3];
		
		public Mp4()
		{
			this.marca = "Spotify";
			this.capacidadGb = 1;
			this.nroCanciones = 4;
			cancion[0, 0] = "Paper Planes";cancion[0, 1] = "M.I.A";cancion[0, 2] = "3150Kb"; 
			cancion[1, 0] = "Out of the Blue";cancion[1, 1] = "Julian Casablancas";cancion[1, 2] = "3250Kb";
			cancion[2, 0] = "So Many Details";cancion[2, 1] = "Toro y Moi";cancion[2, 2] = "3100Kb";
			cancion[3, 0] = "Amen";cancion[3, 1] = "Logic";cancion[3, 2] = "3100Kb";
			this.nroVideos = 3;
			video[0, 0] = "Without you";video[0, 1] = "Mariah Carey";video[0, 2] = "45Mb";
			video[1, 0] = "Sweet Caroline";video[1, 1] = "Neil Diamond";video[1, 2] = "30Mb";
			video[2, 0] = "Racks in the Middle";video[2, 1] = "Nipsey Hussle";video[2, 2] = "50Mb";
		}
		public void mostrar(String x, String y)
		{
			Console.WriteLine("Marca del Reproductor: " + this.marca);
			Console.WriteLine("Capacidad en Gb: " + this.capacidadGb);
			Console.WriteLine("\nN° de canciones: " + this.nroCanciones);
			if(x=="Canciones"){
			Console.WriteLine("Tema:         Artista:        Peso:  ");
			for (int i = 0; i < nroCanciones; i++) {
				Console.WriteLine(cancion[i, 0] + " - " + cancion[i, 1] + " - " + cancion[i, 2]);
			}}
			if(y=="Videos"){
			Console.WriteLine("\nN° de videos: " + this.nroVideos);
			Console.WriteLine("Video:         Artista:        Peso:  ");
			for (int i = 0; i < nroVideos; i++) {
				Console.WriteLine(video[i, 0] + " - " + video[i, 1] + " - " + video[i, 2]);
			}
			}
		}
		public void borrarCancion(String x)
		{
			string aux1 = "";
			string aux2 = "";
			string aux3 = "";
			for (int i = 0; i < nroCanciones; i++) {
				if (x == cancion[i, 0] || x == cancion[i, 1]) {
					aux1 = cancion[i, 0];
					cancion[i, 0] = cancion[i + 1, 0];
					cancion[i + 1, 0] = aux1;
					
					aux2 = cancion[i, 1];
					cancion[i, 1] = cancion[i + 1, 1];
					cancion[i + 1, 1] = aux2;
					
					aux3 = cancion[i, 2];
					cancion[i, 2] = cancion[i + 1, 2];
					cancion[i + 1, 2] = aux3;
				}
			}
			this.nroCanciones--;
		}
		public void borrarCancion(String x, String y)
		{
			string aux1 = "";
			string aux2 = "";
			string aux3 = "";
			for (int i = 0; i < nroCanciones; i++) {
				if (x == cancion[i, 0] && y == cancion[i, 2]) {
					aux1 = cancion[i, 0];
					cancion[i, 0] = cancion[i + 1, 0];
					cancion[i + 1, 0] = aux1;
					
					aux2 = cancion[i, 1];
					cancion[i, 1] = cancion[i + 1, 1];
					cancion[i + 1, 1] = aux2;
					
					aux3 = cancion[i, 2];
					cancion[i, 2] = cancion[i + 1, 2];
					cancion[i + 1, 2] = aux3;
				}
			}
			this.nroCanciones--;
		}
		public static Mp4 operator +(Mp4 x){
			x.nroCanciones++;
			for(int i=x.nroCanciones-1; i<x.nroCanciones;i++){
				for(int j=0; j<3;j++){
					if(j==0){
						Console.WriteLine("Tema:");
						x.cancion[i,0] = Console.ReadLine();
					}
					if(j==1){
						Console.WriteLine("Artista: ");
						x.cancion[i,1] = Console.ReadLine();
					}
					if(j==2){
						Console.WriteLine("Peso: ");
						x.cancion[i,2] = Console.ReadLine();
					}
				}
			}return(x);
		}
		public static Mp4 operator -(Mp4 x){
			x.nroVideos++;
			for(int i=x.nroVideos-1; i<x.nroVideos; i++){
				for(int j=0; j<3; j++){
					if(j==0){
						Console.WriteLine("Video:");
						x.video[i,0] = Console.ReadLine();
					}
					if(j==1){
						Console.WriteLine("Artista:");
						x.video[i,1] = Console.ReadLine();
					}
					if(j==2){
						Console.WriteLine("Peso:");
						x.video[i,2] = Console.ReadLine();
					}
				}
			}return(x);
		}
	}
}
