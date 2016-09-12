using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSO2
{
    public class Contexto
    {
        private string tipoDeParticionamiento;
        private string tipoDeAlgoritmo;

        private int tamañoMemoria;
        private int espacioDisponible;

        public string TipoDeParticionamiento { get {return this.tipoDeParticionamiento; } set { this.tipoDeParticionamiento = value; } }

        public string TipoDeAlgoritmo { get { return this.tipoDeAlgoritmo; } set { this.tipoDeAlgoritmo = value; } }

        public int TamañoMemoria { get { return this.tamañoMemoria; } set { this.tamañoMemoria = value; } }

        public int EspacioDisponible { get { return this.espacioDisponible; } set { this.espacioDisponible = value; } }





    }
}
