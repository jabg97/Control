using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Control
{
    public partial class ControlView : MaterialForm
    {
        private byte bandera_s1 = 0;
        private byte bandera_s2 = 0;

        public ControlView()
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

        private void ControlView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ControlView_Shown(object sender, EventArgs e)
        {
            luz_roja_s1.BackColor = Program.colorGray;
            luz_verde_s1.BackColor = Program.colorGray;
            luz_roja_s2.BackColor = Program.colorGray;
            luz_verde_s2.BackColor = Program.colorGray;
            label1.ForeColor = Program.colorIndigo;
            label2.ForeColor = Program.colorIndigo;
            Text = "Panel de Control (" + Program.conex.PortName+")";
        }

        private void btn_s1_Click(object sender, EventArgs e)
        {
            if (bandera_s1 != 0)
            {
                try
                {
                    if (!Program.conex.IsOpen)
                    {
                        Enviar("0");
                        bandera_s1 = 0;
                        semaforo1.Image = Control.Properties.Resources.Off;
                        ActivarLuzRoja1(false);
                        ActivarLuzVerde1(false);
                        ActivarBoton1(false);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void luz_roja_s1_Click(object sender, EventArgs e)
        {
            if (bandera_s1 != 1)
            {
                try
                {
                    if (!Program.conex.IsOpen)
                    {
                        Enviar("1");
                        bandera_s1 = 1;
                        semaforo1.Image = Control.Properties.Resources.Red;
                        ActivarLuzRoja1(true);
                        ActivarLuzVerde1(false);
                        ActivarBoton1(true);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void luz_verde_s1_Click(object sender, EventArgs e)
        {
            if (bandera_s1 != 2)
            {
                try
                {
                    if (!Program.conex.IsOpen)
                    {
                        Enviar("2");
                        bandera_s1 = 2;
                        semaforo1.Image = Control.Properties.Resources.Teal;
                        ActivarLuzRoja1(false);
                        ActivarLuzVerde1(true);
                        ActivarBoton1(true);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btn_s2_Click(object sender, EventArgs e)
        {
            if (bandera_s2 != 0)
            {
                try
                {
                    if (!Program.conex.IsOpen)
                    {
                        Enviar("3");
                        bandera_s2 = 0;
                        semaforo2.Image = Control.Properties.Resources.Off;
                        ActivarLuzRoja2(false);
                        ActivarLuzVerde2(false);
                        ActivarBoton2(false);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void luz_roja_s2_Click(object sender, EventArgs e)
        {
            if (bandera_s2 != 1)
            {
                try
                {
                    if (!Program.conex.IsOpen)
                    {
                        Enviar("4");
                        bandera_s2 = 1;
                        semaforo2.Image = Control.Properties.Resources.Red;
                        ActivarLuzRoja2(true);
                        ActivarLuzVerde2(false);
                        ActivarBoton2(true);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void luz_verde_s2_Click(object sender, EventArgs e)
        {
            if (bandera_s2 != 2)
            {
                try
                {
                    if (!Program.conex.IsOpen)
                    {
                        Enviar("5");
                        bandera_s2 = 2;
                        semaforo2.Image = Control.Properties.Resources.Teal;
                        ActivarLuzRoja2(false);
                        ActivarLuzVerde2(true);
                        ActivarBoton2(true);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ActivarLuzRoja1(bool activar)
        {
            if (activar)
            {
                luz_roja_s1.BackColor = Program.colorRed;
                luz_roja_s1.Cursor = Cursors.No;
            }
            else
            {
                luz_roja_s1.BackColor = Program.colorGray;
                luz_roja_s1.Cursor = Cursors.Hand;
            }

        }

        private void ActivarLuzVerde1(bool activar)
        {
            if (activar)
            {
                luz_verde_s1.BackColor = Program.colorTeal;
                luz_verde_s1.Cursor = Cursors.No;
            }
            else
            {
                luz_verde_s1.BackColor = Program.colorGray;
                luz_verde_s1.Cursor = Cursors.Hand;
            }

        }

        private void ActivarBoton1(bool activar)
        {
            if (activar)
            {
                btn_s1.Image = Control.Properties.Resources.BtnOn;
                btn_s1.Cursor = Cursors.Hand;
            }
            else
            {
                btn_s1.Image = Control.Properties.Resources.BtnOff;
                btn_s1.Cursor = Cursors.No;
            }

        }

        private void ActivarLuzRoja2(bool activar)
        {
            if (activar)
            {
                luz_roja_s2.BackColor = Program.colorRed;
                luz_roja_s2.Cursor = Cursors.No;
            }
            else
            {
                luz_roja_s2.BackColor = Program.colorGray;
                luz_roja_s2.Cursor = Cursors.Hand;
            }

        }

        private void ActivarLuzVerde2(bool activar)
        {
            if (activar)
            {
                luz_verde_s2.BackColor = Program.colorTeal;
                luz_verde_s2.Cursor = Cursors.No;
            }
            else
            {
                luz_verde_s2.BackColor = Program.colorGray;
                luz_verde_s2.Cursor = Cursors.Hand;
            }

        }

        private void ActivarBoton2(bool activar)
        {
            if (activar)
            {
                btn_s2.Image = Control.Properties.Resources.BtnOn;
                btn_s2.Cursor = Cursors.Hand;
            }
            else
            {
                btn_s2.Image = Control.Properties.Resources.BtnOff;
                btn_s2.Cursor = Cursors.No;
            }

        }

        private void Enviar(string data)
        {
            Program.conex.Open();
            Program.conex.Write(data);
            Program.conex.Close();
        }
    }
}
