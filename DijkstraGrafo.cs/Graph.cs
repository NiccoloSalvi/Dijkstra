using System.Collections.Generic;
using System;

namespace DijkstraGrafo
{
    class Graph
    {
        private List<Nodo> listNodes; // lista di nodi
        private int[,] matrix; // matrice di adiacenza
        private int numNodes; // numero dei nodi

        public Graph(List<Nodo> l)
        {
            numNodes = l.Count;
            matrix = new int[numNodes, numNodes];
            listNodes = l;
        }

        public int[,] getMatrix() { return matrix; }

        // set delle adiacenze, per creazione della matrice di adiacenza
        public void setAdiacenza(Arch a)
        {
            int i = listNodes.IndexOf(a.getStartNode());
            int j = listNodes.IndexOf(a.getFinalNode());
            int w = a.getWeight();

            matrix[i, j] = w;
            matrix[j, i] = w;
        }

        // stampa della matrice in console
        public void PrintMatrix()
        {
            for (int r = 0; r < numNodes; r++)
            {
                for (int c = 0; c < numNodes; c++) 
                    Console.Write(matrix[r, c] + "  ");
                Console.WriteLine();
            }
        }
    }
}
