namespace gestoreDeInventarios
{
    partial class Agregar
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
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtMar = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCan = new System.Windows.Forms.TextBox();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.btnAgr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(73, 43);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(131, 23);
            this.txtCod.TabIndex = 0;
            // 
            // txtMar
            // 
            this.txtMar.Location = new System.Drawing.Point(284, 43);
            this.txtMar.Name = "txtMar";
            this.txtMar.Size = new System.Drawing.Size(131, 23);
            this.txtMar.TabIndex = 1;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(483, 43);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(131, 23);
            this.txtNom.TabIndex = 2;
            // 
            // txtCan
            // 
            this.txtCan.Location = new System.Drawing.Point(73, 92);
            this.txtCan.Name = "txtCan";
            this.txtCan.Size = new System.Drawing.Size(131, 23);
            this.txtCan.TabIndex = 3;
            // 
            // txtPre
            // 
            this.txtPre.Location = new System.Drawing.Point(483, 92);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(131, 23);
            this.txtPre.TabIndex = 5;
            // 
            // btnAgr
            // 
            this.btnAgr.Location = new System.Drawing.Point(284, 92);
            this.btnAgr.Name = "btnAgr";
            this.btnAgr.Size = new System.Drawing.Size(131, 23);
            this.btnAgr.TabIndex = 6;
            this.btnAgr.Text = "Agregar";
            this.btnAgr.UseVisualStyleBackColor = true;
            this.btnAgr.Click += new System.EventHandler(this.btnAgr_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Marca";
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(284, 197);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(131, 23);
            this.btnAtras.TabIndex = 12;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click_1);
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(676, 268);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgr);
            this.Controls.Add(this.txtPre);
            this.Controls.Add(this.txtCan);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtMar);
            this.Controls.Add(this.txtCod);
            this.Name = "Agregar";
            this.Text = "Agregar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCod;
        private TextBox txtMar;
        private TextBox txtNom;
        private TextBox txtCan;
        private TextBox txtPre;
        private Button btnAgr;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAtras;
    }
}