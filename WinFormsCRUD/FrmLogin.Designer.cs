namespace WinFormsCRUD
{
    partial class FrmLogin
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
            txtCorreo = new TextBox();
            txtContraseña = new TextBox();
            btnIngresar = new Button();
            lblCaballos = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCorreo.Location = new Point(396, 127);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Ingrese Correo";
            txtCorreo.Size = new Size(208, 29);
            txtCorreo.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtContraseña.Location = new Point(396, 184);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.PlaceholderText = "Ingrese Contraseña";
            txtContraseña.Size = new Size(208, 29);
            txtContraseña.TabIndex = 1;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.White;
            btnIngresar.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.ForeColor = SystemColors.ControlText;
            btnIngresar.Location = new Point(294, 271);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(208, 37);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblCaballos
            // 
            lblCaballos.AutoSize = true;
            lblCaballos.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaballos.ForeColor = Color.LightCoral;
            lblCaballos.Location = new Point(245, 131);
            lblCaballos.Name = "lblCaballos";
            lblCaballos.Size = new Size(116, 25);
            lblCaballos.TabIndex = 11;
            lblCaballos.Text = "CORREO:";
            lblCaballos.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(216, 186);
            label1.Name = "label1";
            label1.Size = new Size(174, 25);
            label1.TabIndex = 12;
            label1.Text = "CONTRASEÑA:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblCaballos);
            Controls.Add(btnIngresar);
            Controls.Add(txtContraseña);
            Controls.Add(txtCorreo);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            FormClosing += FrmLogin_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCorreo;
        private TextBox txtContraseña;
        private Button btnIngresar;
        private Label lblCaballos;
        private Label label1;
    }
}