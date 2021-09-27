
namespace Sistemalanchonete
{
    partial class Form2
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
            this.maskedtextTelefoneatendente = new System.Windows.Forms.MaskedTextBox();
            this.textNomeatendente = new System.Windows.Forms.TextBox();
            this.textIDatendente = new System.Windows.Forms.TextBox();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textSenhacadastr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // maskedtextTelefoneatendente
            // 
            this.maskedtextTelefoneatendente.Location = new System.Drawing.Point(121, 121);
            this.maskedtextTelefoneatendente.Mask = "(99) 000-0000";
            this.maskedtextTelefoneatendente.Name = "maskedtextTelefoneatendente";
            this.maskedtextTelefoneatendente.Size = new System.Drawing.Size(100, 23);
            this.maskedtextTelefoneatendente.TabIndex = 20;
            // 
            // textNomeatendente
            // 
            this.textNomeatendente.BackColor = System.Drawing.SystemColors.Window;
            this.textNomeatendente.Location = new System.Drawing.Point(121, 73);
            this.textNomeatendente.Name = "textNomeatendente";
            this.textNomeatendente.Size = new System.Drawing.Size(100, 23);
            this.textNomeatendente.TabIndex = 19;
            // 
            // textIDatendente
            // 
            this.textIDatendente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textIDatendente.Location = new System.Drawing.Point(121, 29);
            this.textIDatendente.Name = "textIDatendente";
            this.textIDatendente.Size = new System.Drawing.Size(100, 23);
            this.textIDatendente.TabIndex = 18;
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNomeCliente.Location = new System.Drawing.Point(17, 76);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(43, 15);
            this.labelNomeCliente.TabIndex = 17;
            this.labelNomeCliente.Text = "Nome:";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTelefone.Location = new System.Drawing.Point(17, 124);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(54, 15);
            this.labelTelefone.TabIndex = 16;
            this.labelTelefone.Text = "Telefone:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelID.Location = new System.Drawing.Point(17, 29);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 15);
            this.labelID.TabIndex = 15;
            this.labelID.Text = "ID:";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(17, 229);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 12;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(121, 229);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 22;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(17, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Senha:";
            // 
            // textSenhacadastr
            // 
            this.textSenhacadastr.Location = new System.Drawing.Point(121, 162);
            this.textSenhacadastr.Name = "textSenhacadastr";
            this.textSenhacadastr.PasswordChar = '*';
            this.textSenhacadastr.Size = new System.Drawing.Size(100, 23);
            this.textSenhacadastr.TabIndex = 31;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(247, 276);
            this.Controls.Add(this.textSenhacadastr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.maskedtextTelefoneatendente);
            this.Controls.Add(this.textNomeatendente);
            this.Controls.Add(this.textIDatendente);
            this.Controls.Add(this.labelNomeCliente);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonCadastrar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedtextTelefoneatendente;
        private System.Windows.Forms.TextBox textNomeatendente;
        private System.Windows.Forms.TextBox textIDatendente;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSenhacadastr;
    }
}