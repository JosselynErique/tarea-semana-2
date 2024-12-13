using System;

// Clase que representa un círculo
public class Circulo
{
    private double radio; // Variable privada para almacenar el radio del círculo

    // Constructor para inicializar el radio del círculo
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // Método para calcular el área del círculo
    public double CalcularArea()
    {
        // Fórmula: Área = π * radio^2
        return Math.PI * Math.Pow(radio, 2);
    }

    // Método para calcular el perímetro del círculo
    public double CalcularPerimetro()
    {
        // Fórmula: Perímetro = 2 * π * radio
        return 2 * Math.PI * radio;
    }
}

// Clase que representa un rectángulo
public class Rectangulo
{
    private double largo; // Variable privada para almacenar el largo del rectángulo
    private double ancho; // Variable privada para almacenar el ancho del rectángulo

    // Constructor para inicializar el largo y el ancho del rectángulo
    public Rectangulo(double largo, double ancho)
    {
        this.largo = largo;
        this.ancho = ancho;
    }

    // Método para calcular el área del rectángulo
    public double CalcularArea()
    {
        // Fórmula: Área = largo * ancho
        return largo * ancho;
    }

    // Método para calcular el perímetro del rectángulo
    public double CalcularPerimetro()
    {
        // Fórmula: Perímetro = 2 * (largo + ancho)
        return 2 * (largo + ancho);
    }
}

// Clase principal para probar las figuras geométricas
public class Programa
{
    public static void Main(string[] args)
    {
        // Crear un círculo con radio 5
        Circulo circulo = new Circulo(5);
        Console.WriteLine("Círculo:");
        Console.WriteLine("Área: " + circulo.CalcularArea());
        Console.WriteLine("Perímetro: " + circulo.CalcularPerimetro());

        // Crear un rectángulo con largo 10 y ancho 4
        Rectangulo rectangulo = new Rectangulo(10, 4);
        Console.WriteLine("\nRectángulo:");
        Console.WriteLine("Área: " + rectangulo.CalcularArea());
        Console.WriteLine("Perímetro: " + rectangulo.CalcularPerimetro());
    }
}
