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
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultarJugador = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.dgvJugador = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnConsultarAnio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdJugador = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tbpJugador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugador)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpJugador);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(794, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // txtIdJugador
            // 
            this.txtIdJugador.Location = new System.Drawing.Point(118, 279);
            this.txtIdJugador.Name = "txtIdJugador";
            this.txtIdJugador.Size = new System.Drawing.Size(100, 20);
            this.txtIdJugador.TabIndex = 8;
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
    }
}

