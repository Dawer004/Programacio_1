using System;
using System.Collections.Generic;

class Autobus
{
    public string Modelo { get; set; }
    public int CapacidadPasajeros { get; set; }
    public double PrecioPorKilometro { get; set; }
    public int AsientosDisponibles { get; set; }
    public int PasajerosVendidos { get; set; }

    public Autobus(string modelo, int capacidadPasajeros, double precioPorKilometro)
    {
        Modelo = modelo;
        CapacidadPasajeros = capacidadPasajeros;
        PrecioPorKilometro = precioPorKilometro;
        AsientosDisponibles = capacidadPasajeros;
        PasajerosVendidos = 0;
    }

    public double CalcularTarifa(double distancia)
    {
        return PrecioPorKilometro * distancia;
    }

    public void VenderPasajes(int cantidadPasajes)
    {
        PasajerosVendidos += cantidadPasajes;
        AsientosDisponibles -= cantidadPasajes;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Autobus {Modelo} {PasajerosVendidos} Pasajeros Ventas {CalcularTarifa(1):C} quedan {AsientosDisponibles} asientos disponibles");
    }
}

class Program
{
    static void Main()
    {
        Autobus autobusPlatinum = new Autobus("Platinum", 22, 5000);
        Autobus autobusGold = new Autobus("Gold", 15, 4000);

        Console.WriteLine($"Bienvenido al Autobus {autobusPlatinum.Modelo}");
        Console.Write("Ingrese la distancia recorrida en kilómetros: ");
        double distanciaPlatinum = double.Parse(Console.ReadLine());
        autobusPlatinum.VenderPasajes(5);
        autobusPlatinum.MostrarInformacion();

        Console.WriteLine($"Bienvenido al Autobus {autobusGold.Modelo}");
        Console.Write("Ingrese la distancia recorrida en kilómetros: ");
        double distanciaGold = double.Parse(Console.ReadLine());
        autobusGold.VenderPasajes(3);
        autobusGold.MostrarInformacion();
    }
}
