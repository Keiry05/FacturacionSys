namespace FacturacionSys.Facturacion
{
    partial class Realizar_Pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Realizar_Pedido));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITBIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.nudDescuento = new System.Windows.Forms.Label();
            this.nudPrecioD = new System.Windows.Forms.NumericUpDown();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtItbis = new System.Windows.Forms.TextBox();
            this.txtDescripcionD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.nudPrecio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoD = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 456);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Del Pedido";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Cantidad,
            this.Precio,
            this.ITBIS,
            this.Descuento,
            this.Importe,
            this.Edit,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(13, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 150);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // ITBIS
            // 
            this.ITBIS.HeaderText = "ITBIS";
            this.ITBIS.Name = "ITBIS";
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown3);
            this.groupBox2.Controls.Add(this.nudDescuento);
            this.groupBox2.Controls.Add(this.nudPrecioD);
            this.groupBox2.Controls.Add(this.nudCantidad);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtItbis);
            this.groupBox2.Controls.Add(this.txtDescripcionD);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtImporte);
            this.groupBox2.Controls.Add(this.nudPrecio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCodigoD);
            this.groupBox2.Location = new System.Drawing.Point(13, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 156);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar productos";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(249, 71);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(100, 28);
            this.numericUpDown3.TabIndex = 16;
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
            // nudPrecioD
            // 
            this.nudPrecioD.Location = new System.Drawing.Point(84, 107);
            this.nudPrecioD.Name = "nudPrecioD";
            this.nudPrecioD.Size = new System.Drawing.Size(100, 28);
            this.nudPrecioD.TabIndex = 14;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(84, 70);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(100, 28);
            this.nudCantidad.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(541, 75);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 34);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(541, 35);
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
            // txtItbis
            // 
            this.txtItbis.Location = new System.Drawing.Point(430, 72);
            this.txtItbis.Name = "txtItbis";
            this.txtItbis.Size = new System.Drawing.Size(100, 28);
            this.txtItbis.TabIndex = 9;
            // 
            // txtDescripcionD
            // 
            this.txtDescripcionD.Location = new System.Drawing.Point(195, 37);
            this.txtDescripcionD.Name = "txtDescripcionD";
            this.txtDescripcionD.Size = new System.Drawing.Size(335, 28);
            this.txtDescripcionD.TabIndex = 8;
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
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(430, 106);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(100, 28);
            this.txtImporte.TabIndex = 6;
            this.txtImporte.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código";
            // 
            // txtCodigoD
            // 
            this.txtCodigoD.Location = new System.Drawing.Point(84, 37);
            this.txtCodigoD.Name = "txtCodigoD";
            this.txtCodigoD.Size = new System.Drawing.Size(100, 28);
            this.txtCodigoD.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Items.AddRange(new object[] {
            "",
            "Crédito",
            "Contado"});
            this.listBox1.Location = new System.Drawing.Point(183, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 26);
            this.listBox1.TabIndex = 36;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(183, 105);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(254, 28);
            this.dateTimePicker2.TabIndex = 35;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(183, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(254, 28);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(9, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 22);
            this.label9.TabIndex = 22;
            this.label9.Text = "Fecha De Compromiso";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(15, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 22);
            this.label11.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(107, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(96, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(230, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Guardar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Realizar_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(733, 547);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Realizar_Pedido";
            this.Text = "Realizar_Pedido";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDescripcionD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label nudPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown nudPrecioD;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtItbis;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label nudDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITBIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}