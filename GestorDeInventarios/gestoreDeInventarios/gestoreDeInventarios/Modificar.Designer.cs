namespace gestoreDeInventarios
{
    partial class Modificar
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblMar = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCan = new System.Windows.Forms.Label();
            this.lblPre = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtMar = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCan = new System.Windows.Forms.TextBox();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(531, 190);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(160, 30);
            this.btnAtras.TabIndex = 1;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datos a modificar:";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(76, 72);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(38, 15);
            this.lblCod.TabIndex = 3;
            this.lblCod.Text = "label2";
            // 
            // lblMar
            // 
            this.lblMar.AutoSize = true;
            this.lblMar.Location = new System.Drawing.Point(76, 110);
            this.lblMar.Name = "lblMar";
            this.lblMar.Size = new System.Drawing.Size(38, 15);
            this.lblMar.TabIndex = 4;
            this.lblMar.Text = "label3";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(76, 147);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(38, 15);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "label4";
            // 
            // lblCan
            // 
            this.lblCan.AutoSize = true;
            this.lblCan.Location = new System.Drawing.Point(76, 187);
            this.lblCan.Name = "lblCan";
            this.lblCan.Size = new System.Drawing.Size(38, 15);
            this.lblCan.TabIndex = 6;
            this.lblCan.Text = "label5";
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Location = new System.Drawing.Point(76, 225);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(38, 15);
            this.lblPre.TabIndex = 7;
            this.lblPre.Text = "label6";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(249, 72);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(142, 23);
            this.txtCod.TabIndex = 8;
            // 
            // txtMar
            // 
            this.txtMar.Location = new System.Drawing.Point(249, 110);
            this.txtMar.Name = "txtMar";
            this.txtMar.Size = new System.Drawing.Size(142, 23);
            this.txtMar.TabIndex = 9;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(249, 147);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(142, 23);
            this.txtNom.TabIndex = 10;
            // 
            // txtCan
            // 
            this.txtCan.Location = new System.Drawing.Point(249, 184);
            this.txtCan.Name = "txtCan";
            this.txtCan.Size = new System.Drawing.Size(142, 23);
            this.txtCan.TabIndex = 11;
            // 
            // txtPre
            // 
            this.txtPre.Location = new System.Drawing.Point(249, 222);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(142, 23);
            this.txtPre.TabIndex = 12;
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(744, 285);
            this.Controls.Add(this.txtPre);
            this.Controls.Add(this.txtCan);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtMar);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblPre);
            this.Controls.Add(this.lblCan);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblMar);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.button1);
            this.Name = "Modificar";
            this.Text = "Modificar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button btnAtras;
        private Label label1;
        private Label lblCod;
        private Label lblMar;
        private Label lblNom;
        private Label lblCan;
        private Label lblPre;
        private TextBox txtCod;
        private TextBox txtMar;
        private TextBox txtNom;
        private TextBox txtCan;
        private TextBox txtPre;
    }
}