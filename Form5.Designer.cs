
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textusuario = new System.Windows.Forms.TextBox();
            this.textSenhacadastr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoginatend
            // 
            this.buttonLoginatend.Location = new System.Drawing.Point(195, 170);
            this.buttonLoginatend.Name = "buttonLoginatend";
            this.buttonLoginatend.Size = new System.Drawing.Size(75, 23);
            this.buttonLoginatend.TabIndex = 0;
            this.buttonLoginatend.Text = "Login";
            this.buttonLoginatend.UseVisualStyleBackColor = true;
            this.buttonLoginatend.Click += new System.EventHandler(this.buttonLoginatend_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistemalanchonete.Properties.Resources.logopizza;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(202, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Usuario:";
            // 
            // textusuario
            // 
            this.textusuario.Location = new System.Drawing.Point(272, 71);
            this.textusuario.Name = "textusuario";
            this.textusuario.Size = new System.Drawing.Size(100, 23);
            this.textusuario.TabIndex = 28;
            // 
            // textSenhacadastr
            // 
            this.textSenhacadastr.Location = new System.Drawing.Point(272, 112);
            this.textSenhacadastr.Name = "textSenhacadastr";
            this.textSenhacadastr.PasswordChar = '*';
            this.textSenhacadastr.Size = new System.Drawing.Size(100, 23);
            this.textSenhacadastr.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(202, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Senha:";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(297, 170);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 34;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(238, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Login";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(384, 212);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.textSenhacadastr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLoginatend);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoginatend;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textusuario;
        private System.Windows.Forms.TextBox textSenhacadastr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Label label3;
    }
}