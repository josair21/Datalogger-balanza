namespace Programa_balanza
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ComunicacionBox = new System.Windows.Forms.GroupBox();
            this.BaudRate = new System.Windows.Forms.ComboBox();
            this.PuertoCom = new System.Windows.Forms.ComboBox();
            this.ParametrosLectura = new System.Windows.Forms.GroupBox();
            this.ModoContinuo = new System.Windows.Forms.CheckBox();
            this.Unidad = new System.Windows.Forms.ComboBox();
            this.ParametrosGrabacion = new System.Windows.Forms.GroupBox();
            this.GrabarFecha = new System.Windows.Forms.CheckBox();
            this.GrabarHora = new System.Windows.Forms.CheckBox();
            this.Transmision = new System.Windows.Forms.GroupBox();
            this.EnviarCaracter = new System.Windows.Forms.TextBox();
            this.ZeroBtn = new System.Windows.Forms.Button();
            this.TaraBtn = new System.Windows.Forms.Button();
            this.Repecion = new System.Windows.Forms.GroupBox();
            this.UnidadSel = new System.Windows.Forms.TextBox();
            this.PesoRecibido = new System.Windows.Forms.TextBox();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.Terminal = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StartBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.GrabarUnidad = new System.Windows.Forms.CheckBox();
            this.ComunicacionBox.SuspendLayout();
            this.ParametrosLectura.SuspendLayout();
            this.ParametrosGrabacion.SuspendLayout();
            this.Transmision.SuspendLayout();
            this.Repecion.SuspendLayout();
            this.groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComunicacionBox
            // 
            this.ComunicacionBox.Controls.Add(this.BaudRate);
            this.ComunicacionBox.Controls.Add(this.PuertoCom);
            this.ComunicacionBox.Location = new System.Drawing.Point(12, 14);
            this.ComunicacionBox.Name = "ComunicacionBox";
            this.ComunicacionBox.Size = new System.Drawing.Size(152, 79);
            this.ComunicacionBox.TabIndex = 0;
            this.ComunicacionBox.TabStop = false;
            this.ComunicacionBox.Text = "Comunicacion";
            // 
            // BaudRate
            // 
            this.BaudRate.FormattingEnabled = true;
            this.BaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "576000",
            "921600"});
            this.BaudRate.Location = new System.Drawing.Point(17, 46);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(121, 21);
            this.BaudRate.TabIndex = 1;
            this.BaudRate.Text = "Seleccionar BaudRate";
            this.BaudRate.SelectedIndexChanged += new System.EventHandler(this.BaudRate_SelectedIndexChanged);
            // 
            // PuertoCom
            // 
            this.PuertoCom.FormattingEnabled = true;
            this.PuertoCom.Location = new System.Drawing.Point(17, 19);
            this.PuertoCom.Name = "PuertoCom";
            this.PuertoCom.Size = new System.Drawing.Size(121, 21);
            this.PuertoCom.TabIndex = 0;
            this.PuertoCom.Text = "Seleccionar puerto";
            this.PuertoCom.SelectedIndexChanged += new System.EventHandler(this.PuertoCom_SelectedIndexChanged);
            // 
            // ParametrosLectura
            // 
            this.ParametrosLectura.Controls.Add(this.GrabarUnidad);
            this.ParametrosLectura.Controls.Add(this.ModoContinuo);
            this.ParametrosLectura.Controls.Add(this.Unidad);
            this.ParametrosLectura.Location = new System.Drawing.Point(12, 99);
            this.ParametrosLectura.Name = "ParametrosLectura";
            this.ParametrosLectura.Size = new System.Drawing.Size(152, 78);
            this.ParametrosLectura.TabIndex = 1;
            this.ParametrosLectura.TabStop = false;
            this.ParametrosLectura.Text = "Parametros de lectura";
            // 
            // ModoContinuo
            // 
            this.ModoContinuo.AutoSize = true;
            this.ModoContinuo.Location = new System.Drawing.Point(18, 19);
            this.ModoContinuo.Name = "ModoContinuo";
            this.ModoContinuo.Size = new System.Drawing.Size(123, 17);
            this.ModoContinuo.TabIndex = 2;
            this.ModoContinuo.Text = "Modo compatibilidad";
            this.ModoContinuo.UseVisualStyleBackColor = true;
            // 
            // Unidad
            // 
            this.Unidad.FormattingEnabled = true;
            this.Unidad.Items.AddRange(new object[] {
            "Kilogramo",
            "Gramo",
            "Miligramo",
            "Libra"});
            this.Unidad.Location = new System.Drawing.Point(37, 45);
            this.Unidad.Name = "Unidad";
            this.Unidad.Size = new System.Drawing.Size(101, 21);
            this.Unidad.TabIndex = 1;
            this.Unidad.Text = "Selec. Unidad";
            // 
            // ParametrosGrabacion
            // 
            this.ParametrosGrabacion.Controls.Add(this.GrabarFecha);
            this.ParametrosGrabacion.Controls.Add(this.GrabarHora);
            this.ParametrosGrabacion.Location = new System.Drawing.Point(12, 183);
            this.ParametrosGrabacion.Name = "ParametrosGrabacion";
            this.ParametrosGrabacion.Size = new System.Drawing.Size(152, 68);
            this.ParametrosGrabacion.TabIndex = 2;
            this.ParametrosGrabacion.TabStop = false;
            this.ParametrosGrabacion.Text = "Parametros de grabacion";
            // 
            // GrabarFecha
            // 
            this.GrabarFecha.AutoSize = true;
            this.GrabarFecha.Checked = true;
            this.GrabarFecha.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GrabarFecha.Location = new System.Drawing.Point(18, 42);
            this.GrabarFecha.Name = "GrabarFecha";
            this.GrabarFecha.Size = new System.Drawing.Size(88, 17);
            this.GrabarFecha.TabIndex = 1;
            this.GrabarFecha.Text = "Grabar fecha";
            this.GrabarFecha.UseVisualStyleBackColor = true;
            // 
            // GrabarHora
            // 
            this.GrabarHora.AutoSize = true;
            this.GrabarHora.Checked = true;
            this.GrabarHora.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GrabarHora.Location = new System.Drawing.Point(18, 19);
            this.GrabarHora.Name = "GrabarHora";
            this.GrabarHora.Size = new System.Drawing.Size(82, 17);
            this.GrabarHora.TabIndex = 0;
            this.GrabarHora.Text = "Grabar hora";
            this.GrabarHora.UseVisualStyleBackColor = true;
            // 
            // Transmision
            // 
            this.Transmision.Controls.Add(this.EnviarCaracter);
            this.Transmision.Controls.Add(this.ZeroBtn);
            this.Transmision.Controls.Add(this.TaraBtn);
            this.Transmision.Location = new System.Drawing.Point(170, 14);
            this.Transmision.Name = "Transmision";
            this.Transmision.Size = new System.Drawing.Size(208, 54);
            this.Transmision.TabIndex = 3;
            this.Transmision.TabStop = false;
            this.Transmision.Text = "Transmision";
            // 
            // EnviarCaracter
            // 
            this.EnviarCaracter.BackColor = System.Drawing.Color.White;
            this.EnviarCaracter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnviarCaracter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.EnviarCaracter.Location = new System.Drawing.Point(116, 20);
            this.EnviarCaracter.Name = "EnviarCaracter";
            this.EnviarCaracter.Size = new System.Drawing.Size(74, 26);
            this.EnviarCaracter.TabIndex = 2;
            this.EnviarCaracter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EnviarCaracter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnviarCaracter_KeyDown);
            // 
            // ZeroBtn
            // 
            this.ZeroBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroBtn.Location = new System.Drawing.Point(66, 19);
            this.ZeroBtn.Name = "ZeroBtn";
            this.ZeroBtn.Size = new System.Drawing.Size(37, 28);
            this.ZeroBtn.TabIndex = 1;
            this.ZeroBtn.Text = "Z";
            this.ZeroBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ZeroBtn.UseVisualStyleBackColor = true;
            this.ZeroBtn.Click += new System.EventHandler(this.ZeroBtn_Click);
            // 
            // TaraBtn
            // 
            this.TaraBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaraBtn.Location = new System.Drawing.Point(17, 19);
            this.TaraBtn.Name = "TaraBtn";
            this.TaraBtn.Size = new System.Drawing.Size(37, 28);
            this.TaraBtn.TabIndex = 0;
            this.TaraBtn.Text = "T";
            this.TaraBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.TaraBtn.UseVisualStyleBackColor = true;
            this.TaraBtn.Click += new System.EventHandler(this.TaraBtn_Click);
            // 
            // Repecion
            // 
            this.Repecion.Controls.Add(this.UnidadSel);
            this.Repecion.Controls.Add(this.PesoRecibido);
            this.Repecion.Location = new System.Drawing.Point(170, 74);
            this.Repecion.Name = "Repecion";
            this.Repecion.Size = new System.Drawing.Size(208, 76);
            this.Repecion.TabIndex = 4;
            this.Repecion.TabStop = false;
            this.Repecion.Text = "Recepcion";
            // 
            // UnidadSel
            // 
            this.UnidadSel.BackColor = System.Drawing.SystemColors.Control;
            this.UnidadSel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UnidadSel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnidadSel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UnidadSel.Location = new System.Drawing.Point(163, 31);
            this.UnidadSel.Name = "UnidadSel";
            this.UnidadSel.ReadOnly = true;
            this.UnidadSel.Size = new System.Drawing.Size(34, 20);
            this.UnidadSel.TabIndex = 1;
            this.UnidadSel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UnidadSel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PesoRecibido
            // 
            this.PesoRecibido.BackColor = System.Drawing.Color.White;
            this.PesoRecibido.Font = new System.Drawing.Font("MS Reference Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesoRecibido.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PesoRecibido.Location = new System.Drawing.Point(6, 19);
            this.PesoRecibido.Name = "PesoRecibido";
            this.PesoRecibido.ReadOnly = true;
            this.PesoRecibido.Size = new System.Drawing.Size(151, 50);
            this.PesoRecibido.TabIndex = 0;
            this.PesoRecibido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PesoRecibido.TextChanged += new System.EventHandler(this.PesoRecibido_TextChanged);
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.Terminal);
            this.groupbox.Location = new System.Drawing.Point(170, 156);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(208, 155);
            this.groupbox.TabIndex = 5;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "Terminal";
            // 
            // Terminal
            // 
            this.Terminal.Location = new System.Drawing.Point(6, 16);
            this.Terminal.Multiline = true;
            this.Terminal.Name = "Terminal";
            this.Terminal.ReadOnly = true;
            this.Terminal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Terminal.Size = new System.Drawing.Size(196, 133);
            this.Terminal.TabIndex = 0;
            this.Terminal.TextChanged += new System.EventHandler(this.Terminal_TextChanged);
            this.Terminal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Terminal_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StartBtn
            // 
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.Location = new System.Drawing.Point(12, 257);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(70, 48);
            this.StartBtn.TabIndex = 2;
            this.StartBtn.Text = "Leer";
            this.StartBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopBtn.Location = new System.Drawing.Point(94, 257);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(70, 48);
            this.StopBtn.TabIndex = 6;
            this.StopBtn.Text = "Pausa";
            this.StopBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.ReadTimeout = 10;
            this.serialPort1.WriteTimeout = 100;
            // 
            // GrabarUnidad
            // 
            this.GrabarUnidad.AutoSize = true;
            this.GrabarUnidad.Checked = true;
            this.GrabarUnidad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GrabarUnidad.Location = new System.Drawing.Point(18, 49);
            this.GrabarUnidad.Name = "GrabarUnidad";
            this.GrabarUnidad.Size = new System.Drawing.Size(15, 14);
            this.GrabarUnidad.TabIndex = 3;
            this.GrabarUnidad.UseVisualStyleBackColor = true;
            this.GrabarUnidad.CheckedChanged += new System.EventHandler(this.GrabarUnidad_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(390, 320);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.groupbox);
            this.Controls.Add(this.Repecion);
            this.Controls.Add(this.Transmision);
            this.Controls.Add(this.ParametrosGrabacion);
            this.Controls.Add(this.ParametrosLectura);
            this.Controls.Add(this.ComunicacionBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balanza Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ComunicacionBox.ResumeLayout(false);
            this.ParametrosLectura.ResumeLayout(false);
            this.ParametrosLectura.PerformLayout();
            this.ParametrosGrabacion.ResumeLayout(false);
            this.ParametrosGrabacion.PerformLayout();
            this.Transmision.ResumeLayout(false);
            this.Transmision.PerformLayout();
            this.Repecion.ResumeLayout(false);
            this.Repecion.PerformLayout();
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ComunicacionBox;
        private System.Windows.Forms.ComboBox BaudRate;
        private System.Windows.Forms.ComboBox PuertoCom;
        private System.Windows.Forms.GroupBox ParametrosLectura;
        private System.Windows.Forms.GroupBox ParametrosGrabacion;
        private System.Windows.Forms.GroupBox Transmision;
        private System.Windows.Forms.GroupBox Repecion;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.CheckBox GrabarFecha;
        private System.Windows.Forms.CheckBox GrabarHora;
        private System.Windows.Forms.Button ZeroBtn;
        private System.Windows.Forms.Button TaraBtn;
        private System.Windows.Forms.TextBox PesoRecibido;
        private System.Windows.Forms.ComboBox Unidad;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox ModoContinuo;
        private System.Windows.Forms.TextBox Terminal;
        private System.Windows.Forms.TextBox UnidadSel;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox EnviarCaracter;
        private System.Windows.Forms.CheckBox GrabarUnidad;
    }
}

