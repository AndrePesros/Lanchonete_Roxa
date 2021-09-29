
namespace Sistemalanchonete
{
    partial class Form5
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
            this.buttonLoginatend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textusuario = new System.Windows.Forms.TextBox();
            this.textSenhaLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textSenhaCadastro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedtextTelefone = new System.Windows.Forms.MaskedTextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLoginatend
            // 
            this.buttonLoginatend.Location = new System.Drawing.Point(59, 222);
            this.buttonLoginatend.Name = "buttonLoginatend";
            this.buttonLoginatend.Size = new System.Drawing.Size(75, 23);
            this.buttonLoginatend.TabIndex = 0;
            this.buttonLoginatend.Text = "Login";
            this.buttonLoginatend.UseVisualStyleBackColor = true;
            this.buttonLoginatend.Click += new System.EventHandler(this.buttonLoginatend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(29, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Usuario:";
            // 
            // textusuario
            // 
            this.textusuario.Location = new System.Drawing.Point(99, 113);
            this.textusuario.Name = "textusuario";
            this.textusuario.Size = new System.Drawing.Size(100, 23);
            this.textusuario.TabIndex = 28;
            // 
            // textSenhaLogin
            // 
            this.textSenhaLogin.Location = new System.Drawing.Point(99, 154);
            this.textSenhaLogin.Name = "textSenhaLogin";
            this.textSenhaLogin.PasswordChar = '*';
            this.textSenhaLogin.Size = new System.Drawing.Size(100, 23);
            this.textSenhaLogin.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(29, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(71, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Login";
            // 
            // textSenhaCadastro
            // 
            this.textSenhaCadastro.Location = new System.Drawing.Point(350, 181);
            this.textSenhaCadastro.Name = "textSenhaCadastro";
            this.textSenhaCadastro.PasswordChar = '*';
            this.textSenhaCadastro.Size = new System.Drawing.Size(100, 23);
            this.textSenhaCadastro.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(246, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 44;
            this.label4.Text = "Senha:";
            // 
            // maskedtextTelefone
            // 
            this.maskedtextTelefone.Location = new System.Drawing.Point(350, 140);
            this.maskedtextTelefone.Mask = "(99) 000-0000";
            this.maskedtextTelefone.Name = "maskedtextTelefone";
            this.maskedtextTelefone.Size = new System.Drawing.Size(100, 23);
            this.maskedtextTelefone.TabIndex = 42;
            // 
            // textNome
            // 
            this.textNome.BackColor = System.Drawing.SystemColors.Window;
            this.textNome.Location = new System.Drawing.Point(350, 92);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(100, 23);
            this.textNome.TabIndex = 41;
            // 
            // textID
            // 
            this.textID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textID.Location = new System.Drawing.Point(350, 48);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 23);
            this.textID.TabIndex = 40;
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNomeCliente.Location = new System.Drawing.Point(246, 95);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(43, 15);
            this.labelNomeCliente.TabIndex = 39;
            this.labelNomeCliente.Text = "Nome:";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTelefone.Location = new System.Drawing.Point(246, 143);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(54, 15);
            this.labelTelefone.TabIndex = 38;
            this.labelTelefone.Text = "Telefone:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelID.Location = new System.Drawing.Point(246, 48);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 15);
            this.labelID.TabIndex = 37;
            this.labelID.Text = "ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(275, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "Cadastrar";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(470, 271);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textSenhaCadastro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedtextTelefone);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.labelNomeCliente);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSenhaLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLoginatend);
            this.Name = "Form5";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoginatend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textusuario;
        private System.Windows.Forms.TextBox textSenhaLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSenhaCadastro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedtextTelefone;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}