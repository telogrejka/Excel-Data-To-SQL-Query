using System;
using System.Linq;
using System.Windows.Forms;

namespace Column_to_SQLValues
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertText()
        {
            int valuesInRowCount = Convert.ToInt32(numericUpDown1.Value);
            if (valuesInRowCount < 1) return;
            try
            {
                string text = textBox1.Text;
                int totalRowCount = text.Count(p => p == '\n');
                if (totalRowCount > valuesInRowCount)
                {
                    int row = 0;
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (text[i] == '\n')
                        {
                            row++;
                            if (row % valuesInRowCount == 0)
                            {
                                text = text.Insert(i, "\n");
                                i++;
                            }
                        }
                    }
                }
                text = text.Replace(',', '.');
                text = text.Replace("\t", "', '");
                text = text.Replace("\r\n", "'), ('");
                text = text.Insert(0, "('");
                text = text.Replace(" ('\n", "\n('");
                text = text.Remove(text.Length - 4, 4);
                richTextBox1.Text = text;

                HighLightText();
            }
            catch
            {
            }
        }

        private void HighLightText()
        {
            for(int i = 0; i < richTextBox1.Text.Length; i++)
            {
                if (richTextBox1.Text[i] == '('
                    || richTextBox1.Text[i] == ')'
                    || richTextBox1.Text[i] == ',')
                {
                    richTextBox1.Select(i, 1);
                    richTextBox1.SelectionColor = System.Drawing.Color.Gray;
                }
                else
                {
                    richTextBox1.Select(i, 1);
                    richTextBox1.SelectionColor = System.Drawing.Color.Red;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            convertText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = Clipboard.GetText();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            convertText();
        }
    }
}