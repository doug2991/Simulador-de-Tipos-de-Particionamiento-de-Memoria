namespace ProyectoSO2
{
    partial class btnFinalizar
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaSimulacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbEstado = new System.Windows.Forms.Label();
            this.lbTamañoProceso = new System.Windows.Forms.Label();
            this.lbIdProceso = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnListaDeProcesos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gbMemoria = new System.Windows.Forms.GroupBox();
            this.lbEDisp = new System.Windows.Forms.Label();
            this.lbTamaño = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbAU = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnFin = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbMemoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(863, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaSimulacionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // nuevaSimulacionToolStripMenuItem
            // 
            this.nuevaSimulacionToolStripMenuItem.Name = "nuevaSimulacionToolStripMenuItem";
            this.nuevaSimulacionToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.nuevaSimulacionToolStripMenuItem.Text = "Nueva Simulacion";
            this.nuevaSimulacionToolStripMenuItem.Click += new System.EventHandler(this.nuevaSimulacionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            this.configuraciónToolStripMenuItem.Click += new System.EventHandler(this.configuraciónToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(47, 117);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(419, 356);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(43, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Memoria Principal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.lbEstado);
            this.groupBox1.Controls.Add(this.lbTamañoProceso);
            this.groupBox1.Controls.Add(this.lbIdProceso);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(503, 169);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(264, 122);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Siguiente Proceso";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbEstado.Location = new System.Drawing.Point(66, 89);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(41, 17);
            this.lbEstado.TabIndex = 5;
            this.lbEstado.Text = "label7";
            this.lbEstado.Click += new System.EventHandler(this.lbEstado_Click);
            // 
            // lbTamañoProceso
            // 
            this.lbTamañoProceso.AutoSize = true;
            this.lbTamañoProceso.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTamañoProceso.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTamañoProceso.Location = new System.Drawing.Point(108, 55);
            this.lbTamañoProceso.Name = "lbTamañoProceso";
            this.lbTamañoProceso.Size = new System.Drawing.Size(41, 17);
            this.lbTamañoProceso.TabIndex = 4;
            this.lbTamañoProceso.Text = "label6";
            this.lbTamañoProceso.Click += new System.EventHandler(this.lbTamañoProceso_Click);
            // 
            // lbIdProceso
            // 
            this.lbIdProceso.AutoSize = true;
            this.lbIdProceso.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdProceso.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbIdProceso.Location = new System.Drawing.Point(87, 25);
            this.lbIdProceso.Name = "lbIdProceso";
            this.lbIdProceso.Size = new System.Drawing.Size(41, 17);
            this.lbIdProceso.TabIndex = 3;
            this.lbIdProceso.Text = "label5";
            this.lbIdProceso.Click += new System.EventHandler(this.lbIdProceso_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(8, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Estado:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(8, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tamaño (MB):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(8, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id Proceso:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSiguiente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSiguiente.Location = new System.Drawing.Point(503, 310);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(264, 36);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListaDeProcesos
            // 
            this.btnListaDeProcesos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListaDeProcesos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnListaDeProcesos.Location = new System.Drawing.Point(503, 353);
            this.btnListaDeProcesos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListaDeProcesos.Name = "btnListaDeProcesos";
            this.btnListaDeProcesos.Size = new System.Drawing.Size(264, 34);
            this.btnListaDeProcesos.TabIndex = 6;
            this.btnListaDeProcesos.Text = "Lista de Procesos";
            this.btnListaDeProcesos.UseVisualStyleBackColor = true;
            this.btnListaDeProcesos.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(43, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Algoritmo de Ubicación:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // gbMemoria
            // 
            this.gbMemoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMemoria.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbMemoria.Controls.Add(this.lbEDisp);
            this.gbMemoria.Controls.Add(this.lbTamaño);
            this.gbMemoria.Controls.Add(this.label7);
            this.gbMemoria.Controls.Add(this.label6);
            this.gbMemoria.Location = new System.Drawing.Point(503, 47);
            this.gbMemoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMemoria.Name = "gbMemoria";
            this.gbMemoria.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbMemoria.Size = new System.Drawing.Size(264, 101);
            this.gbMemoria.TabIndex = 8;
            this.gbMemoria.TabStop = false;
            this.gbMemoria.Text = "Memoria";
            // 
            // lbEDisp
            // 
            this.lbEDisp.AutoSize = true;
            this.lbEDisp.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEDisp.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbEDisp.Location = new System.Drawing.Point(170, 62);
            this.lbEDisp.Name = "lbEDisp";
            this.lbEDisp.Size = new System.Drawing.Size(41, 17);
            this.lbEDisp.TabIndex = 3;
            this.lbEDisp.Text = "label8";
            this.lbEDisp.Click += new System.EventHandler(this.lbEDisp_Click);
            // 
            // lbTamaño
            // 
            this.lbTamaño.AutoSize = true;
            this.lbTamaño.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTamaño.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTamaño.Location = new System.Drawing.Point(170, 38);
            this.lbTamaño.Name = "lbTamaño";
            this.lbTamaño.Size = new System.Drawing.Size(41, 17);
            this.lbTamaño.TabIndex = 2;
            this.lbTamaño.Text = "label8";
            this.lbTamaño.Click += new System.EventHandler(this.lbTamaño_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(8, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Espacio Disponible (MB):";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(6, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tamaño de Memoria (MB):";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbAU
            // 
            this.lbAU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbAU.AutoSize = true;
            this.lbAU.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAU.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbAU.Location = new System.Drawing.Point(286, 47);
            this.lbAU.Name = "lbAU";
            this.lbAU.Size = new System.Drawing.Size(44, 18);
            this.lbAU.TabIndex = 9;
            this.lbAU.Text = "lbAU";
            this.lbAU.Click += new System.EventHandler(this.lbAU_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminar.Location = new System.Drawing.Point(379, 487);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 28);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnFin
            // 
            this.btnFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFin.Location = new System.Drawing.Point(503, 395);
            this.btnFin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(264, 36);
            this.btnFin.TabIndex = 11;
            this.btnFin.Text = "Finalizar";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnFinalizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(863, 530);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lbAU);
            this.Controls.Add(this.gbMemoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnListaDeProcesos);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "btnFinalizar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbMemoria.ResumeLayout(false);
            this.gbMemoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaSimulacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.Label lbTamañoProceso;
        private System.Windows.Forms.Label lbIdProceso;
        private System.Windows.Forms.Button btnListaDeProcesos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbMemoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTamaño;
        private System.Windows.Forms.Label lbEDisp;
        private System.Windows.Forms.Label lbAU;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnFin;
    }
}

