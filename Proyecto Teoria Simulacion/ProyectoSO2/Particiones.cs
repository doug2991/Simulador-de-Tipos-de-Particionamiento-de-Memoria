using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSO2
{
    public class Particiones
    {
        private int tamaño;
        private Proceso proceso;


        public Particiones(int tamaño)
        {
            this.tamaño = tamaño;
            this.proceso = null;
            
        }

        public void borrarProceso()
        {
            this.proceso = null;
        }

        public void setTamaño(int t) 
        {
            this.tamaño = t;
        }

        public void setProceso(Proceso p)
        {
            this.proceso = p;
        }

        public Proceso getProceso() 
        {
            return this.proceso;
        }

        public int getTamaño()
        {
            return this.tamaño;
        }

        public bool particionOcupada()
        {
            bool valor;
            if (this.proceso != null)
            {
                valor = true;
            }
            else
            {
                valor = false;
            }
            return valor;
        }

        public string toString()
        {
            if (this.proceso == null)
            {

                return "Tamaño: " + getTamaño() + " MB  Proceso ID: Vacio";
            
            
            }
            else
                if (this.proceso.getId() == -1)
                {

                    return "Tamaño: " + getTamaño() + " MB  Sistema Operativo"+"   Tamaño SO: "+this.proceso.getTamaño()+" MB";

                }
                else

                    return "Tamaño: " + getTamaño() + " MB  Proceso ID: "+this.proceso.getId()+"   Tamaño Proceso: "+this.proceso.getTamaño()+" MB";
        }
    }
}
