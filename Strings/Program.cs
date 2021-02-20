/*
Nombre: Gamaliel israel Aguirre Bravo
Matricula: 180348
universidad politecnica de San luis Potosi
profesor: Juan Carlos Gonzales Ibarra
Descripcion: programa en que se se usa la libreria *.RegularExpressions
y se valida la entrada de datos.
*/
using System;
using System.Text.RegularExpressions;
namespace Strings
{
    class Program
    {
        //funcion estatica que recible la entrada de la cadena por consola
        static void especial(string entrada){
            Regex rg = new Regex("^[0-9a-z]+");  //se crea el objeto en el cual se le indica que solo acepta digitos 0-9 y minusculas
            if(rg.Match(entrada).Success) Console.Write("Salida: True");// se valida la entrada
            else Console.Write("Salida: False");//si la entrada no cumple la condicion returna falso
        }
        static void Main(string[] args)
        {
            Console.Write("Entrada: ");
            string entrada = Console.ReadLine();//entrada de datos por consola
            especial(entrada);
        }
    }
}
