namespace WordPad_Killer
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
            panel1 = new Panel();
            btn_Save = new Button();
            btn_Load = new Button();
            ColorBox = new ComboBox();
            button_R = new Button();
            button_C = new Button();
            button_L = new Button();
            button_ = new Button();
            button_U = new Button();
            button_B = new Button();
            SizeBox = new ComboBox();
            FontBox = new ComboBox();
            label_color = new Label();
            label_alignment = new Label();
            label_fontstyle = new Label();
            label_size = new Label();
            label_font = new Label();
            richTextBox3 = new RichTextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(btn_Save);
            panel1.Controls.Add(btn_Load);
            panel1.Controls.Add(ColorBox);
            panel1.Controls.Add(button_R);
            panel1.Controls.Add(button_C);
            panel1.Controls.Add(button_L);
            panel1.Controls.Add(button_);
            panel1.Controls.Add(button_U);
            panel1.Controls.Add(button_B);
            panel1.Controls.Add(SizeBox);
            panel1.Controls.Add(FontBox);
            panel1.Controls.Add(label_color);
            panel1.Controls.Add(label_alignment);
            panel1.Controls.Add(label_fontstyle);
            panel1.Controls.Add(label_size);
            panel1.Controls.Add(label_font);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1005, 125);
            panel1.TabIndex = 0;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(898, 66);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(95, 29);
            btn_Save.TabIndex = 17;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Load
            // 
            btn_Load.Location = new Point(898, 26);
            btn_Load.Name = "btn_Load";
            btn_Load.Size = new Size(95, 29);
            btn_Load.TabIndex = 16;
            btn_Load.Text = "Load";
            btn_Load.UseVisualStyleBackColor = true;
            // 
            // ColorBox
            // 
            ColorBox.FormattingEnabled = true;
            ColorBox.Location = new Point(502, 49);
            ColorBox.Name = "ColorBox";
            ColorBox.Size = new Size(130, 28);
            ColorBox.TabIndex = 13;
            // 
            // button_R
            // 
            button_R.Location = new Point(442, 48);
            button_R.Name = "button_R";
            button_R.Size = new Size(34, 29);
            button_R.TabIndex = 12;
            button_R.Text = "R";
            button_R.UseVisualStyleBackColor = true;
            // 
            // button_C
            // 
            button_C.Location = new Point(402, 47);
            button_C.Name = "button_C";
            button_C.Size = new Size(34, 29);
            button_C.TabIndex = 11;
            button_C.Text = "C";
            button_C.UseVisualStyleBackColor = true;
            // 
            // button_L
            // 
            button_L.Location = new Point(362, 47);
            button_L.Name = "button_L";
            button_L.Size = new Size(34, 29);
            button_L.TabIndex = 10;
            button_L.Text = "L";
            button_L.UseVisualStyleBackColor = true;
            // 
            // button_
            // 
            button_.Location = new Point(308, 47);
            button_.Name = "button_";
            button_.Size = new Size(34, 29);
            button_.TabIndex = 9;
            button_.Text = "/";
            button_.UseVisualStyleBackColor = true;
            // 
            // button_U
            // 
            button_U.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            button_U.Location = new Point(268, 46);
            button_U.Name = "button_U";
            button_U.Size = new Size(34, 29);
            button_U.TabIndex = 8;
            button_U.Text = "U";
            button_U.UseVisualStyleBackColor = true;
            // 
            // button_B
            // 
            button_B.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_B.Location = new Point(228, 46);
            button_B.Name = "button_B";
            button_B.Size = new Size(34, 29);
            button_B.TabIndex = 7;
            button_B.Text = "B";
            button_B.UseVisualStyleBackColor = true;
            // 
            // SizeBox
            // 
            SizeBox.FormattingEnabled = true;
            SizeBox.Location = new Point(123, 46);
            SizeBox.Name = "SizeBox";
            SizeBox.Size = new Size(65, 28);
            SizeBox.TabIndex = 6;
            // 
            // FontBox
            // 
            FontBox.FormattingEnabled = true;
            FontBox.Location = new Point(3, 46);
            FontBox.Name = "FontBox";
            FontBox.Size = new Size(114, 28);
            FontBox.TabIndex = 5;
            // 
            // label_color
            // 
            label_color.AutoSize = true;
            label_color.Location = new Point(544, 12);
            label_color.Name = "label_color";
            label_color.Size = new Size(45, 20);
            label_color.TabIndex = 4;
            label_color.Text = "Color";
            // 
            // label_alignment
            // 
            label_alignment.AutoSize = true;
            label_alignment.Location = new Point(375, 12);
            label_alignment.Name = "label_alignment";
            label_alignment.Size = new Size(78, 20);
            label_alignment.TabIndex = 3;
            label_alignment.Text = "Alignment";
            // 
            // label_fontstyle
            // 
            label_fontstyle.AutoSize = true;
            label_fontstyle.Location = new Point(250, 12);
            label_fontstyle.Name = "label_fontstyle";
            label_fontstyle.Size = new Size(70, 20);
            label_fontstyle.TabIndex = 2;
            label_fontstyle.Text = "FontStyle";
            // 
            // label_size
            // 
            label_size.AutoSize = true;
            label_size.Location = new Point(138, 12);
            label_size.Name = "label_size";
            label_size.Size = new Size(36, 20);
            label_size.TabIndex = 1;
            label_size.Text = "Size";
            // 
            // label_font
            // 
            label_font.AutoSize = true;
            label_font.Location = new Point(36, 12);
            label_font.Name = "label_font";
            label_font.Size = new Size(38, 20);
            label_font.TabIndex = 0;
            label_font.Text = "Font";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(12, 131);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(981, 368);
            richTextBox3.TabIndex = 1;
            richTextBox3.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(665, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 27);
            textBox1.TabIndex = 18;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(665, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(197, 27);
            textBox2.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 529);
            Controls.Add(richTextBox3);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox SizeBox;
        private ComboBox FontBox;
        private Label label_color;
        private Label label_alignment;
        private Label label_fontstyle;
        private Label label_size;
        private Label label_font;
        private ComboBox ColorBox;
        private Button button_R;
        private Button button_C;
        private Button button_L;
        private Button button_;
        private Button button_U;
        private Button button_B;
        private Button btn_Save;
        private Button btn_Load;
        private RichTextBox richTextBox3;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
