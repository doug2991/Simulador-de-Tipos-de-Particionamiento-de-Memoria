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
    public partial class FormLista : Form
    {
        Queue<Proceso> ColaProcesos = new Queue<Proceso>();

        public FormLista(ref Queue<Proceso> lista)
        { 
            this.ColaProcesos = lista;
            InitializeComponent();
            foreach (Proceso p in ColaProcesos)
            {

                listBox1.Items.Add("Proceso:" + p.getId() + "    Tamaño: " + p.getTamaño() + "    Estado: " + p.getEstado());
            }
        
        }
    }
}
