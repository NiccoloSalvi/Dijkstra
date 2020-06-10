using System.Windows.Forms;
using System.Drawing;

namespace DijkstraGrafo
{
    public class Nodo
    {
        private Point Position; // posizione del nodo
        private string Name; // nome del nodo
        private int Radius = 50; // raggio del cerchio
        
        public Nodo(Point pos, string n)
        {
            Position = pos;
            Name = n;
        }

        public string getName() { return Name; }
        public Point getPosition() { return Position; }

        public override string ToString() { return Name + ": " + Position.ToString(); }

        public void Draw(Bitmap drawArea, PictureBox pb)
        {
            Graphics g = Graphics.FromImage(drawArea);
            Pen p = new Pen(Color.Black, 3);
            SolidBrush b = new SolidBrush(Color.Red);

            g.DrawEllipse(p, Position.X, Position.Y, Radius, Radius); // disegno del cercio
            // scrittura del nome all'interno del cerchio
            g.DrawString(Name, new Font(new FontFamily("Arial"), 12 * Radius / 25), b, new Point(Position.X + 5 * Radius / 25, Position.Y + 4 * Radius / 25));

            g.Dispose();
            pb.Image = drawArea;
        }
    }
}
