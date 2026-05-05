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
    public partial class Version3 : Form
    {
        bool borradoAutomatico = false;
        string TextoTemp = "";
        bool modoEncriptar = true;
        int llave = 0;
        public Version3()
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
        Random rnd = new Random();

        public int Llave()
        {
            return rnd.Next(1, 61);
        }
        private void BManual_Click(object sender, EventArgs e)
        {
        Pmanual.Visible = true;
        }

        private void BCerra_Click(object sender, EventArgs e)
        {
            Pmanual.Visible = false;
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
                    BarraProgre.Value = 100;
                    LbPorcentaje.Text = "100%";
                    TimerCarga.Stop();

                    byte[] datos = Encoding.UTF8.GetBytes(TextoTemp);

                    for (int i = 0; i < datos.Length; i++)
                    {
                        datos[i] = (byte)((datos[i] + llave) % 256);
                    }

                    ResultadoEncrip.Text = Convert.ToBase64String(datos);

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

                    byte[] datos = Convert.FromBase64String(TextoTemp);

                    for (int i = 0; i < datos.Length; i++)
                    {
                        datos[i] = (byte)((datos[i] - llave + 256) % 256);
                    }

                    ResultaoDes.Text = Encoding.UTF8.GetString(datos);

                    BarraDescrip.Visible = false;
                    LbPorDes.Visible = false;
                    PanelContinuar.Visible = true;
                }
            }
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BTencriptar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TBencriptado.Text))
            {
                MessageBox.Show("No hay texto para encriptar");
                return;
            }

            TextoTemp = TBencriptado.Text;
            modoEncriptar = true;

            ResultadoEncrip.Text = "";
            ResultaoDes.Text = "";

            BarraProgre.Value = 0;
            LbPorcentaje.Text = "0%";

            BarraProgre.Visible = true;
            LbPorcentaje.Visible = true;

            TimerCarga.Start();
        }

        private void BTdesencriptar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ResultaoDes.Text))
                return;

            if (string.IsNullOrWhiteSpace(ResultadoEncrip.Text))
            {
                MessageBox.Show("No hay texto para desencriptar");
                return;
            }

            TextoTemp = ResultadoEncrip.Text;
            modoEncriptar = false;

            BarraDescrip.Value = 0;
            LbPorDes.Text = "0%";

            BarraDescrip.Visible = true;
            LbPorDes.Visible = true;


            TimerCarga.Start();
        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            TBencriptado.Clear();
            TBNumero.Clear();

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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Version3_Load(object sender, EventArgs e)
        {
            llave = Llave();
            TBNumero.Text = llave.ToString();
        }

        private void BarraDescrip_Click(object sender, EventArgs e)
        {

        }

        private void ResultadoEncrip_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
