namespace WinFormsCRUD
{
    partial class FrmUsuariosRegistrados
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
            lstLog = new ListBox();
            lblRegistro = new Label();
            SuspendLayout();
            // 
            // lstLog
            // 
            lstLog.FormattingEnabled = true;
            lstLog.ItemHeight = 15;
            lstLog.Location = new Point(38, 54);
            lstLog.Name = "lstLog";
            lstLog.Size = new Size(431, 424);
            lstLog.TabIndex = 0;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistro.ForeColor = Color.Maroon;
            lblRegistro.Location = new Point(176, 21);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(165, 18);
            lblRegistro.TabIndex = 13;
            lblRegistro.Text = "Registro de usuarios";
            lblRegistro.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmUsuariosRegistrados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 514);
            Controls.Add(lblRegistro);
            Controls.Add(lstLog);
            Name = "FrmUsuariosRegistrados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUsuariosRegistrados";
            Load += FrmUsuariosRegistrados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstLog;
        private Label lblRegistro;
    }
}