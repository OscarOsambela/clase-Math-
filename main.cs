using System;

class MainClass {
  public static void Main (string[] args) {
    realizarTarea();

		//algunos ejemplos de MAth
		Console.WriteLine("Redondeo hacia arriba de 15.3 es {0}", Math.Ceiling(15.3));   
    Console.WriteLine("Redondeo hacia arriba de 15.3 es {0}", Math.Floor(15.3));    

    int a = 24;
    int b = 47;
    Console.WriteLine("El valor más bajo entre {0} y {1} es {2}", a, b, Math.Min(a,b));
    Console.WriteLine("El valor más alto entre {0} y {1} es {2}", a, b, Math.Max(a,b));

    Console.WriteLine("3 elevado a 2 es {0}", Math.Pow(3,2));

    Console.WriteLine("La raíz cuadrada de 25 es {0}", Math.Sqrt(25));

    Console.WriteLine("El número absoluto de -12 es {0}", Math.Abs(-12));

  }

static void realizarTarea(){
  Punto origen = new Punto();
  Punto destino = new Punto(150,90);
	Punto otroPunto = new Punto();
	double distancia = origen.DistanciaHasta(destino);
	Console.WriteLine($"La distancia entre los puntos es de: {distancia}");
	Console.WriteLine($"Número de objetos creados: {Punto.ContadorDeObjetos()}");
	}

}