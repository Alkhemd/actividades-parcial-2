using System;

class ConsumoAgua
{
    public double metrosCubicos { get; set; }
    public double litros { get; set; }

    public ConsumoAgua(double metrosCubicos)
    {
        this.metrosCubicos = metrosCubicos;
        this.litros = metrosCubicos * 1000;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el consumo en metros cúbicos (m³):");
        double m3 = Convert.ToDouble(Console.ReadLine());

        ConsumoAgua consumo = new ConsumoAgua(m3);

        Console.WriteLine("El consumo en litros es: " + consumo.litros + " litros");
    }
}
