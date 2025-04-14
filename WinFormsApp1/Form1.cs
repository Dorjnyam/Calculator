using Calculator;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// "." tovch darakhad floating buyu butarhai too bolgoh method
        /// </summary>
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    textBox1.Text = "0.";
                }
                else
                {
                    textBox1.Text += ".";
                }
            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Button-iin darakhad text tuhain buttonii (too/uildel etc.) oruulakh method
        /// </summary>
        private void btnClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        /// <summary>
        /// Clear button-iin darakhad textBox-iig tseverleh method
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        /// <summary>
        /// "=" button-iin darakhad expression-g tseverleh, tootsoh method
        /// </summary>
        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = textBox1.Text;
                float result = EvaluateExpression(expression);
                textBox1.Text = result.ToString();
            }
            catch
            {
                textBox1.Text = "Error";
            }
        }

        /// <summary>
        /// Expression-iig tootsooh method
        /// </summary>
        private float EvaluateExpression(string expression)
        {
            UndsenCalculator calc = new UndsenCalculator();

            expression = expression.Replace(" ", "");
            char[] operators = { '+', '-', '*', '/' };

            foreach (char op in operators)
            {
                int index = expression.IndexOf(op);
                if (index > 0)
                {
                    string left = expression.Substring(0, index);
                    string right = expression.Substring(index + 1);
                    float a = float.Parse(left);
                    float b = float.Parse(right);

                    switch (op)
                    {
                        case '+':
                            calc.Sum(a, b);
                            return calc.Result;
                        case '-':
                            calc.Substraction(a, b);
                            return calc.Result;
                        case '*':
                            calc.Multiplication(a, b);
                            return calc.Result;
                        case '/':
                            calc.Division(a, b);
                            return calc.Result;
                    }
                }
            }

            return float.Parse(expression);
        }

        /// <summary>
        /// Memory panel-iig zohitsuulakh deesh ni hooson zaigui bolgoj shahah method
        /// </summary>
        private void RearrangeMemoryPanels()
        {
            int y = 0;
            foreach (Control control in memoryContainerPanel.Controls)
            {
                control.Location = new Point(0, y);
                y += 90;
            }
        }

        /// <summary>
        /// Memory-iin element hadgalah method
        /// </summary>
        private void btnStoreMemory_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double result))
            {
                MemoryItem memoryItem = new MemoryItem((float)result);
                UndsenCalculator calc = new UndsenCalculator();
                calc.MemoryStore(memoryItem);

                Panel newMemoryPanel = new Panel();
                newMemoryPanel.BorderStyle = BorderStyle.FixedSingle;
                newMemoryPanel.Size = new Size(280, 80);
                newMemoryPanel.Location = new Point(0, memoryContainerPanel.Controls.Count * 90);

                Label newMemoryLabel = new Label();
                newMemoryLabel.Text = result.ToString();
                newMemoryLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
                newMemoryLabel.Location = new Point(10, 10);
                newMemoryLabel.TextAlign = ContentAlignment.MiddleRight;
                newMemoryLabel.Size = new Size(260, 30);
                newMemoryPanel.Controls.Add(newMemoryLabel);

                Button btnMAddNew = new Button();
                btnMAddNew.Text = "M+";
                btnMAddNew.Size = new Size(60, 30);
                btnMAddNew.Location = new Point(10, 50);
                btnMAddNew.Click += (s, args) =>
                {
                    if (double.TryParse(textBox1.Text, out double input))
                    {
                        calc.MemoryAdd(0, (float)input); newMemoryLabel.Text = calc.RecallMemoryItem(0).ToString();
                    }
                };

                Button btnMSubtractNew = new Button();
                btnMSubtractNew.Text = "M-";
                btnMSubtractNew.Size = new Size(60, 30);
                btnMSubtractNew.Location = new Point(80, 50);
                btnMSubtractNew.Click += (s, args) =>
                {
                    if (double.TryParse(textBox1.Text, out double input))
                    {
                        calc.MemorySubstract(0, (float)input); newMemoryLabel.Text = calc.RecallMemoryItem(0).ToString();
                    }
                };

                Button btnMClearNew = new Button();
                btnMClearNew.Text = "MC";
                btnMClearNew.Size = new Size(60, 30);
                btnMClearNew.Location = new Point(150, 50);
                btnMClearNew.Click += (s, args) =>
                {
                    calc.ClearAllMemory(); newMemoryLabel.Text = "0"; memoryContainerPanel.Controls.Remove(newMemoryPanel);
                    memoryPanel.Visible = false;
                    RearrangeMemoryPanels();
                };

                Button btnMRecallNew = new Button();
                btnMRecallNew.Text = "MR";
                btnMRecallNew.Size = new Size(60, 30);
                btnMRecallNew.Location = new Point(220, 50);
                btnMRecallNew.Click += (s, args) =>
                {
                    textBox1.Text = calc.RecallMemoryItem(0).ToString();
                };

                newMemoryPanel.Controls.Add(btnMAddNew);
                newMemoryPanel.Controls.Add(btnMSubtractNew);
                newMemoryPanel.Controls.Add(btnMClearNew);
                newMemoryPanel.Controls.Add(btnMRecallNew);

                memoryContainerPanel.Controls.Add(newMemoryPanel);

                textBox1.Clear();
            }
        }


        private void BtnMAdd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double result))
            {
                memoryValue += result;
                memoryLabel.Text = memoryValue.ToString();
                textBox1.Clear();
            }
        }

        private void BtnMSubtract_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double result))
            {
                memoryValue -= result;
                memoryLabel.Text = memoryValue.ToString();
                textBox1.Clear();
            }
        }

        private void BtnMClear_Click(object sender, EventArgs e)
        {
            memoryValue = 0;
            memoryPanel.Visible = false;
            textBox1.Clear();
        }

        private void BtnMRecall_Click(object sender, EventArgs e)
        {
            textBox1.Text = memoryValue.ToString();
        }
    }
}
