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
    public partial class FormProcesos : Form
    {
        Queue<Proceso> ColaProcesos = new Queue<Proceso>();
        //List<Proceso> listaDeProcesos = new List<Proceso>();
        public FormProcesos(ref Queue<Proceso> cp)
        {
            this.ColaProcesos = cp;
            InitializeComponent();
            foreach (Proceso p in ColaProcesos)
            {

                listBox1.Items.Add("Proceso:" + p.getId() + "    Tamaño: " + p.getTamaño() + "    Estado: " + p.getEstado());
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          

           
        }
        //Finalizacion de agregar Procesos
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        //Agregar Nuevos Procesos
        private void button2_Click(object sender, EventArgs e)
        {
            //Validacio de campos vacios
            if ((textBox1.Text != String.Empty) && (textBox2.Text != String.Empty))
            {
                //Creacion del objeto proceso
                Proceso nuevo = new Proceso(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text),"Nuevo");
                ColaProcesos.Enqueue(nuevo);
                
                //Se muestra en la lista
                listBox1.Items.Clear();
                foreach (Proceso p in ColaProcesos)
                {

                    listBox1.Items.Add("Proceso:" + p.getId() + "    Tamaño: " + p.getTamaño()+ "    Estado: "+p.getEstado());
                }
                //Se limpian campos
                textBox1.Text = String.Empty;
                textBox2.Text = String.Empty;

            }
                //Mensaje de alerta de campos vacios
            else
                MessageBox.Show("Imposible crear el proceso, hay campos vacios", "Campos Vacios");
        }
        

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
