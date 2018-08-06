namespace contaPalavras
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBox = new System.Windows.Forms.RichTextBox();
            this.Characteres = new System.Windows.Forms.Label();
            this.Palavras = new System.Windows.Forms.Label();
            this.bttSair = new System.Windows.Forms.Button();
            this.lblChar = new System.Windows.Forms.Label();
            this.lblPalavras = new System.Windows.Forms.Label();
            this.bttLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(12, 12);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(580, 200);
            this.txtBox.TabIndex = 0;
            this.txtBox.Text = "";
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            this.txtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // Characteres
            // 
            this.Characteres.AutoSize = true;
            this.Characteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Characteres.Location = new System.Drawing.Point(9, 224);
            this.Characteres.Name = "Characteres";
            this.Characteres.Size = new System.Drawing.Size(72, 13);
            this.Characteres.TabIndex = 1;
            this.Characteres.Text = "Caracteres:";
            // 
            // Palavras
            // 
            this.Palavras.AutoSize = true;
            this.Palavras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Palavras.Location = new System.Drawing.Point(235, 224);
            this.Palavras.Name = "Palavras";
            this.Palavras.Size = new System.Drawing.Size(60, 13);
            this.Palavras.TabIndex = 2;
            this.Palavras.Text = "Palavras:";
            // 
            // bttSair
            // 
            this.bttSair.Location = new System.Drawing.Point(517, 218);
            this.bttSair.Name = "bttSair";
            this.bttSair.Size = new System.Drawing.Size(75, 23);
            this.bttSair.TabIndex = 3;
            this.bttSair.Text = "Sair";
            this.bttSair.UseVisualStyleBackColor = true;
            this.bttSair.Click += new System.EventHandler(this.bttSair_Click);
            // 
            // lblChar
            // 
            this.lblChar.AutoSize = true;
            this.lblChar.Location = new System.Drawing.Point(87, 224);
            this.lblChar.Name = "lblChar";
            this.lblChar.Size = new System.Drawing.Size(0, 13);
            this.lblChar.TabIndex = 4;
            // 
            // lblPalavras
            // 
            this.lblPalavras.AutoSize = true;
            this.lblPalavras.Location = new System.Drawing.Point(301, 224);
            this.lblPalavras.Name = "lblPalavras";
            this.lblPalavras.Size = new System.Drawing.Size(0, 13);
            this.lblPalavras.TabIndex = 5;
            // 
            // bttLimpar
            // 
            this.bttLimpar.Location = new System.Drawing.Point(435, 218);
            this.bttLimpar.Name = "bttLimpar";
            this.bttLimpar.Size = new System.Drawing.Size(75, 23);
            this.bttLimpar.TabIndex = 6;
            this.bttLimpar.Text = "Limpar";
            this.bttLimpar.UseVisualStyleBackColor = true;
            this.bttLimpar.Click += new System.EventHandler(this.bttLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(604, 248);
            this.Controls.Add(this.bttLimpar);
            this.Controls.Add(this.lblPalavras);
            this.Controls.Add(this.lblChar);
            this.Controls.Add(this.bttSair);
            this.Controls.Add(this.Palavras);
            this.Controls.Add(this.Characteres);
            this.Controls.Add(this.txtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador de Caracteres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBox;
        private System.Windows.Forms.Label Characteres;
        private System.Windows.Forms.Label Palavras;
        private System.Windows.Forms.Button bttSair;
        private System.Windows.Forms.Label lblChar;
        private System.Windows.Forms.Label lblPalavras;
        private System.Windows.Forms.Button bttLimpar;
    }
}

