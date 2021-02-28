# Programa String y sus metodos realizado en un proyecto de C# en el editor de codigo mediante VSCode

  <li> Nombre: Gamaliel Israel Aguirre Bravo </li>
  <li> Matricula: 180348 </li>
  <li> universidad politecnica de San luis Potosi </li>
  <li> profesor: Juan Carlos Gonzales Ibarra </li>
  <li> Descripcion: el programa se usa las clases *.Globalization y 
  se usan los metodos de la clase string</li>
    <br>
  <p>Para la realizacion de esta practica echa en C# fue necesario realizar una busqueda de los string y como
  estos funcionan en le lenguaje de C#. En la practica se usa la palabra reservada 'var' el cual detecta 
  automaticamente el tipo de variable que almacena en este caso es string y entero. en este caso a diferencia con 
  phyton hubo que programar un ciclo para contar la cantidad de letras iguales a 'a' ya que C# no cuenta
  con un metodo para realizar esto</p>
  # Codigo fuente

```C#
/*
Nombre: Gamaliel israel Aguirre Bravo
Matricula: 180348
universidad politecnica de San luis Potosi
profesor: Juan Carlos Gonzales Ibarra
Descripcion: programa el cual se utilizan los metodos de la Clase 
String de C#
*/
using System;
using System.Globalization;//usada para la conversion del primera letra en mayuscula
namespace lenguajes
{
    class Program
    {
        static void Main(string[] args)
        {
            var msg1 = "Hola en C#";
            Console.WriteLine(msg1);//imprime mensaje entre comillas;
            var msg2 = "Hola en C#";
            Console.WriteLine(msg2[8]);//imprime el caracter de la posicion indicada empezando en 0
            //text           = cadenas C#
            //index positivo = 0123456789 //el index comienza en 0 y no existe index negativo
            var msg3 = "cadenas C#";
            Console.WriteLine(msg3[9]);//imprime la procicion 9 empezando en 0
            var msg4 = "Hello, C#";
            Console.WriteLine(msg4.Substring(3,4));//imprime desde la pocicion 3 una longitud de 4 caracteres .Substring(startIndex,length)
            var msg5 = "  Welcome C#.  ";
            Console.WriteLine(msg5.Trim());// #.Trim() quita todos los espacios de principio y fin de la cadena actual
            var msg6 = "Welcome C#!!";
            Console.WriteLine(msg6.ToLower());//imprime todo en minusculas
            Console.WriteLine(msg6.ToUpper());//imprime todo en mayusculas
            Console.WriteLine(msg6.Length);//imprime la longitud de la cadena
            
            var msg7 = "Bienvenido a C#";
            Console.WriteLine(msg7.Replace("Bienvenido","Aprendiendo"));//imprime remplazando Bienvenido por aprendiendo
            var msg8 = "Bienvenido, a, lenguaje, C#";
            string[] palabras = msg8.Split(',');//guardamos en un arreglo los valores separados por ','
            foreach (var word in palabras) //imprime por medio de un for each
                Console.Write($"<{word}>");
            Console.WriteLine("");
            var msg9= "bienvenido a lenguaje c#";
            Console.WriteLine(CultureInfo.InvariantCulture.TextInfo.ToTitleCase(msg9));//imprime la primera letra de cada palabra en mayuscula    
            var msg10= "trabajando con C#";
            var contador = 0;//contador de caracteres
            for(var i=0; i<msg10.Length; i++){//for para recorrer lada indice de la cadena
                if(msg10[i].Equals('a')){//compara si la posicion es igual al char indicado
                    contador++;
                }
            }
            Console.WriteLine("Cantidad de 'a' es: {0}",contador);//imprime la cantidad de a en la oracion
            
            var msg11 = "Trabajando con C#";
            Console.WriteLine("la posicion donde esta con es: {0}",msg11.IndexOf("con"));//imprime el index donde se ubica la cadena 'con' 
            
            var uno_string= "programando en";
            var dos_string= "C#";
            Console.WriteLine(uno_string +" "+ dos_string);//imprime 2 cadenas separadas con espacio

            var uno_string1 = "programa";
            var dos_string1 = "echo en";
            var tres_string1 = "C#";
            Console.WriteLine(uno_string1+" "+dos_string1+" "+tres_string1);//imprime 3 cadenas separadas con espacio
            
            var uno_string2 = "programa";
            var dos_string2 = 4;
            var tres_string2 = "echo en C#";
            Console.WriteLine(uno_string2+" "+dos_string2.ToString()+" "+tres_string2);//imprime 2 cadenas y un entero impreso en forma de string
        }
    }
}


```
