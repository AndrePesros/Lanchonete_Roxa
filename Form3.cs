using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistemalanchonete
{
    public partial class Form3 : Form
    {
        Pedido p = new Pedido();
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonSalvarPedido_Click(object sender, EventArgs e)
        {
            p.IDPEDIDO = int.Parse(textIdPedido.Text);
            p.DESCRICAO = textDescriçao.Text;
            p.VALOR = double.Parse(textValorpedido.Text);
            //dataGridView1.Rows.Add(new object[] { p.IDPEDIDO, p.DESCRICAO, p.VALOR });
        }

        
    }
}
