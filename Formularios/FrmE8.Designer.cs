namespace Tarea2.Formularios
{
    partial class FrmE8
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstnombre = new System.Windows.Forms.ListBox();
            this.lstnota = new System.Windows.Forms.ListBox();
            this.lstobservacion = new System.Windows.Forms.ListBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notas de alumnos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nota";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Aprobado/Reprobado";
            // 
            // lstnombre
            // 
            this.lstnombre.FormattingEnabled = true;
            this.lstnombre.Location = new System.Drawing.Point(52, 215);
            this.lstnombre.Name = "lstnombre";
            this.lstnombre.Size = new System.Drawing.Size(120, 95);
            this.lstnombre.TabIndex = 6;
            // 
            // lstnota
            // 
            this.lstnota.FormattingEnabled = true;
            this.lstnota.Location = new System.Drawing.Point(178, 215);
            this.lstnota.Name = "lstnota";
            this.lstnota.Size = new System.Drawing.Size(120, 95);
            this.lstnota.TabIndex = 7;
            // 
            // lstobservacion
            // 
            this.lstobservacion.FormattingEnabled = true;
            this.lstobservacion.Location = new System.Drawing.Point(305, 215);
            this.lstobservacion.Name = "lstobservacion";
            this.lstobservacion.Size = new System.Drawing.Size(120, 95);
            this.lstobservacion.TabIndex = 8;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(99, 50);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 9;
            // 
            // txtnota
            // 
            this.txtnota.Location = new System.Drawing.Point(261, 51);
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(100, 20);
            this.txtnota.TabIndex = 10;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(386, 51);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 11;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // FrmE8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtnota);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.lstobservacion);
            this.Controls.Add(this.lstnota);
            this.Controls.Add(this.lstnombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmE8";
            this.Text = "FrmE8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstnombre;
        private System.Windows.Forms.ListBox lstnota;
        private System.Windows.Forms.ListBox lstobservacion;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtnota;
        private System.Windows.Forms.Button btnagregar;
    }
}