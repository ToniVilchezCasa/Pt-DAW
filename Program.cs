﻿using System;
using Models;  // Importa la classe Vehicle des de Models

class Program
{
    static void Main(string[] args)
    {
<<<<<<< Updated upstream
        // Crear un objecte Vehicle
        Cotxe cotxe1 = new Cotxe("Cooper", "Mini", 2020, 220.0, 5);

        // Mostrar la informació del vehicle
        cotxe1.MostrarInformacio();

        // Crear un altre objecte Vehicle
        Cotxe cotxe2 = new Cotxe("A3", "Audi", 2006, 210.0, 3);
        
        // Mostrar la informació del segon vehicle
        cotxe2.MostrarInformacio();
=======
         // Crear llistes per a cada tipus de vehicle
        List<Vaixell> vaixells = new List<Vaixell>
        {
            new Vaixell("Explorer", "OceanX", 2015, 45, 12000),
            new Vaixell("Voyager", "BlueWave", 2020, 60, 15000)
        };

        List<Cotxe> cotxes = new List<Cotxe>
        {
            new Cotxe("Model S", "Tesla", 2022, 250, 4),
            new Cotxe("Civic", "Honda", 2019, 220, 4)
        };

        List<Camio> camions = new List<Camio>
        {
            new Camio("Actros", "Mercedes", 2021, 120, 18000),
            new Camio("FH16", "Volvo", 2018, 110, 25000)
        };

        // Mostrar informació de cada tipus de vehicle
        Console.WriteLine("Llista de Vaixells:");
        foreach (var vaixell in vaixells)
        {
            vaixell.MostrarInformacio();
        }

        Console.WriteLine("\nLlista de Cotxes:");
        foreach (var cotxe in cotxes)
        {
            cotxe.MostrarInformacio();
        }

        Console.WriteLine("\nLlista de Camions:");
        foreach (var camio in camions)
        {
            camio.MostrarInformacio();
        }
>>>>>>> Stashed changes
    }
}
