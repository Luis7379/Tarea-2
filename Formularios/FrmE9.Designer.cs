namespace Tarea2.Formularios
{
    partial class FrmE9
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
            this.lstproducto = new System.Windows.Forms.ListBox();
            this.lstprecio = new System.Windows.Forms.ListBox();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // lstproducto
            // 
            this.lstproducto.FormattingEnabled = true;
            this.lstproducto.Location = new System.Drawing.Point(35, 164);
            this.lstproducto.Name = "lstproducto";
            this.lstproducto.Size = new System.Drawing.Size(120, 95);
            this.lstproducto.TabIndex = 2;
            // 
            // lstprecio
            // 
            this.lstprecio.FormattingEnabled = true;
            this.lstprecio.Location = new System.Drawing.Point(171, 164);
            this.lstprecio.Name = "lstprecio";
            this.lstprecio.Size = new System.Drawing.Size(55, 95);
            this.lstprecio.TabIndex = 3;
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(73, 34);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(100, 20);
            this.txtproducto.TabIndex = 4;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(244, 34);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 20);
            this.txtprecio.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Producto";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(168, 148);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(37, 13);
            this.l.TabIndex = 7;
            this.l.Text = "Precio";
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(361, 32);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 8;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(244, 198);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 9;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(361, 200);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 10;
            // 
            // FrmE9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.l);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.lstprecio);
            this.Controls.Add(this.lstproducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmE9";
            this.Text = "FrmE9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstproducto;
        private System.Windows.Forms.ListBox lstprecio;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txttotal;
    }
}