namespace Encriptacion_Simul
{
    partial class Version1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Version1));
            this.BarraProgre = new System.Windows.Forms.ProgressBar();
            this.TBencriptado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BTencriptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btnlimpiar = new System.Windows.Forms.Button();
            this.TBNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LbErrorNumero = new System.Windows.Forms.Label();
            this.LbPorcentaje = new System.Windows.Forms.Label();
            this.BTdesencriptar = new System.Windows.Forms.Button();
            this.BarraDescrip = new System.Windows.Forms.ProgressBar();
            this.ErrorTexto = new System.Windows.Forms.Label();
            this.LbPorDes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ResultadoEncrip = new System.Windows.Forms.TextBox();
            this.ResultaoDes = new System.Windows.Forms.TextBox();
            this.BManual = new System.Windows.Forms.Button();
            this.Pmanual = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.BCerra = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Pmanual.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraProgre
            // 
            this.BarraProgre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.BarraProgre.Location = new System.Drawing.Point(14, 390);
            this.BarraProgre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BarraProgre.Name = "BarraProgre";
            this.BarraProgre.Size = new System.Drawing.Size(261, 22);
            this.BarraProgre.Step = 35;
            this.BarraProgre.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BarraProgre.TabIndex = 13;
            // 
            // TBencriptado
            // 
            this.TBencriptado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.TBencriptado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TBencriptado.Location = new System.Drawing.Point(14, 174);
            this.TBencriptado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBencriptado.MaxLength = 1000;
            this.TBencriptado.Multiline = true;
            this.TBencriptado.Name = "TBencriptado";
            this.TBencriptado.Size = new System.Drawing.Size(463, 93);
            this.TBencriptado.TabIndex = 2;
            this.TBencriptado.TextChanged += new System.EventHandler(this.TBencriptado_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label3.Location = new System.Drawing.Point(482, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Capacidad (1-100) Caracteres";
            // 
            // BTencriptar
            // 
            this.BTencriptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.BTencriptar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTencriptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BTencriptar.Location = new System.Drawing.Point(14, 318);
            this.BTencriptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTencriptar.Name = "BTencriptar";
            this.BTencriptar.Size = new System.Drawing.Size(159, 37);
            this.BTencriptar.TabIndex = 3;
            this.BTencriptar.Text = "Encriptar";
            this.BTencriptar.UseVisualStyleBackColor = false;
            this.BTencriptar.Click += new System.EventHandler(this.BTencriptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encriptacion simetrica";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(9, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ingrese un texto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label4.Location = new System.Drawing.Point(9, 360);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Resultado encriptado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label5.Location = new System.Drawing.Point(9, 504);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Resultado Desencriptado:";
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
            // TBNumero
            // 
            this.TBNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.TBNumero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TBNumero.Location = new System.Drawing.Point(14, 107);
            this.TBNumero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TBNumero.Name = "TBNumero";
            this.TBNumero.Size = new System.Drawing.Size(136, 29);
            this.TBNumero.TabIndex = 1;
            this.TBNumero.TextChanged += new System.EventHandler(this.TBNumero_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(158, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Numero a sumar (1-15)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label8.Location = new System.Drawing.Point(9, 76);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ingrese un Numero";
            // 
            // LbErrorNumero
            // 
            this.LbErrorNumero.AutoSize = true;
            this.LbErrorNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(96)))), ((int)(((byte)(71)))));
            this.LbErrorNumero.Location = new System.Drawing.Point(168, 127);
            this.LbErrorNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbErrorNumero.Name = "LbErrorNumero";
            this.LbErrorNumero.Size = new System.Drawing.Size(0, 21);
            this.LbErrorNumero.TabIndex = 23;
            // 
            // LbPorcentaje
            // 
            this.LbPorcentaje.AutoSize = true;
            this.LbPorcentaje.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPorcentaje.Location = new System.Drawing.Point(284, 390);
            this.LbPorcentaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbPorcentaje.Name = "LbPorcentaje";
            this.LbPorcentaje.Size = new System.Drawing.Size(0, 28);
            this.LbPorcentaje.TabIndex = 24;
            // 
            // BTdesencriptar
            // 
            this.BTdesencriptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.BTdesencriptar.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTdesencriptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BTdesencriptar.Location = new System.Drawing.Point(14, 458);
            this.BTdesencriptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTdesencriptar.Name = "BTdesencriptar";
            this.BTdesencriptar.Size = new System.Drawing.Size(159, 37);
            this.BTdesencriptar.TabIndex = 4;
            this.BTdesencriptar.Text = "Desencriptar";
            this.BTdesencriptar.UseVisualStyleBackColor = false;
            this.BTdesencriptar.Click += new System.EventHandler(this.BTdesencriptar_Click);
            // 
            // BarraDescrip
            // 
            this.BarraDescrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.BarraDescrip.Location = new System.Drawing.Point(14, 534);
            this.BarraDescrip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BarraDescrip.Name = "BarraDescrip";
            this.BarraDescrip.Size = new System.Drawing.Size(261, 23);
            this.BarraDescrip.Step = 35;
            this.BarraDescrip.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.BarraDescrip.TabIndex = 26;
            // 
            // ErrorTexto
            // 
            this.ErrorTexto.AutoSize = true;
            this.ErrorTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(96)))), ((int)(((byte)(71)))));
            this.ErrorTexto.Location = new System.Drawing.Point(490, 214);
            this.ErrorTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorTexto.Name = "ErrorTexto";
            this.ErrorTexto.Size = new System.Drawing.Size(0, 21);
            this.ErrorTexto.TabIndex = 27;
            // 
            // LbPorDes
            // 
            this.LbPorDes.AutoSize = true;
            this.LbPorDes.Font = new System.Drawing.Font("Segoe UI Variable Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPorDes.Location = new System.Drawing.Point(301, 534);
            this.LbPorDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbPorDes.Name = "LbPorDes";
            this.LbPorDes.Size = new System.Drawing.Size(0, 28);
            this.LbPorDes.TabIndex = 28;
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
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button1.Location = new System.Drawing.Point(171, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 30;
            this.button1.Text = "No";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Btnlimpiar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(14, 591);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 77);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ResultadoEncrip
            // 
            this.ResultadoEncrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ResultadoEncrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultadoEncrip.ForeColor = System.Drawing.Color.White;
            this.ResultadoEncrip.Location = new System.Drawing.Point(205, 305);
            this.ResultadoEncrip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResultadoEncrip.Multiline = true;
            this.ResultadoEncrip.Name = "ResultadoEncrip";
            this.ResultadoEncrip.ReadOnly = true;
            this.ResultadoEncrip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultadoEncrip.Size = new System.Drawing.Size(434, 80);
            this.ResultadoEncrip.TabIndex = 32;
            // 
            // ResultaoDes
            // 
            this.ResultaoDes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ResultaoDes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultaoDes.ForeColor = System.Drawing.Color.White;
            this.ResultaoDes.Location = new System.Drawing.Point(205, 446);
            this.ResultaoDes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResultaoDes.Multiline = true;
            this.ResultaoDes.Name = "ResultaoDes";
            this.ResultaoDes.ReadOnly = true;
            this.ResultaoDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultaoDes.Size = new System.Drawing.Size(434, 79);
            this.ResultaoDes.TabIndex = 33;
            // 
            // BManual
            // 
            this.BManual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.BManual.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BManual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BManual.Location = new System.Drawing.Point(306, 14);
            this.BManual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BManual.Name = "BManual";
            this.BManual.Size = new System.Drawing.Size(112, 37);
            this.BManual.TabIndex = 40;
            this.BManual.Text = "Manual";
            this.BManual.UseVisualStyleBackColor = false;
            this.BManual.Click += new System.EventHandler(this.BManual_Click_1);
            // 
            // Pmanual
            // 
            this.Pmanual.AutoScroll = true;
            this.Pmanual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Pmanual.Controls.Add(this.label9);
            this.Pmanual.Controls.Add(this.BCerra);
            this.Pmanual.Location = new System.Drawing.Point(707, 0);
            this.Pmanual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pmanual.Name = "Pmanual";
            this.Pmanual.Size = new System.Drawing.Size(433, 355);
            this.Pmanual.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label9.Location = new System.Drawing.Point(4, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(419, 306);
            this.label9.TabIndex = 37;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // BCerra
            // 
            this.BCerra.AutoSize = true;
            this.BCerra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(83)))));
            this.BCerra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BCerra.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCerra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.BCerra.Location = new System.Drawing.Point(0, 318);
            this.BCerra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BCerra.Name = "BCerra";
            this.BCerra.Size = new System.Drawing.Size(433, 37);
            this.BCerra.TabIndex = 36;
            this.BCerra.Text = "Cerrar";
            this.BCerra.UseVisualStyleBackColor = false;
            this.BCerra.Click += new System.EventHandler(this.BCerra_Click);
            // 
            // Version1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1146, 784);
            this.Controls.Add(this.Pmanual);
            this.Controls.Add(this.BManual);
            this.Controls.Add(this.ResultaoDes);
            this.Controls.Add(this.ResultadoEncrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LbPorDes);
            this.Controls.Add(this.ErrorTexto);
            this.Controls.Add(this.BarraDescrip);
            this.Controls.Add(this.BTdesencriptar);
            this.Controls.Add(this.LbPorcentaje);
            this.Controls.Add(this.LbErrorNumero);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBNumero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarraProgre);
            this.Controls.Add(this.TBencriptado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTencriptar);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Version1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Pmanual.ResumeLayout(false);
            this.Pmanual.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TBencriptado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTencriptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btnlimpiar;
        private System.Windows.Forms.TextBox TBNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LbErrorNumero;
        private System.Windows.Forms.Label LbPorcentaje;
        public System.Windows.Forms.ProgressBar BarraProgre;
        private System.Windows.Forms.Button BTdesencriptar;
        public System.Windows.Forms.ProgressBar BarraDescrip;
        private System.Windows.Forms.Label ErrorTexto;
        private System.Windows.Forms.Label LbPorDes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ResultadoEncrip;
        private System.Windows.Forms.TextBox ResultaoDes;
        private System.Windows.Forms.Button BManual;
        private System.Windows.Forms.Panel Pmanual;
        private System.Windows.Forms.Button BCerra;
        private System.Windows.Forms.Label label9;
    }
}

