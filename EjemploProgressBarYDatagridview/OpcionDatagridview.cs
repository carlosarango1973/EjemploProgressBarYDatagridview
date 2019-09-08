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
    public partial class OpcionDatagridview : Form
    {
        public OpcionDatagridview()
        {
            InitializeComponent();
        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            dtregistros.Rows.Add(txtcedula.Text, txtnombre.Text, txtedad.Text);
            MessageBox.Show("Registro guardado exitosamente.");
            txtcedula.Text = "";
            txtnombre.Text = "";
            txtedad.Text = "";
            txtcedula.Focus();
        }

        private void Dtregistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcedula.Text = dtregistros.Rows[dtregistros.CurrentRow.Index].Cells[0].Value.ToString();
            txtnombre.Text = dtregistros.Rows[dtregistros.CurrentRow.Index].Cells[1].Value.ToString();
            txtnombre.Text = dtregistros.Rows[dtregistros.CurrentRow.Index].Cells[2].Value.ToString();


            dtregistros.Rows.RemoveAt(dtregistros.CurrentRow.Index);
        }

        private void Dtregistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            int fila = int.Parse(txtfila.Text);
            dtregistros.CurrentCell = dtregistros.Rows[(fila - 1)].Cells[0];

            DialogResult respuesta = MessageBox.Show("Estás seguro de eliminar?"
                , "Validacion de respuesta"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);

            if(respuesta == DialogResult.Yes) {
                dtregistros.Rows.RemoveAt(dtregistros.CurrentRow.Index);
            } else
            {
                txtfila.Focus();
            }
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Dispose();
        }
    }
}
