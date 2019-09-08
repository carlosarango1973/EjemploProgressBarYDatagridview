using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploProgressBarYDatagridview
{
    public partial class OpcionGroupBox : Form
    {
        public OpcionGroupBox()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            gbgenero.Visible = true;
            gbnacionalidad.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            gbgenero.Visible = false;
            gbnacionalidad.Visible = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }
    }
}
