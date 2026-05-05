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
    public partial class Version2 : Form
    {
        bool borradoAutomatico = false;
        string TextoTemp = "";
        bool modoEncriptar = true;
        int llave = 0;
        public Version2()
        {
            InitializeComponent();
            TimerHrActual.Start();
            BarraProgre.ForeColor = Color.Green;
            BarraDescrip.ForeColor = Color.Green;
            TBencriptado.Font = new Font("Courier New", 12);
            ResultadoEncrip.Font = new Font("Courier New", 12);
            ResultaoDes.Font = new Font("Courier New", 12);

            BarraProgre.Minimum = 0;
            BarraProgre.Maximum = 100;

            BarraDescrip.Minimum = 0;
            BarraDescrip.Maximum = 100;

            Panelcontinuar.Visible = false;
            Pmanual.Visible = false;

            BarraProgre.Visible = false;
            BarraDescrip.Visible = false;
            LbErrorText.Visible = false;

            TimerCarga.Interval = 20;
            TimerCarga.Tick += TimerCarga_Tick; 


        }

        private void Version2_Load(object sender, EventArgs e)
        {
        
        }
        #region Atajos de teclado
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
        #endregion

        public int LlaveHr()
        {
            string tiempo = DateTime.Now.ToString("hhmm");

            int h1 = int.Parse(tiempo[0].ToString());
            int h2 = int.Parse(tiempo[1].ToString());
            int m1 = int.Parse(tiempo[2].ToString());
            int m2 = int.Parse(tiempo[3].ToString());

            int resultado = (h1 * 7) + (h2 * 11) + (m1 * 13) + (m2 * 17);

            resultado = (resultado * (h1 + m2 + 1)) % 60;

            if (resultado < 1)
                resultado += 1;

            return resultado;
        }
        
        private void BTencriptar_Click(object sender, EventArgs e)
        {
            string debug = "";
            foreach (char c in TBencriptado.Text)
                debug += $"'{c}' = {(int)c}\n";
            MessageBox.Show(debug);

            if (!string.IsNullOrWhiteSpace(ResultadoEncrip.Text))
            {
                ResultadoEncrip.Text = "";
            }
                

            if (string.IsNullOrWhiteSpace(TBencriptado.Text))
            {
                MessageBox.Show("No hay texto para encriptar");
                return;
            }


            TextoTemp = TBencriptado.Text;

            llave = LlaveHr();
            modoEncriptar = true;
            BarraProgre.Value = 0;
            LbPorcentaje.Text = "0%";

            
            ResultadoEncrip.Text = "";
            ResultaoDes.Text = "";
            Panelcontinuar.Visible = false;

            BarraProgre.Visible = true;
            LbPorcentaje.Visible = true;

            TimerCarga.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            horaactual.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void horaactual_TextChanged(object sender, EventArgs e)
        {

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

        private void TimerCarga_Tick(object sender, EventArgs e)
        {
            if(modoEncriptar)
            {
                BarraProgre.Value++;
                LbPorcentaje.Text = BarraProgre.Value + "%";
                if (BarraProgre.Value >= 100)
                {
                    BarraProgre.Value = 100;
                    LbPorcentaje.Text = "100%";
                    TimerCarga.Stop();

                    string resultado = "";

                    // ENCRIPTAR
                    foreach (char c in TextoTemp)
                    {
                        if (c >= 32 && c <= 255)
                        {
                            int desplazado = ((c - 32 + llave) % 224 + 224) % 224 + 32;
                            resultado += (char)desplazado;
                        }
                        else
                        {
                            resultado += c;
                        }
                    }
                    string debug2 = "";
                    foreach (char c in resultado)
                        debug2 += $"'{c}' = {(int)c}\n";
                    MessageBox.Show("CIFRADO:\n" + debug2);

                    ResultadoEncrip.Text = resultado;
                    llaveGenerada.Text = $"Llave: {llave} | Caracteres: {resultado.Length}";
                    // llaveGenerada.Text = "Llave generada: " + llave.ToString();


                    BarraProgre.Visible = false;
                    LbPorcentaje.Visible = false;
                }

            }
            else
            {
                BarraDescrip.Value++;
                LbPorDes.Text = BarraDescrip.Value + "%";

                if(BarraDescrip.Value >= 100)
                {
                  TimerCarga.Stop();
                    string resultado = "";
                    // DESENCRIPTAR
                    foreach (char c in TextoTemp)
                    {
                        if (c >= 32 && c <= 255)
                        {
                            int desplazado = ((c - 32 - llave) % 224 + 224) % 224 + 32;
                            resultado += (char)desplazado;
                        }
                        else
                        {
                            resultado += c;
                        }
                    }

                    ResultaoDes.Text = resultado;
                    BarraDescrip.Visible = false;
                    LbPorDes.Visible = false;
                    Panelcontinuar.Visible = true;
                }
            }
        }

        private void Btnlimpiar_Click(object sender, EventArgs e)
        {
            TBencriptado.Clear();
            horaactual.Text = DateTime.Now.ToString("hh:mm tt");

            ResultadoEncrip.Text = "";
            ResultaoDes.Text = "";

            BarraProgre.Visible = false;
            BarraDescrip.Visible = false;

            BarraProgre.Value = 0;
            BarraDescrip.Value = 0;

            LbPorcentaje.Text = "0%";
            LbPorDes.Text = "0%";
                
            LbErrorText.Visible = false;
            Panelcontinuar.Visible = false;
            llaveGenerada.Text = "";

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
                LbErrorText.Text = "Solo se permiten 100 caracteres.";
                LbErrorText.Visible = true;
            }
            else
                LbErrorText.Visible = false;
        }

        private void Bsalida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BManual_Click(object sender, EventArgs e)
        {
            Pmanual.Visible = true;
        }

        private void BCerra_Click(object sender, EventArgs e)
        {
            Pmanual.Visible = false;
        }
    }

}
