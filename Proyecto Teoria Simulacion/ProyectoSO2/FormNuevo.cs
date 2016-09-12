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
    public partial class FormNuevo : Form
    {
        Contexto contexto;

        public FormNuevo(ref Contexto c)
        {
            this.contexto = c;  
            InitializeComponent();
            
            //radio Button Particionamiento Fijo Mismo Tamaño de Particiones
            rbPFMT.Checked = true;
            
        }

        //Clic boton Siguiente

       

        private void button2_Click(object sender, EventArgs e)
        {
            //Asignar dependiendo del tipo de particionamiento a la variable contexto el tipo de particionamiento de memoria
            //a simular

            //Radio Button Particionamiento Fijo 
            if (rbPF.Checked)
            {
                //Radio Button Particionamiento Fijo Mismo Tamaño
                if (rbPFMT.Checked)
                {
                    contexto.TipoDeParticionamiento="Particionamiento Fijo, Mismo Tamaño";
                   
                }
                else
                {
                    contexto.TipoDeParticionamiento="Particionamiento Fijo, Distinto Tamaño";
                }

            }
            else
            {
               contexto.TipoDeParticionamiento="Particionamiento Dinamico";
                
            }

            //Se le asigna a la variable contexto el tipo de algoritmo de ubicacion a simular

            //radio Button primer ajuste
            if (rbPA.Checked)
            {
                contexto.TipoDeAlgoritmo="Primer Ajuste";
            }
            else
            {
                //radio button mejor ajuste
                if (rbMA.Checked)
                {
                    contexto.TipoDeAlgoritmo="Mejor Ajuste";
                }
                else
                    //radio button siguiente ajuste
                    if (rbSA.Checked)
                    {
                        contexto.TipoDeAlgoritmo="Siguiente Ajuste";
                    }
                    else
                        //radio button particion mas pequeña
                        if(rbMP.Checked){
                            contexto.TipoDeAlgoritmo="Mas Pequeña";
                        }
                        else
                            //radio button mas pequeña disponible
                            if (rbMPD.Checked)
                            {
                                contexto.TipoDeAlgoritmo="Mas Pequeña Disponible";
                            }

                
            }
            //radio button particionamiento fijo mismo tamaño
            if (rbPFMT.Checked)
            {
                //Particionamiento fijo mismo tamaño
                DialogResult = DialogResult.Cancel;
               

            }
            else if (rbPFDT.Checked)
            {
                //Particionamiento fijo distinto Tamaño
                DialogResult = DialogResult.No;
               
            }
            else
            {
                //Particionamiento Dinamico y cualquier Algoritmo de busqueda 
               DialogResult = DialogResult.OK;
            }

            
           
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FormNuevo_Load(object sender, EventArgs e)
        {

        }

        private void rbPD_CheckedChanged(object sender, EventArgs e)
        {
            rbPFDT.Checked = false;
            rbPFMT.Checked = false;
            rbMP.Checked = false;
            rbMPD.Checked = false;

            panel1.Enabled = false;

            gbAUPF.Enabled = false;

            gbAUPD.Enabled = true;
            rbPA.Checked = true;

        }

        private void rbPF_CheckedChanged(object sender, EventArgs e)
        {
            gbAUPD.Enabled = false;
            rbPA.Checked = false;
            rbSA.Checked = false;
            rbMA.Checked = false;

            panel1.Enabled = true;
            rbPFMT.Checked = true;
           
            gbAUPF.Enabled = true;
            rbMP.Checked = true;
        }

        private void rbPFMT_CheckedChanged(object sender, EventArgs e)
        {
            rbMPD.Enabled = false;
            rbMP.Enabled = false;
            
            
        }

        private void rbPFDT_CheckedChanged(object sender, EventArgs e)
        {
            rbMPD.Enabled = true;
            rbMP.Enabled = true;
        }

       
    }
}
