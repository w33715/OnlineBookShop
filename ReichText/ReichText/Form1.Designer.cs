namespace ReichText
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            richTextBox1 = new RichTextBox();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            buttonFont = new Button();
            buttonClolr = new Button();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 102);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(417, 289);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // buttonFont
            // 
            buttonFont.Location = new Point(61, 35);
            buttonFont.Name = "buttonFont";
            buttonFont.Size = new Size(75, 23);
            buttonFont.TabIndex = 1;
            buttonFont.Text = "button1";
            buttonFont.UseVisualStyleBackColor = true;
            buttonFont.Click += buttonFont_Click;
            // 
            // buttonClolr
            // 
            buttonClolr.Location = new Point(267, 32);
            buttonClolr.Name = "buttonClolr";
            buttonClolr.Size = new Size(75, 23);
            buttonClolr.TabIndex = 2;
            buttonClolr.Text = "button1";
            buttonClolr.UseVisualStyleBackColor = true;
            buttonClolr.Click += buttonClolr_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(560, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 179);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(515, 314);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(237, 79);
            listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonClolr);
            Controls.Add(buttonFont);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private Button buttonFont;
        private Button buttonClolr;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private ListBox listBox1;
    }
}