using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ServiceReference1.WebService1SoapClient webService = new ServiceReference1.WebService1SoapClient();

        private void Form1_Load(object sender, EventArgs e)
        {

            label2.Text = webService.DateNow();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = webService.DateNow();
        }
    }
}
