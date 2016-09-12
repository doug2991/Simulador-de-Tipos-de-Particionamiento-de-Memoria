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
    public partial class btnFinalizar : Form
    {
        Apuntador apuntador;
        private Queue<Proceso> ColaDeProcesos = new Queue<Proceso>();

        private Queue<Particiones> ColaDeParticiones = new Queue<Particiones>();

        private List<Proceso> listaDeProcesos = new List<Proceso>();

        private List<Particiones> listaDeParticion = new List<Particiones>();


         int tamañoMemoria = 256;
         int espacioDisponible = 256;
         int tamañoSO = 10;
         int tamañoParticionesIguales = 32;

        //Objeto contexto que contiene la informacion del ciclo que se esta ejecutando.
        Contexto contexto = new Contexto();

        public btnFinalizar()
        {
            InitializeComponent();

            
            //label Algoritmo de Ubicacion
            lbAU.Text=contexto.TipoDeAlgoritmo;
            
            //label Tamaño de Memoria
            lbTamaño.Text = tamañoMemoria.ToString();

            //label que muestra el Espacio disponible
            lbEDisp.Text = this.espacioDisponible.ToString();

            //Label que muestra el estado del proceso siguiente
            lbEstado.Hide();
            //label que muestra el id del proceso siguiente
            lbIdProceso.Hide();

            //label que muestra el tamaño del proceso siguiente
            lbTamañoProceso.Hide();
            //boton para llamar al proceso siguiente y ejecutar una nueva insercion en memoria
            btnSiguiente.Enabled = false;
            
            //Muestra la lista de procesos por ejecutarse
            btnListaDeProcesos.Enabled = false;

            //Boton para eliminar el proceso seleccionado en la memoria
            btnEliminar.Visible = false;

 
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Clic en la opcion de menu salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //Evento Clic en Boton siguiente
        private void button1_Click(object sender, EventArgs e)
        {
            

            //Particionamiento Fijo Mismo Tamaño
            if (this.contexto.TipoDeParticionamiento == "Particionamiento Fijo, Mismo Tamaño")
            {

                if (this.ColaDeProcesos.Count() != 0)
                {

                    Proceso pIn = this.ColaDeProcesos.Dequeue();

                    

                    if (pIn.getTamaño() > listaDeParticion[0].getTamaño())
                    {
                        MessageBox.Show("El Tamaño del Proceso es Mayor que el tamaño \n" +
                        "de las Particiones");

                        cargarSiguienteInfo();

                    }
                    else
                    {

                        insertarPFijo(pIn);
                        //
                        this.listBox1.Items.Clear();

                        cargarParticiones();
                        actualizarTamañoDisponible();

                        cargarSiguienteInfo();

                    }
                }
                else
                {

                   
                    this.btnSiguiente.Enabled = false;
                    borrarInfoProcesos();

                }
            }




                //Particionamiento Fijo Distinto Tamaño
               else{

              

                    if(this.contexto.TipoDeParticionamiento == "Particionamiento Fijo, Distinto Tamaño")
                         {
                             if (this.contexto.TipoDeAlgoritmo == "Mas Pequeña")
                             {

                                 if (this.ColaDeProcesos.Count != 0)
                                 {
                                    

                                     Proceso pIn = this.ColaDeProcesos.Dequeue();

                                     if (insertarFijoDistintoTamañoMinimo(pIn))
                                     {

                                         this.listBox1.Items.Clear();

                                         cargarParticiones();

                                         actualizarTamañoDisponible();
                                     }
                                     else
                                     {
                                         MessageBox.Show("Proceso demasiado grande para las particiones establecidas");
                                     }
                                     cargarSiguienteInfo();
                                 }
                                 else
                                 {
                                     this.btnSiguiente.Enabled = false;
                                   
                                     borrarInfoProcesos();
                                 }
                             }
                             else







                                 if (this.contexto.TipoDeAlgoritmo == "Mas Pequeña Disponible")
                                 {
                                     if (this.ColaDeProcesos.Count != 0)
                                     {


                                         Proceso pIn = this.ColaDeProcesos.Dequeue();

                                         if (insertarFijoDistintoTamañoMinimo(pIn))
                                         {

                                             this.listBox1.Items.Clear();

                                             cargarParticiones();

                                             actualizarTamañoDisponible();
                                         }
                                         
                                         cargarSiguienteInfo();
                                     }
                                     else
                                     {
                                         this.btnSiguiente.Enabled = false;
                                        
                                         borrarInfoProcesos();
                                     }
 


                                 }










                         }
                    }
            if (this.contexto.TipoDeParticionamiento == "Particionamiento Dinamico")
            {
                this.lbEDisp.Visible = false;
                this.label7.Visible = false;
                this.btnEliminar.Visible = true;
                if (this.contexto.TipoDeAlgoritmo == "Primer Ajuste")
                {
                    
                    dinamicoPrimerAjuste();

                }
                else
                    if (this.contexto.TipoDeAlgoritmo == "Mejor Ajuste")
                    {
                        dinamicoMejorAjuste();

                    }
                    else
                        if (this.contexto.TipoDeAlgoritmo == "Siguiente Ajuste")
                        {

                            dinamicoSiguienteAjuste(ref apuntador);

                        }


            }






                     
        }
        //Evento Clic en Nueva Simulacion
        private void nuevaSimulacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.configuraciónToolStripMenuItem.Enabled = false;
            this.apuntador = new Apuntador(1);
            this.ColaDeProcesos.Clear();
            this.ColaDeParticiones.Clear();

            this.listaDeParticion.Clear();

            this.listBox1.Items.Clear();

            this.espacioDisponible = tamañoMemoria;


            this.contexto = new Contexto();

            contexto.TamañoMemoria=tamañoMemoria;
            contexto.EspacioDisponible=tamañoMemoria;

            //Form para seleccionar el Tipo de Memoria y Algoritmo de Ubicacion.

            FormNuevo Nuevo = new FormNuevo(ref this.contexto);
            DialogResult resultado = Nuevo.ShowDialog();
            //Resultado == dialog result ok es particionamiento dinamico
            //Resultado == dialog result cancel es particionamiento fijo mismo tamaño de particiones
            //Resultado == dialog result no es particionamiento fijo distinto tamaño de particiones
            //Resultado == cualquier otra cosa es que se cancelo antes de escoger y se dara clic a finalizar


            if (resultado == DialogResult.OK)
            {
              
                //Form para agregar los procesos a simular
                FormProcesos proceso = new FormProcesos(ref this.ColaDeProcesos);

                this.lbEDisp.Visible = false;
                this.label7.Visible = false;

                this.btnEliminar.Visible = true;

                //Muestra la ventana para agregar procesos
                proceso.ShowDialog();
                
                lbAU.Text = contexto.TipoDeAlgoritmo;
                
                //Verifaca que la cola de procesos no este vacia
                if (this.ColaDeProcesos.Count() != 0)
                {
                    //Se le manda la posicion a la que debe apuntar 
                    Apuntador apuntador = new Apuntador(1);

                    Particiones nuevaPar = new Particiones(10);
                    
                    //Se crea el proceso del Sistema Operativo
                    Proceso nuevoPro = new Proceso(-1,this.tamañoSO,"SO");

                    nuevaPar.setProceso(nuevoPro);

                    this.listaDeParticion.Add(nuevaPar);
                    
                    //Calculando espacio disponible
                    int espacioD = this.contexto.TamañoMemoria - nuevaPar.getProceso().getTamaño();

                    this.contexto.EspacioDisponible=espacioD;

                    lbEDisp.Text = this.contexto.EspacioDisponible.ToString();

                    listBox1.Items.Add(this.listaDeParticion[0].toString());

                    //Agrega nueva particion con todo el espacio disponible
                    Particiones Nueva = new Particiones(this.contexto.EspacioDisponible);
                    this.listaDeParticion.Add(Nueva);
                    this.listBox1.Items.Clear();



                    cargarParticiones();

                    mostrarInfoProcesos(this.ColaDeProcesos.Peek().getId().ToString(),
                        this.ColaDeProcesos.Peek().getTamaño().ToString(),
                        this.ColaDeProcesos.Peek().getEstado().ToString());

                    
                    btnListaDeProcesos.Enabled = true;
                    btnSiguiente.Enabled = true;
                

                }
                else
                   
                {
                    this.btnFin.PerformClick();
                    //MessageBox.Show("Lista Vacia porque entre aqui");
                    //Particionamiento Fijo hay que definir tamaño de las particiones
                   
                   // FormMemoria memoria = new FormMemoria(ref this.contexto, ref this.listaDeParticion);
                    //memoria.ShowDialog();

                    //lbAU.Text = contexto.TipoDeAlgoritmo;

                    btnListaDeProcesos.Enabled = false;
                    btnSiguiente.Enabled = false;
                    
                }


            }
            else
                //Particionamiento fijo mismo tamaño de particiones
                if ( resultado == DialogResult.Cancel)
                {


                    lbAU.Text = contexto.TipoDeAlgoritmo;

                    //Asigna el tamaño de configuracion
                    asignarMemoriaMismoTamaño(this.tamañoParticionesIguales);

                    agregarSO();

                    this.contexto.EspacioDisponible=tamañoMemoria - this.listaDeParticion[0].getProceso().getTamaño();

                    this.lbEDisp.Text = this.contexto.EspacioDisponible.ToString();

                    crearProcesos();

                    cargarParticiones();

                   
                    

                }

                else
                    //Particionamiento fijo deistinto tamaño
                    if (resultado == DialogResult.No)
                    {
                        FormMemoria m = new FormMemoria(ref this
                            .contexto, ref this.listaDeParticion);
                        if (m.ShowDialog() == DialogResult.Cancel)
                        {




                            this.contexto.EspacioDisponible = tamañoMemoria - this.listaDeParticion[0].getTamaño();
                            this.lbEDisp.Text = this.contexto.EspacioDisponible.ToString();


                            ordenarListaDeParticiones();
                            cargarParticiones();

                            crearProcesos();

                        }
                        else
                            MessageBox.Show("Situacion Extraña");
                    }
                    else
                    {
                        this.btnFin.PerformClick();
                    }
        }

        public void ordenarListaDeParticiones()
        {
            Particiones temporal;
         
            for (int i = 0; i < this.listaDeParticion.Count(); i++)
            {
              
                for (int j = i+1; j < this.listaDeParticion.Count; j++)
                {

                    if (this.listaDeParticion[i].getTamaño() > this.listaDeParticion[j].getTamaño())
                    {
                        temporal=this.listaDeParticion[i];
                        this.listaDeParticion[i] = this.listaDeParticion[j];
                        this.listaDeParticion[j] = temporal;
                    }


                }

            }

        }

       

        private void memoriaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMemoria Memoria = new FormMemoria(ref this.contexto,ref this.listaDeParticion);
            Memoria.ShowDialog();
        }

        private void listaDeProcesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProcesos Procesos = new FormProcesos(ref this.ColaDeProcesos);
            //FormProcesos Procesos = new FormProcesos(ref this.listaDeProcesos);
            Procesos.ShowDialog();
        }

        //Evento Clic en Lista de Procesos
        private void button3_Click(object sender, EventArgs e)
        {
            FormLista frmLista = new FormLista(ref this.ColaDeProcesos);
            frmLista.ShowDialog();
        }
        
        
        public void mostrarInfoProcesos(string id, string tamaño, string estado)
        {
            this.lbTamañoProceso.Visible = true;
            this.lbIdProceso.Visible = true;
            this.lbEstado.Visible = true;
            this.lbIdProceso.Text = id;
            this.lbTamañoProceso.Text = tamaño;
            this.lbEstado.Text = estado;
        }

        public void borrarInfoProcesos()
        {
            this.lbTamañoProceso.Visible = false;
            this.lbIdProceso.Visible = false;
            this.lbEstado.Visible = false;
            this.lbIdProceso.Text = String.Empty;
            this.lbTamañoProceso.Text = String.Empty;
            this.lbEstado.Text = String.Empty;

        }

        public void asignarMemoriaMismoTamaño(int tamaño) {

            //Crear particiones con un tamaño de 32 MB cada una para particiones de mismo tamaño
            int tamañoP = tamaño;
          //error al cambiar el tamaño de las particiones fijas
            while((this.espacioDisponible != 0)&&(this.espacioDisponible>tamañoP))
                       {
                           
                               Particiones nuevaP = new Particiones(tamañoP);
                               this.listaDeParticion.Add(nuevaP);

                               this.espacioDisponible = this.espacioDisponible - tamañoP;
                           

            }

           
           
        }

        public void cargarParticiones()
        {
            
            foreach (Particiones p in this.listaDeParticion)
            {
                this.listBox1.Items.Add(p.toString());
            }

           

        }

        public void actualizarTamañoDisponible()
        {

            this.lbEDisp.Text = this.contexto.EspacioDisponible.ToString();

        }

        public void agregarSO()
        {
            Proceso SO = new Proceso(-1,this.tamañoSO,"SO");
            this.listaDeParticion[0].setProceso(SO);

        }

        public void crearProcesos()
        {

            FormProcesos p = new FormProcesos(ref this.ColaDeProcesos);
            p.ShowDialog();

            if (this.ColaDeProcesos.Count() != 0)
            {
                mostrarInfoProcesos(this.ColaDeProcesos.Peek().getId().ToString(),
                       this.ColaDeProcesos.Peek().getTamaño().ToString(),
                       this.ColaDeProcesos.Peek().getEstado().ToString());

                btnListaDeProcesos.Enabled = true;
                btnSiguiente.Enabled = true;
                
            }
            else
            {
                btnListaDeProcesos.Enabled = false;
                btnSiguiente.Enabled = false;
                
                borrarInfoProcesos();
            }
        }


        public void insertarPFijo(Proceso p)
        {
            bool particionesLlenas = false;
           
            int tamañoProceso = p.getTamaño();

            for (int i = 1; i < this.listaDeParticion.Count(); i++)
            {
                if (!this.listaDeParticion[i].particionOcupada())
                {
                    this.contexto.EspacioDisponible = this.contexto.EspacioDisponible - tamañoProceso; 
                    particionesLlenas = false;

                    this.listaDeParticion[i].setProceso(p);

                    return;
                }
                else
                {
                    if (this.listaDeParticion[i].particionOcupada())
                    {

                        particionesLlenas = true;

                    }
                }

            }

            if (particionesLlenas)
            {
                MessageBox.Show("No Hay Particiones Disponibles \n "+
                "La Memoria Esta Llena de Procesos, Se Debe Hacer Un Intercambio");
                this.btnSiguiente.Enabled = false;
                
            }

           


        }

        public bool insertarFijoDistintoTamañoMinimoDiponilbe(Proceso pIn)
        {
            bool pudoInsertar = false;
            int tamañoProceso = pIn.getTamaño();
            for(int i=0;i<this.listaDeParticion.Count();i++){

                if (tamañoProceso <= this.listaDeParticion[i].getTamaño())
                {
                    if (this.listaDeParticion[i].particionOcupada())
                    {
                        if (this.listaDeParticion[i].getProceso().getId() != -1)
                        {
                            MessageBox.Show("Se realiza un intercambio");
                            this.contexto.EspacioDisponible = this.contexto.EspacioDisponible + this.listaDeParticion[i].getProceso().getTamaño();
                            this.listaDeParticion[i].setProceso(pIn);
                            this.contexto.EspacioDisponible = this.contexto.EspacioDisponible - tamañoProceso;
                            pudoInsertar = true;
                            return pudoInsertar;
                        }
                        else
                        {
                            if (this.listaDeParticion[i].getProceso().getId() == -1)
                            {
                              //No debe agregar en esta particion porque es la de el sistema operativo 
                              //debe pasar a la siguiente
                            }
                        }
                    }
                    else
                    {
                        
                        this.listaDeParticion[i].setProceso(pIn);
                        this.contexto.EspacioDisponible = this.contexto.EspacioDisponible - tamañoProceso;
                        pudoInsertar = true;
                        return pudoInsertar;
                    }
                }
                
            }
            return false;
        }


        public bool insertarFijoDistintoTamañoMinimo(Proceso pIn)
        {
            bool pudoInsertar = false;
            int tamañoProceso = pIn.getTamaño();

            for(int i=0;i<this.listaDeParticion.Count();i++){

                if (tamañoProceso <= this.listaDeParticion[i].getTamaño())
                {
                    if (this.listaDeParticion[i].particionOcupada())
                    {
                        if (this.listaDeParticion[i].getProceso().getId() != -1)
                        {

                            for (int z = i+1; z < this.listaDeParticion.Count(); z++)
                            {

                                if (!this.listaDeParticion[z].particionOcupada())
                                {
                                    this.listaDeParticion[z].setProceso(pIn);
                                    this.contexto.EspacioDisponible = this.contexto.EspacioDisponible - tamañoProceso;
                                    pudoInsertar = true;
                                    return pudoInsertar;
                                }
                                else
                                {
                                  
                                }

                            }

                            MessageBox.Show("Memoria llena y particiones ocupadas, se debe aplicar un \n "
                            +"algoritmo de reemplazo");

                            return false;

                        }
                        else
                        {
                            if (this.listaDeParticion[i].getProceso().getId() == -1)
                            {
                              //No debe agregar en esta particion porque es la de el sistema operativo 
                              //debe pasar a la siguiente
                            }
                        }
                    }
                    else
                    {
                        
                        this.listaDeParticion[i].setProceso(pIn);
                        this.contexto.EspacioDisponible = this.contexto.EspacioDisponible - tamañoProceso;
                        pudoInsertar = true;
                        return pudoInsertar;
                    }
                }
                
            }
            return false;
        }








        public void cargarSiguienteInfo()
        {

            if (this.ColaDeProcesos.Count != 0)
            {
                mostrarInfoProcesos(this.ColaDeProcesos.Peek().getId().ToString(),
                this.ColaDeProcesos.Peek().getTamaño().ToString(),
                this.ColaDeProcesos.Peek().getEstado().ToString());
            }
            else
            {
                borrarInfoProcesos();
                this.btnSiguiente.Enabled = false;
               
            }

        }

        public bool espaciosVaciosParticiones(ref Queue<int> posicionesVacias)
        {
            bool respuesta = false;
            int contador = 0;
            foreach (Particiones p in this.listaDeParticion)
            {

                if (!p.particionOcupada())
                {

                    posicionesVacias.Enqueue(contador);
                    contador = contador + 1;
                    respuesta = true;
                }
                else
                {
                    contador = contador + 1;
                }

            }
            return respuesta;
        }

        public void dinamicoPrimerAjuste()
        {
            Proceso pIn;
            bool procesoDemasiadoGrande = true;
            Queue<int> posicionesVacias = new Queue<int>();

            if (this.ColaDeProcesos.Count != 0)
            {
                pIn = this.ColaDeProcesos.Dequeue();

                if (espaciosVaciosParticiones(ref posicionesVacias))
                {
                    foreach (int i in posicionesVacias)
                    {
                        if (this.listaDeParticion[i].getTamaño() > pIn.getTamaño())
                        {
                            Particiones p1 = new Particiones(pIn.getTamaño());
                            p1.setProceso(pIn);
                            Particiones p2 = new Particiones(this.listaDeParticion[i].getTamaño() - p1.getTamaño());

                            this.listaDeParticion.RemoveAt(i);

                            this.listaDeParticion.Insert(i, p1);
                            this.listaDeParticion.Insert(i + 1, p2);
                            this.listBox1.Items.Clear();
                            cargarParticiones();
                            cargarSiguienteInfo();
                           
                            return;
                        }
                        else
                        {
                            if (this.listaDeParticion[i].getTamaño() == pIn.getTamaño())
                            {
                                this.listaDeParticion[i].setProceso(pIn);
                                this.listBox1.Items.Clear();
                                cargarParticiones();
                                cargarSiguienteInfo();

                                return;

                            }
                            else
                            {
                                //El proceso no cabe en las particiones disponibles
                            }

                        }
                    }

                    if (procesoDemasiadoGrande)
                    {
                        //Salio del Foreach y no pudo agregar el proceso a ninguna particion vacia por espacio insuficiente
                        MessageBox.Show("Particiones Disponibles Demasiado Pequeñas Para el Proceso");
                        cargarSiguienteInfo();
                    }
                    else
                    {
                        cargarSiguienteInfo();
                    }
                }
                else
                {
                    MessageBox.Show("Todas las Particiones están Llenas, Memoria Insuficiente \n Aplicar Algoritmos de reemplazo");
                }


            }
            else
            {

                borrarInfoProcesos();
                this.btnSiguiente.Enabled = false;
               

            }
          

        }

        public void ordenarPosicionesVacias(int posicion, ref Queue<int> posicionesVacias)
        {

            List<int> listaPosiciones = new List<int>();
            Queue<int> cola = new Queue<int>();

            foreach(int p in posicionesVacias)
            {
                listaPosiciones.Add(p);
            }


            for (int p = 0; p < listaPosiciones.Count(); p++)
            {
                if (posicion <= listaPosiciones[p])
                {
                    cola.Enqueue(listaPosiciones[p]);
                }
            }
            for (int p = 0; p < listaPosiciones.Count(); p++)
            {
                if (posicion > listaPosiciones[p])
                {
                    cola.Enqueue(listaPosiciones[p]);
                }
            }

            posicionesVacias = cola;


        }
     
        public void dinamicoSiguienteAjuste(ref Apuntador apuntador)
        {
            Proceso pIn;
            bool procesoDemasiadoGrande = true;
            Queue<int> posicionesVacias = new Queue<int>();

            if (this.ColaDeProcesos.Count != 0)
            {
                pIn = this.ColaDeProcesos.Dequeue();
                
                if (espaciosVaciosParticiones(ref posicionesVacias))
                {
                    ordenarPosicionesVacias(apuntador.Posicion, ref posicionesVacias);

                    foreach (int i in posicionesVacias)
                    {
                        if (this.listaDeParticion[i].getTamaño() > pIn.getTamaño())
                        {
                            
                            Particiones p1 = new Particiones(pIn.getTamaño());
                            p1.setProceso(pIn);
                            Particiones p2 = new Particiones(this.listaDeParticion[i].getTamaño() - p1.getTamaño());

                            this.listaDeParticion.RemoveAt(i);

                            this.listaDeParticion.Insert(i, p1);
                            this.apuntador.Posicion = i ;
                            this.listaDeParticion.Insert(i + 1, p2);
                            this.listBox1.Items.Clear();
                            cargarParticiones();
                            cargarSiguienteInfo();

                            return;
                        }
                        else
                        {
                            if (this.listaDeParticion[i].getTamaño() == pIn.getTamaño())
                            {
                                this.listaDeParticion[i].setProceso(pIn);
                                this.apuntador.Posicion=i;
                                this.listBox1.Items.Clear();
                                cargarParticiones();
                                cargarSiguienteInfo();

                                return;

                            }
                            else
                            {
                                //El proceso no cabe en las particiones disponibles
                            }

                        }
                    }

                    if (procesoDemasiadoGrande)
                    {
                        //Salio del Foreach y no pudo agregar el proceso a ninguna particion vacia por espacio insuficiente
                        MessageBox.Show("Particiones Disponibles Demasiado Pequeñas Para el Proceso");
                        cargarSiguienteInfo();
                    }
                    else
                    {
                        cargarSiguienteInfo();
                    }
                }
                else
                {
                    MessageBox.Show("Todas las Particiones están Llenas, Memoria Insuficiente \n Aplicar Algoritmos de reemplazo");
                }


            }
            else
            {

                borrarInfoProcesos();
                this.btnSiguiente.Enabled = false;
               

            }
          
        }

        public void ordenarMejor(ref Queue<int> posiciones, Proceso p)
        {
            List<int> listaPosiciones = new List<int>();
            List<int> listaPosicionesPosibles = new List<int>(); 
            Queue<int> cola = new Queue<int>();
            int menorDesperdicio;

            foreach (int i in posiciones)
            {
                listaPosiciones.Add(i);
            }

            
            for (int i = 0; i < listaPosiciones.Count(); i++)
            {
                menorDesperdicio = this.listaDeParticion[listaPosiciones[i]].getTamaño() - p.getTamaño();
                if (menorDesperdicio >= 0)
                {
                    listaPosicionesPosibles.Add(listaPosiciones[i]);
                }


               
            }
            
            int particion = this.listaDeParticion[listaPosicionesPosibles[0]].getTamaño();
            int proceso = p.getTamaño();
            int posicionfinal=0;

            menorDesperdicio = particion - proceso;
            for (int i = 1; i < listaPosicionesPosibles.Count(); i++)
            {
                if(menorDesperdicio> (this.listaDeParticion[listaPosicionesPosibles[i]].getTamaño()-proceso))
                {
                    menorDesperdicio = this.listaDeParticion[listaPosicionesPosibles[i]].getTamaño() - proceso;
                    posicionfinal = i;
                }
            }

            posiciones.Clear();
            posiciones.Enqueue(listaPosicionesPosibles[posicionfinal]);



        }

        public void dinamicoMejorAjuste()
        {
            Proceso pIn;
            bool procesoDemasiadoGrande = true;
            Queue<int> posicionesVacias = new Queue<int>();

            if (this.ColaDeProcesos.Count != 0)
            {
                pIn = this.ColaDeProcesos.Dequeue();

                if (espaciosVaciosParticiones(ref posicionesVacias))
                {
                    ordenarMejor(ref posicionesVacias, pIn );

                    foreach (int i in posicionesVacias)
                    {
                        if (this.listaDeParticion[i].getTamaño() > pIn.getTamaño())
                        {

                            Particiones p1 = new Particiones(pIn.getTamaño());
                            p1.setProceso(pIn);
                            Particiones p2 = new Particiones(this.listaDeParticion[i].getTamaño() - p1.getTamaño());

                            this.listaDeParticion.RemoveAt(i);

                            this.listaDeParticion.Insert(i, p1);
                            this.apuntador.Posicion = i;
                            this.listaDeParticion.Insert(i + 1, p2);
                            this.listBox1.Items.Clear();
                            cargarParticiones();
                            cargarSiguienteInfo();

                            return;
                        }
                        else
                        {
                            if (this.listaDeParticion[i].getTamaño() == pIn.getTamaño())
                            {
                                this.listaDeParticion[i].setProceso(pIn);
                                this.apuntador.Posicion = i;
                                this.listBox1.Items.Clear();
                                cargarParticiones();
                                cargarSiguienteInfo();

                                return;

                            }
                            else
                            {
                                //El proceso no cabe en las particiones disponibles
                            }

                        }
                    }

                    if (procesoDemasiadoGrande)
                    {
                        //Salio del Foreach y no pudo agregar el proceso a ninguna particion vacia por espacio insuficiente
                        MessageBox.Show("Particiones Disponibles Demasiado Pequeñas Para el Proceso");
                        cargarSiguienteInfo();
                    }
                    else
                    {
                        cargarSiguienteInfo();
                    }
                }
                else
                {
                    MessageBox.Show("Todas las Particiones están Llenas, Memoria Insuficiente \n Aplicar Algoritmos de reemplazo");
                }


            }
            else
            {

                borrarInfoProcesos();
                this.btnSiguiente.Enabled = false;
                

            }
        }

        //Evento Clic en Boton Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((this.listBox1.SelectedIndex != -1)&&(this.listBox1.SelectedIndex != 0))
            {
               this.contexto.EspacioDisponible = this.contexto.EspacioDisponible + this.listaDeParticion[this.listBox1.SelectedIndex].getProceso().getTamaño();
                this.listaDeParticion[this.listBox1.SelectedIndex].borrarProceso();
               actualizarTamañoDisponible();
                this.listBox1.Items.Clear();
                cargarParticiones();

            }
        }

        private void lbAU_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lbEDisp_Click(object sender, EventArgs e)
        {

        }

        private void lbTamaño_Click(object sender, EventArgs e)
        {

        }

        private void lbIdProceso_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbTamañoProceso_Click(object sender, EventArgs e)
        {

        }

        private void lbEstado_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //Evento Clic en Configuracion
        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configuracion frmConfiguracion = new configuracion(ref this.tamañoMemoria, ref this.tamañoSO, ref this.tamañoParticionesIguales);
            if (frmConfiguracion.ShowDialog() == DialogResult.OK)
            {
                this.tamañoMemoria = frmConfiguracion.TamañoMemoria;
                this.lbTamaño.Text = this.tamañoMemoria.ToString();
                this.tamañoSO = frmConfiguracion.TamañoSO;
                this.lbEDisp.Text = this.tamañoMemoria.ToString();
                this.tamañoParticionesIguales = frmConfiguracion.TamañoParticionesFijas;
            }
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.btnSiguiente.Enabled = false;
            this.btnListaDeProcesos.Enabled = false;
            this.configuraciónToolStripMenuItem.Enabled = true;
            this.lbAU.Text = "";
            this.label7.Visible = true;
            this.lbEDisp.Visible = true;
            this.apuntador = new Apuntador(1);
            this.ColaDeProcesos.Clear();
            this.ColaDeParticiones.Clear();

            this.listaDeParticion.Clear();

            this.listBox1.Items.Clear();


            this.espacioDisponible = tamañoMemoria;
           

            this.contexto = new Contexto();
            contexto.TamañoMemoria = tamañoMemoria;
            contexto.EspacioDisponible = tamañoMemoria;

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
      
    
    
    }

    
 
   
}

 