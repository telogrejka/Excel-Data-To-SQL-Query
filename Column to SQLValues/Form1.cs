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

        private void convertText(string textFromClipBoard)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();

            try
            {
                int linesCount = textBox1.Lines.Count();
                if (linesCount == 0)
                    return;

                StringBuilder text = new StringBuilder(MakeColumns(textFromClipBoard, numericUpDown1.Value));
                text.AppendLine();
                //if (text[text.Length-1] != '\n')
                //    text.Append("\n");
                text = text.Replace(',', '.');
                text = text.Replace("\t", "', '");
                if (InsertCheckBox.Checked)
                {
                    text = text.Replace("\r\n", "') ('");
                }
                else
                {
                    text = text.Replace("\r\n", "'), ('");
                }
                if (InsertCheckBox.Checked)
                {
                    text = text.Insert(0, $"INSERT INTO {TableNameTextBox.Text} VALUES ('");
                    text = text.Replace(" ('\n", $"\nINSERT INTO {TableNameTextBox.Text} VALUES ('");
                }
                else
                {
                    text = text.Insert(0, "('");
                    text = text.Replace(" ('\n", $"\n('");
                }

                if (linesCount > 1)
                    text = text.Remove(text.Length - 2, 2);

                richTextBox1.Text = text.ToString();
                if(!InsertCheckBox.Checked)
                    richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.LastIndexOf(','));
                //HighLightText(); //сильно лагает на больших данных
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string RemoveLastLine(string myStr)
        {
            if (myStr.Length > 2)
            {
                int lastNewLine;
                if ((lastNewLine = myStr.Substring(0, myStr.Length - 2).LastIndexOf("\r\n")) != -1)
                    return (myStr.Substring(0, lastNewLine));
            }
            return ("");
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
            convertText(textBox1.Text);
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
            convertText(textBox1.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TableNameTextBox_TextChanged(object sender, EventArgs e)
        {
            convertText(textBox1.Text);
        }

        private void InsertCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(InsertCheckBox.Checked)
            {
                label2.Visible = true;
                TableNameTextBox.Visible = true;
            }
            else
            {
                label2.Visible = false;
                TableNameTextBox.Visible = false;
            }
            convertText(textBox1.Text);
        }
    }
}