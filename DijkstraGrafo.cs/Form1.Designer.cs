namespace DijkstraGrafo
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CalcGraph = new System.Windows.Forms.Button();
            this.Weight = new System.Windows.Forms.Label();
            this.End = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Label();
            this.NameNode = new System.Windows.Forms.Label();
            this.NewNode = new System.Windows.Forms.Button();
            this.WeightArch = new System.Windows.Forms.TextBox();
            this.AreaDisegno = new System.Windows.Forms.PictureBox();
            this.StartNode = new System.Windows.Forms.TextBox();
            this.EndNode = new System.Windows.Forms.TextBox();
            this.NewNameNode = new System.Windows.Forms.TextBox();
            this.NewArch = new System.Windows.Forms.Button();
            this.Arches = new System.Windows.Forms.ListBox();
            this.Nodes = new System.Windows.Forms.ListBox();
            this.SourceNode = new System.Windows.Forms.TextBox();
            this.Sorgente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Destinazione = new System.Windows.Forms.Label();
            this.DestNode = new System.Windows.Forms.TextBox();
            this.DeleteGraph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AreaDisegno)).BeginInit();
            this.SuspendLayout();
            // 
            // CalcGraph
            // 
            this.CalcGraph.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcGraph.Location = new System.Drawing.Point(571, 311);
            this.CalcGraph.Name = "CalcGraph";
            this.CalcGraph.Size = new System.Drawing.Size(135, 24);
            this.CalcGraph.TabIndex = 60;
            this.CalcGraph.Text = "Calcola GRAFO";
            this.CalcGraph.UseVisualStyleBackColor = true;
            this.CalcGraph.Click += new System.EventHandler(this.CalcolaGrafo_Click);
            // 
            // Weight
            // 
            this.Weight.AutoSize = true;
            this.Weight.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weight.Location = new System.Drawing.Point(739, 60);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(53, 18);
            this.Weight.TabIndex = 58;
            this.Weight.Text = "Peso: ";
            // 
            // End
            // 
            this.End.AutoSize = true;
            this.End.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.End.Location = new System.Drawing.Point(739, 34);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(47, 18);
            this.End.TabIndex = 57;
            this.End.Text = "Fine: ";
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(739, 9);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(47, 18);
            this.Start.TabIndex = 56;
            this.Start.Text = "Inizio:";
            // 
            // NameNode
            // 
            this.NameNode.AutoSize = true;
            this.NameNode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameNode.Location = new System.Drawing.Point(568, 60);
            this.NameNode.Name = "NameNode";
            this.NameNode.Size = new System.Drawing.Size(58, 18);
            this.NameNode.TabIndex = 55;
            this.NameNode.Text = "Nome: ";
            // 
            // NewNode
            // 
            this.NewNode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewNode.Location = new System.Drawing.Point(571, 88);
            this.NewNode.Name = "NewNode";
            this.NewNode.Size = new System.Drawing.Size(126, 25);
            this.NewNode.TabIndex = 54;
            this.NewNode.Text = "Inserisci NODO";
            this.NewNode.UseVisualStyleBackColor = true;
            this.NewNode.Click += new System.EventHandler(this.InserisciNodo_Click);
            // 
            // WeightArch
            // 
            this.WeightArch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightArch.Location = new System.Drawing.Point(792, 57);
            this.WeightArch.Name = "WeightArch";
            this.WeightArch.Size = new System.Drawing.Size(28, 24);
            this.WeightArch.TabIndex = 53;
            this.WeightArch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AreaDisegno
            // 
            this.AreaDisegno.Location = new System.Drawing.Point(17, 21);
            this.AreaDisegno.Name = "AreaDisegno";
            this.AreaDisegno.Size = new System.Drawing.Size(545, 584);
            this.AreaDisegno.TabIndex = 52;
            this.AreaDisegno.TabStop = false;
            // 
            // StartNode
            // 
            this.StartNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartNode.Location = new System.Drawing.Point(792, 3);
            this.StartNode.Name = "StartNode";
            this.StartNode.Size = new System.Drawing.Size(28, 24);
            this.StartNode.TabIndex = 50;
            this.StartNode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EndNode
            // 
            this.EndNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndNode.Location = new System.Drawing.Point(792, 31);
            this.EndNode.Name = "EndNode";
            this.EndNode.Size = new System.Drawing.Size(28, 24);
            this.EndNode.TabIndex = 49;
            this.EndNode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewNameNode
            // 
            this.NewNameNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewNameNode.Location = new System.Drawing.Point(632, 57);
            this.NewNameNode.Name = "NewNameNode";
            this.NewNameNode.Size = new System.Drawing.Size(28, 24);
            this.NewNameNode.TabIndex = 48;
            this.NewNameNode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewArch
            // 
            this.NewArch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewArch.Location = new System.Drawing.Point(720, 88);
            this.NewArch.Name = "NewArch";
            this.NewArch.Size = new System.Drawing.Size(126, 25);
            this.NewArch.TabIndex = 47;
            this.NewArch.Text = "Inserisci ARCO";
            this.NewArch.UseVisualStyleBackColor = true;
            this.NewArch.Click += new System.EventHandler(this.InserisciArco_Click);
            // 
            // Arches
            // 
            this.Arches.FormattingEnabled = true;
            this.Arches.Location = new System.Drawing.Point(720, 119);
            this.Arches.Name = "Arches";
            this.Arches.Size = new System.Drawing.Size(126, 173);
            this.Arches.TabIndex = 46;
            // 
            // Nodes
            // 
            this.Nodes.FormattingEnabled = true;
            this.Nodes.Location = new System.Drawing.Point(571, 119);
            this.Nodes.Name = "Nodes";
            this.Nodes.Size = new System.Drawing.Size(126, 173);
            this.Nodes.TabIndex = 45;
            // 
            // SourceNode
            // 
            this.SourceNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceNode.Location = new System.Drawing.Point(651, 341);
            this.SourceNode.Name = "SourceNode";
            this.SourceNode.Size = new System.Drawing.Size(28, 24);
            this.SourceNode.TabIndex = 61;
            this.SourceNode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Sorgente
            // 
            this.Sorgente.AutoSize = true;
            this.Sorgente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sorgente.Location = new System.Drawing.Point(569, 340);
            this.Sorgente.Name = "Sorgente";
            this.Sorgente.Size = new System.Drawing.Size(76, 18);
            this.Sorgente.TabIndex = 62;
            this.Sorgente.Text = "Sorgente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(584, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 63;
            this.label2.Text = "Dijkstra Grafo";
            // 
            // Destinazione
            // 
            this.Destinazione.AutoSize = true;
            this.Destinazione.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Destinazione.Location = new System.Drawing.Point(689, 340);
            this.Destinazione.Name = "Destinazione";
            this.Destinazione.Size = new System.Drawing.Size(103, 18);
            this.Destinazione.TabIndex = 65;
            this.Destinazione.Text = "Destinazione:";
            // 
            // DestNode
            // 
            this.DestNode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestNode.Location = new System.Drawing.Point(798, 340);
            this.DestNode.Name = "DestNode";
            this.DestNode.Size = new System.Drawing.Size(28, 24);
            this.DestNode.TabIndex = 64;
            this.DestNode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeleteGraph
            // 
            this.DeleteGraph.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteGraph.Location = new System.Drawing.Point(720, 310);
            this.DeleteGraph.Name = "DeleteGraph";
            this.DeleteGraph.Size = new System.Drawing.Size(135, 24);
            this.DeleteGraph.TabIndex = 66;
            this.DeleteGraph.Text = "Elimina GRAFO";
            this.DeleteGraph.UseVisualStyleBackColor = true;
            this.DeleteGraph.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 617);
            this.Controls.Add(this.DeleteGraph);
            this.Controls.Add(this.DestNode);
            this.Controls.Add(this.Destinazione);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sorgente);
            this.Controls.Add(this.SourceNode);
            this.Controls.Add(this.CalcGraph);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.NameNode);
            this.Controls.Add(this.NewNode);
            this.Controls.Add(this.WeightArch);
            this.Controls.Add(this.AreaDisegno);
            this.Controls.Add(this.StartNode);
            this.Controls.Add(this.EndNode);
            this.Controls.Add(this.NewNameNode);
            this.Controls.Add(this.NewArch);
            this.Controls.Add(this.Arches);
            this.Controls.Add(this.Nodes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dijkstra ";
            ((System.ComponentModel.ISupportInitialize)(this.AreaDisegno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcGraph;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.Label End;
        private System.Windows.Forms.Label Start;
        private System.Windows.Forms.Label NameNode;
        private System.Windows.Forms.Button NewNode;
        private System.Windows.Forms.TextBox WeightArch;
        private System.Windows.Forms.PictureBox AreaDisegno;
        private System.Windows.Forms.TextBox StartNode;
        private System.Windows.Forms.TextBox EndNode;
        private System.Windows.Forms.TextBox NewNameNode;
        private System.Windows.Forms.Button NewArch;
        private System.Windows.Forms.ListBox Arches;
        private System.Windows.Forms.ListBox Nodes;
        private System.Windows.Forms.TextBox SourceNode;
        private System.Windows.Forms.Label Sorgente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Destinazione;
        private System.Windows.Forms.TextBox DestNode;
        private System.Windows.Forms.Button DeleteGraph;
    }
}

