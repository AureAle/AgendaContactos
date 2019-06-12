using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica_38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //hacer tabla y después conectar 
        //ver-otras ventanas- origenes de datos y en esa pestaña se selecciona la tabla(en el form) clic derecho en la flecha y en diseño o la datagridview y arrastrar

        private void datosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.datosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dIRECTORIODataSet);
            label1.Visible=true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dIRECTORIODataSet.Datos' Puede moverla o quitarla según sea necesario.
            this.datosTableAdapter.Fill(this.dIRECTORIODataSet.Datos);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Base_de_datos bdd = new Base_de_datos();
            bdd.ShowDialog();
        }

        private void BindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
