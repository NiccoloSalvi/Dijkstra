namespace DijkstraGrafo
{
    class Line
    {
        private double M; // m della retta
        private double Q; // q della retta
        
        public Line(double m, double q)
        {
            M = m;
            Q = q;
        }

        public Line(double m)
        {
            M = m;
        }

        public double getM() { return M; }
        public double getQ() { return Q; }
    }
}
