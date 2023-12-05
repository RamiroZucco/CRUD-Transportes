namespace WinFormsCRUD
{
    partial class FrmCaballo
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
            lblCantPasajeros = new Label();
            lblVelocidad = new Label();
            lblCarga = new Label();
            lblNombre = new Label();
            lblColor = new Label();
            txtCantPasajeros = new TextBox();
            txtVelocidad = new TextBox();
            txtCarga = new TextBox();
            txtNombre = new TextBox();
            txtColor = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblCantPasajeros
            // 
            lblCantPasajeros.AutoSize = true;
            lblCantPasajeros.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantPasajeros.ForeColor = Color.Maroon;
            lblCantPasajeros.Location = new Point(31, 48);
            lblCantPasajeros.Name = "lblCantPasajeros";
            lblCantPasajeros.Size = new Size(144, 16);
            lblCantPasajeros.TabIndex = 11;
            lblCantPasajeros.Text = "Cantidad de pasajeros";
            lblCantPasajeros.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblVelocidad
            // 
            lblVelocidad.AutoSize = true;
            lblVelocidad.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblVelocidad.ForeColor = Color.Maroon;
            lblVelocidad.Location = new Point(31, 105);
            lblVelocidad.Name = "lblVelocidad";
            lblVelocidad.Size = new Size(257, 16);
            lblVelocidad.TabIndex = 12;
            lblVelocidad.Text = "Velocidad (Minima,Baja,Media,Alta,Hiper)";
            lblVelocidad.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCarga
            // 
            lblCarga.AutoSize = true;
            lblCarga.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCarga.ForeColor = Color.Maroon;
            lblCarga.Location = new Point(31, 167);
            lblCarga.Name = "lblCarga";
            lblCarga.Size = new Size(266, 16);
            lblCarga.TabIndex = 13;
            lblCarga.Text = "Carga (Liviana,Media,Pesada,MuyPesada)";
            lblCarga.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.Maroon;
            lblNombre.Location = new Point(31, 229);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(126, 16);
            lblNombre.TabIndex = 14;
            lblNombre.Text = "Nombre del caballo";
            lblNombre.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblColor.ForeColor = Color.Maroon;
            lblColor.Location = new Point(31, 292);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(109, 16);
            lblColor.TabIndex = 15;
            lblColor.Text = "Color del caballo";
            lblColor.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtCantPasajeros
            // 
            txtCantPasajeros.Location = new Point(31, 67);
            txtCantPasajeros.Name = "txtCantPasajeros";
            txtCantPasajeros.Size = new Size(304, 23);
            txtCantPasajeros.TabIndex = 16;
            // 
            // txtVelocidad
            // 
            txtVelocidad.Location = new Point(31, 124);
            txtVelocidad.Name = "txtVelocidad";
            txtVelocidad.Size = new Size(304, 23);
            txtVelocidad.TabIndex = 17;
            // 
            // txtCarga
            // 
            txtCarga.Location = new Point(31, 186);
            txtCarga.Name = "txtCarga";
            txtCarga.Size = new Size(304, 23);
            txtCarga.TabIndex = 18;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(31, 248);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(304, 23);
            txtNombre.TabIndex = 19;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(31, 311);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(304, 23);
            txtColor.TabIndex = 20;
            // 
            // btnAceptar
            // 
            btnAceptar.ForeColor = Color.ForestGreen;
            btnAceptar.Location = new Point(61, 360);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(96, 37);
            btnAceptar.TabIndex = 21;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = Color.Maroon;
            btnCancelar.Location = new Point(201, 360);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 37);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmCaballo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 422);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtColor);
            Controls.Add(txtNombre);
            Controls.Add(txtCarga);
            Controls.Add(txtVelocidad);
            Controls.Add(txtCantPasajeros);
            Controls.Add(lblColor);
            Controls.Add(lblNombre);
            Controls.Add(lblCarga);
            Controls.Add(lblVelocidad);
            Controls.Add(lblCantPasajeros);
            Name = "FrmCaballo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caballo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCantPasajeros;
        private Label lblVelocidad;
        private Label lblCarga;
        private Label lblNombre;
        private Label lblColor;
        private TextBox txtCantPasajeros;
        private TextBox txtVelocidad;
        private TextBox txtCarga;
        private TextBox txtNombre;
        private TextBox txtColor;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}