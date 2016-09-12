using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSO2
{
   public class Apuntador
    {
       int posicion;

       public Apuntador(int i)
       {
           this.posicion = i;
       }

       public int Posicion { get { return this.posicion; } set { this.posicion = value; } }

    }
}
