﻿using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Falcom_Bodega
{
    public partial class Form1 : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Form1()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green500, MaterialSkin.Primary.Green700, MaterialSkin.Primary.Green100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        private void abrirFormulariohijo(object formhija)
        {
            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);
            }

            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            abrirFormulariohijo(new FormularioProducto());
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            abrirFormulariohijo(new Clientes());
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            abrirFormulariohijo(new CrearSolicitud());
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            abrirFormulariohijo(new Usuarios());
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            abrirFormulariohijo(new Frm_Inventario());
        }

        private void materialButton7_Click(object sender, EventArgs e)
        {
            abrirFormulariohijo(new Colaboradores());
        }
    }
}
