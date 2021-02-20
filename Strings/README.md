# Programa String realizado en un proyecto de C# en el editor de codigo mediante VSCode

  <li> Nombre: Gamaliel Israel Aguirre Bravo </li>
  <li> Matricula: 180348 </li>
  <li> universidad politecnica de San luis Potosi </li>
  <li> profesor: Juan Carlos Gonzales Ibarra </li>
  <li> Descripcion: programa en que se se usa la libreria *RegularExpressions
y se valida la entrada de datos.</li>
    <br>
  <p>Para poder resolver este problema primero se busco la libreria de C# llamada *.RegularExpressions
  posteriormente se investigaron que metodos se utilizaban para validar la entrada y se encontraron
  gran variedad y al final se utilizo el metodo .match() el cual al ser llamado solo recibe la cadena y este
  utilizando un if podriamos validar si es falso o verdadero que la entrada de texto tiene minusculas de
  {a-z} y numeros {0-9}.</p>
  # Codigo fuente

```C#
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

```
#