namespace WinFormsCRUD
{
    partial class FrmAuto
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
            txtPuertas = new TextBox();
            txtPatente = new TextBox();
            txtCantPasajeros = new TextBox();
            lblCantPuertas = new Label();
            lblPatente = new Label();
            lblCarga = new Label();
            lblVelocidad = new Label();
            lblCantPasajeros = new Label();
            cmBoxVelocidad = new ComboBox();
            cmBoxCarga = new ComboBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = Color.Maroon;
            btnCancelar.Location = new Point(207, 351);
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
            btnAceptar.Location = new Point(69, 351);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(96, 37);
            btnAceptar.TabIndex = 33;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtPuertas
            // 
            txtPuertas.Location = new Point(37, 295);
            txtPuertas.Name = "txtPuertas";
            txtPuertas.Size = new Size(304, 23);
            txtPuertas.TabIndex = 32;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(37, 235);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(304, 23);
            txtPatente.TabIndex = 31;
            // 
            // txtCantPasajeros
            // 
            txtCantPasajeros.Location = new Point(37, 52);
            txtCantPasajeros.Name = "txtCantPasajeros";
            txtCantPasajeros.Size = new Size(304, 23);
            txtCantPasajeros.TabIndex = 28;
            // 
            // lblCantPuertas
            // 
            lblCantPuertas.AutoSize = true;
            lblCantPuertas.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantPuertas.ForeColor = Color.Maroon;
            lblCantPuertas.Location = new Point(37, 276);
            lblCantPuertas.Name = "lblCantPuertas";
            lblCantPuertas.Size = new Size(128, 16);
            lblCantPuertas.TabIndex = 27;
            lblCantPuertas.Text = "Cantidad de puertas";
            lblCantPuertas.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPatente.ForeColor = Color.Maroon;
            lblPatente.Location = new Point(37, 216);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(198, 16);
            lblPatente.TabIndex = 26;
            lblPatente.Text = "Últimos 3 números de la patente";
            lblPatente.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCarga
            // 
            lblCarga.AutoSize = true;
            lblCarga.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCarga.ForeColor = Color.Maroon;
            lblCarga.Location = new Point(37, 155);
            lblCarga.Name = "lblCarga";
            lblCarga.Size = new Size(44, 16);
            lblCarga.TabIndex = 25;
            lblCarga.Text = "Carga";
            lblCarga.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblVelocidad
            // 
            lblVelocidad.AutoSize = true;
            lblVelocidad.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblVelocidad.ForeColor = Color.Maroon;
            lblVelocidad.Location = new Point(37, 92);
            lblVelocidad.Name = "lblVelocidad";
            lblVelocidad.Size = new Size(69, 16);
            lblVelocidad.TabIndex = 24;
            lblVelocidad.Text = "Velocidad";
            lblVelocidad.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCantPasajeros
            // 
            lblCantPasajeros.AutoSize = true;
            lblCantPasajeros.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantPasajeros.ForeColor = Color.Maroon;
            lblCantPasajeros.Location = new Point(37, 33);
            lblCantPasajeros.Name = "lblCantPasajeros";
            lblCantPasajeros.Size = new Size(144, 16);
            lblCantPasajeros.TabIndex = 23;
            lblCantPasajeros.Text = "Cantidad de pasajeros";
            lblCantPasajeros.TextAlign = ContentAlignment.TopCenter;
            // 
            // cmBoxVelocidad
            // 
            cmBoxVelocidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmBoxVelocidad.FormattingEnabled = true;
            cmBoxVelocidad.Items.AddRange(new object[] { "MINIMA", "BAJA", "MEDIA", "ALTA", "HIPER" });
            cmBoxVelocidad.Location = new Point(37, 111);
            cmBoxVelocidad.Name = "cmBoxVelocidad";
            cmBoxVelocidad.Size = new Size(163, 23);
            cmBoxVelocidad.TabIndex = 36;
            // 
            // cmBoxCarga
            // 
            cmBoxCarga.DropDownStyle = ComboBoxStyle.DropDownList;
            cmBoxCarga.FormattingEnabled = true;
            cmBoxCarga.Items.AddRange(new object[] { "LIVIANA", "MEDIA", "PESADA", "MUYPESADA" });
            cmBoxCarga.Location = new Point(37, 174);
            cmBoxCarga.Name = "cmBoxCarga";
            cmBoxCarga.Size = new Size(163, 23);
            cmBoxCarga.TabIndex = 37;
            // 
            // FrmAuto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 422);
            Controls.Add(cmBoxCarga);
            Controls.Add(cmBoxVelocidad);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtPuertas);
            Controls.Add(txtPatente);
            Controls.Add(txtCantPasajeros);
            Controls.Add(lblCantPuertas);
            Controls.Add(lblPatente);
            Controls.Add(lblCarga);
            Controls.Add(lblVelocidad);
            Controls.Add(lblCantPasajeros);
            Name = "FrmAuto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtPuertas;
        private TextBox txtPatente;
        private TextBox txtCantPasajeros;
        private Label lblCantPuertas;
        private Label lblPatente;
        private Label lblCarga;
        private Label lblVelocidad;
        private Label lblCantPasajeros;
        private ComboBox cmBoxVelocidad;
        private ComboBox cmBoxCarga;
    }
}