namespace Excel_data_to_SQL_Statement
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CopyToClipboardButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PasteFromClipboardButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.InsertCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TableNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // CopyToClipboardButton
            // 
            this.CopyToClipboardButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyToClipboardButton.Location = new System.Drawing.Point(280, 37);
            this.CopyToClipboardButton.Name = "CopyToClipboardButton";
            this.CopyToClipboardButton.Size = new System.Drawing.Size(547, 23);
            this.CopyToClipboardButton.TabIndex = 2;
            this.CopyToClipboardButton.Text = "Скопировать в буфер";
            this.CopyToClipboardButton.UseVisualStyleBackColor = true;
            this.CopyToClipboardButton.Click += new System.EventHandler(this.CopyToClipboardButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 66);
            this.textBox1.MaxLength = 2147483647;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(262, 297);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PasteFromClipboardButton
            // 
            this.PasteFromClipboardButton.Location = new System.Drawing.Point(12, 37);
            this.PasteFromClipboardButton.Name = "PasteFromClipboardButton";
            this.PasteFromClipboardButton.Size = new System.Drawing.Size(262, 23);
            this.PasteFromClipboardButton.TabIndex = 1;
            this.PasteFromClipboardButton.Text = "Вставить из буфера";
            this.PasteFromClipboardButton.UseVisualStyleBackColor = true;
            this.PasteFromClipboardButton.Click += new System.EventHandler(this.PasteFromClipboardButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.Location = new System.Drawing.Point(281, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(546, 297);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(781, 9);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // InsertCheckBox
            // 
            this.InsertCheckBox.AutoSize = true;
            this.InsertCheckBox.Location = new System.Drawing.Point(12, 9);
            this.InsertCheckBox.Name = "InsertCheckBox";
            this.InsertCheckBox.Size = new System.Drawing.Size(166, 17);
            this.InsertCheckBox.TabIndex = 5;
            this.InsertCheckBox.Text = "INSERT для каждой строки";
            this.InsertCheckBox.UseVisualStyleBackColor = true;
            this.InsertCheckBox.CheckedChanged += new System.EventHandler(this.InsertCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(691, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Строк в строке";
            // 
            // TableNameTextBox
            // 
            this.TableNameTextBox.Location = new System.Drawing.Point(265, 8);
            this.TableNameTextBox.Name = "TableNameTextBox";
            this.TableNameTextBox.Size = new System.Drawing.Size(147, 20);
            this.TableNameTextBox.TabIndex = 7;
            this.TableNameTextBox.Visible = false;
            this.TableNameTextBox.TextChanged += new System.EventHandler(this.TableNameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Имя таблицы";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 370);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TableNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InsertCheckBox);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.PasteFromClipboardButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CopyToClipboardButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel data to SQL Statement";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button CopyToClipboardButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button PasteFromClipboardButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox InsertCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TableNameTextBox;
        private System.Windows.Forms.Label label2;
    }
}

