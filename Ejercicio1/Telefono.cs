using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Telefono
    {
        //Agregale los siguientes ATRIBUTOS:
        //Modelo string.
        //Marca string.
        //NumeroTelefonico string.
        //CodigoOperador int (1, 2 o 3).

        private string modelo;
        private string marca;
        private string numeroTelefono;
        private int codigoOperador;

        //Agregale las PROPIEDADES correspondientes.Podés hacer el formato largo o el corto:
        //Modelo: solo lectura. Es decir, solo get.
        //Marca: solo lectura.
        //NumeroTelefonico: lectura y escritura.
        //CodigoOperador: lectura y escritura.Validar escritura que solo admita 1, 2 o 3,
        //caso contrario escribir un cero.

        public string Modelo
        {
            get { return modelo; }
        }
        public string Marca 
        {
            get { return marca; } 
        }
        public string NumeroTelefono
        {
            get { return numeroTelefono; }
            set { numeroTelefono = value; }
        }
        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if (value > 0 && value < 4){

                    codigoOperador = value;
                    Console.WriteLine("CODIGO CORRECTO");
                }
                else
                {
                    codigoOperador = 0;
                    Console.WriteLine("CODIGO INCORRECTO");
                }
            }
        }
        //Agregar CONSTRUCTOR que reciba Modelo y Marca.

        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }

        //Agregar METODO Llamar() sin parámetros que devuelva un string con la leyenda "Realizando llamada...".
        public string Llamar()
        {
            return "Realizando llamada...";
        }

        //SOBRECARGA DE METODO Llamar(string contacto) para que reciba un contacto y devuelva un string 
        //con la leyenda "Llamando a " + contacto
        public string Llamar(string contacto)
        {
            return "Llamando a " + contacto;
        }

    }
}
