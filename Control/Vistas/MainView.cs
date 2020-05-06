using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Control
{
    public partial class MainView : MaterialForm
    {
        private delegate void DelegadoEstado(string texto, Color color);
        private delegate void DelegadoPuerto(string texto);
        private delegate void DelegadoBarra(int valor);
        private delegate void DelegadoValidar();
        private ArrayList tarjetas;
        private bool continuar = false; 
        public MainView()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey900,
                Primary.Lime700, Accent.Pink700,
                TextShade.WHITE
            );
        }

        public void Run()
        {
            DelegadoPuerto delegadoP = new DelegadoPuerto(ModificarPuerto);
            DelegadoEstado delegadoE = new DelegadoEstado(ModificarEstado);
            DelegadoBarra delegadoB = new DelegadoBarra(ModificarBarra);
            DelegadoValidar delegadoV = new DelegadoValidar(ValidarPuertos);
            string[] ports;

            do {
            ports = SerialPort.GetPortNames();
            tarjetas = new ArrayList();
            for (int i = 0; i < ports.Length; i++)
            {
                this.Invoke(delegadoB, new object[] { (100 / (ports.Length - i)) });
                this.Invoke(delegadoP, new object[] { ports[i] });
                try
                {
                    if (ports[i] != "COM1")
                    {
                        if (Program.conex.Validar(ports[i]))
                        {
                            tarjetas.Add(ports[i]);
                            this.Invoke(delegadoE, new object[] { "Conectado con exito", Program.colorTeal });
                        }
                        else
                        {
                            this.Invoke(delegadoE, new object[] { "No se pudo conectar", Program.colorPink });
                        }
                    }
                }
                catch (Exception error)
                {
                    this.Invoke(delegadoE, new object[] { error.Message, Program.colorPink });
                }

                Thread.Sleep(1000);
            }
            this.Invoke(delegadoV);
        }while (continuar);

        }
        private void ValidarPuertos()
        {
            if (tarjetas.Count > 0)
            {
                PortView portView = new PortView(tarjetas.ToArray());
                portView.Visible = true;
                Visible = false;
            }
            else
            {
                continuar = (MessageBox.Show("No hay dispositivos conectados.\n¿Desea volver a Buscar?", "Error de conexión", MessageBoxButtons.YesNo, MessageBoxIcon.Error).ToString().Equals("Yes")) ? true : false;
                if (!continuar)
                {
                    System.Environment.Exit(0);
                }
            }
        }
        private void MainView_Shown(object sender, EventArgs e)
        {
            estado.ForeColor = Program.colorPink;
            puerto.ForeColor = Program.colorBlueGray;
            Thread hilo = new Thread(new ThreadStart(Run));
            hilo.Start();
        }

        private void ModificarEstado(string texto, Color color)
        {
            estado.Text = texto;
            estado.ForeColor = color;
        }

        private void ModificarPuerto(string texto)
        {
            puerto.Text = texto;
        }
        private void ModificarBarra(int valor)
        {
            barra.Value = valor;
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
