/*
 * Creado por SharpDevelop.
 * Usuario: andru
 * Fecha: 30/3/2021
 * Hora: 17:15
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Juego
{
	class Program
	{
		public static void Main(string[] args)
		{	
			Juego j1 = new Juego();
			Juego j2 = new Juego("Fortnite", "Shooter", 3.3, 2018);
			j1.leer();
			j1.Mostrar();
			j2.Mostrar();
			//a) Mostrar el enesimo atributo
			j1.Mostrar(j1);
			j2.Mostrar(j2);
			//b) Verificar si es un juego del año k
			j1.Verificar(j1);
			j2.Verificar(j2);
			//c) Verificar si el juego salió el año pasado
			j1.Verificar(j1,2020);
			j2.Verificar(j2,2020);
			//d) Creando 3 juegos (Fornite, MarioKart, dota1)
			Juego j3 = new Juego();
			Juego j4 = new Juego();
			Juego j5 = new Juego();
			j1.Reciente(j3,j4,j5);
			//e) Sobrecargar operadores para los incisos anteriores
			j1++;
			j2++;
			
			Console.ReadKey();
		}
	}
}