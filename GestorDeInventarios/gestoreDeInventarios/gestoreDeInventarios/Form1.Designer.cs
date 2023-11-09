namespace gestoreDeInventarios
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnInc = new Button();
            user = new TextBox();
            contra = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lbl = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnInc
            // 
            btnInc.Location = new Point(218, 192);
            btnInc.Name = "btnInc";
            btnInc.Size = new Size(121, 23);
            btnInc.TabIndex = 0;
            btnInc.Text = "Iniciar sesion";
            btnInc.UseVisualStyleBackColor = true;
            btnInc.Click += btnInc_Click;
            // 
            // user
            // 
            user.Location = new Point(218, 80);
            user.Name = "user";
            user.Size = new Size(121, 23);
            user.TabIndex = 1;
            // 
            // contra
            // 
            contra.Location = new Point(218, 145);
            contra.Name = "contra";
            contra.Size = new Size(121, 23);
            contra.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 51);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 116);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 4;
            label2.Text = "CONTRASEÑA";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(218, 231);
            lbl.Name = "lbl";
            lbl.Size = new Size(0, 15);
            lbl.TabIndex = 5;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(218, 280);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(121, 23);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(612, 315);
            Controls.Add(btnSalir);
            Controls.Add(lbl);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(contra);
            Controls.Add(user);
            Controls.Add(btnInc);
            Name = "Form1";
            Text = "Inicio de Sesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInc;
        private TextBox user;
        private TextBox contra;
        private Label label1;
        private Label label2;
        private Label lbl;
        private Button btnSalir;
    }
}