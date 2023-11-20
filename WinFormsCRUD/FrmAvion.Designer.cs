namespace WinFormsCRUD
{
    partial class FrmAvion
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
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtCantVentanas = new TextBox();
            txtModelo = new TextBox();
            txtCarga = new TextBox();
            txtVelocidad = new TextBox();
            txtCantPasajeros = new TextBox();
            lblCantVentanas = new Label();
            lblModelo = new Label();
            lblCarga = new Label();
            lblVelocidad = new Label();
            lblCantPasajeros = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = Color.Maroon;
            btnCancelar.Location = new Point(207, 349);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 37);
            btnCancelar.TabIndex = 34;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.ForeColor = Color.ForestGreen;
            btnAceptar.Location = new Point(67, 349);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(96, 37);
            btnAceptar.TabIndex = 33;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtCantVentanas
            // 
            txtCantVentanas.Location = new Point(37, 300);
            txtCantVentanas.Name = "txtCantVentanas";
            txtCantVentanas.Size = new Size(304, 23);
            txtCantVentanas.TabIndex = 32;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(37, 237);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(304, 23);
            txtModelo.TabIndex = 31;
            // 
            // txtCarga
            // 
            txtCarga.Location = new Point(37, 175);
            txtCarga.Name = "txtCarga";
            txtCarga.Size = new Size(304, 23);
            txtCarga.TabIndex = 30;
            // 
            // txtVelocidad
            // 
            txtVelocidad.Location = new Point(37, 113);
            txtVelocidad.Name = "txtVelocidad";
            txtVelocidad.Size = new Size(304, 23);
            txtVelocidad.TabIndex = 29;
            // 
            // txtCantPasajeros
            // 
            txtCantPasajeros.Location = new Point(37, 56);
            txtCantPasajeros.Name = "txtCantPasajeros";
            txtCantPasajeros.Size = new Size(304, 23);
            txtCantPasajeros.TabIndex = 28;
            // 
            // lblCantVentanas
            // 
            lblCantVentanas.AutoSize = true;
            lblCantVentanas.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantVentanas.ForeColor = Color.Maroon;
            lblCantVentanas.Location = new Point(37, 281);
            lblCantVentanas.Name = "lblCantVentanas";
            lblCantVentanas.Size = new Size(138, 16);
            lblCantVentanas.TabIndex = 27;
            lblCantVentanas.Text = "Cantidad de ventanas";
            lblCantVentanas.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblModelo.ForeColor = Color.Maroon;
            lblModelo.Location = new Point(37, 218);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(111, 16);
            lblModelo.TabIndex = 26;
            lblModelo.Text = "Modelo del avión";
            lblModelo.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCarga
            // 
            lblCarga.AutoSize = true;
            lblCarga.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCarga.ForeColor = Color.Maroon;
            lblCarga.Location = new Point(37, 156);
            lblCarga.Name = "lblCarga";
            lblCarga.Size = new Size(266, 16);
            lblCarga.TabIndex = 25;
            lblCarga.Text = "Carga (Liviana,Media,Pesada,MuyPesada)";
            lblCarga.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblVelocidad
            // 
            lblVelocidad.AutoSize = true;
            lblVelocidad.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblVelocidad.ForeColor = Color.Maroon;
            lblVelocidad.Location = new Point(37, 94);
            lblVelocidad.Name = "lblVelocidad";
            lblVelocidad.Size = new Size(257, 16);
            lblVelocidad.TabIndex = 24;
            lblVelocidad.Text = "Velocidad (Minima,Baja,Media,Alta,Hiper)";
            lblVelocidad.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCantPasajeros
            // 
            lblCantPasajeros.AutoSize = true;
            lblCantPasajeros.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantPasajeros.ForeColor = Color.Maroon;
            lblCantPasajeros.Location = new Point(37, 37);
            lblCantPasajeros.Name = "lblCantPasajeros";
            lblCantPasajeros.Size = new Size(144, 16);
            lblCantPasajeros.TabIndex = 23;
            lblCantPasajeros.Text = "Cantidad de pasajeros";
            lblCantPasajeros.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmAvion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 422);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtCantVentanas);
            Controls.Add(txtModelo);
            Controls.Add(txtCarga);
            Controls.Add(txtVelocidad);
            Controls.Add(txtCantPasajeros);
            Controls.Add(lblCantVentanas);
            Controls.Add(lblModelo);
            Controls.Add(lblCarga);
            Controls.Add(lblVelocidad);
            Controls.Add(lblCantPasajeros);
            Name = "FrmAvion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAvion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtCantVentanas;
        private TextBox txtModelo;
        private TextBox txtCarga;
        private TextBox txtVelocidad;
        private TextBox txtCantPasajeros;
        private Label lblCantVentanas;
        private Label lblModelo;
        private Label lblCarga;
        private Label lblVelocidad;
        private Label lblCantPasajeros;
    }
}