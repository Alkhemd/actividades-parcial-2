using System;

class Alimento
{
    public string Nombre_producto { get; set; }
    public double Precio { get; set; }
    public double Cantidad { get; set; }

    public Alimento(string nombre_producto, double precio, double cantidad)
    {
        this.Nombre_producto = nombre_producto;
        this.Precio = precio;
        this.Cantidad = cantidad;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el nombre del alimento de su mascota:");
        string nombreProducto = Console.ReadLine();

        Console.WriteLine("Ingrese el precio del producto:");
        double precio = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("¿Cuántos días estará de viaje?");
        int dias = Convert.ToInt32(Console.ReadLine());

        
        double consumoDiarioKg = 0.75; // 750 gramos en kilogramos
        double totalNecesario = dias * consumoDiarioKg;

        Console.WriteLine("Ingrese la cantidad en kilogramos que dejó a su mascota:");
        double cantidadDejada = Convert.ToDouble(Console.ReadLine());

        
        Alimento alimento = new Alimento(nombreProducto, precio, cantidadDejada);

        Console.WriteLine("\nTotal de alimento necesario para " + dias + " días: " + totalNecesario + " kg");
        Console.WriteLine("Cantidad dejada: " + alimento.Cantidad + " kg");

        if (alimento.Cantidad >= totalNecesario)
        {
            Console.WriteLine("Hay suficiente alimento para el viaje.");
        }
        else
        {
            double faltante = totalNecesario - alimento.Cantidad;
            Console.WriteLine(" Faltan " + faltante + " kg de alimento para cubrir los días del viaje.");
        }
    }
}

