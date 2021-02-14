/*
Nombre: Gamaliel israel Aguirre Bravo
Matricula: 180348
universidad politecnica de San luis Potosi
profesor: Juan Carlos Gonzales Ibarra
Descripcion: programa de grafos y imprime la matriz adyacente
*/

using System;
using System.Collections.Generic;
namespace graphs{
    //clase principal
    class Program
    {
        //metodo el cual recibe la lista linkeada como array list en entero ademas de los char
        static void addEdge(LinkedList<int>[] adj, char a, char b) { 
            int u = Convert.ToInt32(a)-97;//se realiza la conversion de char a decimal(ascii) y se le restan 97
            int v = Convert.ToInt32(b)-97;//ya que el abecedario en ascii inicia en 97 
            addEdgeFinal(adj,u,v);//mandamos a llamar la funcion que realiza el linkeo
        } 
        //funcion para agregar los bordes al grafo
        static void addEdgeFinal(LinkedList<int>[] adj, int u, int v) { 
            adj[u].AddLast(v); 
            //adj[v].AddLast(u); 
        } 
        //metodo estatico la cual hace la impresion de la adyacencia
        static void printGraph( LinkedList<int>[]  adj) {
            //recorre mi lista linkeada
            for (int i = 0; i < adj.Length; i++) 
            { 
                Console.WriteLine("\nLista de adyacencia de vértice " + Convert.ToChar(i+97));//realiza convercion de entero a char(ascii) 
                Console.Write("Cabeza "); 
                
                foreach (var item in adj[i]) 
                {  
                    
                    Console.Write(" -> " + Convert.ToChar(item+97)); //realiza convercion de entero a char(ascii)
                } 
                Console.WriteLine(); 
            } 
        } 
        //metodo main
        static void Main(string[] args)
        {
            int V = 5; //este incida el numero de vertices que abra en nuestro grafo
            LinkedList<int>[] graph = new LinkedList<int>[V]; 

            for (int i = 0; i < V; i++) 
                graph[i] = new LinkedList<int>(); 
    
            // añadimos los bordes al grafo 
            addEdge(graph,'a','c') ;
            addEdge(graph,'b','c') ;
            addEdge(graph,'b','e') ;
            addEdge(graph,'c','d') ;
            addEdge(graph,'c','e') ;
            addEdge(graph,'c','a') ;
            addEdge(graph,'c','b') ;
            addEdge(graph,'e','b') ;
            addEdge(graph,'d','c') ;
            addEdge(graph,'e','c') ;
            //llamado del metodo de impresion
            printGraph(graph); 
            Console.ReadKey(); 
        }
    }
}
