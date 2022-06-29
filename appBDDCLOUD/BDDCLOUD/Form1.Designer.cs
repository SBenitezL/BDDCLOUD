namespace BDDCLOUD
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpJugador = new System.Windows.Forms.TabPage();
            this.txtIdJugador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConsultarAnio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultarJugador = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.dgvJugador = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tbpConsult = new System.Windows.Forms.TabPage();
            this.btnConsultarVideojuego = new System.Windows.Forms.Button();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.lblIdJuego = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPlataforma = new System.Windows.Forms.Label();
            this.lblJugador = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.dtGrdPlataforma = new System.Windows.Forms.DataGridView();
            this.dtGrdJugador = new System.Windows.Forms.DataGridView();
            this.dtGrdGenero = new System.Windows.Forms.DataGridView();
            this.tbpDictionary = new System.Windows.Forms.TabPage();
            this.btnDiccionario = new System.Windows.Forms.Button();
            this.dgvDiccionario = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbpJugador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugador)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tbpConsult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdPlataforma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdJugador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdGenero)).BeginInit();
            this.tbpDictionary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiccionario)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpJugador);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tbpConsult);
            this.tabControl1.Controls.Add(this.tbpDictionary);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(802, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpJugador
            // 
            this.tbpJugador.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tbpJugador.Controls.Add(this.txtIdJugador);
            this.tbpJugador.Controls.Add(this.label4);
            this.tbpJugador.Controls.Add(this.label3);
            this.tbpJugador.Controls.Add(this.btnConsultarAnio);
            this.tbpJugador.Controls.Add(this.label2);
            this.tbpJugador.Controls.Add(this.btnConsultarJugador);
            this.tbpJugador.Controls.Add(this.label1);
            this.tbpJugador.Controls.Add(this.txtAnio);
            this.tbpJugador.Controls.Add(this.dgvJugador);
            this.tbpJugador.Location = new System.Drawing.Point(4, 22);
            this.tbpJugador.Name = "tbpJugador";
            this.tbpJugador.Padding = new System.Windows.Forms.Padding(3);
            this.tbpJugador.Size = new System.Drawing.Size(794, 411);
            this.tbpJugador.TabIndex = 0;
            this.tbpJugador.Text = "tabPage1";
            // 
            // txtIdJugador
            // 
            this.txtIdJugador.Location = new System.Drawing.Point(118, 279);
            this.txtIdJugador.Name = "txtIdJugador";
            this.txtIdJugador.Size = new System.Drawing.Size(100, 20);
            this.txtIdJugador.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "id del jugador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "videojuegos jugados";
            // 
            // btnConsultarAnio
            // 
            this.btnConsultarAnio.BackColor = System.Drawing.Color.BurlyWood;
            this.btnConsultarAnio.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarAnio.Location = new System.Drawing.Point(251, 75);
            this.btnConsultarAnio.Name = "btnConsultarAnio";
            this.btnConsultarAnio.Size = new System.Drawing.Size(88, 23);
            this.btnConsultarAnio.TabIndex = 5;
            this.btnConsultarAnio.Text = "CONSULTAR";
            this.btnConsultarAnio.UseVisualStyleBackColor = false;
            this.btnConsultarAnio.Click += new System.EventHandler(this.btnConsultarAnio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Videojuegos lanzados en una fecha";
            // 
            // btnConsultarJugador
            // 
            this.btnConsultarJugador.BackColor = System.Drawing.Color.BurlyWood;
            this.btnConsultarJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarJugador.Location = new System.Drawing.Point(251, 279);
            this.btnConsultarJugador.Name = "btnConsultarJugador";
            this.btnConsultarJugador.Size = new System.Drawing.Size(96, 23);
            this.btnConsultarJugador.TabIndex = 3;
            this.btnConsultarJugador.Text = "CONSULTAR";
            this.btnConsultarJugador.UseVisualStyleBackColor = false;
            this.btnConsultarJugador.Click += new System.EventHandler(this.btnConsultarJugador_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Año de consulta";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(118, 77);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(100, 20);
            this.txtAnio.TabIndex = 1;
            // 
            // dgvJugador
            // 
            this.dgvJugador.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvJugador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugador.Location = new System.Drawing.Point(413, 6);
            this.dgvJugador.Name = "dgvJugador";
            this.dgvJugador.Size = new System.Drawing.Size(370, 399);
            this.dgvJugador.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "label5";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(511, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(272, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnConsultarPlatVidJu);
            // 
            // tbpConsult
            // 
            this.tbpConsult.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tbpConsult.Controls.Add(this.btnConsultarVideojuego);
            this.tbpConsult.Controls.Add(this.txtBoxId);
            this.tbpConsult.Controls.Add(this.lblIdJuego);
            this.tbpConsult.Controls.Add(this.lblTitulo);
            this.tbpConsult.Controls.Add(this.lblPlataforma);
            this.tbpConsult.Controls.Add(this.lblJugador);
            this.tbpConsult.Controls.Add(this.lblGenero);
            this.tbpConsult.Controls.Add(this.dtGrdPlataforma);
            this.tbpConsult.Controls.Add(this.dtGrdJugador);
            this.tbpConsult.Controls.Add(this.dtGrdGenero);
            this.tbpConsult.Location = new System.Drawing.Point(4, 22);
            this.tbpConsult.Name = "tbpConsult";
            this.tbpConsult.Padding = new System.Windows.Forms.Padding(3);
            this.tbpConsult.Size = new System.Drawing.Size(794, 411);
            this.tbpConsult.TabIndex = 2;
            this.tbpConsult.Text = "Consultas";
            // 
            // btnConsultarVideojuego
            // 
            this.btnConsultarVideojuego.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.btnConsultarVideojuego.Location = new System.Drawing.Point(123, 75);
            this.btnConsultarVideojuego.Name = "btnConsultarVideojuego";
            this.btnConsultarVideojuego.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarVideojuego.TabIndex = 9;
            this.btnConsultarVideojuego.Text = "Consultar";
            this.btnConsultarVideojuego.UseVisualStyleBackColor = true;
            this.btnConsultarVideojuego.Click += new System.EventHandler(this.btnConsultarVideojuego_Click);
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(98, 49);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(100, 20);
            this.txtBoxId.TabIndex = 8;
            // 
            // lblIdJuego
            // 
            this.lblIdJuego.AutoSize = true;
            this.lblIdJuego.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.lblIdJuego.Location = new System.Drawing.Point(8, 50);
            this.lblIdJuego.Name = "lblIdJuego";
            this.lblIdJuego.Size = new System.Drawing.Size(84, 16);
            this.lblIdJuego.TabIndex = 7;
            this.lblIdJuego.Text = "Id videojuego";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(237, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(360, 26);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Sistema De Consulta De Videojuegos";
            // 
            // lblPlataforma
            // 
            this.lblPlataforma.AutoSize = true;
            this.lblPlataforma.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.lblPlataforma.Location = new System.Drawing.Point(591, 174);
            this.lblPlataforma.Name = "lblPlataforma";
            this.lblPlataforma.Size = new System.Drawing.Size(140, 16);
            this.lblPlataforma.TabIndex = 5;
            this.lblPlataforma.Text = "Plataformas Disponibles";
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.lblJugador.Location = new System.Drawing.Point(325, 174);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(141, 16);
            this.lblJugador.TabIndex = 4;
            this.lblJugador.Text = "Jugaodres Profesionales";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.lblGenero.Location = new System.Drawing.Point(62, 174);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(108, 16);
            this.lblGenero.TabIndex = 3;
            this.lblGenero.Text = "Genero Del Juego";
            // 
            // dtGrdPlataforma
            // 
            this.dtGrdPlataforma.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtGrdPlataforma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdPlataforma.Location = new System.Drawing.Point(543, 209);
            this.dtGrdPlataforma.Name = "dtGrdPlataforma";
            this.dtGrdPlataforma.Size = new System.Drawing.Size(240, 150);
            this.dtGrdPlataforma.TabIndex = 2;
            // 
            // dtGrdJugador
            // 
            this.dtGrdJugador.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtGrdJugador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdJugador.Location = new System.Drawing.Point(282, 209);
            this.dtGrdJugador.Name = "dtGrdJugador";
            this.dtGrdJugador.Size = new System.Drawing.Size(240, 150);
            this.dtGrdJugador.TabIndex = 1;
            // 
            // dtGrdGenero
            // 
            this.dtGrdGenero.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtGrdGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdGenero.Location = new System.Drawing.Point(7, 209);
            this.dtGrdGenero.Name = "dtGrdGenero";
            this.dtGrdGenero.Size = new System.Drawing.Size(240, 150);
            this.dtGrdGenero.TabIndex = 0;
            // 
            // tbpDictionary
            // 
            this.tbpDictionary.Controls.Add(this.label8);
            this.tbpDictionary.Controls.Add(this.dgvDiccionario);
            this.tbpDictionary.Controls.Add(this.btnDiccionario);
            this.tbpDictionary.Location = new System.Drawing.Point(4, 22);
            this.tbpDictionary.Name = "tbpDictionary";
            this.tbpDictionary.Size = new System.Drawing.Size(794, 411);
            this.tbpDictionary.TabIndex = 3;
            this.tbpDictionary.Text = "Diccionario";
            this.tbpDictionary.UseVisualStyleBackColor = true;
            // 
            // btnDiccionario
            // 
            this.btnDiccionario.Location = new System.Drawing.Point(358, 108);
            this.btnDiccionario.Name = "btnDiccionario";
            this.btnDiccionario.Size = new System.Drawing.Size(115, 44);
            this.btnDiccionario.TabIndex = 0;
            this.btnDiccionario.Text = "Consultar";
            this.btnDiccionario.UseVisualStyleBackColor = true;
            this.btnDiccionario.Click += new System.EventHandler(this.btnDiccionario_Click);
            // 
            // dgvDiccionario
            // 
            this.dgvDiccionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiccionario.Location = new System.Drawing.Point(16, 177);
            this.dgvDiccionario.Name = "dgvDiccionario";
            this.dgvDiccionario.Size = new System.Drawing.Size(758, 222);
            this.dgvDiccionario.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "DICCIONARIO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tbpJugador.ResumeLayout(false);
            this.tbpJugador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugador)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tbpConsult.ResumeLayout(false);
            this.tbpConsult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdPlataforma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdJugador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdGenero)).EndInit();
            this.tbpDictionary.ResumeLayout(false);
            this.tbpDictionary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiccionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpJugador;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnConsultarJugador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.DataGridView dgvJugador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultarAnio;
        private System.Windows.Forms.TextBox txtIdJugador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tbpConsult;
        private System.Windows.Forms.Label lblPlataforma;
        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.DataGridView dtGrdPlataforma;
        private System.Windows.Forms.DataGridView dtGrdJugador;
        private System.Windows.Forms.DataGridView dtGrdGenero;
        private System.Windows.Forms.Button btnConsultarVideojuego;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Label lblIdJuego;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabPage tbpDictionary;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvDiccionario;
        private System.Windows.Forms.Button btnDiccionario;
    }
}

