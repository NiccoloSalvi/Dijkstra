using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace DijkstraGrafo
{
    class Arch
    {
        private Nodo StartNode; // nodo di inizio
        private Nodo FinalNode; // nodo di fine
        private int Weight; // peso del nodo

        public Arch(Nodo Start, Nodo Final, int W)
        {
            StartNode = Start;
            FinalNode = Final;
            Weight = W;
        }

        public Nodo getStartNode() { return StartNode; }
        public Nodo getFinalNode() { return FinalNode; }
        public int getWeight() { return Weight; }

        public override string ToString()
        {
            return StartNode.getName() + " -> " + FinalNode.getName() + " " + Weight;
        }

        public void Draw(Point p1, Point p2, Bitmap DrawArea, PictureBox pb)
        {
            Graphics g = Graphics.FromImage(DrawArea);
            Pen p = new Pen(Color.Black, 3);
            AdjustableArrowCap arrow = new AdjustableArrowCap(5, 5);

            p.CustomStartCap = arrow; // disegno della freccia
            p.CustomEndCap = arrow;
            g.DrawLine(p, p2.X + 25, p2.Y + 25, p1.X + 25, p1.Y + 25);

            g.Dispose();
            pb.Image = DrawArea;
        }

        public Point trovaIntersezioni(Point c, float raggio, Point point1, Point point2, string sod)
        {
            float cx = c.X;
            float cy = c.Y;
            float dx, dy, A, B, C, det, t;

            Point ret;
            dx = point2.X - point1.X;
            dy = point2.Y - point1.Y;

            A = dx * dx + dy * dy;
            B = 2 * (dx * (point1.X - cx) + dy * (point1.Y - cy));
            C = (point1.X - cx) * (point1.X - cx) + (point1.Y - cy) * (point1.Y - cy) - raggio * raggio;

            det = B * B - 4 * A * C;
            if ((A <= 0.0000001) || (det < 0))
                ret = new Point(0, 0);
            else if (det == 0)
            {
                t = -B / (2 * A);
                ret = new Point(Convert.ToInt32(point1.X + t * dx), Convert.ToInt32(point1.Y + t * dy));
            }
            else
            {
                if (sod != "sor")
                    t = (float)((-B - Math.Sqrt(det)) / (2 * A));
                else
                    t = (float)((-B + Math.Sqrt(det)) / (2 * A));
                ret = new Point(Convert.ToInt32(point1.X + t * dx), Convert.ToInt32(point1.Y + t * dy));
            }
            return ret;
        }

        // ritorna il punto medio, dati 2 punti
        public Point Midle(Point p1, Point p2)
        {
            Point p3 = new Point();
            p3.X = (p1.X + 25 + p2.X + 25) / 2;
            p3.Y = (p1.Y + 25 + p2.Y + 25) / 2;
            return p3;
        }

        public void Colora(Color c, Point p1, Point p2, Bitmap DrawArea, PictureBox pb)
        {
            Graphics g = Graphics.FromImage(DrawArea);
            Pen p = new Pen(c, 3); // cambio colore della penna
            AdjustableArrowCap arrow = new AdjustableArrowCap(5, 5);

            p.CustomStartCap = arrow;
            p.CustomEndCap = arrow;
            g.DrawLine(p, p2.X + 25, p2.Y + 25, p1.X + 25, p1.Y + 25);

            g.Dispose();
            pb.Image = DrawArea;
        }
    }
}
