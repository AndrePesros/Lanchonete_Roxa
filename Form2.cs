using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistemalanchonete
{
    public partial class Form2 : Form
    {
        Atendente a = new Atendente();
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            a.IdAtendente = int.Parse(textIDatendente.Text);
            a.NomeAtendente = textNomeatendente.Text;
            a.TelefoneAtendente = maskedtextTelefoneatendente.Text;
            a.Senhaatendente = textSenhacadastr.Text;

            
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 k = new Form5();
            k.Closed += (s, args) => this.Close();
            k.Show();
        }
    }
}
