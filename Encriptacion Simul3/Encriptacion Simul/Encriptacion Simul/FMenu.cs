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
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
        

            PanelVersion1.Visible = false;
            PanelV2.Visible = false;
            PVer3.Visible = false;
        }
        private void AbrirFormEnPanel(object formHijo)
        {
        
            if (this.Pconter.Controls.Count > 0)
                this.Pconter.Controls.RemoveAt(0);

            Form fh = formHijo as Form;
            fh.TopLevel = false; 
            fh.FormBorderStyle = FormBorderStyle.None; 
            fh.Dock = DockStyle.Fill;

            this.Pconter.Controls.Add(fh); 
            this.Pconter.Tag = fh;
            fh.Show();
        }

        private void FMenu_Load(object sender, EventArgs e)
        {

        }
        private void MostrarSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                OcultarSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        private void OcultarSubMenu()
        {
            if (PanelVersion1.Visible == true)
                PanelVersion1.Visible = false;
            if (PanelV2.Visible == true)
                PanelV2.Visible = false;
            if (PVer3.Visible == true)
                PVer3.Visible = false;
        }

        private void Bver1_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelVersion1);
        }

        private void Bver2_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelV2);
        }

        private void BV2_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Version2());
            Pconter.Visible = true;
        }

        private void BVersion1_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Version1());
            Pconter.Visible = true;
        }

        private void BVer3_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PVer3);
        }

        private void BVersion3A_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Version3());
            Pconter.Visible = true;
        }

        private void BVersion3b_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Version31());
            Pconter.Visible = true;
        }
    }
}
