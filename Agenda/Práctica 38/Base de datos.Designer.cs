namespace Práctica_38
{
    partial class Base_de_datos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dIRECTORIODataSet = new Práctica_38.DIRECTORIODataSet();
            this.datosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datosTableAdapter = new Práctica_38.DIRECTORIODataSetTableAdapters.DatosTableAdapter();
            this.tableAdapterManager = new Práctica_38.DIRECTORIODataSetTableAdapters.TableAdapterManager();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.rbtnDireccion = new System.Windows.Forms.RadioButton();
            this.rbtnTelefono = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dIRECTORIODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dIRECTORIODataSet
            // 
            this.dIRECTORIODataSet.DataSetName = "DIRECTORIODataSet";
            this.dIRECTORIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // datosBindingSource
            // 
            this.datosBindingSource.DataMember = "Datos";
            this.datosBindingSource.DataSource = this.dIRECTORIODataSet;
            // 
            // datosTableAdapter
            // 
            this.datosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DatosTableAdapter = this.datosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Práctica_38.DIRECTORIODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DataGridView
            // 
            this.DataGridView.AutoGenerateColumns = false;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.DataGridView.DataSource = this.datosBindingSource;
            this.DataGridView.Location = new System.Drawing.Point(57, 161);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.Size = new System.Drawing.Size(442, 204);
            this.DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Dirección";
            this.dataGridViewTextBoxColumn3.HeaderText = "Dirección";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Teléfono";
            this.dataGridViewTextBoxColumn4.HeaderText = "Teléfono";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Location = new System.Drawing.Point(81, 29);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(62, 17);
            this.rbtnNombre.TabIndex = 2;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // rbtnDireccion
            // 
            this.rbtnDireccion.AutoSize = true;
            this.rbtnDireccion.Location = new System.Drawing.Point(221, 29);
            this.rbtnDireccion.Name = "rbtnDireccion";
            this.rbtnDireccion.Size = new System.Drawing.Size(73, 17);
            this.rbtnDireccion.TabIndex = 3;
            this.rbtnDireccion.TabStop = true;
            this.rbtnDireccion.Text = "Dirección ";
            this.rbtnDireccion.UseVisualStyleBackColor = true;
            // 
            // rbtnTelefono
            // 
            this.rbtnTelefono.AutoSize = true;
            this.rbtnTelefono.Location = new System.Drawing.Point(372, 29);
            this.rbtnTelefono.Name = "rbtnTelefono";
            this.rbtnTelefono.Size = new System.Drawing.Size(67, 17);
            this.rbtnTelefono.TabIndex = 4;
            this.rbtnTelefono.TabStop = true;
            this.rbtnTelefono.Text = "Teléfono";
            this.rbtnTelefono.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(81, 70);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(359, 20);
            this.txtBuscar.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(318, 111);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(102, 34);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Base_de_datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(572, 405);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.rbtnTelefono);
            this.Controls.Add(this.rbtnDireccion);
            this.Controls.Add(this.rbtnNombre);
            this.Controls.Add(this.DataGridView);
            this.Name = "Base_de_datos";
            this.Text = "Base de datos";
            this.Load += new System.EventHandler(this.Base_de_datos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dIRECTORIODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DIRECTORIODataSet dIRECTORIODataSet;
        private System.Windows.Forms.BindingSource datosBindingSource;
        private DIRECTORIODataSetTableAdapters.DatosTableAdapter datosTableAdapter;
        private DIRECTORIODataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.RadioButton rbtnNombre;
        private System.Windows.Forms.RadioButton rbtnDireccion;
        private System.Windows.Forms.RadioButton rbtnTelefono;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRegresar;
    }
}