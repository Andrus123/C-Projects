/*
 * Creado por SharpDevelop.
 * Usuario: andru
 * Fecha: 15/4/2021
 * Hora: 10:28
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace ClasesAbstractas
{
	class Program
	{
		public static void Main(string[] args)
		{
			Cuadrado A = new Cuadrado();
			Cuadrado B = new Cuadrado("Verde",6);
			Rectangulo C = new Rectangulo();
			Rectangulo[] rv = new Rectangulo[10];
			Cuadrado[] vc = new Cuadrado[30]; //Vector de objetos cuadrado, para almacenar
											  // n objetos cuadrado
			
			A.Mostrar();
			B.Mostrar();
			C.Mostrar();
			
			A.Area();
			
			B.Area();
			
			Console.WriteLine("\n Perimetros de Figuras Cuadrado");
			
			Console.WriteLine(A.Perimetro());
			
			Console.WriteLine(B.Perimetro());
			
			Console.WriteLine("\n Comparar dos Figuras Cuadrado si son del mismo Color");
			A.compFigura(B);
			
			Console.WriteLine("Perimetro y Area de Figuras Rectangulo");
			C.Perimetro();
			C.Area();
			
			//EJERCICIOS
			/*
			 * a. Implementar la clase Triangulo
			 * b. Dado n objetos Cuadrado, cuantos tienen el color X
			 * c. Dado dos triangulos verificar si son iguales
			 * d. Implementar la clase Circulo
			 * e. Dado n objetos rectangulo y un objeto cuadrado, determinar cuantos rectangulos
			 *    tienen la misma area del cuadrado    
			 */
			
			//a)
			Triangulo D = new Triangulo();
			Triangulo E = new Triangulo("naranja",6.7,7);
			Console.WriteLine("Area y Perimetro de Figuras Triangulo");
			D.Area();
			D.Perimetro();
			E.Area();
			E.Perimetro();
			
			//c)
			D.CompTriangulo(D,E);
			
			//d)
			Circulo F = new Circulo();
			Circulo G = new Circulo("Celeste",8);
			F.Mostrar();
			G.Mostrar();
			Console.WriteLine("Area y Perimetro de Circulos");
			F.Area();
			F.Perimetro();
			G.Area();
			G.Perimetro();
			
			//e)
			Console.WriteLine("N objetos Rectangulo");
			int nro = 4;
			rv[0] = new Rectangulo();
			rv[1] = new Rectangulo("azul",5,4);
			rv[2] = new Rectangulo("lila",9,8);
			rv[3] = new Rectangulo("rojo",5,3);
			for(int i=0; i<nro;i++){
				rv[i].Mostrar();
			}
			Console.WriteLine("Rectangulos con el Area similar a Cuadrado: " + RectanCuadrado(rv,nro,A));
			
			//b)
			Console.WriteLine("\nN objetos cuadrado");
			int n = 5;
			
			vc[0] = new Cuadrado();
			vc[1] = new Cuadrado();
			vc[2] = new Cuadrado();
			vc[3] = new Cuadrado("rojo",5);
			vc[4] = new Cuadrado("amarillo",4);
			
//			for(int i=0; i<n; i++){
//				//Cuadrado z = new Cuadrado();
//				//Cuadrado z = new Cuadrado(Console.ReadLine(),double.Parse(Console.ReadLine()));
//				//vc[i] = z;
//				vc[i] = new Cuadrado();
//			}
			
			for(int i=0; i<n; i++){
				vc[i].Mostrar();
			}
			
			
			//llamada a procedimientos
			//llenar(vc, n);
			mostrar(vc, n);
			int  c =0;
			for(int i=0; i<n; i++){
				if(vc[i].Color == "verde")
					c++;
			}
			Console.WriteLine("nro de cuadrados de color verde :" + c);
			Console.WriteLine("nro de cuadrados de color verde :" + contarCuadradoColor(vc,n,"verde"));
						
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		//Procedimiento para llenar y mostrar vectores de objetos
		static void llenar(Cuadrado[] v, int n){
			for(int i=0; i<n; i++){
				Cuadrado z = new Cuadrado();
				v[i] = z;
			}
		}
		static void mostrar(Cuadrado[] v,int n){
			for(int i=0; i<n;i++){
				v[i].Mostrar();
			}
		}
		//funcion contar
		static int contarCuadradoColor( Cuadrado[] v, int n,string colorx){
			int  c =0;
			for(int i=0; i<n; i++){
				if(v[i].Color == colorx)
					c++;
			}
			return c;
		}
		//funcion Area Rectangulo Similar a Cuadrado
		static int RectanCuadrado(Rectangulo[] rv, int nro, Cuadrado A){
			int c = 0;
			for(int i=0; i<nro; i++){
				if(rv[i].Perimetro() == A.Perimetro()){
					c++;
				}
			}
			return c;
		}
	}
}