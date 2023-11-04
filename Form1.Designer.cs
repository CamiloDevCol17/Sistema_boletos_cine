namespace MovieLibrary
{
    partial class Sistema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema));
            this.label2 = new System.Windows.Forms.Label();
            this.lbllistmovies = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblhorarios = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbasientos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lsbhorario = new System.Windows.Forms.ListBox();
            this.lblasientosdisponibles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "SISTEMA DE REGISTRO BOLETOS CINECOLOMBIA";
            // 
            // lbllistmovies
            // 
            this.lbllistmovies.AutoSize = true;
            this.lbllistmovies.Location = new System.Drawing.Point(86, 52);
            this.lbllistmovies.Name = "lbllistmovies";
            this.lbllistmovies.Size = new System.Drawing.Size(80, 13);
            this.lbllistmovies.TabIndex = 2;
            this.lbllistmovies.Text = "Lista Peliculas: ";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(77, 155);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(69, 13);
            this.lbldescripcion.TabIndex = 3;
            this.lbldescripcion.Text = "Descripcion: ";
            this.lbldescripcion.Click += new System.EventHandler(this.lbldescripcion_Click_1);
            // 
            // lblhorarios
            // 
            this.lblhorarios.AutoSize = true;
            this.lblhorarios.Location = new System.Drawing.Point(354, 52);
            this.lblhorarios.Name = "lblhorarios";
            this.lblhorarios.Size = new System.Drawing.Size(52, 13);
            this.lblhorarios.TabIndex = 4;
            this.lblhorarios.Text = "Horarios: ";
            this.lblhorarios.Click += new System.EventHandler(this.lblhorarios_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Asiento: ";
            // 
            // txbasientos
            // 
            this.txbasientos.Location = new System.Drawing.Point(403, 134);
            this.txbasientos.Name = "txbasientos";
            this.txbasientos.Size = new System.Drawing.Size(100, 20);
            this.txbasientos.TabIndex = 7;
            this.txbasientos.TextChanged += new System.EventHandler(this.txbasientos_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 61);
            this.button1.TabIndex = 8;
            this.button1.Text = "Confirmar boleto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(172, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lsbhorario
            // 
            this.lsbhorario.FormattingEnabled = true;
            this.lsbhorario.Location = new System.Drawing.Point(420, 33);
            this.lsbhorario.Name = "lsbhorario";
            this.lsbhorario.Size = new System.Drawing.Size(120, 95);
            this.lsbhorario.TabIndex = 10;
            this.lsbhorario.SelectedIndexChanged += new System.EventHandler(this.lsbhorario_SelectedIndexChanged);
            // 
            // lblasientosdisponibles
            // 
            this.lblasientosdisponibles.AutoSize = true;
            this.lblasientosdisponibles.Location = new System.Drawing.Point(354, 168);
            this.lblasientosdisponibles.Name = "lblasientosdisponibles";
            this.lblasientosdisponibles.Size = new System.Drawing.Size(108, 13);
            this.lblasientosdisponibles.TabIndex = 11;
            this.lblasientosdisponibles.Text = "Asientos disponibles: ";
            this.lblasientosdisponibles.Click += new System.EventHandler(this.lblasientosdisponibles_Click);
            // 
            // Sistema
            // 
            this.ClientSize = new System.Drawing.Size(808, 261);
            this.Controls.Add(this.lblasientosdisponibles);
            this.Controls.Add(this.lsbhorario);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbasientos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblhorarios);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.lbllistmovies);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sistema";
            this.Load += new System.EventHandler(this.Sistema_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblpelicula;
        private System.Windows.Forms.ListBox lstPeliculas;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.ComboBox cmbHorariodisponible;
        private System.Windows.Forms.Label lblhorario;
        private System.Windows.Forms.Label lblasientos;
        private System.Windows.Forms.TextBox txbcantidadasientos;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbllistmovies;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lblhorarios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbasientos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox lsbhorario;
        private System.Windows.Forms.Label lblasientosdisponibles;
    }
}

