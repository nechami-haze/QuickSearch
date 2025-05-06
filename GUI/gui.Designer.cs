namespace GUI
{
    partial class GUI
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
            textBox2 = new TextBox();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(192, 255, 192);
            textBox2.Location = new Point(577, 24);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "?מה לחפש לך היום";
            textBox2.Size = new Size(210, 30);
            textBox2.TabIndex = 3;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.BackColor = Color.FromArgb(192, 192, 255);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Location = new Point(10, 303);
            listBox1.Name = "listBox1";
            listBox1.RightToLeft = RightToLeft.Yes;
            listBox1.Size = new Size(1340, 246);
            listBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(455, 139);
            label1.Name = "label1";
            label1.Size = new Size(0, 22);
            label1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(607, 230);
            label2.Name = "label2";
            label2.Size = new Size(85, 58);
            label2.TabIndex = 6;
            label2.Text = "🔍";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(17, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(1333, 87);
            panel1.TabIndex = 7;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 128, 128);
            button4.Location = new Point(607, 61);
            button4.Name = "button4";
            button4.Size = new Size(151, 72);
            button4.TabIndex = 9;
            button4.Text = "לחיפוש חדש\r\n🆕";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Location = new Point(759, 61);
            button3.Name = "button3";
            button3.Size = new Size(151, 72);
            button3.TabIndex = 11;
            button3.Text = "להצגת מקלדת\r\n⌨️";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(455, 62);
            button1.Name = "button1";
            button1.Size = new Size(151, 72);
            button1.TabIndex = 12;
            button1.Text = "ראשי תיבות\r\n👀";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // GUI
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 571);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(textBox2);
            Name = "GUI";
            Text = "ח.ב & נ.ה";
            TransparencyKey = Color.FromArgb(255, 128, 0);
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button button4;
        private Button button2;
        private Button button3;
        private Button button1;
    }
        }
