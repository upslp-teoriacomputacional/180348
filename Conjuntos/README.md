# Programa realizado en un proyecto de C# en el editor de codigo mediante VSCode

  <li> Nombre: Gamaliel Israel Aguirre Bravo </li>
  <li> Matricula: 180348 </li>
  <li> universidad politecnica de San luis Potosi </li>
  <li> profesor: Juan Carlos Gonzales Ibarra </li>
  <li> Descripcion: un programa donde se utilizan los conjuntos y se hizo uso de la clase HashSet<>
      ademas se realizaron operaciones con conjuntos.</li>
    <br>
  <h3>¿Que se hizo para llegar a la solucion?</h3>

  <p> Fue necesario primeramente descargar un editor de texto el cual fuera compatible<br>
  con el lenguaje C#, se utilizo el editor Visual Studio Code el cual fue descargado<br> 
  desde el link https://code.visualstudio.com/download .<br>
  </p>
  <p> Fue necesario instalar las extenciones necesarias para el funcionamiento<br>
  Extensiones C# y C# Extensions. Aparte fue necesario descargar .net 5.0 Framework.
  </p><br>
  <p> La unica manera que encontre de trabajar fue creado un proyecto
  mediante el codigo ***dotnet new console***
  </p> 


## Codigo fuente

```C#
using System;
using System.Collections.Generic;

namespace prueba1
{
    class Program
    {
        
        // variables globales
        // definimos 3 conjuntos
        /*
        HashSet es una libreria la cual se usa 

        */
        HashSet<int> A = new HashSet<int> {1,2,3,4,5};
        HashSet<int> B = new HashSet<int> {3,4,5,6,7};
        HashSet<int> C = new HashSet<int> ();
        //pertenencia
        void pertenencia(){
        }
        //transformar
        void transformar(){
            Console.WriteLine("");
            int[] A= {1,2,3};
            HashSet<int> conjuntoA = new HashSet<int> (A);
            Console.Write("ConjuntoA: ");
            imprimir(conjuntoA);
            int[] B= {1,2,3,4};
            HashSet<int> conjuntoB = new HashSet<int> (B);
            Console.Write("ConjuntoB: ");
            imprimir(conjuntoB);
            String[] C= {"nuevo"};
            HashSet<string> conjuntoC =new HashSet<string> (C);
            Console.Write("ConjuntoB: ");
            foreach(var f in conjuntoC){
                Console.Write(f+" ");
            }
            Console.WriteLine("");
        }
        //quitar un elemento del conjunto
        void quitar(){
            HashSet<int> quitar = new HashSet<int> (A);
            quitar.Remove(2);
            Console.Write("Conjunto A despues de borrar: ");
            imprimir(quitar);
        }
        //metodo para limpiar a conjunto
        void limpiarConjunto(){
            HashSet<int> limpiar = new HashSet<int> (A);
            limpiar.Clear();
            Console.Write("Conjunto A despues de limpiar: ");
            imprimir(limpiar);
        }
        //metodo para agregar a conjunto
        void copiar(){
            HashSet<int> copiar =new HashSet<int> (A);
            imprimir(copiar);
        }
        //metodo para agregar a conjunto
        void agregar(){
            HashSet<int> agregar = new HashSet<int> (B);
            agregar.Add(987);
            Console.Write("El conjunto B despues de agregar un valor ");
            imprimir(agregar);
        }
        //operaciones con set
        //Union
        void union(){
            HashSet<int> unionC = new HashSet<int> (A);
            unionC.UnionWith(B);
            Console.Write("la union de A y B es : ");
            imprimir(unionC);
        }   
        //interseccion
        void interseccion(){
            HashSet<int> interseccionC = new HashSet<int> (A);
            interseccionC.IntersectWith(B);
            Console.Write("La interseccion entre A y B es: ");
            imprimir(interseccionC);
        }
        //diferencia
        void diferencia(){
            HashSet<int> diferenciaC = new HashSet<int> (A);
            diferenciaC.ExceptWith(B);
            Console.Write("La diferencia entre A y B es: ");
            imprimir(diferenciaC);
        }
        //metodo para diferencia simetrica
        void diferenciaSimetrica(){
            HashSet<int> diferenciaS = new HashSet<int> (A);
            diferenciaS.SymmetricExceptWith(B);
            Console.Write("La diferencia simetrica entre A y B es = ");
            imprimir(diferenciaS);
            HashSet<int> diferenciaS2 = new HashSet<int> (B); 
            diferenciaS2.SymmetricExceptWith(A);
            Console.Write("La diferencia simetrica entre B y A es = ");
            imprimir(diferenciaS2);
            HashSet<int> diferenciaS3 = new HashSet<int> (A);
            diferenciaS3.SymmetricExceptWith(C);
            Console.Write("La diferencia simetrica ebtre A y C es = ");
            imprimir(diferenciaS3);
            HashSet<int> diferenciaS4 = new HashSet<int> (B); 
            diferenciaS4.SymmetricExceptWith(C);
            Console.Write("La diferencia simetrica entre B y C es = ");
            imprimir(diferenciaS4);
        }
        //metodo de subconjunto
        void subConjunto(){
            Console.WriteLine("el sub conjunto es = {0}", A.IsSubsetOf(B));
            Console.WriteLine("el sub conjunto es = {0}", B.IsSubsetOf(A));
        }
        //metodo superconjunto
        void superConjunto(){
            Console.WriteLine("El superconjunto es = {0}", A.IsSubsetOf(B));
            Console.WriteLine("El superconjunto es = {0}", B.IsSubsetOf(A));
        }
        //metodo para poder imprimir de mejor manera el conjunto
        void imprimir(HashSet<int> collection){
            Console.Write("{");
            foreach (int i in collection)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine(" }");
        }
        static void Main(string[] args)
        {
            // debido a que es un lenguaje orientado a objetos 
            // se crea un objeto para poder ejecutar
            Program prueba =new Program();

            Console.Write("conjunto A es = ");
            prueba.imprimir(prueba.A);
            Console.Write("conjunto B es = ");
            prueba.imprimir(prueba.B);
            Console.Write("conjunto C es = ");
            prueba.imprimir(prueba.C);
            prueba.transformar(); 
            prueba.quitar();
            prueba.limpiarConjunto();
            prueba.copiar();
            prueba.agregar();
            prueba.union();
            prueba.interseccion();
            prueba.diferencia();
            prueba.diferenciaSimetrica();
            prueba.subConjunto();
            prueba.superConjunto();
        }
    }

    
}


```
#