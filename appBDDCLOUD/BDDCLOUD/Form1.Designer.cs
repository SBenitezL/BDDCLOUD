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
            this.tbpCRUD = new System.Windows.Forms.TabPage();
            this.btnEliminarPVJ = new System.Windows.Forms.Button();
            this.btnActualizarPVJ = new System.Windows.Forms.Button();
            this.btnInsertarPVJ = new System.Windows.Forms.Button();
            this.txtbNPID = new System.Windows.Forms.TextBox();
            this.txtbPID = new System.Windows.Forms.TextBox();
            this.txtbVJID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPVJ = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbpJugador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugador)).BeginInit();
            this.tbpCRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPVJ)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpJugador);
            this.tabControl1.Controls.Add(this.tbpCRUD);
            this.tabControl1.Controls.Add(this.tabPage1);
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
            // tbpCRUD
            // 
            this.tbpCRUD.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tbpCRUD.Controls.Add(this.label8);
            this.tbpCRUD.Controls.Add(this.btnEliminarPVJ);
            this.tbpCRUD.Controls.Add(this.btnActualizarPVJ);
            this.tbpCRUD.Controls.Add(this.btnInsertarPVJ);
            this.tbpCRUD.Controls.Add(this.txtbNPID);
            this.tbpCRUD.Controls.Add(this.txtbPID);
            this.tbpCRUD.Controls.Add(this.txtbVJID);
            this.tbpCRUD.Controls.Add(this.label7);
            this.tbpCRUD.Controls.Add(this.label6);
            this.tbpCRUD.Controls.Add(this.label5);
            this.tbpCRUD.Controls.Add(this.dgvPVJ);
            this.tbpCRUD.Controls.Add(this.button1);
            this.tbpCRUD.Location = new System.Drawing.Point(4, 22);
            this.tbpCRUD.Name = "tbpCRUD";
            this.tbpCRUD.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCRUD.Size = new System.Drawing.Size(794, 411);
            this.tbpCRUD.TabIndex = 1;
            this.tbpCRUD.Text = "CRUD";
            // 
            // btnEliminarPVJ
            // 
            this.btnEliminarPVJ.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEliminarPVJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPVJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEliminarPVJ.Location = new System.Drawing.Point(179, 360);
            this.btnEliminarPVJ.Name = "btnEliminarPVJ";
            this.btnEliminarPVJ.Size = new System.Drawing.Size(108, 36);
            this.btnEliminarPVJ.TabIndex = 9;
            this.btnEliminarPVJ.Text = "Eliminar";
            this.btnEliminarPVJ.UseVisualStyleBackColor = false;
            this.btnEliminarPVJ.Click += new System.EventHandler(this.btnEliminarPVJ_Click);
            // 
            // btnActualizarPVJ
            // 
            this.btnActualizarPVJ.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnActualizarPVJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarPVJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnActualizarPVJ.Location = new System.Drawing.Point(179, 318);
            this.btnActualizarPVJ.Name = "btnActualizarPVJ";
            this.btnActualizarPVJ.Size = new System.Drawing.Size(108, 36);
            this.btnActualizarPVJ.TabIndex = 8;
            this.btnActualizarPVJ.Text = "Actualizar";
            this.btnActualizarPVJ.UseVisualStyleBackColor = false;
            this.btnActualizarPVJ.Click += new System.EventHandler(this.btnActualizarPVJ_Click);
            // 
            // btnInsertarPVJ
            // 
            this.btnInsertarPVJ.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnInsertarPVJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertarPVJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnInsertarPVJ.Location = new System.Drawing.Point(179, 273);
            this.btnInsertarPVJ.Name = "btnInsertarPVJ";
            this.btnInsertarPVJ.Size = new System.Drawing.Size(108, 36);
            this.btnInsertarPVJ.TabIndex = 7;
            this.btnInsertarPVJ.Text = "Insertar";
            this.btnInsertarPVJ.UseVisualStyleBackColor = false;
            this.btnInsertarPVJ.Click += new System.EventHandler(this.btnInsertarPVJ_Click);
            // 
            // txtbNPID
            // 
            this.txtbNPID.Location = new System.Drawing.Point(469, 157);
            this.txtbNPID.Name = "txtbNPID";
            this.txtbNPID.Size = new System.Drawing.Size(100, 20);
            this.txtbNPID.TabIndex = 6;
            // 
            // txtbPID
            // 
            this.txtbPID.Location = new System.Drawing.Point(469, 115);
            this.txtbPID.Name = "txtbPID";
            this.txtbPID.Size = new System.Drawing.Size(100, 20);
            this.txtbPID.TabIndex = 5;
            // 
            // txtbVJID
            // 
            this.txtbVJID.Location = new System.Drawing.Point(469, 79);
            this.txtbVJID.Name = "txtbVJID";
            this.txtbVJID.Size = new System.Drawing.Size(100, 20);
            this.txtbVJID.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.label7.Location = new System.Drawing.Point(228, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nuevo ID Plataforma:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.label6.Location = new System.Drawing.Point(228, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Plataforma ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F);
            this.label5.Location = new System.Drawing.Point(228, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Video Juego ID:";
            // 
            // dgvPVJ
            // 
            this.dgvPVJ.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvPVJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPVJ.Location = new System.Drawing.Point(467, 255);
            this.dgvPVJ.Name = "dgvPVJ";
            this.dgvPVJ.Size = new System.Drawing.Size(316, 150);
            this.dgvPVJ.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(675, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnConsultarPlatVidJu);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(794, 411);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(376, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "CRUD";
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
            this.tbpCRUD.ResumeLayout(false);
            this.tbpCRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPVJ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpJugador;
        private System.Windows.Forms.TabPage tbpCRUD;
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
        private System.Windows.Forms.DataGridView dgvPVJ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnEliminarPVJ;
        private System.Windows.Forms.Button btnActualizarPVJ;
        private System.Windows.Forms.Button btnInsertarPVJ;
        private System.Windows.Forms.TextBox txtbNPID;
        private System.Windows.Forms.TextBox txtbPID;
        private System.Windows.Forms.TextBox txtbVJID;
        private System.Windows.Forms.Label label8;
    }
}

