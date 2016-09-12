using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoSO2
{
    public partial class configuracion : Form
    {
       
        public int TamañoMemoria { get; set; }
        public int TamañoSO { get; set; }
        public int TamañoParticionesFijas { get; set; } 

        public configuracion(ref int tamaño,ref int SO, ref int tamañoFijas)
        {
            InitializeComponent();

            TamañoMemoria = tamaño;
            TamañoSO = SO;
            TamañoParticionesFijas = tamañoFijas;
            this.nudTamañoMemoria.Value = tamaño;
            this.nudSO.Value = SO;
            this.nudTParticiones.Value = tamañoFijas;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TamañoMemoria =Int32.Parse(this.nudTamañoMemoria.Value.ToString());
            TamañoSO = Int32.Parse(this.nudSO.Value.ToString());
            TamañoParticionesFijas = Int32.Parse(this.nudTParticiones.Value.ToString());
            DialogResult = DialogResult.OK;
             this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.nudSO.Maximum = Int32.Parse(this.nudTamañoMemoria.Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
