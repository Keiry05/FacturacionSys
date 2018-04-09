namespace FacturacionSys.Facturacion
{
    partial class Realizar_Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Realizar_Factura));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridproducto = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtImporte = new System.Windows.Forms.NumericUpDown();
            this.txtItbis = new System.Windows.Forms.NumericUpDown();
            this.numdescuento = new System.Windows.Forms.NumericUpDown();
            this.nudDescuento = new System.Windows.Forms.Label();
            this.numprecio = new System.Windows.Forms.NumericUpDown();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudPrecio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoD = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridproducto)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItbis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numprecio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboClientes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtOrden);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 141);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(149, 66);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(206, 30);
            this.cboClientes.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de Orden";
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(149, 30);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(99, 28);
            this.txtOrden.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 48;
            this.label3.Text = "Cliente";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(435, 28);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(254, 28);
            this.dtpFecha.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(645, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 67);
            this.button1.TabIndex = 8;
            this.button1.Text = "Emitir factura";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(15, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 22);
            this.label11.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(377, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.dataGridproducto);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 439);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.CadetBlue;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(273, 358);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 43);
            this.button5.TabIndex = 43;
            this.button5.Text = "Guardar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // dataGridproducto
            // 
            this.dataGridproducto.AllowUserToAddRows = false;
            this.dataGridproducto.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridproducto.Location = new System.Drawing.Point(11, 189);
            this.dataGridproducto.Name = "dataGridproducto";
            this.dataGridproducto.Size = new System.Drawing.Size(694, 150);
            this.dataGridproducto.TabIndex = 42;
            this.dataGridproducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridproducto_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtImporte);
            this.groupBox3.Controls.Add(this.txtItbis);
            this.groupBox3.Controls.Add(this.numdescuento);
            this.groupBox3.Controls.Add(this.nudDescuento);
            this.groupBox3.Controls.Add(this.numprecio);
            this.groupBox3.Controls.Add(this.nudCantidad);
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtdescripcion);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.nudPrecio);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtCodigoD);
            this.groupBox3.Location = new System.Drawing.Point(11, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(694, 158);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Editar productos";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(431, 105);
            this.txtImporte.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(99, 28);
            this.txtImporte.TabIndex = 20;
            // 
            // txtItbis
            // 
            this.txtItbis.Location = new System.Drawing.Point(430, 70);
            this.txtItbis.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtItbis.Name = "txtItbis";
            this.txtItbis.Size = new System.Drawing.Size(99, 28);
            this.txtItbis.TabIndex = 19;
            // 
            // numdescuento
            // 
            this.numdescuento.Location = new System.Drawing.Point(249, 71);
            this.numdescuento.Name = "numdescuento";
            this.numdescuento.Size = new System.Drawing.Size(100, 28);
            this.numdescuento.TabIndex = 16;
            this.numdescuento.ValueChanged += new System.EventHandler(this.numdescuento_ValueChanged);
            // 
            // nudDescuento
            // 
            this.nudDescuento.AutoSize = true;
            this.nudDescuento.Location = new System.Drawing.Point(191, 73);
            this.nudDescuento.Name = "nudDescuento";
            this.nudDescuento.Size = new System.Drawing.Size(44, 22);
            this.nudDescuento.TabIndex = 15;
            this.nudDescuento.Text = "Desc";
            // 
            // numprecio
            // 
            this.numprecio.Location = new System.Drawing.Point(84, 107);
            this.numprecio.Name = "numprecio";
            this.numprecio.Size = new System.Drawing.Size(100, 28);
            this.numprecio.TabIndex = 14;
            this.numprecio.ValueChanged += new System.EventHandler(this.numprecio_ValueChanged);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(84, 70);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(100, 28);
            this.nudCantidad.TabIndex = 13;
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(579, 92);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 34);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(579, 56);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 30);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "ITBIS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(195, 37);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(335, 28);
            this.txtdescripcion.TabIndex = 8;
            this.txtdescripcion.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Importe";
            // 
            // nudPrecio
            // 
            this.nudPrecio.AutoSize = true;
            this.nudPrecio.Location = new System.Drawing.Point(25, 109);
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(53, 22);
            this.nudPrecio.TabIndex = 5;
            this.nudPrecio.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "Código";
            // 
            // txtCodigoD
            // 
            this.txtCodigoD.Location = new System.Drawing.Point(84, 37);
            this.txtCodigoD.Name = "txtCodigoD";
            this.txtCodigoD.Size = new System.Drawing.Size(100, 28);
            this.txtCodigoD.TabIndex = 0;
            // 
            // Realizar_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(730, 576);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Realizar_Factura";
            this.Text = "Realizar_Factura";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridproducto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtImporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItbis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numprecio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numdescuento;
        private System.Windows.Forms.Label nudDescuento;
        private System.Windows.Forms.NumericUpDown numprecio;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label nudPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoD;
        private System.Windows.Forms.DataGridView dataGridproducto;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.NumericUpDown txtItbis;
        private System.Windows.Forms.NumericUpDown txtImporte;
    }
}