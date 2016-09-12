using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSO2
{
  public class Proceso
    {

      private int idProceso;
      private int Tamaño;
      private String estado;
      

      public Proceso(int id, int tamaño,string es)
      {
          this.idProceso = id;
          this.Tamaño = tamaño;
          this.estado = es;
       
      }

      public void setId(int id){
          this.idProceso = id;
      }

      public void setTamaño(int tamaño)
      {
          this.Tamaño = tamaño;
      }

      public void setEstado(string e)
      {
          this.estado = e;
      }

      public int getId()
      {
          return this.idProceso;
      }

      public int getTamaño()
      {
          return this.Tamaño;
      }

      public string getEstado()
      {
          return this.estado;
      }

      
      

      

      }
}
