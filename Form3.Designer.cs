
namespace Sistemalanchonete
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textIdPedido = new System.Windows.Forms.TextBox();
            this.textDescriçao = new System.Windows.Forms.TextBox();
            this.textValorpedido = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonSalvarPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistemalanchonete.Properties.Resources.logopizza;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(23, 249);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(17, 15);
            this.label.TabIndex = 26;
            this.label.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 27;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Valor";
            // 
            // textIdPedido
            // 
            this.textIdPedido.Location = new System.Drawing.Point(112, 241);
            this.textIdPedido.Name = "textIdPedido";
            this.textIdPedido.Size = new System.Drawing.Size(100, 23);
            this.textIdPedido.TabIndex = 30;
            // 
            // textDescriçao
            // 
            this.textDescriçao.Location = new System.Drawing.Point(112, 275);
            this.textDescriçao.Name = "textDescriçao";
            this.textDescriçao.Size = new System.Drawing.Size(100, 23);
            this.textDescriçao.TabIndex = 31;
            // 
            // textValorpedido
            // 
            this.textValorpedido.Location = new System.Drawing.Point(112, 320);
            this.textValorpedido.Name = "textValorpedido";
            this.textValorpedido.Size = new System.Drawing.Size(100, 23);
            this.textValorpedido.TabIndex = 32;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "******************  Menu  ***********************",
            "*                                                                               *" +
                "",
            "*Coxinha de Frango.............................. R$ 03.50*",
            "*Coxinha de Frango com Catupiry..... R$ 04.00*",
            "*Empadao de Frango com Catupiry... R$ 05.00*",
            "*Empadao de Camarão........................ R$ 07.90*",
            "*kibe........................................................ R$ 03.90*",
            "*Pastel de Vento..................................... R$ 02.90*",
            "*Pastel de Frango com Catupiry.......... R$ 02.90*",
            "*Pastel de Carne Moida......................... R$ 02.90*",
            "*Pastel de Queijo.................................... R$ 02.90*",
            "******************  Bebidas  *********************",
            "*Coca Cola (300ml)................................ R$ 02.90*",
            "*Coca Cola (500ml)................................ R$ 02.90*",
            "*Guarana Coroa (1L).............................. R$ 02.90*",
            "*Guarana Coroa (300ml)....................... R$ 02.90*",
            "*                                                                               *" +
                "",
            "**************************************************"});
            this.listBox1.Location = new System.Drawing.Point(240, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(262, 274);
            this.listBox1.TabIndex = 33;
            // 
            // buttonSalvarPedido
            // 
            this.buttonSalvarPedido.Location = new System.Drawing.Point(59, 371);
            this.buttonSalvarPedido.Name = "buttonSalvarPedido";
            this.buttonSalvarPedido.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvarPedido.TabIndex = 34;
            this.buttonSalvarPedido.Text = "Salvar Pedido";
            this.buttonSalvarPedido.UseVisualStyleBackColor = true;
            this.buttonSalvarPedido.Click += new System.EventHandler(this.buttonSalvarPedido_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(514, 411);
            this.Controls.Add(this.buttonSalvarPedido);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textValorpedido);
            this.Controls.Add(this.textDescriçao);
            this.Controls.Add(this.textIdPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textIdPedido;
        private System.Windows.Forms.TextBox textDescriçao;
        private System.Windows.Forms.TextBox textValorpedido;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonSalvarPedido;
    }
}