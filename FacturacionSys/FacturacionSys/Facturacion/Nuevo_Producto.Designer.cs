namespace FacturacionSys.Facturacion
{
    partial class Nuevo_Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nuevo_Producto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.precio = new System.Windows.Forms.NumericUpDown();
            this.costo = new System.Windows.Forms.NumericUpDown();
            this.FechaInclucion = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.fechamodificacion = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.txtreferencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.precio);
            this.groupBox1.Controls.Add(this.costo);
            this.groupBox1.Controls.Add(this.FechaInclucion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.fechamodificacion);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtreferencia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 363);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Del Producto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(221, 132);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(120, 26);
            this.precio.TabIndex = 21;
            // 
            // costo
            // 
            this.costo.Location = new System.Drawing.Point(221, 99);
            this.costo.Name = "costo";
            this.costo.Size = new System.Drawing.Size(120, 26);
            this.costo.TabIndex = 20;
            // 
            // FechaInclucion
            // 
            this.FechaInclucion.Location = new System.Drawing.Point(221, 167);
            this.FechaInclucion.Name = "FechaInclucion";
            this.FechaInclucion.Size = new System.Drawing.Size(339, 26);
            this.FechaInclucion.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(15, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Fecha de Inclución";
            // 
            // fechamodificacion
            // 
            this.fechamodificacion.Location = new System.Drawing.Point(221, 199);
            this.fechamodificacion.Name = "fechamodificacion";
            this.fechamodificacion.Size = new System.Drawing.Size(339, 26);
            this.fechamodificacion.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(290, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 66);
            this.button1.TabIndex = 8;
            this.button1.Text = "Guardar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtreferencia
            // 
            this.txtreferencia.Location = new System.Drawing.Point(221, 35);
            this.txtreferencia.Name = "txtreferencia";
            this.txtreferencia.Size = new System.Drawing.Size(339, 26);
            this.txtreferencia.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(16, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Precio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(15, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 19);
            this.label11.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(221, 67);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(339, 26);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(16, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Costo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(15, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Modificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Referencia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(15, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripción Producto";
            // 
            // Nuevo_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(706, 364);
            this.Controls.Add(this.groupBox1);
            this.Name = "Nuevo_Producto";
            this.Text = "Nuevo_Producto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtreferencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker FechaInclucion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker fechamodificacion;
        private System.Windows.Forms.NumericUpDown precio;
        private System.Windows.Forms.NumericUpDown costo;
    }
}