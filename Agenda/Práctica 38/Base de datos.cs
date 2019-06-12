using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Práctica_38
{
    public partial class Base_de_datos : Form
    {
        

        public Base_de_datos()
        {
            InitializeComponent();
        }

        private void datosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.datosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dIRECTORIODataSet);

        }

        private void Base_de_datos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dIRECTORIODataSet.Datos' Puede moverla o quitarla según sea necesario.
            this.datosTableAdapter.Fill(this.dIRECTORIODataSet.Datos);

        }
        //Buscar
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True;ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlDataAdapter da;
            DataTable dt;


            if (rbtnNombre.Checked && txtBuscar.Text != string.Empty)
            {
                datosBindingSource.Filter = string.Format("Nombre LIKE '*{0}*'", txtBuscar.Text);
                }
                else if (rbtnDireccion.Checked && txtBuscar.Text != string.Empty)
                {
                    datosBindingSource.Filter = string.Format("Direccion LIKE '*{0}*'", txtBuscar.Text);
                }
                else if (rbtnTelefono.Checked && txtBuscar.Text != string.Empty)
                {
                    datosBindingSource.Filter = string.Format("Telefono LIKE '*{0}*'", txtBuscar.Text);
                }
                else
                {
                    if (!rbtnNombre.Checked && !rbtnDireccion.Checked && !rbtnTelefono.Checked)
                        MessageBox.Show("Seleccione un radio button");
                    if (txtBuscar.Text == string.Empty)
                        MessageBox.Show("Escriba un texto de busqueda");
                }
            }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
        }

