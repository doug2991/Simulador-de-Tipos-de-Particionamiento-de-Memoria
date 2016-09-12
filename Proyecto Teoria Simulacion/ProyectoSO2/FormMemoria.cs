using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSO2
{
    public partial class FormMemoria : Form
    {
        private Contexto c;
        private List<Particiones> lstParticiones;


        public FormMemoria(ref Contexto contexto, ref List<Particiones> lp)
        {
            this.c = contexto;
            this.lstParticiones = lp;
           

            Particiones so = new Particiones(10);

            Proceso p = new Proceso(-1, 10, "SO");

            so.setProceso(p);

            this.lstParticiones.Add(so);

            this.c.EspacioDisponible=this.c.TamañoMemoria-p.getTamaño();

            InitializeComponent();

            this.listBox1.Items.Add(this.lstParticiones[0].toString());
            lbTamaño.Text = c.EspacioDisponible.ToString()+" MB";
        }

         private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //FormProcesos Procesos = new FormProcesos();
            //Procesos.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (c.EspacioDisponible == 0)
            {
                DialogResult = DialogResult.Cancel;

            }
            else
                MessageBox.Show("Debe Particionar La Memoria Completa Para Continuar", "Error de Particionamiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lbTamaño_Click(object sender, EventArgs e)
        {
          
        }

        public void calcularEspacioDisponible(int i)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != String.Empty)
            {
                if ((this.c.EspacioDisponible >= Convert.ToInt32(textBox1.Text)) && (Convert.ToInt32(textBox1.Text) != 0))
                {
                    Particiones nuevaP = new Particiones(Convert.ToInt32(textBox1.Text));

                    this.lstParticiones.Add(nuevaP);

                    this.c.EspacioDisponible = this.c.EspacioDisponible - Convert.ToInt32(textBox1.Text);
                    this.lbTamaño.Text = this.c.EspacioDisponible.ToString() + " MB"; ;

                    this.textBox1.Text = String.Empty;

                    if (this.c.EspacioDisponible == 0)
                    {
                        button1.Enabled = false;
                        this.textBox1.Enabled = false;
                    }

                    this.listBox1.Items.Clear();
                    foreach (Particiones p in this.lstParticiones)
                    {
                        this.listBox1.Items.Add(p.toString());
                    }

                }
                else
                {
                    if (Convert.ToInt32(textBox1.Text) == 0)
                    {
                        MessageBox.Show("La partición no debe ser de tamaño 0",
                           "Tamaño Incorrecto ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Text = String.Empty;
                    }
                    else
                    {
                        if (this.c.EspacioDisponible < Convert.ToInt32(textBox1.Text))
                        {
                            MessageBox.Show("Insuficiente espacio disponible en memoria\n para crear esta partición",
                                "Insuficiente Espacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox1.Text = String.Empty;

                        }
                    }
                }
            }
            else
                MessageBox.Show("Introdusca el Tamaño de la Partición y Después Insertar",
                    "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
                    
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

            }
        }


        }
    
}
