using System.Collections.Generic;

namespace DijkstraGrafo
{
    class Dijkstra
    {
        private static readonly int NO_PARENT = -1;
 
        public List<int>[] calculate(int[,] adjacencyMatrix, int startVertex)
        {
            int nVertices = adjacencyMatrix.GetLength(0); // numero dei vertici
            int[] shortestDistances = new int[nVertices]; // vettore che indica le minime distanze per ogni nodo dalla sorgente
            bool[] added = new bool[nVertices]; // vettore che indica se un nodo è stato processato

            // come prima iterazione
            for (int vertexIndex = 0; vertexIndex < nVertices; vertexIndex++)
            {
                shortestDistances[vertexIndex] = int.MaxValue; // distanza tra i nodi e la sorgente è +inf
                added[vertexIndex] = false; // inizializzato vettore dei nodi processati
            }
            shortestDistances[startVertex] = 0; // la distanza minima tra la sorgente e sè stessa è sempre 0

            int[] parents = new int[nVertices]; // vettore dei nodi genitori di un nodo 
            parents[startVertex] = NO_PARENT; // la sorgente non presenta genitori
            // trovato il percorso minimo dalla sorgente a tutti gli altri nodi
            for (int i = 1; i < nVertices; i++)
            {
                // dal vettore dei vertici non ancora processati
                // viene preso il vertice con la distanza minima dalla sorgente.
                int nearestVertex = -1;
                int shortestDistance = int.MaxValue;
                for (int vertexIndex = 0; vertexIndex < nVertices; vertexIndex++)
                {
                    if (!added[vertexIndex] && shortestDistances[vertexIndex] < shortestDistance)
                    {
                        nearestVertex = vertexIndex;
                        shortestDistance = shortestDistances[vertexIndex];
                    }
                }

                added[nearestVertex] = true; // aggiunto il nodo al vettore di quelli processati
                // confronto della distanza con il valore presente nella matrice di adiacenza
                for (int vertexIndex = 0; vertexIndex < nVertices; vertexIndex++)
                {
                    int edgeDistance = adjacencyMatrix[nearestVertex, vertexIndex];
                    if (edgeDistance > 0 && ((shortestDistance + edgeDistance) < shortestDistances[vertexIndex]))
                    {
                        parents[vertexIndex] = nearestVertex; // aggiunto il nodo al vettore dei nodi precedenti
                        shortestDistances[vertexIndex] = shortestDistance + edgeDistance;
                    }
                }
            }
            return printSolution(startVertex, shortestDistances, parents);
        }

        private List<int>[] printSolution(int startVertex, int[] distances, int[] parents)
        {
            int nVertices = distances.Length; // numero di vertici

            List<int>[] t = new List<int>[nVertices];
            for (int a = 0; a < nVertices; a++)
                t[a] = new List<int>();

            int i = 0;
            for (int vertexIndex = 0; vertexIndex < nVertices; vertexIndex++)
            {
                if (vertexIndex != startVertex) // se il nodo non corrisponde alla sorgente
                    printPath(t[i], vertexIndex, parents);
                else
                    t[i] = null;
                i++;
            }
            return t;
        }

        private void printPath(List<int> t, int currentVertex, int[] parents)
        {
            if (currentVertex == NO_PARENT) // si torna indietro fino alla sorgente
                return;
            printPath(t, parents[currentVertex], parents);
            t.Add(currentVertex); // aggiunto il nodo alla lista dei nodi che formano il percorso
        }
    }
}
