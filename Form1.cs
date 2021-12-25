using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceReservasi;

namespace ServerConfig_Reservasi_097
{
    public partial class Form1 : Form
    {
        private ServiceHost Host;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Service1));
            labelOnOrOff.Text = "Server ON";
            labelKet.Text = "Klik OFF untuk Mematikan Server";
            Host.Open();
            btnOn.Enabled = false;
            btnOff.Enabled = true;
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            btnOn.Enabled = true;
            btnOff.Enabled = false;
            Host.Close();
            labelOnOrOff.Text = "Server OFF";
            labelKet.Text = "Klik ON untuk Menjalankan Server";

        }
    }
}
