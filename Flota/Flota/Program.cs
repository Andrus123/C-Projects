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
	class Program
	{
		public static void Main(string[] args)
		{
			Flota f1 = new Flota();
			Flota f2 = new Flota("RICK123",4);			
			f2.leer();
			f1.Mostrar();
			f2.Mostrar();
			//a)Mostrar la placa de la flota donde se encuentra el pasajero de nombre x
			Console.WriteLine("a)");
			f1.Mostrar("Alexis Troche");
			f2.Mostrar("Pedro Perez");
			//b)Mostrar los pasajeros mayores de edad
			Console.WriteLine("b)");
			f1.Mostrar(18);
			f2.Mostrar(18);
			//c)Sean dos flotas mostrar aquella flota que tenga la mayor cantidad de pasajeros
			Console.WriteLine("c)");
			f1.Mostrar(f1,f2);
			//d) Alexis tiene una extraña obsesión donde desea que los hombres estén en asientos pares 
                //y las mujeres en asientos impares, dime si Alexis será feliz en su viaje D:
			Console.WriteLine("d)");
            f1.ParImpar();
            f2.ParImpar();
            //e) Alexis quiere un bus con puras mujeres
            Console.WriteLine("e)");
            f1.ParImpar("Femenino");
            f2.ParImpar("Femenino");
            //SOBRECARGA DE OPERADORES
            f1++;
            if(f1>f2)
				Console.WriteLine("El bus con más pasajeros es : " + f1.getPlaca() + " con " + f1.getNroPasajeros() + " pasajeros");
            else
				Console.WriteLine("El bus con más pasajeros es : " + f2.getPlaca() + " con " + f2.getNroPasajeros() + " pasajeros");            	
            
			Console.WriteLine("Presione una tecla para terminar");
			Console.ReadKey();
			
		}
	}
}