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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            if (pgbCargaInicial.Value < 100) {

                pgbCargaInicial.Value++;
                label1.Text =  "cargando " +pgbCargaInicial.Value.ToString() + "%";
           
                    } else {
                timer1.Stop();
                //MessageBox.Show("El progresBar ya esta completado.");
                Menu menu = new Menu();
                menu.Show();
                this.Hide();

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
