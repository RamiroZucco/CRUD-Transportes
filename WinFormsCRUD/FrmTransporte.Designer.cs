namespace WinFormsCRUD
{
    partial class FrmTransporte
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
            btnAgregarCaballo = new Button();
            lblTituloTransporte = new Label();
            btnAgregarAuto = new Button();
            btnAgregarAvion = new Button();
            SuspendLayout();
            // 
            // btnAgregarCaballo
            // 
            btnAgregarCaballo.BackColor = Color.LightCoral;
            btnAgregarCaballo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarCaballo.Location = new Point(82, 80);
            btnAgregarCaballo.Margin = new Padding(2);
            btnAgregarCaballo.Name = "btnAgregarCaballo";
            btnAgregarCaballo.Size = new Size(100, 30);
            btnAgregarCaballo.TabIndex = 5;
            btnAgregarCaballo.Text = "Caballo";
            btnAgregarCaballo.UseVisualStyleBackColor = false;
            btnAgregarCaballo.Click += btnAgregarCaballo_Click;
            // 
            // lblTituloTransporte
            // 
            lblTituloTransporte.AutoSize = true;
            lblTituloTransporte.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTituloTransporte.ForeColor = SystemColors.ControlText;
            lblTituloTransporte.Location = new Point(12, 29);
            lblTituloTransporte.Name = "lblTituloTransporte";
            lblTituloTransporte.Size = new Size(252, 19);
            lblTituloTransporte.TabIndex = 6;
            lblTituloTransporte.Text = "QUE TRANSPORTE DESEA AGREGAR?";
            lblTituloTransporte.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAgregarAuto
            // 
            btnAgregarAuto.BackColor = Color.LightCoral;
            btnAgregarAuto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarAuto.Location = new Point(82, 128);
            btnAgregarAuto.Margin = new Padding(2);
            btnAgregarAuto.Name = "btnAgregarAuto";
            btnAgregarAuto.Size = new Size(100, 30);
            btnAgregarAuto.TabIndex = 7;
            btnAgregarAuto.Text = "Auto";
            btnAgregarAuto.UseVisualStyleBackColor = false;
            btnAgregarAuto.Click += btnAgregarAuto_Click;
            // 
            // btnAgregarAvion
            // 
            btnAgregarAvion.BackColor = Color.LightCoral;
            btnAgregarAvion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarAvion.Location = new Point(82, 181);
            btnAgregarAvion.Margin = new Padding(2);
            btnAgregarAvion.Name = "btnAgregarAvion";
            btnAgregarAvion.Size = new Size(100, 30);
            btnAgregarAvion.TabIndex = 8;
            btnAgregarAvion.Text = "Avion";
            btnAgregarAvion.UseVisualStyleBackColor = false;
            btnAgregarAvion.Click += btnAgregarAvion_Click;
            // 
            // FrmTransporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 257);
            Controls.Add(btnAgregarAvion);
            Controls.Add(btnAgregarAuto);
            Controls.Add(lblTituloTransporte);
            Controls.Add(btnAgregarCaballo);
            Name = "FrmTransporte";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transporte";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarCaballo;
        private Label lblTituloTransporte;
        private Button btnAgregarAuto;
        private Button btnAgregarAvion;
    }
}