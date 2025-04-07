using System;
using System.Text.Json;
using System.IO;

class Producto
{
    public string nombre { get; set; }
    public double precio { get; set; }
    public double cantidad { get; set; }
    public double cambio { get; set; }

    public Producto(string nombre, double precio, double cantidad, double cambio)
    {
        this.nombre = nombre;
        this.precio = precio;
        this.cantidad = cantidad;
        this.cambio = cambio;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escriba el nombre del producto:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Digite el precio del producto:");
        double precio = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite la cantidad que dio el cliente (dinero recibido):");
        double cantidad = Convert.ToDouble(Console.ReadLine());

        double cambio = cantidad - precio;

        
        Producto p = new Producto(nombre, precio, cantidad, cambio);

        Console.WriteLine("Su cambio es: " + cambio);

        string archivo = "producto.json";
        string json = JsonSerializer.Serialize(p, new JsonSerializerOptions {  WriteIndented = true});
        File.WriteAllText(archivo, json);
        Console.WriteLine("el producto se guardo en el archivo" + archivo);
    }
}
