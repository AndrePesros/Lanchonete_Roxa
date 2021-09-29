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
        Banco x = new Banco();
        List<Banco> dados = new List<Banco>();
        public Form5()
        {
            InitializeComponent();
        }
        public void CarregarDados()
        {
            x.Id = int.Parse(textID.Text);
            x.Nome = textNome.Text;
            x.Telefone = maskedtextTelefone.Text;
            x.Senha = textSenhaCadastro.Text;
            dados.Add(x);
        }


        private void buttonLoginatend_Click(object sender, EventArgs e)
        {
            if (textusuario == textNome && textSenhaLogin == textSenhaCadastro)
            {
                MessageBox.Show("Seja Bem Vindo(a)");
            }
            else
            {
                MessageBox.Show("Usuario ou Senha Incorreto \n !Tente Novamente!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregarDados();


            if (x.SalvarDados(dados, @"C:/Bd/BdBanco.Joson"))
            {
                MessageBox.Show("Dados cadastrados com sucesso!");
            }
        }
    }
}
