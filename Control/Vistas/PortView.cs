using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Control
{
    public partial class PortView : MaterialForm
    {
        public PortView(object[] lista)
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

            foreach (string port in lista)
            {
                lista_puertos.Items.Add(port);
            }
            lista_puertos.SelectedItem = lista_puertos.Items[0];
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Program.conex.PortName = lista_puertos.SelectedItem.ToString();
            ControlView controlView = new ControlView();
            controlView.Visible = true;
            Visible = false;
        }

        private void PortView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
