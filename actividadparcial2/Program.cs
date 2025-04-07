using System;

class CuentaBancaria
{
    public string NombreTitular { get; set; }
    public double Saldo { get; set; }

    public CuentaBancaria(string nombreTitular, double saldo)
    {
        this.NombreTitular = nombreTitular;
        this.Saldo = saldo;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Titular: " + NombreTitular + " | Saldo: $" + Saldo);
    }
}

class Banco
{
    private CuentaBancaria[] cuentas;
    private int cantidadCuentas;

    public Banco(int capacidad)
    {
        cuentas = new CuentaBancaria[capacidad];
        cantidadCuentas = 0;
    }

    public void AgregarCuenta(CuentaBancaria cuenta)
    {
        if (cantidadCuentas < cuentas.Length)
        {
            cuentas[cantidadCuentas] = cuenta;
            cantidadCuentas++;
        }
        else
        {
            Console.WriteLine("No se pueden agregar más cuentas.");
        }
    }

    public void MostrarCuentas()
    {
        for (int i = 0; i < cantidadCuentas; i++)
        {
            cuentas[i].MostrarInformacion();
        }
    }

    public double CalcularSaldoTotalRecursivo(int indice = 0)
    {
        if (indice >= cantidadCuentas)
        {
            return 0;
        }
        return cuentas[indice].Saldo + CalcularSaldoTotalRecursivo(indice + 1);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Banco banco = new Banco(5); // hasta 5 cuentas

        // Agregar cuentas
        banco.AgregarCuenta(new CuentaBancaria("Juan", 1500));
        banco.AgregarCuenta(new CuentaBancaria("María", 2300));
        banco.AgregarCuenta(new CuentaBancaria("Luis", 1800));

        // Mostrar información de todas las cuentas
        Console.WriteLine("Información de cuentas:");
        banco.MostrarCuentas();

        // Calcular y mostrar el saldo total de forma recursiva
        double saldoTotal = banco.CalcularSaldoTotalRecursivo();
        Console.WriteLine("Saldo total del banco: $" + saldoTotal);
    }
}
