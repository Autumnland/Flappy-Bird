namespace Flappy_Bird
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TuboA = new System.Windows.Forms.PictureBox();
            this.TuboB = new System.Windows.Forms.PictureBox();
            this.Flappy = new System.Windows.Forms.PictureBox();
            this.Suelo = new System.Windows.Forms.PictureBox();
            this.Puntos = new System.Windows.Forms.Label();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TuboA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TuboB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Suelo)).BeginInit();
            this.SuspendLayout();
            // 
            // TuboA
            // 
            this.TuboA.Image = global::Flappy_Bird.Properties.Resources.pipedown;
            this.TuboA.Location = new System.Drawing.Point(500, -31);
            this.TuboA.Name = "TuboA";
            this.TuboA.Size = new System.Drawing.Size(100, 192);
            this.TuboA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TuboA.TabIndex = 0;
            this.TuboA.TabStop = false;
            // 
            // TuboB
            // 
            this.TuboB.Image = global::Flappy_Bird.Properties.Resources.pipe;
            this.TuboB.Location = new System.Drawing.Point(405, 401);
            this.TuboB.Name = "TuboB";
            this.TuboB.Size = new System.Drawing.Size(100, 192);
            this.TuboB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TuboB.TabIndex = 1;
            this.TuboB.TabStop = false;
            // 
            // Flappy
            // 
            this.Flappy.Image = global::Flappy_Bird.Properties.Resources.bird;
            this.Flappy.Location = new System.Drawing.Point(71, 210);
            this.Flappy.Name = "Flappy";
            this.Flappy.Size = new System.Drawing.Size(62, 55);
            this.Flappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flappy.TabIndex = 2;
            this.Flappy.TabStop = false;
            // 
            // Suelo
            // 
            this.Suelo.Image = global::Flappy_Bird.Properties.Resources.ground;
            this.Suelo.Location = new System.Drawing.Point(-7, 543);
            this.Suelo.Name = "Suelo";
            this.Suelo.Size = new System.Drawing.Size(706, 50);
            this.Suelo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Suelo.TabIndex = 3;
            this.Suelo.TabStop = false;
            // 
            // Puntos
            // 
            this.Puntos.AutoSize = true;
            this.Puntos.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.Puntos.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puntos.Location = new System.Drawing.Point(173, 554);
            this.Puntos.Name = "Puntos";
            this.Puntos.Size = new System.Drawing.Size(151, 39);
            this.Puntos.TabIndex = 4;
            this.Puntos.Text = "Puntaje: 0";
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            this.Temporizador.Interval = 20;
            this.Temporizador.Tick += new System.EventHandler(this.TemporizadorEvento);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(691, 586);
            this.Controls.Add(this.Puntos);
            this.Controls.Add(this.Suelo);
            this.Controls.Add(this.Flappy);
            this.Controls.Add(this.TuboB);
            this.Controls.Add(this.TuboA);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.TuboA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TuboB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Suelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TuboA;
        private System.Windows.Forms.PictureBox TuboB;
        private System.Windows.Forms.PictureBox Flappy;
        private System.Windows.Forms.PictureBox Suelo;
        private System.Windows.Forms.Label Puntos;
        private System.Windows.Forms.Timer Temporizador;
    }
}

