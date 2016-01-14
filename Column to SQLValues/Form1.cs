using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excel_data_to_SQL_Statement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertText()
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();

            try
            {
                int linesCount = textBox1.Lines.Count();
                if (linesCount == 0) 
                    return;

                StringBuilder text = new StringBuilder(MakeColumns(textBox1.Text, numericUpDown1.Value));
                text = text.Replace(',', '.');
                text = text.Replace("\t", "', '");
                text = text.Replace("\r\n", "'), ('");
                text = text.Insert(0, "('");
                text = text.Replace(" ('\n", "\n('");

                if (linesCount > 1)
                    text = text.Remove(text.Length - 4, 4);

                richTextBox1.Text = text.ToString();

                //HighLightText(); //сильно лагает на больших данных
                Cursor.Current = Cursors.Default;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static string MakeColumns(string text, decimal colNumber)
        {
            int totalRowCount = text.Count(p => p == '\n');
            if (totalRowCount > colNumber)
            {
                int row = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == '\n')
                    {
                        row++;
                        if (row % colNumber == 0)
                        {
                            text = text.Insert(i, "\n");
                            i++;
                        }
                    }
                }
            }
            return text;
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

        private void CopyToClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
        }

        private void PasteFromClipboardButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = Clipboard.GetText();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 1)
            {
                numericUpDown1.Value = 1;
            }
            convertText();
        }
    }
}