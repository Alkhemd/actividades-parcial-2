using System;

class Aguinaldo
{
    public string NombreEmpleado { get; set; }
    public double SalarioDiario { get; set; }
    public double MontoAguinaldo { get; set; }

    public Aguinaldo(string nombreEmpleado, double salarioDiario)
    {
        this.NombreEmpleado = nombreEmpleado;
        this.SalarioDiario = salarioDiario;
        this.MontoAguinaldo = salarioDiario * 15; // 15 días de aguinaldo
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el nombre del empleado:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese el salario diario del empleado:");
        double salarioDiario = Convert.ToDouble(Console.ReadLine());

        Aguinaldo empleado = new Aguinaldo(nombre, salarioDiario);

        Console.WriteLine("\nEl aguinaldo para " + empleado.NombreEmpleado + " es: $" + empleado.MontoAguinaldo);
    }
}

