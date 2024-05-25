using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemaPicasYFijas
{
    internal class Program
    {

        static void validarPintas(String numero, List<string> numerosQueNoCoinciden)
        {
            int picas = 0;
            numerosQueNoCoinciden = numerosQueNoCoinciden.Distinct().ToList();
            foreach (var posiblePica in numerosQueNoCoinciden)
            {
                if (numero.Contains(posiblePica))
                {
                    picas++;
                }
            }
            Console.WriteLine("Tienes " + picas + " picas");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*            JUEGO DE ADIVINAR NÚMERO               *");
            Console.WriteLine("*****************************************************");
            bool heGanado = false;
            int numeroSecreto = new Random().Next(1111, 9999);
            string numeroSecretoTexto = numeroSecreto.ToString();
            string numero;
            
            while (heGanado == false)
            {
                do
                {
                    Console.WriteLine("Escribe un número de 4 digitos");
                    numero = Console.ReadLine();
                } while (numero.Length < 4 || numero.Length > 4);
                
                
                
                // VALIDAR FIJAS
                // Caso que coincidan los 4 en el mismo orden
                if (numeroSecretoTexto[0].Equals(numero[0]) &&
                    numeroSecretoTexto[1].Equals(numero[1]) &&
                    numeroSecretoTexto[2].Equals(numero[2]) &&
                    numeroSecretoTexto[3].Equals(numero[3]))
                {
                    Console.WriteLine("Tienes 4 fijas");
                    heGanado = true;
                }
                else if(
                    numeroSecretoTexto[0].Equals(numero[0]) &&
                    !numeroSecretoTexto[1].Equals(numero[1]) &&
                    !numeroSecretoTexto[2].Equals(numero[2]) &&
                    !numeroSecretoTexto[3].Equals(numero[3]))
                {
                    Console.WriteLine("Tienes 1 fija");
                    List<string> numerosQueNoCoinciden = new List<string>();
                    numerosQueNoCoinciden.Add(numero[1].ToString());
                    numerosQueNoCoinciden.Add(numero[2].ToString());
                    numerosQueNoCoinciden.Add(numero[3].ToString());
                    validarPintas(numeroSecretoTexto, numerosQueNoCoinciden);
                }
                else if(
                    !numeroSecretoTexto[0].Equals(numero[0]) &&
                    numeroSecretoTexto[1].Equals(numero[1]) &&
                    !numeroSecretoTexto[2].Equals(numero[2]) &&
                    !numeroSecretoTexto[3].Equals(numero[3]))
                {
                    Console.WriteLine("Tienes 1 fija");
                    List<string> numerosQueNoCoinciden = new List<string>();
                    numerosQueNoCoinciden.Add(numero[0].ToString());
                    numerosQueNoCoinciden.Add(numero[2].ToString());
                    numerosQueNoCoinciden.Add(numero[3].ToString());
                    validarPintas(numeroSecretoTexto, numerosQueNoCoinciden);
                }
                else if(
                    !numeroSecretoTexto[0].Equals(numero[0]) &&
                    !numeroSecretoTexto[1].Equals(numero[1]) &&
                    numeroSecretoTexto[2].Equals(numero[2]) &&
                    !numeroSecretoTexto[3].Equals(numero[3]))
                {
                    Console.WriteLine("Tienes 1 fija");
                    List<string> numerosQueNoCoinciden = new List<string>();
                    numerosQueNoCoinciden.Add(numero[0].ToString());
                    numerosQueNoCoinciden.Add(numero[1].ToString());
                    numerosQueNoCoinciden.Add(numero[3].ToString());
                    validarPintas(numeroSecretoTexto, numerosQueNoCoinciden);
                }
                else if(
                    !numeroSecretoTexto[0].Equals(numero[0]) &&
                    !numeroSecretoTexto[1].Equals(numero[1]) &&
                    !numeroSecretoTexto[2].Equals(numero[2]) &&
                    numeroSecretoTexto[3].Equals(numero[3]))
                {
                    Console.WriteLine("Tienes 1 fija");
                    List<string> numerosQueNoCoinciden = new List<string>();
                    numerosQueNoCoinciden.Add(numero[0].ToString());
                    numerosQueNoCoinciden.Add(numero[1].ToString());
                    numerosQueNoCoinciden.Add(numero[2].ToString());
                    validarPintas(numeroSecretoTexto, numerosQueNoCoinciden);
                }
                else if(
                    numeroSecretoTexto[0].Equals(numero[0]) &&
                    numeroSecretoTexto[1].Equals(numero[1]) &&
                    !numeroSecretoTexto[2].Equals(numero[2]) &&
                    !numeroSecretoTexto[3].Equals(numero[3]))
                {
                    Console.WriteLine("Tienes 2 fijas");
                    List<string> numerosQueNoCoinciden = new List<string>();
                    numerosQueNoCoinciden.Add(numero[2].ToString());
                    numerosQueNoCoinciden.Add(numero[3].ToString());
                    validarPintas(numeroSecretoTexto, numerosQueNoCoinciden);
                }
                else if(
                    !numeroSecretoTexto[0].Equals(numero[0]) &&
                    !numeroSecretoTexto[1].Equals(numero[1]) &&
                    numeroSecretoTexto[2].Equals(numero[2]) &&
                    numeroSecretoTexto[3].Equals(numero[3]))
                {
                    Console.WriteLine("Tienes 2 fijas");
                    List<string> numerosQueNoCoinciden = new List<string>();
                    numerosQueNoCoinciden.Add(numero[0].ToString());
                    numerosQueNoCoinciden.Add(numero[1].ToString());
                    validarPintas(numeroSecretoTexto, numerosQueNoCoinciden);
                }
                else if(
                    !numeroSecretoTexto[0].Equals(numero[0]) &&
                    numeroSecretoTexto[1].Equals(numero[1]) &&
                    !numeroSecretoTexto[2].Equals(numero[2]) &&
                    numeroSecretoTexto[3].Equals(numero[3]))
                {
                    Console.WriteLine("Tienes 2 fijas");
                    List<string> numerosQueNoCoinciden = new List<string>();
                    numerosQueNoCoinciden.Add(numero[0].ToString());
                    numerosQueNoCoinciden.Add(numero[2].ToString());
                    validarPintas(numeroSecretoTexto, numerosQueNoCoinciden);
                }
                else if(
                    numeroSecretoTexto[0].Equals(numero[0]) &&
                    !numeroSecretoTexto[1].Equals(numero[1]) &&
                    !numeroSecretoTexto[2].Equals(numero[2]) &&
                    numeroSecretoTexto[3].Equals(numero[3]))
                {
                    Console.WriteLine("Tienes 2 fijas");
                    List<string> numerosQueNoCoinciden = new List<string>();
                    numerosQueNoCoinciden.Add(numero[1].ToString());
                    numerosQueNoCoinciden.Add(numero[2].ToString());
                    validarPintas(numeroSecretoTexto, numerosQueNoCoinciden);
                }
                else if(
                    !numeroSecretoTexto[0].Equals(numero[0]) &&
                    numeroSecretoTexto[1].Equals(numero[1]) &&
                    numeroSecretoTexto[2].Equals(numero[2]) &&
                    !numeroSecretoTexto[3].Equals(numero[3]))
                {
                    Console.WriteLine("Tienes 2 fijas");
                    List<string> numerosQueNoCoinciden = new List<string>();
                    numerosQueNoCoinciden.Add(numero[0].ToString());
                    numerosQueNoCoinciden.Add(numero[3].ToString());
                    validarPintas(numeroSecretoTexto, numerosQueNoCoinciden);
                }
                else if(
                    numeroSecretoTexto[0].Equals(numero[0]) &&
                    numeroSecretoTexto[1].Equals(numero[1]) &&
                    numeroSecretoTexto[2].Equals(numero[2]) &&
                    !numeroSecretoTexto[3].Equals(numero[3]))
                {
                    Console.WriteLine("Tienes 3 fijas");
                    List<string> numerosQueNoCoinciden = new List<string>();
                    numerosQueNoCoinciden.Add(numero[3].ToString());
                    validarPintas(numeroSecretoTexto, numerosQueNoCoinciden);
                }
               
                else if(
                    !numeroSecretoTexto[0].Equals(numero[0]) &&
                    numeroSecretoTexto[1].Equals(numero[1]) &&
                    numeroSecretoTexto[2].Equals(numero[2]) &&
                    numeroSecretoTexto[3].Equals(numero[3]))
                {
                    Console.WriteLine("Tienes 3 fijas");
                    List<string> numerosQueNoCoinciden = new List<string>();
                    numerosQueNoCoinciden.Add(numero[0].ToString());
                    validarPintas(numeroSecretoTexto, numerosQueNoCoinciden);
                }
                else if(
                    numeroSecretoTexto[0].Equals(numero[0]) &&
                    !numeroSecretoTexto[1].Equals(numero[1]) &&
                    numeroSecretoTexto[2].Equals(numero[2]) &&
                    numeroSecretoTexto[3].Equals(numero[3]))
                {
                    Console.WriteLine("Tienes 3 fijas");
                    List<string> numerosQueNoCoinciden = new List<string>();
                    numerosQueNoCoinciden.Add(numero[1].ToString());
                    validarPintas(numeroSecretoTexto, numerosQueNoCoinciden);
                }
                else if(
                    numeroSecretoTexto[0].Equals(numero[0]) &&
                    numeroSecretoTexto[1].Equals(numero[1]) &&
                    !numeroSecretoTexto[2].Equals(numero[2]) &&
                    numeroSecretoTexto[3].Equals(numero[3]))
                {
                    Console.WriteLine("Tienes 3 fijas");
                    List<string> numerosQueNoCoinciden = new List<string>();
                    numerosQueNoCoinciden.Add(numero[2].ToString());
                    validarPintas(numeroSecretoTexto, numerosQueNoCoinciden);
                }
                else
                {
                    Console.WriteLine("Intenta con otro número");
                }
            }
            Console.WriteLine("¡¡FELICIDADES HAS GANADO!!");
        }
    }
}