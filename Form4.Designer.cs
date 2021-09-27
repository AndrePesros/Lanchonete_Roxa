
namespace Sistemalanchonete
{
    partial class Form4
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
            this.buttonNF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textValorTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonNF
            // 
            this.buttonNF.Location = new System.Drawing.Point(447, 403);
            this.buttonNF.Name = "buttonNF";
            this.buttonNF.Size = new System.Drawing.Size(75, 23);
            this.buttonNF.TabIndex = 37;
            this.buttonNF.Text = "Nota Fiscal";
            this.buttonNF.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Total:";
            // 
            // textValorTotal
            // 
            this.textValorTotal.Location = new System.Drawing.Point(267, 408);
            this.textValorTotal.Name = "textValorTotal";
            this.textValorTotal.Size = new System.Drawing.Size(100, 23);
            this.textValorTotal.TabIndex = 39;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.textValorTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNF);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonNF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textValorTotal;
    }
}