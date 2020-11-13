using System;

class MainClass {
  public static void Main (string[] args) {
    realizarTarea();
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