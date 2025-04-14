using System;
using System.Windows.Forms;
using Calculator;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        UndsenCalculator calc = new UndsenCalculator();
        private double memoryValue = 0;
        private Panel memoryContainerPanel;
        private Panel memoryPanel;
        private Label memoryLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnClear;
        private Button button1;
        private Button btnStoreMemory;

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnEquals = new Button();
            btnClear = new Button();
            button1 = new Button();
            btnStoreMemory = new Button();
            memoryContainerPanel = new Panel();
            memoryPanel = new Panel();
            memoryLabel = new Label();
            memoryPanel.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 52);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 70);
            btn1.Name = "btn1";
            btn1.Size = new Size(60, 60);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnClick;
            // 
            // btn2
            // 
            btn2.Location = new Point(78, 70);
            btn2.Name = "btn2";
            btn2.Size = new Size(60, 60);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnClick;
            // 
            // btn3
            // 
            btn3.Location = new Point(144, 70);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 60);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnClick;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 136);
            btn4.Name = "btn4";
            btn4.Size = new Size(60, 60);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnClick;
            // 
            // btn5
            // 
            btn5.Location = new Point(78, 136);
            btn5.Name = "btn5";
            btn5.Size = new Size(60, 60);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnClick;
            // 
            // btn6
            // 
            btn6.Location = new Point(144, 136);
            btn6.Name = "btn6";
            btn6.Size = new Size(60, 60);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnClick;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 202);
            btn7.Name = "btn7";
            btn7.Size = new Size(60, 60);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnClick;
            // 
            // btn8
            // 
            btn8.Location = new Point(78, 202);
            btn8.Name = "btn8";
            btn8.Size = new Size(60, 60);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnClick;
            // 
            // btn9
            // 
            btn9.Location = new Point(144, 202);
            btn9.Name = "btn9";
            btn9.Size = new Size(60, 60);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnClick;
            // 
            // btn0
            // 
            btn0.Location = new Point(78, 268);
            btn0.Name = "btn0";
            btn0.Size = new Size(60, 60);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(210, 136);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(60, 60);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnClick;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(210, 202);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(60, 60);
            btnSubtract.TabIndex = 12;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnClick;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(210, 268);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(60, 60);
            btnMultiply.TabIndex = 13;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnClick;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(210, 334);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(60, 60);
            btnDivide.TabIndex = 14;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnClick;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(12, 334);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(192, 60);
            btnEquals.TabIndex = 15;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 268);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(60, 60);
            btnClear.TabIndex = 16;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // button1
            // 
            button1.Location = new Point(144, 269);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 22;
            button1.Text = ".";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnStoreMemory
            // 
            btnStoreMemory.Location = new Point(210, 70);
            btnStoreMemory.Name = "btnStoreMemory";
            btnStoreMemory.Size = new Size(60, 60);
            btnStoreMemory.TabIndex = 23;
            btnStoreMemory.Text = "MS";
            btnStoreMemory.UseVisualStyleBackColor = true;
            btnStoreMemory.Click += btnStoreMemory_Click;
            // 
            // memoryContainerPanel
            // 
            memoryContainerPanel.AutoScroll = true;
            memoryContainerPanel.Location = new Point(276, 12);
            memoryContainerPanel.Name = "memoryContainerPanel";
            memoryContainerPanel.Size = new Size(300, 377);
            memoryContainerPanel.TabIndex = 0;
            // 
            // memoryPanel
            // 
            memoryPanel.BorderStyle = BorderStyle.FixedSingle;
            memoryPanel.Controls.Add(memoryLabel);
            memoryPanel.Location = new Point(276, 12);
            memoryPanel.Name = "memoryPanel";
            memoryPanel.Size = new Size(300, 100);
            memoryPanel.TabIndex = 0;
            memoryPanel.Visible = false;
            // 
            // memoryLabel
            // 
            memoryLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            memoryLabel.Location = new Point(10, 10);
            memoryLabel.Name = "memoryLabel";
            memoryLabel.Size = new Size(280, 30);
            memoryLabel.TabIndex = 0;
            memoryLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            ClientSize = new Size(594, 401);
            Controls.Add(memoryContainerPanel);
            Controls.Add(memoryPanel);
            Controls.Add(btnStoreMemory);
            Controls.Add(button1);
            Controls.Add(btnClear);
            Controls.Add(btnEquals);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(textBox1);
            MaximumSize = new Size(610, 440);
            MinimumSize = new Size(610, 440);
            Name = "Form1";
            Text = "l";
            Load += Form1_Load_1;
            memoryPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
