namespace WinFormsCRUD
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            lblTitulo = new Label();
            lstVisorCaballos = new ListBox();
            lstVisorAutos = new ListBox();
            lstVisorAviones = new ListBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            lblAgregar = new Label();
            lblModificar = new Label();
            label3 = new Label();
            lblCaballos = new Label();
            lblAutos = new Label();
            label4 = new Label();
            picCaballo = new PictureBox();
            picAuto = new PictureBox();
            picAviones = new PictureBox();
            lblOrdenar = new Label();
            btnMasPasajeros = new Button();
            btnMenosPasajeros = new Button();
            btnMasVeloz = new Button();
            button2 = new Button();
            btnUsuariosRegistrados = new Button();
            btnCargarCaballos = new Button();
            btnGuardarCaballos = new Button();
            btnCargarAutos = new Button();
            btnGuardarAutos = new Button();
            btnCargarAviones = new Button();
            btnGuardarAviones = new Button();
            ((System.ComponentModel.ISupportInitialize)picCaballo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAuto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAviones).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(511, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(455, 33);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "TRANSPORTES DISPONIBLES";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // lstVisorCaballos
            // 
            lstVisorCaballos.FormattingEnabled = true;
            lstVisorCaballos.ItemHeight = 15;
            lstVisorCaballos.Location = new Point(248, 120);
            lstVisorCaballos.Name = "lstVisorCaballos";
            lstVisorCaballos.Size = new Size(751, 124);
            lstVisorCaballos.TabIndex = 1;
            // 
            // lstVisorAutos
            // 
            lstVisorAutos.FormattingEnabled = true;
            lstVisorAutos.ItemHeight = 15;
            lstVisorAutos.Location = new Point(248, 268);
            lstVisorAutos.Name = "lstVisorAutos";
            lstVisorAutos.Size = new Size(751, 124);
            lstVisorAutos.TabIndex = 2;
            // 
            // lstVisorAviones
            // 
            lstVisorAviones.FormattingEnabled = true;
            lstVisorAviones.ItemHeight = 15;
            lstVisorAviones.Location = new Point(248, 418);
            lstVisorAviones.Name = "lstVisorAviones";
            lstVisorAviones.Size = new Size(751, 124);
            lstVisorAviones.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.LightCoral;
            btnAgregar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(64, 255);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 30);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            btnAgregar.MouseEnter += btnAgregar_MouseEnter;
            btnAgregar.MouseLeave += btnAgregar_MouseLeave;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.LightCoral;
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = SystemColors.ControlText;
            btnEliminar.Location = new Point(64, 407);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 32);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            btnEliminar.MouseEnter += btnEliminar_MouseEnter;
            btnEliminar.MouseLeave += btnEliminar_MouseLeave;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.LightCoral;
            btnModificar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(64, 328);
            btnModificar.Margin = new Padding(2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 32);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            btnModificar.MouseEnter += btnModificar_MouseEnter;
            btnModificar.MouseLeave += btnModificar_MouseLeave;
            // 
            // lblAgregar
            // 
            lblAgregar.AutoSize = true;
            lblAgregar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAgregar.ForeColor = SystemColors.ControlText;
            lblAgregar.Location = new Point(46, 226);
            lblAgregar.Name = "lblAgregar";
            lblAgregar.Size = new Size(153, 18);
            lblAgregar.TabIndex = 7;
            lblAgregar.Text = "Agregar Transporte";
            lblAgregar.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblModificar
            // 
            lblModificar.AutoSize = true;
            lblModificar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblModificar.ForeColor = SystemColors.ControlText;
            lblModificar.Location = new Point(34, 298);
            lblModificar.Name = "lblModificar";
            lblModificar.Size = new Size(165, 18);
            lblModificar.TabIndex = 8;
            lblModificar.Text = "Modificar Transporte";
            lblModificar.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(34, 375);
            label3.Name = "label3";
            label3.Size = new Size(156, 18);
            label3.TabIndex = 9;
            label3.Text = "Eliminar Transporte";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblCaballos
            // 
            lblCaballos.AutoSize = true;
            lblCaballos.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCaballos.ForeColor = Color.Maroon;
            lblCaballos.Location = new Point(925, 99);
            lblCaballos.Name = "lblCaballos";
            lblCaballos.Size = new Size(74, 18);
            lblCaballos.TabIndex = 10;
            lblCaballos.Text = "Caballos";
            lblCaballos.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblAutos
            // 
            lblAutos.AutoSize = true;
            lblAutos.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAutos.ForeColor = Color.Maroon;
            lblAutos.Location = new Point(948, 247);
            lblAutos.Name = "lblAutos";
            lblAutos.Size = new Size(51, 18);
            lblAutos.TabIndex = 11;
            lblAutos.Text = "Autos";
            lblAutos.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(932, 397);
            label4.Name = "label4";
            label4.Size = new Size(67, 18);
            label4.TabIndex = 12;
            label4.Text = "Aviones";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // picCaballo
            // 
            picCaballo.Image = Properties.Resources.pngegg__1_;
            picCaballo.Location = new Point(1031, 120);
            picCaballo.Name = "picCaballo";
            picCaballo.Size = new Size(136, 90);
            picCaballo.SizeMode = PictureBoxSizeMode.StretchImage;
            picCaballo.TabIndex = 13;
            picCaballo.TabStop = false;
            // 
            // picAuto
            // 
            picAuto.Image = Properties.Resources.png_car_3031752_1280;
            picAuto.Location = new Point(1031, 286);
            picAuto.Name = "picAuto";
            picAuto.Size = new Size(151, 95);
            picAuto.SizeMode = PictureBoxSizeMode.StretchImage;
            picAuto.TabIndex = 14;
            picAuto.TabStop = false;
            // 
            // picAviones
            // 
            picAviones.Image = (Image)resources.GetObject("picAviones.Image");
            picAviones.Location = new Point(1031, 418);
            picAviones.Name = "picAviones";
            picAviones.Size = new Size(136, 124);
            picAviones.SizeMode = PictureBoxSizeMode.StretchImage;
            picAviones.TabIndex = 15;
            picAviones.TabStop = false;
            // 
            // lblOrdenar
            // 
            lblOrdenar.AutoSize = true;
            lblOrdenar.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrdenar.ForeColor = SystemColors.ControlText;
            lblOrdenar.Location = new Point(185, 583);
            lblOrdenar.Name = "lblOrdenar";
            lblOrdenar.Size = new Size(104, 18);
            lblOrdenar.TabIndex = 16;
            lblOrdenar.Text = "Ordenar por:";
            lblOrdenar.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnMasPasajeros
            // 
            btnMasPasajeros.BackColor = Color.Silver;
            btnMasPasajeros.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMasPasajeros.Location = new Point(324, 570);
            btnMasPasajeros.Margin = new Padding(2);
            btnMasPasajeros.Name = "btnMasPasajeros";
            btnMasPasajeros.Size = new Size(114, 44);
            btnMasPasajeros.TabIndex = 17;
            btnMasPasajeros.Text = "Mayor cantidad de pasajeros";
            btnMasPasajeros.UseVisualStyleBackColor = false;
            btnMasPasajeros.Click += btnMasPasajeros_Click;
            // 
            // btnMenosPasajeros
            // 
            btnMenosPasajeros.BackColor = Color.Silver;
            btnMenosPasajeros.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenosPasajeros.Location = new Point(481, 570);
            btnMenosPasajeros.Margin = new Padding(2);
            btnMenosPasajeros.Name = "btnMenosPasajeros";
            btnMenosPasajeros.Size = new Size(129, 44);
            btnMenosPasajeros.TabIndex = 18;
            btnMenosPasajeros.Text = "Menor cantidad de pasajeros";
            btnMenosPasajeros.UseVisualStyleBackColor = false;
            btnMenosPasajeros.Click += btnMenosPasajeros_Click;
            // 
            // btnMasVeloz
            // 
            btnMasVeloz.BackColor = Color.Silver;
            btnMasVeloz.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMasVeloz.Location = new Point(799, 570);
            btnMasVeloz.Margin = new Padding(2);
            btnMasVeloz.Name = "btnMasVeloz";
            btnMasVeloz.Size = new Size(108, 44);
            btnMasVeloz.TabIndex = 19;
            btnMasVeloz.Text = "Mas rapido";
            btnMasVeloz.UseVisualStyleBackColor = false;
            btnMasVeloz.Click += btnMasVeloz_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(659, 570);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(95, 44);
            button2.TabIndex = 20;
            button2.Text = "Mas lento";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnUsuariosRegistrados
            // 
            btnUsuariosRegistrados.BackColor = Color.Maroon;
            btnUsuariosRegistrados.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnUsuariosRegistrados.ForeColor = SystemColors.ControlLightLight;
            btnUsuariosRegistrados.Location = new Point(34, 40);
            btnUsuariosRegistrados.Margin = new Padding(2);
            btnUsuariosRegistrados.Name = "btnUsuariosRegistrados";
            btnUsuariosRegistrados.Size = new Size(202, 42);
            btnUsuariosRegistrados.TabIndex = 22;
            btnUsuariosRegistrados.Text = "Ver usuarios registrados";
            btnUsuariosRegistrados.UseVisualStyleBackColor = false;
            btnUsuariosRegistrados.Click += btnUsuariosRegistrados_Click;
            // 
            // btnCargarCaballos
            // 
            btnCargarCaballos.BackColor = Color.Maroon;
            btnCargarCaballos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargarCaballos.ForeColor = SystemColors.ControlLightLight;
            btnCargarCaballos.Location = new Point(1216, 137);
            btnCargarCaballos.Margin = new Padding(2);
            btnCargarCaballos.Name = "btnCargarCaballos";
            btnCargarCaballos.Size = new Size(192, 30);
            btnCargarCaballos.TabIndex = 23;
            btnCargarCaballos.Text = "Cargar caballos";
            btnCargarCaballos.UseVisualStyleBackColor = false;
            btnCargarCaballos.Click += btnCargarCaballos_Click;
            // 
            // btnGuardarCaballos
            // 
            btnGuardarCaballos.BackColor = Color.Maroon;
            btnGuardarCaballos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarCaballos.ForeColor = SystemColors.ControlLightLight;
            btnGuardarCaballos.Location = new Point(1216, 171);
            btnGuardarCaballos.Margin = new Padding(2);
            btnGuardarCaballos.Name = "btnGuardarCaballos";
            btnGuardarCaballos.Size = new Size(192, 30);
            btnGuardarCaballos.TabIndex = 24;
            btnGuardarCaballos.Text = "Guardar caballos";
            btnGuardarCaballos.UseVisualStyleBackColor = false;
            btnGuardarCaballos.Click += btnGuardarCaballos_Click;
            // 
            // btnCargarAutos
            // 
            btnCargarAutos.BackColor = Color.Maroon;
            btnCargarAutos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargarAutos.ForeColor = SystemColors.ControlLightLight;
            btnCargarAutos.Location = new Point(1216, 292);
            btnCargarAutos.Margin = new Padding(2);
            btnCargarAutos.Name = "btnCargarAutos";
            btnCargarAutos.Size = new Size(192, 30);
            btnCargarAutos.TabIndex = 25;
            btnCargarAutos.Text = "Cargar autos";
            btnCargarAutos.UseVisualStyleBackColor = false;
            btnCargarAutos.Click += btnCargarAutos_Click;
            // 
            // btnGuardarAutos
            // 
            btnGuardarAutos.BackColor = Color.Maroon;
            btnGuardarAutos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarAutos.ForeColor = SystemColors.ControlLightLight;
            btnGuardarAutos.Location = new Point(1216, 328);
            btnGuardarAutos.Margin = new Padding(2);
            btnGuardarAutos.Name = "btnGuardarAutos";
            btnGuardarAutos.Size = new Size(192, 30);
            btnGuardarAutos.TabIndex = 26;
            btnGuardarAutos.Text = "Guardar autos";
            btnGuardarAutos.UseVisualStyleBackColor = false;
            btnGuardarAutos.Click += btnGuardarAutos_Click;
            // 
            // btnCargarAviones
            // 
            btnCargarAviones.BackColor = Color.Maroon;
            btnCargarAviones.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargarAviones.ForeColor = SystemColors.ControlLightLight;
            btnCargarAviones.Location = new Point(1216, 443);
            btnCargarAviones.Margin = new Padding(2);
            btnCargarAviones.Name = "btnCargarAviones";
            btnCargarAviones.Size = new Size(192, 30);
            btnCargarAviones.TabIndex = 27;
            btnCargarAviones.Text = "Cargar aviones";
            btnCargarAviones.UseVisualStyleBackColor = false;
            btnCargarAviones.Click += btnCargarAviones_Click;
            // 
            // btnGuardarAviones
            // 
            btnGuardarAviones.BackColor = Color.Maroon;
            btnGuardarAviones.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardarAviones.ForeColor = SystemColors.ControlLightLight;
            btnGuardarAviones.Location = new Point(1216, 477);
            btnGuardarAviones.Margin = new Padding(2);
            btnGuardarAviones.Name = "btnGuardarAviones";
            btnGuardarAviones.Size = new Size(192, 30);
            btnGuardarAviones.TabIndex = 28;
            btnGuardarAviones.Text = "Guardar aviones";
            btnGuardarAviones.UseVisualStyleBackColor = false;
            btnGuardarAviones.Click += btnGuardarAviones_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 640);
            Controls.Add(btnGuardarAviones);
            Controls.Add(btnCargarAviones);
            Controls.Add(btnGuardarAutos);
            Controls.Add(btnCargarAutos);
            Controls.Add(btnGuardarCaballos);
            Controls.Add(btnCargarCaballos);
            Controls.Add(btnUsuariosRegistrados);
            Controls.Add(button2);
            Controls.Add(btnMasVeloz);
            Controls.Add(btnMenosPasajeros);
            Controls.Add(btnMasPasajeros);
            Controls.Add(lblOrdenar);
            Controls.Add(picAviones);
            Controls.Add(picAuto);
            Controls.Add(picCaballo);
            Controls.Add(label4);
            Controls.Add(lblAutos);
            Controls.Add(lblCaballos);
            Controls.Add(label3);
            Controls.Add(lblModificar);
            Controls.Add(lblAgregar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(lstVisorAviones);
            Controls.Add(lstVisorAutos);
            Controls.Add(lstVisorCaballos);
            Controls.Add(lblTitulo);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            FormClosing += FrmPrincipal_FormClosing;
            Load += FrmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)picCaballo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAuto).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAviones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private ListBox lstVisorCaballos;
        private ListBox lstVisorAutos;
        private ListBox lstVisorAviones;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnModificar;
        private Label lblAgregar;
        private Label lblModificar;
        private Label label3;
        private Label lblCaballos;
        private Label lblAutos;
        private Label label4;
        private PictureBox picCaballo;
        private PictureBox picAuto;
        private PictureBox picAviones;
        private Label lblOrdenar;
        private Button btnMasPasajeros;
        private Button btnMenosPasajeros;
        private Button btnMasVeloz;
        private Button button2;
        //private ToolStripStatusLabel toolStripStatusLabel1;
        private Button btnUsuariosRegistrados;
        private Button btnCargarCaballos;
        private Button btnGuardarCaballos;
        private Button btnCargarAutos;
        private Button btnGuardarAutos;
        private Button btnCargarAviones;
        private Button btnGuardarAviones;
    }
}