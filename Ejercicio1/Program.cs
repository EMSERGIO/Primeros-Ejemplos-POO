using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Agregar CONSTRUCTOR que reciba Modelo y Marca.
            //Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en pantalla
            //el estado del Telefono.
            //Agregar método Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
            //Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva un string 
            //con la leyenda "Llamando a " + contacto
            //Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.

            Telefono t1 = new Telefono("MotoG", "Motorola");
            string marca = t1.Marca;
            string modelo = t1.Modelo;
            Console.WriteLine("Tu Telefono es un: " + marca + " y su modelo es: " + modelo);

            Console.WriteLine("Escriba el Codigo del Operador: ");
            t1.CodigoOperador = int.Parse(Console.ReadLine());



            t1.Llamar();
            Console.WriteLine("Estado:" + t1.Llamar());
            
            t1.Llamar();
            Console.WriteLine("Estado:" + t1.Llamar("2804709908"));



            Console.ReadKey();

        }
    }
}
