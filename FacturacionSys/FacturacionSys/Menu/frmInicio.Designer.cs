namespace FacturacionSys.Menu
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.btnModFacturacion = new System.Windows.Forms.Button();
            this.btnModInventario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnModFacturacion
            // 
            this.btnModFacturacion.BackColor = System.Drawing.Color.Teal;
            this.btnModFacturacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModFacturacion.BackgroundImage")));
            this.btnModFacturacion.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModFacturacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModFacturacion.Location = new System.Drawing.Point(40, 170);
            this.btnModFacturacion.Name = "btnModFacturacion";
            this.btnModFacturacion.Size = new System.Drawing.Size(207, 175);
            this.btnModFacturacion.TabIndex = 0;
            this.btnModFacturacion.UseVisualStyleBackColor = false;
            this.btnModFacturacion.Click += new System.EventHandler(this.btnModFacturacion_Click);
            // 
            // btnModInventario
            // 
            this.btnModInventario.BackColor = System.Drawing.Color.Teal;
            this.btnModInventario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModInventario.BackgroundImage")));
            this.btnModInventario.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModInventario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModInventario.Location = new System.Drawing.Point(360, 170);
            this.btnModInventario.Name = "btnModInventario";
            this.btnModInventario.Size = new System.Drawing.Size(207, 175);
            this.btnModInventario.TabIndex = 1;
            this.btnModInventario.UseVisualStyleBackColor = false;
            this.btnModInventario.Click += new System.EventHandler(this.btnModInventario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(216, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 74);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inicio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(632, 437);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModInventario);
            this.Controls.Add(this.btnModFacturacion);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModFacturacion;
        private System.Windows.Forms.Button btnModInventario;
        private System.Windows.Forms.Label label1;
    }
}