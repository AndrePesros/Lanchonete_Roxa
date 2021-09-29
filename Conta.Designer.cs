
namespace Sistemalanchonete
{
    partial class Conta
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
            this.textValorTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textValorTotal
            // 
            this.textValorTotal.Location = new System.Drawing.Point(280, 174);
            this.textValorTotal.Name = "textValorTotal";
            this.textValorTotal.Size = new System.Drawing.Size(100, 23);
            this.textValorTotal.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "Total:";
            // 
            // buttonNF
            // 
            this.buttonNF.Location = new System.Drawing.Point(434, 169);
            this.buttonNF.Name = "buttonNF";
            this.buttonNF.Size = new System.Drawing.Size(75, 23);
            this.buttonNF.TabIndex = 40;
            this.buttonNF.Text = "Nota Fiscal";
            this.buttonNF.UseVisualStyleBackColor = true;
            // 
            // Conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(658, 302);
            this.Controls.Add(this.textValorTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNF);
            this.Name = "Conta";
            this.Text = "Conta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textValorTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNF;
    }
}