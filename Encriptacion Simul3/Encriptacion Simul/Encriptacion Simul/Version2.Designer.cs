namespace Encriptacion_Simul
{
    partial class Version2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Version2));
            this.ResultaoDes = new System.Windows.Forms.TextBox();
            this.ResultadoEncrip = new System.Windows.Forms.TextBox();
            this.Panelcontinuar = new System.Windows.Forms.Panel();
            this.Bsalida = new System.Windows.Forms.Button();
            this.Btnlimpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.LbPorDes = new System.Windows.Forms.Label();
            this.LbErrorText = new System.Windows.Forms.Label();
            this.BarraDescrip = new System.Windows.Forms.ProgressBar();
            this.BTdesencriptar = new System.Windows.Forms.Button();
            this.LbPorcentaje = new System.Windows.Forms.Label();
            this.LbErrorNumero = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.llaveGenerada = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BarraProgre = new System.Windows.Forms.ProgressBar();
            this.TBencriptado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTencriptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TimerHrActual = new System.Windows.Forms.Timer(this.components);
            this.horaactual = new System.Windows.Forms.TextBox();
            this.TimerCarga = new System.Windows.Forms.Timer(this.components);
            this.BManual = new System.Windows.Forms.Button();
            this.Pmanual = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.BCerra = new System.Windows.Forms.Button();
            this.Panelcontinuar.SuspendLayout();
            this.Pmanual.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultaoDes
            // 
            this.ResultaoDes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ResultaoDes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultaoDes.ForeColor = System.Drawing.Color.White;
            this.ResultaoDes.Location = new System.Drawing.Point(204, 447);
            this.ResultaoDes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResultaoDes.Multiline = true;
            this.ResultaoDes.Name = "ResultaoDes";
            this.ResultaoDes.ReadOnly = true;
            this.ResultaoDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultaoDes.Size = new System.Drawing.Size(347, 63);
            this.ResultaoDes.TabIndex = 54;
            // 
            // ResultadoEncrip
            // 
            this.ResultadoEncrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ResultadoEncrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultadoEncrip.ForeColor = System.Drawing.Color.White;
            this.ResultadoEncrip.Location = new System.Drawing.Point(204, 306);
            this.ResultadoEncrip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResultadoEncrip.Multiline = true;
            this.ResultadoEncrip.Name = "ResultadoEncrip";
            this.ResultadoEncrip.ReadOnly = true;
            this.ResultadoEncrip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultadoEncrip.Size = new System.Drawing.Size(347, 64);
            this.ResultadoEncrip.TabIndex = 53;
            // 
            // Panelcontinuar
            // 
            this.Panelcontinuar.Controls.Add(this.Bsalida);
            this.Panelcontinuar.Controls.Add(this.Btnlimpiar);
            this.Panelcontinuar.Controls.Add(this.label6);
            this.Panelcontinuar.Location = new System.Drawing.Point(13, 592);
            this.Panelcontinuar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panelcontinuar.Name = "Panelcontinuar";
            this.Panelcontinuar.Size = new System.Drawing.Size(287, 77);
            this.Panelcontinuar.TabIndex = 51;
            // 
            // Bsalida
            // 
            this.Bsalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.Bsalida.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bsalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Bsalida.Location = new System.Drawing.Point(171, 26);
            this.Bsalida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bsalida.Name = "Bsalida";
            this.Bsalida.Size = new System.Drawing.Size(112, 37);
            this.Bsalida.TabIndex = 30;
            this.Bsalida.Text = "No";
            this.Bsalida.UseVisualStyleBackColor = false;
            this.Bsalida.Click += new System.EventHandler(this.Bsalida_Click);
            // 
            // Btnlimpiar
            // 
            this.Btnlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.Btnlimpiar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnlimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Btnlimpiar.Location = new System.Drawing.Point(13, 26);
            this.Btnlimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btnlimpiar.Name = "Btnlimpiar";
            this.Btnlimpiar.Size = new System.Drawing.Size(112, 37);
            this.Btnlimpiar.TabIndex = 5;
            this.Btnlimpiar.Text = "Si";
            this.Btnlimpiar.UseVisualStyleBackColor = false;
            this.Btnlimpiar.Click += new System.EventHandler(this.Btnlimpiar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label6.Location = new System.Drawing.Point(42, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Desea encriptar de nuevo?";
            // 
            // LbPorDes
            // 
            this.LbPorDes.AutoSize = true;
            this.LbPorDes.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPorDes.Location = new System.Drawing.Point(300, 535);
            this.LbPorDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbPorDes.Name = "LbPorDes";
            this.LbPorDes.Size = new System.Drawing.Size(0, 28);
            this.LbPorDes.TabIndex = 50;
            // 
            // LbErrorText
            // 
            this.LbErrorText.AutoSize = true;
            this.LbErrorText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(96)))), ((int)(((byte)(71)))));
            this.LbErrorText.Location = new System.Drawing.Point(399, 212);
            this.LbErrorText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbErrorText.Name = "LbErrorText";
            this.LbErrorText.Size = new System.Drawing.Size(0, 13);
            this.LbErrorText.TabIndex = 49;
            // 
            // BarraDescrip
            // 
            this.BarraDescrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.BarraDescrip.Location = new System.Drawing.Point(13, 535);
            this.BarraDescrip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BarraDescrip.Name = "BarraDescrip";
            this.BarraDescrip.Size = new System.Drawing.Size(261, 23);
            this.BarraDescrip.Step = 35;
            this.BarraDescrip.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BarraDescrip.TabIndex = 48;
            // 
            // BTdesencriptar
            // 
            this.BTdesencriptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.BTdesencriptar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTdesencriptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BTdesencriptar.Location = new System.Drawing.Point(13, 459);
            this.BTdesencriptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTdesencriptar.Name = "BTdesencriptar";
            this.BTdesencriptar.Size = new System.Drawing.Size(159, 37);
            this.BTdesencriptar.TabIndex = 38;
            this.BTdesencriptar.Text = "Desencriptar";
            this.BTdesencriptar.UseVisualStyleBackColor = false;
            this.BTdesencriptar.Click += new System.EventHandler(this.BTdesencriptar_Click);
            // 
            // LbPorcentaje
            // 
            this.LbPorcentaje.AutoSize = true;
            this.LbPorcentaje.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPorcentaje.Location = new System.Drawing.Point(283, 391);
            this.LbPorcentaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbPorcentaje.Name = "LbPorcentaje";
            this.LbPorcentaje.Size = new System.Drawing.Size(0, 28);
            this.LbPorcentaje.TabIndex = 47;
            // 
            // LbErrorNumero
            // 
            this.LbErrorNumero.AutoSize = true;
            this.LbErrorNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(96)))), ((int)(((byte)(71)))));
            this.LbErrorNumero.Location = new System.Drawing.Point(167, 128);
            this.LbErrorNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbErrorNumero.Name = "LbErrorNumero";
            this.LbErrorNumero.Size = new System.Drawing.Size(0, 10);
            this.LbErrorNumero.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label8.Location = new System.Drawing.Point(8, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Hora actual";
            // 
            // llaveGenerada
            // 
            this.llaveGenerada.AutoSize = true;
            this.llaveGenerada.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.llaveGenerada.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.llaveGenerada.Location = new System.Drawing.Point(219, 101);
            this.llaveGenerada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llaveGenerada.Name = "llaveGenerada";
            this.llaveGenerada.Size = new System.Drawing.Size(0, 21);
            this.llaveGenerada.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label5.Location = new System.Drawing.Point(8, 505);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 21);
            this.label5.TabIndex = 45;
            this.label5.Text = "Resultado Desencriptado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label4.Location = new System.Drawing.Point(8, 361);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 21);
            this.label4.TabIndex = 44;
            this.label4.Text = "Resultado encriptado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(8, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 43;
            this.label1.Text = "Ingrese un texto";
            // 
            // BarraProgre
            // 
            this.BarraProgre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.BarraProgre.Location = new System.Drawing.Point(13, 391);
            this.BarraProgre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BarraProgre.Name = "BarraProgre";
            this.BarraProgre.Size = new System.Drawing.Size(261, 22);
            this.BarraProgre.Step = 35;
            this.BarraProgre.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BarraProgre.TabIndex = 42;
            // 
            // TBencriptado
            // 
            this.TBencriptado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.TBencriptado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TBencriptado.Location = new System.Drawing.Point(13, 175);
            this.TBencriptado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBencriptado.MaxLength = 1000;
            this.TBencriptado.Multiline = true;
            this.TBencriptado.Name = "TBencriptado";
            this.TBencriptado.Size = new System.Drawing.Size(370, 74);
            this.TBencriptado.TabIndex = 35;
            this.TBencriptado.TextChanged += new System.EventHandler(this.TBencriptado_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label3.Location = new System.Drawing.Point(391, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "Capacidad (1-100) Caracteres";
            // 
            // BTencriptar
            // 
            this.BTencriptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.BTencriptar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTencriptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BTencriptar.Location = new System.Drawing.Point(13, 319);
            this.BTencriptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTencriptar.Name = "BTencriptar";
            this.BTencriptar.Size = new System.Drawing.Size(159, 37);
            this.BTencriptar.TabIndex = 36;
            this.BTencriptar.Text = "Encriptar";
            this.BTencriptar.UseVisualStyleBackColor = false;
            this.BTencriptar.Click += new System.EventHandler(this.BTencriptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label2.Location = new System.Drawing.Point(5, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 37);
            this.label2.TabIndex = 37;
            this.label2.Text = "Encriptacion simetrica";
            // 
            // TimerHrActual
            // 
            this.TimerHrActual.Enabled = true;
            this.TimerHrActual.Interval = 1000;
            this.TimerHrActual.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // horaactual
            // 
            this.horaactual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.horaactual.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horaactual.ForeColor = System.Drawing.SystemColors.Info;
            this.horaactual.Location = new System.Drawing.Point(13, 101);
            this.horaactual.Multiline = true;
            this.horaactual.Name = "horaactual";
            this.horaactual.ReadOnly = true;
            this.horaactual.Size = new System.Drawing.Size(147, 31);
            this.horaactual.TabIndex = 55;
            this.horaactual.TextChanged += new System.EventHandler(this.horaactual_TextChanged);
            // 
            // TimerCarga
            // 
            this.TimerCarga.Tick += new System.EventHandler(this.TimerCarga_Tick);
            // 
            // BManual
            // 
            this.BManual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.BManual.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BManual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BManual.Location = new System.Drawing.Point(317, 14);
            this.BManual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BManual.Name = "BManual";
            this.BManual.Size = new System.Drawing.Size(172, 37);
            this.BManual.TabIndex = 56;
            this.BManual.Text = "Manual de Uso\r\n";
            this.BManual.UseVisualStyleBackColor = false;
            this.BManual.Click += new System.EventHandler(this.BManual_Click);
            // 
            // Pmanual
            // 
            this.Pmanual.AutoScroll = true;
            this.Pmanual.AutoSize = true;
            this.Pmanual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Pmanual.Controls.Add(this.label9);
            this.Pmanual.Controls.Add(this.BCerra);
            this.Pmanual.Location = new System.Drawing.Point(706, 0);
            this.Pmanual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pmanual.Name = "Pmanual";
            this.Pmanual.Size = new System.Drawing.Size(449, 370);
            this.Pmanual.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label9.Location = new System.Drawing.Point(14, 11);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(431, 323);
            this.label9.TabIndex = 38;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // BCerra
            // 
            this.BCerra.AutoSize = true;
            this.BCerra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.BCerra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BCerra.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCerra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BCerra.Location = new System.Drawing.Point(0, 339);
            this.BCerra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BCerra.Name = "BCerra";
            this.BCerra.Size = new System.Drawing.Size(449, 31);
            this.BCerra.TabIndex = 36;
            this.BCerra.Text = "Cerrar";
            this.BCerra.UseVisualStyleBackColor = false;
            this.BCerra.Click += new System.EventHandler(this.BCerra_Click);
            // 
            // Version2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1146, 784);
            this.Controls.Add(this.Pmanual);
            this.Controls.Add(this.BManual);
            this.Controls.Add(this.horaactual);
            this.Controls.Add(this.ResultaoDes);
            this.Controls.Add(this.ResultadoEncrip);
            this.Controls.Add(this.Panelcontinuar);
            this.Controls.Add(this.LbPorDes);
            this.Controls.Add(this.LbErrorText);
            this.Controls.Add(this.BarraDescrip);
            this.Controls.Add(this.BTdesencriptar);
            this.Controls.Add(this.LbPorcentaje);
            this.Controls.Add(this.LbErrorNumero);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.llaveGenerada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarraProgre);
            this.Controls.Add(this.TBencriptado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTencriptar);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Version2";
            this.Text = "Version2";
            this.Load += new System.EventHandler(this.Version2_Load);
            this.Panelcontinuar.ResumeLayout(false);
            this.Panelcontinuar.PerformLayout();
            this.Pmanual.ResumeLayout(false);
            this.Pmanual.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ResultaoDes;
        private System.Windows.Forms.TextBox ResultadoEncrip;
        private System.Windows.Forms.Panel Panelcontinuar;
        private System.Windows.Forms.Button Bsalida;
        private System.Windows.Forms.Button Btnlimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LbPorDes;
        private System.Windows.Forms.Label LbErrorText;
        public System.Windows.Forms.ProgressBar BarraDescrip;
        private System.Windows.Forms.Button BTdesencriptar;
        private System.Windows.Forms.Label LbPorcentaje;
        private System.Windows.Forms.Label LbErrorNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label llaveGenerada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ProgressBar BarraProgre;
        private System.Windows.Forms.TextBox TBencriptado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTencriptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer TimerHrActual;
        private System.Windows.Forms.TextBox horaactual;
        private System.Windows.Forms.Timer TimerCarga;
        private System.Windows.Forms.Button BManual;
        private System.Windows.Forms.Panel Pmanual;
        private System.Windows.Forms.Button BCerra;
        private System.Windows.Forms.Label label9;
    }
}