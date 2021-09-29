using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistemalanchonete
{
    
    public partial class Form4 : Form
    {
        Banco c = new Banco();
        List<Banco> listardados = new List<Banco>();
        Form5 h = new Form5();
        public Form4()
        {
            InitializeComponent();
            
            ExibirDados();
        }

        private void CarregarDados()
        {
            
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listardados;

        }


        private void ExibirDados()
        {

            listardados = Banco.carregarCliente(@"C:\Bd\BdCliente.json");

            dataGridView1.DataSource = listardados;

        }
    }
}
