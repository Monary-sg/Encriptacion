namespace Encriptacion_Simul
{
    partial class Version31
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Version31));
            this.BarraProgre = new System.Windows.Forms.ProgressBar();
            this.ResultaoDes = new System.Windows.Forms.TextBox();
            this.BarraDescrip = new System.Windows.Forms.ProgressBar();
            this.TBencriptado = new System.Windows.Forms.TextBox();
            this.BManual = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.BCerra = new System.Windows.Forms.Button();
            this.ErrorTexto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LbPorcentaje = new System.Windows.Forms.Label();
            this.LbPorDes = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PanelContinuar = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.Btnlimpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TimerCarga = new System.Windows.Forms.Timer(this.components);
            this.Pmanual = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ResultadoEncrip = new System.Windows.Forms.TextBox();
            this.BTencriptar = new System.Windows.Forms.Button();
            this.BTdesencriptar = new System.Windows.Forms.Button();
            this.PanelContinuar.SuspendLayout();
            this.Pmanual.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraProgre
            // 
            this.BarraProgre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.BarraProgre.Location = new System.Drawing.Point(30, 339);
            this.BarraProgre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BarraProgre.Name = "BarraProgre";
            this.BarraProgre.Size = new System.Drawing.Size(261, 22);
            this.BarraProgre.Step = 35;
            this.BarraProgre.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BarraProgre.TabIndex = 51;
            // 
            // ResultaoDes
            // 
            this.ResultaoDes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ResultaoDes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultaoDes.ForeColor = System.Drawing.Color.White;
            this.ResultaoDes.Location = new System.Drawing.Point(214, 443);
            this.ResultaoDes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResultaoDes.Multiline = true;
            this.ResultaoDes.Name = "ResultaoDes";
            this.ResultaoDes.ReadOnly = true;
            this.ResultaoDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultaoDes.Size = new System.Drawing.Size(347, 70);
            this.ResultaoDes.TabIndex = 62;
            this.ResultaoDes.TextChanged += new System.EventHandler(this.ResultaoDes_TextChanged);
            // 
            // BarraDescrip
            // 
            this.BarraDescrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.BarraDescrip.Location = new System.Drawing.Point(30, 523);
            this.BarraDescrip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BarraDescrip.Name = "BarraDescrip";
            this.BarraDescrip.Size = new System.Drawing.Size(261, 23);
            this.BarraDescrip.Step = 35;
            this.BarraDescrip.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BarraDescrip.TabIndex = 64;
            // 
            // TBencriptado
            // 
            this.TBencriptado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.TBencriptado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TBencriptado.Location = new System.Drawing.Point(30, 152);
            this.TBencriptado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBencriptado.MaxLength = 1000;
            this.TBencriptado.Multiline = true;
            this.TBencriptado.Name = "TBencriptado";
            this.TBencriptado.Size = new System.Drawing.Size(370, 74);
            this.TBencriptado.TabIndex = 65;
            this.TBencriptado.TextChanged += new System.EventHandler(this.TBencriptado_TextChanged);
            // 
            // BManual
            // 
            this.BManual.BackColor = System.Drawing.Color.Maroon;
            this.BManual.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BManual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BManual.Location = new System.Drawing.Point(402, 14);
            this.BManual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BManual.Name = "BManual";
            this.BManual.Size = new System.Drawing.Size(172, 37);
            this.BManual.TabIndex = 66;
            this.BManual.Text = "Manual";
            this.BManual.UseVisualStyleBackColor = false;
            this.BManual.Click += new System.EventHandler(this.BManual_Click_1);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label9.Location = new System.Drawing.Point(4, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(373, 477);
            this.label9.TabIndex = 37;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // BCerra
            // 
            this.BCerra.AutoSize = true;
            this.BCerra.BackColor = System.Drawing.Color.Maroon;
            this.BCerra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BCerra.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCerra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BCerra.Location = new System.Drawing.Point(0, 630);
            this.BCerra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BCerra.Name = "BCerra";
            this.BCerra.Size = new System.Drawing.Size(441, 37);
            this.BCerra.TabIndex = 36;
            this.BCerra.Text = "Cerrar";
            this.BCerra.UseVisualStyleBackColor = false;
            // 
            // ErrorTexto
            // 
            this.ErrorTexto.AutoSize = true;
            this.ErrorTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(96)))), ((int)(((byte)(71)))));
            this.ErrorTexto.Location = new System.Drawing.Point(416, 192);
            this.ErrorTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorTexto.Name = "ErrorTexto";
            this.ErrorTexto.Size = new System.Drawing.Size(0, 13);
            this.ErrorTexto.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label3.Location = new System.Drawing.Point(408, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 21);
            this.label3.TabIndex = 68;
            this.label3.Text = "Capacidad (1-100) Caracteres";
            // 
            // TBNumero
            // 
            this.TBNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.TBNumero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TBNumero.Location = new System.Drawing.Point(30, 93);
            this.TBNumero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBNumero.Multiline = true;
            this.TBNumero.Name = "TBNumero";
            this.TBNumero.ReadOnly = true;
            this.TBNumero.Size = new System.Drawing.Size(136, 33);
            this.TBNumero.TabIndex = 70;
            this.TBNumero.TextChanged += new System.EventHandler(this.TBNumero_TextChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label8.Location = new System.Drawing.Point(28, 47);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(292, 20);
            this.label8.TabIndex = 72;
            this.label8.Text = "Numero Generado Aleatoriamente";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label2.Location = new System.Drawing.Point(23, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 38);
            this.label2.TabIndex = 71;
            this.label2.Text = "Encriptacion Version 3.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label4.Location = new System.Drawing.Point(210, 239);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 21);
            this.label4.TabIndex = 73;
            this.label4.Text = "Resultado encriptado:";
            // 
            // LbPorcentaje
            // 
            this.LbPorcentaje.AutoSize = true;
            this.LbPorcentaje.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPorcentaje.Location = new System.Drawing.Point(299, 333);
            this.LbPorcentaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbPorcentaje.Name = "LbPorcentaje";
            this.LbPorcentaje.Size = new System.Drawing.Size(0, 28);
            this.LbPorcentaje.TabIndex = 74;
            // 
            // LbPorDes
            // 
            this.LbPorDes.AutoSize = true;
            this.LbPorDes.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPorDes.Location = new System.Drawing.Point(299, 518);
            this.LbPorDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbPorDes.Name = "LbPorDes";
            this.LbPorDes.Size = new System.Drawing.Size(0, 28);
            this.LbPorDes.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label5.Location = new System.Drawing.Point(210, 417);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 21);
            this.label5.TabIndex = 76;
            this.label5.Text = "Resultado Desencriptado:";
            // 
            // PanelContinuar
            // 
            this.PanelContinuar.Controls.Add(this.button2);
            this.PanelContinuar.Controls.Add(this.Btnlimpiar);
            this.PanelContinuar.Controls.Add(this.label6);
            this.PanelContinuar.Location = new System.Drawing.Point(30, 586);
            this.PanelContinuar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PanelContinuar.Name = "PanelContinuar";
            this.PanelContinuar.Size = new System.Drawing.Size(287, 77);
            this.PanelContinuar.TabIndex = 77;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button2.Location = new System.Drawing.Point(157, 26);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 37);
            this.button2.TabIndex = 82;
            this.button2.Text = "No";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.Btnlimpiar.Click += new System.EventHandler(this.Btnlimpiar_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label6.Location = new System.Drawing.Point(50, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Desea encriptar de nuevo?";
            // 
            // Pmanual
            // 
            this.Pmanual.AutoScroll = true;
            this.Pmanual.AutoSize = true;
            this.Pmanual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Pmanual.Controls.Add(this.label1);
            this.Pmanual.Controls.Add(this.button1);
            this.Pmanual.Location = new System.Drawing.Point(692, 0);
            this.Pmanual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pmanual.Name = "Pmanual";
            this.Pmanual.Size = new System.Drawing.Size(377, 661);
            this.Pmanual.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 589);
            this.label1.TabIndex = 37;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button1.Location = new System.Drawing.Point(0, 624);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(377, 37);
            this.button1.TabIndex = 36;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ResultadoEncrip
            // 
            this.ResultadoEncrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ResultadoEncrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultadoEncrip.ForeColor = System.Drawing.Color.White;
            this.ResultadoEncrip.Location = new System.Drawing.Point(214, 265);
            this.ResultadoEncrip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResultadoEncrip.Multiline = true;
            this.ResultadoEncrip.Name = "ResultadoEncrip";
            this.ResultadoEncrip.ReadOnly = true;
            this.ResultadoEncrip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultadoEncrip.Size = new System.Drawing.Size(347, 64);
            this.ResultadoEncrip.TabIndex = 79;
            this.ResultadoEncrip.TextChanged += new System.EventHandler(this.ResultadoEncrip_TextChanged);
            // 
            // BTencriptar
            // 
            this.BTencriptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.BTencriptar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTencriptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BTencriptar.Location = new System.Drawing.Point(30, 292);
            this.BTencriptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTencriptar.Name = "BTencriptar";
            this.BTencriptar.Size = new System.Drawing.Size(159, 37);
            this.BTencriptar.TabIndex = 80;
            this.BTencriptar.Text = "Encriptar";
            this.BTencriptar.UseVisualStyleBackColor = false;
            this.BTencriptar.Click += new System.EventHandler(this.BTencriptar_Click_1);
            // 
            // BTdesencriptar
            // 
            this.BTdesencriptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.BTdesencriptar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTdesencriptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BTdesencriptar.Location = new System.Drawing.Point(30, 476);
            this.BTdesencriptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTdesencriptar.Name = "BTdesencriptar";
            this.BTdesencriptar.Size = new System.Drawing.Size(159, 37);
            this.BTdesencriptar.TabIndex = 81;
            this.BTdesencriptar.Text = "Desencriptar";
            this.BTdesencriptar.UseVisualStyleBackColor = false;
            this.BTdesencriptar.Click += new System.EventHandler(this.BTdesencriptar_Click_2);
            // 
            // Version31
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1222, 749);
            this.Controls.Add(this.BTdesencriptar);
            this.Controls.Add(this.BTencriptar);
            this.Controls.Add(this.ResultadoEncrip);
            this.Controls.Add(this.Pmanual);
            this.Controls.Add(this.PanelContinuar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LbPorDes);
            this.Controls.Add(this.LbPorcentaje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBNumero);
            this.Controls.Add(this.ErrorTexto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BManual);
            this.Controls.Add(this.TBencriptado);
            this.Controls.Add(this.BarraDescrip);
            this.Controls.Add(this.ResultaoDes);
            this.Controls.Add(this.BarraProgre);
            this.Name = "Version31";
            this.Text = "Version31";
            this.Load += new System.EventHandler(this.Version3_Load);
            this.PanelContinuar.ResumeLayout(false);
            this.PanelContinuar.PerformLayout();
            this.Pmanual.ResumeLayout(false);
            this.Pmanual.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ProgressBar BarraProgre;
        private System.Windows.Forms.TextBox ResultaoDes;
        public System.Windows.Forms.ProgressBar BarraDescrip;
        private System.Windows.Forms.TextBox TBencriptado;
        private System.Windows.Forms.Button BManual;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BCerra;
        private System.Windows.Forms.Label ErrorTexto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LbPorcentaje;
        private System.Windows.Forms.Label LbPorDes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel PanelContinuar;
        private System.Windows.Forms.Button Btnlimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer TimerCarga;
        private System.Windows.Forms.Panel Pmanual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ResultadoEncrip;
        private System.Windows.Forms.Button BTencriptar;
        private System.Windows.Forms.Button BTdesencriptar;
        private System.Windows.Forms.Button button2;
    }
}