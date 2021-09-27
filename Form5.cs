using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace Sistemalanchonete
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 k = new Form2();
            k.Closed += (s, args) => this.Close();
            k.Show();
        }

        private void buttonLoginatend_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seja Bem Vindo(a) \n" + textusuario.Text);
        }
    }
}
