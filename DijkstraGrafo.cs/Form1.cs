using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace DijkstraGrafo
{
    public partial class Form1 : Form
    {
        private List<Arch> listArches;
        private List<Nodo> listNodes;

        private Bitmap drawArea;
        private Random rdn;
        
        private static int Radius;
        private static int Dist;
        private Graph grp;
        
        public Form1()
        {
            InitializeComponent();

            listArches = new List<Arch>(); // lista di archi 
            listNodes = new List<Nodo>(); // lista di nodi
           
            drawArea = new Bitmap(AreaDisegno.Size.Width, AreaDisegno.Size.Height); // area di disegno
            AreaDisegno.Image = drawArea;

            rdn = new Random();

            Radius = 50; // raggio dei cerchi che rappresentano i nodi
            Dist = 45; // range
        }

        // ritorna false se esiste un nodo che abbia lo stesso nome
        private bool checkName(string na)
        {
            foreach (Nodo n in listNodes)
                if (n.getName() == na)
                {
                    MessageBox.Show("Inserire nome differente!");
                    return false;
                }
            return true;
        }

        // calcolo della retta che congiunge 2 punti
        private Line CalcolaRetta(Point n1, Point n2)
        {
            if (Math.Abs(n1.X - n2.X) < (Radius * Dist / 50))
                return new Line(n1.X); // retta verticale

            double m = (n1.Y - n2.Y) / (n1.X - n2.X); // calcolo m
            double q = n1.Y - m * n1.X; // calcolo q
            return new Line(m, q);
        }

        // ritorna false se nessun nodo si trova nelle vicinanze di una retta che congiunge altri due nodi
        private bool RettaLibera(Nodo n, Line r)
        {
            foreach (Nodo no in listNodes)
                if (n != no)
                    if (DistRetta(no.getPosition(), r) < (Radius * Dist / 50))
                        return false;
            return true;
        }

        // calcolo della distanza fra un punto ed una retta
        private double DistRetta(Point p1, Line r)
        {
            return Math.Abs(-r.getM() * p1.X + p1.Y - r.getQ()) / Math.Sqrt(Math.Pow(r.getM(), 2) + 1);
        }

        // ritorna il nodo in base al nome
        private Nodo FindNode(string n)
        {
            foreach (Nodo no in listNodes)
                if (no.getName() == n)
                    return no;
            return null;
        }

        private void InserisciNodo_Click(object sender, EventArgs e)
        {
            string na;
            int x, y;

            // accettabili nomi lunghi solo un carattere
            if (NewNameNode.Text.Length == 1)
            {
                na = NewNameNode.Text.ToUpper(); // nome dei nodi solo caratteri maiuscoli
                if (checkName(na)) // se non esiste alcun nodo con lo stesso nome
                {
                    do
                    {
                        x = rdn.Next(0, AreaDisegno.Size.Width - Radius);
                        y = rdn.Next(0, AreaDisegno.Size.Height - Radius);
                    } while (!checkPosition(new Point(x, y))); // inserisci il nodo solo quando la posizione è accettabile
                    Nodo n = new Nodo(new Point(x, y), na); // nuovo nodo
                    n.Draw(drawArea, AreaDisegno); // disegnato il nodo

                    listNodes.Add(n); // aggiunto il nodo alla lista
                    Nodes.Items.Add(n); // aggiunto il nodo alla listbox dei nodi
                }
            }
            else
                MessageBox.Show("Nome non valido!");
            NewNameNode.Text = ""; // resettato il campo di inserimento
        }

        // controllo della posizione
        private bool checkPosition(Point p)
        {
            foreach (Nodo no in listNodes)
            {
                if (Math.Abs(p.X - no.getPosition().X) < (Radius * Dist / 50) || Math.Abs(p.Y - no.getPosition().Y) < (Radius * Dist / 50))
                    return false;
                if (!RettaLibera(no, CalcolaRetta(p, no.getPosition())))
                    return false;
            }
            return true;
        }

        private void InserisciArco_Click(object sender, EventArgs e)
        {
            Nodo Start = FindNode(StartNode.Text.ToUpper()); // nodo di inizio dell'arco
            Nodo End = FindNode(EndNode.Text.ToUpper()); // nodo di fine dell'arco
            int Weight = Int32.Parse(WeightArch.Text); // peso dell'arco

            if (Start == null)
                StartNode.Text = "";
            if (End == null)
                EndNode.Text = "";
            if (End != null && Start != null)
            {
                Arch a = new Arch(Start, End, Weight); // nuovo arco

                // calcolate le intersezioni
                Point inter_st = a.trovaIntersezioni(Start.getPosition(), Radius / 2, Start.getPosition(), End.getPosition(), "sor");
                Point inter_end = a.trovaIntersezioni(End.getPosition(), Radius / 2, Start.getPosition(), End.getPosition(), "dest");
                
                // textbox che contiene al suo interno il peso
                TextBox t = new TextBox
                {
                    Size = new Size(25, 15),
                    Location = a.Midle(inter_st, inter_end) // punto medio del segmento che indica l'arco
                };

                // proprietà della textbox
                t.BackColor = DefaultBackColor;
                t.BorderStyle = BorderStyle.None;
                t.Font = new Font("Arial", 15);
                t.TextAlign = HorizontalAlignment.Center;
                t.Text = Weight.ToString();
                Controls.Add(t);
                t.BringToFront();
                
                a.Draw(inter_st, inter_end, drawArea, AreaDisegno); // disegno dell'arco

                listArches.Add(a); // aggiunto arco alla lista
                Arches.Items.Add(a); // aggiunto arco alla listbox degli archi

                ResetArchTextboxes(); // resettati i campi di inserimento dell'arco
            }
            else
                MessageBox.Show("Nodi non validi!");
        }

        private void CalcolaGrafo_Click(object sender, EventArgs e)
        {
            List<int>[] t = new List<int>[listNodes.Count - 1];
            Dijkstra dj = new Dijkstra();
            grp = new Graph(listNodes);

            // creazione della matrice di adiacenza
            foreach (Arch ar in listArches)
                grp.setAdiacenza(ar);

            Nodo dest = null;
            Nodo n = FindNode(SourceNode.Text.ToUpper());
            
            // se non è inserito il nodo di destinazione,
            // viene calcolato il percorso minimo dalla sorgente verso tutti gli altri nodi
            if (DestNode.Text != "")    
                dest = FindNode(DestNode.Text.ToUpper());

            if (DestNode.Text != "" && dest == null || n == null)
            {
                MessageBox.Show("Nodi non validi");
                ResetGraphTextboxes(); // resettati i campi di inserimento del grafo
            }
            else
            {
                t = dj.calculate(grp.getMatrix(), listNodes.IndexOf(n));

                Arch arc = new Arch(null, null, 0);
                int a = 0;
                if (DestNode.Text == "")
                {
                    for (int i = 0; i < listNodes.Count; i++)
                    {
                        if (t[i] != null)
                        {
                            a = 0;
                            while (a + 1 < t[i].Count)
                            {
                                // trovate le intersezioni tra retta e cerchio
                                Point inter_st = arc.trovaIntersezioni(listNodes[t[i][a]].getPosition(), Radius / 2, listNodes[t[i][a]].getPosition(), listNodes[t[i][a + 1]].getPosition(), "sor");
                                Point inter_end = arc.trovaIntersezioni(listNodes[t[i][a + 1]].getPosition(), Radius / 2, listNodes[t[i][a]].getPosition(), listNodes[t[i][a + 1]].getPosition(), "dest");

                                arc.Colora(Color.Red, inter_st, inter_end, drawArea, AreaDisegno); // colorato l'arco che fa parte dell'albero dei cammini minimi
                                a++;
                            }
                        }
                    }
                }
                else
                {
                    int index = listNodes.IndexOf(FindNode(DestNode.Text.ToUpper()));
                    if (t[index] == null)
                    {
                        MessageBox.Show("La destinazione corrisponde con la sorgente!");
                        DestNode.Text = "";
                    }
                    else
                    {
                        a = 0;
                        while (a + 1 < t[index].Count)
                        {
                            // trovate le intersezioni tra retta e cerchio
                            Point inter_st = arc.trovaIntersezioni(listNodes[t[index][a]].getPosition(), Radius / 2, listNodes[t[index][a]].getPosition(), listNodes[t[index][a + 1]].getPosition(), "sor");
                            Point inter_end = arc.trovaIntersezioni(listNodes[t[index][a + 1]].getPosition(), Radius / 2, listNodes[t[index][a]].getPosition(), listNodes[t[index][a + 1]].getPosition(), "dest");

                            arc.Colora(Color.Green, inter_st, inter_end, drawArea, AreaDisegno); // colorato l'arco che fa parte dell'albero dei cammini minimi
                            a++;
                        }
                    }
                }
            }
        }
        
        private void Delete_Click(object sender, EventArgs e)
        {
            ResetNodeTextbox();
            ResetArchTextboxes();
            ResetGraphTextboxes();

            listNodes.Clear();
            listArches.Clear();

            Nodes.Items.Clear();
            Arches.Items.Clear();

            foreach (Control c in Controls)
                if (c is TextBox)
                    Controls.Remove(c);

            drawArea.Dispose();
            drawArea = new Bitmap(AreaDisegno.Size.Width, AreaDisegno.Size.Height);
            AreaDisegno.Image = drawArea;
        }

        private void ResetArchTextboxes()
        {
            StartNode.Text = "";
            EndNode.Text = "";
            WeightArch.Text = "";
        }

        private void ResetGraphTextboxes()
        {
            DestNode.Text = "";
            SourceNode.Text = "";
        }

        private void ResetNodeTextbox()
        {
            NewNameNode.Text = "";
        }
    }
}
