using System;

class Nombre
{
    public string nombre { get; set; }
    public string nombre2 { get; set; }
    public string apellido { get; set; }
    public string apellido2 { get; set; }

    public Nombre(string nombre, string nombre2, string apellido, string apellido2)
    {
        this.nombre = nombre;
        this.nombre2 = nombre2;
        this.apellido = apellido;
        this.apellido2 = apellido2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escriba su primer nombre:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Escriba su segundo nombre:");
        string nombre2 = Console.ReadLine();

        Console.WriteLine("Escriba su primer apellido:");
        string apellido = Console.ReadLine();

        Console.WriteLine("Escriba su segundo apellido:");
        string apellido2 = Console.ReadLine();

        Nombre persona = new Nombre(nombre, nombre2, apellido, apellido2);

        // Mostrar nombre completo (nombres primero)
        Console.WriteLine("\nNombre completo (nombres primero): " +
            persona.nombre + " " + persona.nombre2 + " " + persona.apellido + " " + persona.apellido2);

        // Mostrar nombre completo (apellidos primero)
        Console.WriteLine("Nombre completo (apellidos primero): " +
            persona.apellido + " " + persona.apellido2 + " " + persona.nombre + " " + persona.nombre2);
    }
}
