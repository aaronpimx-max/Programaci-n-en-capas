# Codigo-Sistema-de-Gesti-n-de-Creditos
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    internal class Program
    {
        static void SumarCredito(ref decimal saldoActual, decimal MontoAsumar)
        {
            saldoActual += MontoAsumar;
        }
        static void MostrarInformacion(string nombre, decimal saldocredito)
        { 

            Console.WriteLine($"Cliente:{nombre}, Saldo Actual:{saldocredito:C}");

        }
        static void Main(string[] args)
        {
            int idcliente;
            string nombre;
            decimal saldocredito = 0m;

            Console.WriteLine("Gestion de Creditos");

            idcliente = 101;
            nombre = "";

            nombre = "Cliente Registrado";
            SumarCredito(ref saldocredito, 500m);
            MostrarInformacion(nombre, saldocredito);

        }
    }
}
