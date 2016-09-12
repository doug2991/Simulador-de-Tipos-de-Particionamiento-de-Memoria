namespace ProyectoSO2
{
    partial class FormNuevo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbPFDT = new System.Windows.Forms.RadioButton();
            this.rbPFMT = new System.Windows.Forms.RadioButton();
            this.rbPD = new System.Windows.Forms.RadioButton();
            this.rbPF = new System.Windows.Forms.RadioButton();
            this.gbAUPD = new System.Windows.Forms.GroupBox();
            this.rbMA = new System.Windows.Forms.RadioButton();
            this.rbSA = new System.Windows.Forms.RadioButton();
            this.rbPA = new System.Windows.Forms.RadioButton();
            this.gbAUPF = new System.Windows.Forms.GroupBox();
            this.rbMPD = new System.Windows.Forms.RadioButton();
            this.rbMP = new System.Windows.Forms.RadioButton();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbAUPD.SuspendLayout();
            this.gbAUPF.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.rbPD);
            this.groupBox1.Controls.Add(this.rbPF);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Particionamiento:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbPFDT);
            this.panel1.Controls.Add(this.rbPFMT);
            this.panel1.Location = new System.Drawing.Point(7, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 49);
            this.panel1.TabIndex = 2;
            // 
            // rbPFDT
            // 
            this.rbPFDT.AutoSize = true;
            this.rbPFDT.Location = new System.Drawing.Point(40, 27);
            this.rbPFDT.Name = "rbPFDT";
            this.rbPFDT.Size = new System.Drawing.Size(117, 17);
            this.rbPFDT.TabIndex = 1;
            this.rbPFDT.TabStop = true;
            this.rbPFDT.Text = "Distinto Tamaño";
            this.toolTip1.SetToolTip(this.rbPFDT, "Distintos tamaños para las particiones de la memoria.");
            this.rbPFDT.UseVisualStyleBackColor = true;
            this.rbPFDT.CheckedChanged += new System.EventHandler(this.rbPFDT_CheckedChanged);
            // 
            // rbPFMT
            // 
            this.rbPFMT.AutoSize = true;
            this.rbPFMT.Location = new System.Drawing.Point(40, 4);
            this.rbPFMT.Name = "rbPFMT";
            this.rbPFMT.Size = new System.Drawing.Size(109, 17);
            this.rbPFMT.TabIndex = 0;
            this.rbPFMT.TabStop = true;
            this.rbPFMT.Text = "Mismo Tamaño";
            this.toolTip1.SetToolTip(this.rbPFMT, "Mismo tamaño para todas las particiones de la memoria.");
            this.rbPFMT.UseVisualStyleBackColor = true;
            this.rbPFMT.CheckedChanged += new System.EventHandler(this.rbPFMT_CheckedChanged);
            // 
            // rbPD
            // 
            this.rbPD.AutoSize = true;
            this.rbPD.Location = new System.Drawing.Point(7, 98);
            this.rbPD.Name = "rbPD";
            this.rbPD.Size = new System.Drawing.Size(175, 17);
            this.rbPD.TabIndex = 1;
            this.rbPD.TabStop = true;
            this.rbPD.Text = "Particionamiento Dinámico";
            this.toolTip1.SetToolTip(this.rbPD, "El tamaño de las particiones si cambia a medida que se agregan procesos.");
            this.rbPD.UseVisualStyleBackColor = true;
            this.rbPD.CheckedChanged += new System.EventHandler(this.rbPD_CheckedChanged);
            // 
            // rbPF
            // 
            this.rbPF.AutoSize = true;
            this.rbPF.Location = new System.Drawing.Point(7, 20);
            this.rbPF.Name = "rbPF";
            this.rbPF.Size = new System.Drawing.Size(143, 17);
            this.rbPF.TabIndex = 0;
            this.rbPF.TabStop = true;
            this.rbPF.Text = "Particionamiento Fijo";
            this.toolTip1.SetToolTip(this.rbPF, "El tamaño de las particiones no cambia a medida que se agregan procesos.");
            this.rbPF.UseVisualStyleBackColor = true;
            this.rbPF.CheckedChanged += new System.EventHandler(this.rbPF_CheckedChanged);
            // 
            // gbAUPD
            // 
            this.gbAUPD.Controls.Add(this.rbMA);
            this.gbAUPD.Controls.Add(this.rbSA);
            this.gbAUPD.Controls.Add(this.rbPA);
            this.gbAUPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAUPD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbAUPD.Location = new System.Drawing.Point(291, 153);
            this.gbAUPD.Name = "gbAUPD";
            this.gbAUPD.Size = new System.Drawing.Size(159, 100);
            this.gbAUPD.TabIndex = 1;
            this.gbAUPD.TabStop = false;
            this.gbAUPD.Text = "Algoritmo de Ubicación";
            // 
            // rbMA
            // 
            this.rbMA.AutoSize = true;
            this.rbMA.Location = new System.Drawing.Point(7, 68);
            this.rbMA.Name = "rbMA";
            this.rbMA.Size = new System.Drawing.Size(95, 17);
            this.rbMA.TabIndex = 2;
            this.rbMA.TabStop = true;
            this.rbMA.Text = "Mejor Ajuste";
            this.rbMA.UseVisualStyleBackColor = true;
            // 
            // rbSA
            // 
            this.rbSA.AutoSize = true;
            this.rbSA.Location = new System.Drawing.Point(7, 44);
            this.rbSA.Name = "rbSA";
            this.rbSA.Size = new System.Drawing.Size(117, 17);
            this.rbSA.TabIndex = 1;
            this.rbSA.TabStop = true;
            this.rbSA.Text = "Siguiente Ajuste";
            this.rbSA.UseVisualStyleBackColor = true;
            // 
            // rbPA
            // 
            this.rbPA.AutoSize = true;
            this.rbPA.Location = new System.Drawing.Point(7, 20);
            this.rbPA.Name = "rbPA";
            this.rbPA.Size = new System.Drawing.Size(99, 17);
            this.rbPA.TabIndex = 0;
            this.rbPA.TabStop = true;
            this.rbPA.Text = "Primer Ajuste";
            this.rbPA.UseVisualStyleBackColor = true;
            // 
            // gbAUPF
            // 
            this.gbAUPF.Controls.Add(this.rbMPD);
            this.gbAUPF.Controls.Add(this.rbMP);
            this.gbAUPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAUPF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbAUPF.Location = new System.Drawing.Point(33, 153);
            this.gbAUPF.Name = "gbAUPF";
            this.gbAUPF.Size = new System.Drawing.Size(252, 100);
            this.gbAUPF.TabIndex = 2;
            this.gbAUPF.TabStop = false;
            this.gbAUPF.Text = "Algoritmo de Ubicación";
            // 
            // rbMPD
            // 
            this.rbMPD.AutoSize = true;
            this.rbMPD.Location = new System.Drawing.Point(7, 53);
            this.rbMPD.Name = "rbMPD";
            this.rbMPD.Size = new System.Drawing.Size(219, 17);
            this.rbMPD.TabIndex = 1;
            this.rbMPD.TabStop = true;
            this.rbMPD.Text = "Partición Mas Pequeña Disponible";
            this.rbMPD.UseVisualStyleBackColor = true;
            // 
            // rbMP
            // 
            this.rbMP.AutoSize = true;
            this.rbMP.Location = new System.Drawing.Point(6, 30);
            this.rbMP.Name = "rbMP";
            this.rbMP.Size = new System.Drawing.Size(156, 17);
            this.rbMP.TabIndex = 0;
            this.rbMP.TabStop = true;
            this.rbMP.Text = "Partición Mas Pequeña";
            this.toolTip1.SetToolTip(this.rbMP, "Ubica el proceso en la particion mas pequeña disponible");
            this.rbMP.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(375, 272);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "Siguiente ";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(481, 324);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.gbAUPF);
            this.Controls.Add(this.gbAUPD);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormNuevo";
            this.Text = "FormNuevo";
            this.Load += new System.EventHandler(this.FormNuevo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbAUPD.ResumeLayout(false);
            this.gbAUPD.PerformLayout();
            this.gbAUPF.ResumeLayout(false);
            this.gbAUPF.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPD;
        private System.Windows.Forms.RadioButton rbPF;
        private System.Windows.Forms.GroupBox gbAUPD;
        private System.Windows.Forms.RadioButton rbMA;
        private System.Windows.Forms.RadioButton rbSA;
        private System.Windows.Forms.RadioButton rbPA;
        private System.Windows.Forms.GroupBox gbAUPF;
        private System.Windows.Forms.RadioButton rbMPD;
        private System.Windows.Forms.RadioButton rbMP;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbPFDT;
        private System.Windows.Forms.RadioButton rbPFMT;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}