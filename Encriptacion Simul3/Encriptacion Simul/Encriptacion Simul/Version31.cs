using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encriptacion_Simul
{
    public partial class Version31 : Form
    {
        bool borradoAutomatico = false;
        string resultadoPendiente = "";
        string TextoTemp = "";
        bool modoEncriptar = true;
        int llave = 0;
        Random rnd = new Random();
        public Version31()
        {
            InitializeComponent();
            BarraProgre.ForeColor = Color.Green;
            BarraDescrip.ForeColor = Color.Green;
            TBencriptado.Font = new Font("Courier New", 12);
            ResultadoEncrip.Font = new Font("Courier New", 12);
            ResultaoDes.Font = new Font("Courier New", 12);

            BarraProgre.Minimum = 0;
            BarraProgre.Maximum = 100;

            BarraDescrip.Minimum = 0;
            BarraDescrip.Maximum = 100;

            PanelContinuar.Visible = false;
            Pmanual.Visible = false;

            BarraProgre.Visible = false;
            BarraDescrip.Visible = false;
            ErrorTexto.Visible = false;

            TimerCarga.Interval = 20;
            TimerCarga.Tick += TimerCarga_Tick;
        }
        public int Llave()
        {
            Random rnd = new Random();

            int numeroRandom = rnd.Next(1, 101);

            int hora = DateTime.Now.Hour;
            int minutos = DateTime.Now.Minute;
            int longitud = TextoTemp.Length;

            int formula = (hora * minutos) + longitud;

            int resultado = (numeroRandom + formula) % 60;

            if (resultado == 0)
                resultado = 1;

            return resultado;
        }
        private void BManual_Click(object sender, EventArgs e)
        {
            Pmanual.Visible = true;
        }

        private void BCerra_Click(object sender, EventArgs e)
        {

        }

        private void TimerCarga_Tick(object sender, EventArgs e)
        {
            if (modoEncriptar)
            {
                if (BarraProgre.Value < 100)
                {
                    BarraProgre.Value++;
                    LbPorcentaje.Text = BarraProgre.Value + "%";
                }
                else
                {
                    TimerCarga.Stop();

                    ResultadoEncrip.Text = resultadoPendiente;

                    BarraProgre.Visible = false;
                    LbPorcentaje.Visible = false;
                }
            }
            else
            {
                if (BarraDescrip.Value < 100)
                {
                    BarraDescrip.Value++;
                    LbPorDes.Text = BarraDescrip.Value + "%";
                }
                else
                {
                    TimerCarga.Stop();

                    ResultaoDes.Text = resultadoPendiente;

                    BarraDescrip.Visible = false;
                    LbPorDes.Visible = false;
                    PanelContinuar.Visible = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Version3_Load(object sender, EventArgs e)
        {
            llave = Llave();
            TBNumero.Text = llave.ToString();
        }

        private void ResultaoDes_TextChanged(object sender, EventArgs e)
        {

        }



        private void BManual_Click_1(object sender, EventArgs e)
        {
            Pmanual.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Pmanual.Visible = false;

        }

        private void BTencriptar_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TBencriptado.Text))
            {
                MessageBox.Show("No hay texto para encriptar");
                return;
            }

            TextoTemp = TBencriptado.Text;
            modoEncriptar = true;

            resultadoPendiente = "";

            foreach (char c in TextoTemp)
            {
                int desplazado = (c + llave) % char.MaxValue;
                resultadoPendiente += (char)desplazado;
            }

            ResultadoEncrip.Text = "";

            BarraProgre.Value = 0;
            BarraProgre.Visible = true;
            LbPorcentaje.Visible = true;

            TimerCarga.Start();
        }

        private void Btnlimpiar_Click_1(object sender, EventArgs e)
        {

            TBencriptado.Clear();
            ResultadoEncrip.Text = "";
            ResultaoDes.Text = "";

            BarraProgre.Visible = false;
            BarraDescrip.Visible = false;

            BarraProgre.Value = 0;
            BarraDescrip.Value = 0;

            LbPorcentaje.Text = "0%";
            LbPorDes.Text = "0%";

            PanelContinuar.Visible = false;

            llave = Llave();
            TBNumero.Text = llave.ToString();
        }

        private void BTdesencriptar_Click_2(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ResultadoEncrip.Text))
            {
                MessageBox.Show("No hay texto para desencriptar");
                return;
            }

            TextoTemp = ResultadoEncrip.Text;
            modoEncriptar = false;

            resultadoPendiente = "";

            foreach (char c in TextoTemp)
            {
                int desplazado = (c - llave) % char.MaxValue;

                if (desplazado < 0)
                    desplazado += char.MaxValue;

                resultadoPendiente += (char)desplazado;
            }

            ResultaoDes.Text = "";

            BarraDescrip.Value = 0;
            BarraDescrip.Visible = true;
            LbPorDes.Visible = true;

            TimerCarga.Start();
        }

        private void ResultadoEncrip_TextChanged(object sender, EventArgs e)
        {

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

        private void TBNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

