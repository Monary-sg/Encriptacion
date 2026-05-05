using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Encriptacion_Simul
{

    public partial class Version1 : Form
    {
        bool borradoAutomatico = false;

        bool modoEncriptar = true;

        string textoTemp = "";
        int desplazamientoTemp = 0;

        Timer timerCarga = new Timer();


        public Version1()
        {
            InitializeComponent();
            BarraProgre.ForeColor = Color.Green;
            BarraDescrip.ForeColor = Color.Green;

            BarraProgre.Minimum = 0;
            BarraProgre.Maximum = 100;

            BarraDescrip.Minimum = 0;
            BarraDescrip.Maximum = 100;
            panel1.Visible = false;
            Pmanual.Visible = false;

            BarraProgre.Visible = false;
            LbPorcentaje.Visible = false;

            BarraDescrip.Visible = false;
            LbPorDes.Visible = false;

            LbErrorNumero.Visible = false;
            ErrorTexto.Visible = false;

            timerCarga.Interval = 20;
            timerCarga.Tick += TimerCarga_Tick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TBNumero.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (this.ActiveControl == TBencriptado)
                    BTencriptar.PerformClick();

                else if (this.ActiveControl == ResultadoEncrip)
                    BTdesencriptar.PerformClick();

                else
                    this.SelectNextControl(this.ActiveControl, true, true, true, true);

                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        // BOTON ENCRIPTAR
        private void BTencriptar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ResultadoEncrip.Text))
                return;

            if (string.IsNullOrWhiteSpace(TBencriptado.Text))
            {
                MessageBox.Show("No hay texto para encriptar");
                return;
            }

            if (!int.TryParse(TBNumero.Text, out int desplazamiento))
            {
                MessageBox.Show("Número inválido");
                return;
            }

            if (desplazamiento < 1 || desplazamiento > 15)
            {
                MessageBox.Show("El número debe estar entre 1 y 15");
                return;
            }

            textoTemp = TBencriptado.Text;
            desplazamientoTemp = desplazamiento;

            modoEncriptar = true;

            BarraProgre.Value = 0;
            LbPorcentaje.Text = "0%";

            BarraProgre.Visible = true;
            LbPorcentaje.Visible = true;

            timerCarga.Start();
        }

        #region desencriptar
        private void BTdesencriptar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ResultaoDes.Text))
                return;

            if (string.IsNullOrWhiteSpace(ResultadoEncrip.Text))
            {
                MessageBox.Show("No hay texto para desencriptar");
                return;
            }

            if (!int.TryParse(TBNumero.Text, out int desplazamiento))
            {
                MessageBox.Show("Número inválido");
                return;
            }

            textoTemp = ResultadoEncrip.Text;
            desplazamientoTemp = desplazamiento;

            modoEncriptar = false;

            BarraDescrip.Value = 0;
            LbPorDes.Text = "0%";

            BarraDescrip.Visible = true;
            LbPorDes.Visible = true;


            timerCarga.Start();
        }
        #endregion 
        // Timer
        private void TimerCarga_Tick(object sender, EventArgs e)
        {
            if (modoEncriptar)
            {
                BarraProgre.Value++;
                LbPorcentaje.Text = BarraProgre.Value + "%";

                if (BarraProgre.Value >= 100)
                {
                    BarraProgre.Value = 100;
                    LbPorcentaje.Text = "100%";
                    timerCarga.Stop();

                    string resultado = "";

                    foreach (char c in textoTemp)
                        resultado += (char)(c + desplazamientoTemp);

                    ResultadoEncrip.Text = resultado;

                    BarraProgre.Visible = false;
                    LbPorcentaje.Visible = false;
                }
            }

            else
            {
                BarraDescrip.Value++;
                LbPorDes.Text = BarraDescrip.Value + "%";

                if (BarraDescrip.Value >= 100)
                {
                    timerCarga.Stop();

                    string resultado = "";

                    foreach (char c in textoTemp)
                        resultado += (char)(c - desplazamientoTemp);

                    ResultaoDes.Text = resultado;

                    BarraDescrip.Visible = false;
                    LbPorDes.Visible = false;
                    panel1.Visible = true;
                }
            }
        }
        #region  

        private void TBNumero_TextChanged(object sender, EventArgs e)
        {
            if (borradoAutomatico)
                return;

            if (TBNumero.Text == "")
                return;

            if (int.TryParse(TBNumero.Text, out int numero))
            {
                if (numero >= 1 && numero <= 15)
                    LbErrorNumero.Visible = false;
                else
                {
                    LbErrorNumero.Text = "Solo números del 1 al 15";
                    LbErrorNumero.Visible = true;

                    borradoAutomatico = true;
                    TBNumero.Clear();
                    borradoAutomatico = false;
                }
            }
            else
            {
                LbErrorNumero.Text = "Solo números del 1 al 15";
                LbErrorNumero.Visible = true;

                borradoAutomatico = true;
                TBNumero.Clear();
                borradoAutomatico = false;
            }
        }
        #endregion

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            TBencriptado.Clear();
            TBNumero.Clear();
            ResultadoEncrip.Text = "";
            ResultaoDes.Text = "";

            BarraProgre.Visible = false;
            BarraDescrip.Visible = false;

            LbPorcentaje.Visible = false;
            LbPorDes.Visible = false;

            BarraProgre.Value = 0;
            BarraDescrip.Value = 0;

            LbPorcentaje.Text = "0%";
            LbPorDes.Text = "0%";

            panel1.Visible = false;
            LbErrorNumero.Visible = false;
        }

        private void TBencriptado_TextChanged(object sender, EventArgs e)
        {
            if (borradoAutomatico)
                return;

            int longitud = TBencriptado.Text.Length;

            if (longitud > 100)
            {
                borradoAutomatico = true;

                TBencriptado.Text = TBencriptado.Text.Substring(0, 100);
                TBencriptado.SelectionStart = TBencriptado.Text.Length;

                borradoAutomatico = false;

                longitud = 100;
            }

            if (longitud == 100)
            {
                ErrorTexto.Text = "Solo se permiten 100 caracteres.";
                ErrorTexto.Visible = true;
            }
            else
                ErrorTexto.Visible = false;
        }
        #region NoNcecesario
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BManual_Click(object sender, EventArgs e)
        {
           
        }

   
        #endregion

        private void BManual_Click_1(object sender, EventArgs e)
        {
            Pmanual.Visible = true;
        }

        private void BCerra_Click(object sender, EventArgs e)
        {
            Pmanual.Visible = false;
        }
    }
}