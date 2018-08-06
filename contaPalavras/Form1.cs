using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contaPalavras
{
    public partial class Form1 : Form
    {
        string cxTexto, contChar;
        public Form1()
        {
            InitializeComponent();
        }

        public String ContarChar()
        {
            cxTexto = Convert.ToString(txtBox.Text);
            contChar = Convert.ToString(cxTexto.Length);
            return contChar;
        }

        public long ContarPalavras()
        {
            long intCount = 0;
            for (int i = 1; i < cxTexto.Length; i++)
            {
                if (char.IsWhiteSpace(cxTexto[i - 1]) == true)
                {
                    if (char.IsLetterOrDigit(cxTexto[i]) == true || char.IsPunctuation(cxTexto[i]))
                    {
                        intCount++;
                    }
                }
            }

            if (cxTexto.Length > 2)
            {
                intCount++;
            }
            return intCount;

        }

        private void bttLimpar_Click(object sender, EventArgs e)
        {
            txtBox.Clear();
            lblChar.ResetText();
            lblPalavras.ResetText();
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            
            lblChar.Text = Convert.ToString(ContarChar());
            lblPalavras.Text = Convert.ToString(ContarPalavras());
            
        }

        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }

        private void bttSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}