using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MemoryForm : Form
    {
        private ListView memoryListView;
        public event Action<double> OnMemoryAdd;
        public event Action<double> OnMemorySubtract;
        public event Action OnMemoryClear;

        public MemoryForm(ListView.ListViewItemCollection memoryItems)
        {
            InitializeComponent();
            InitializeMemoryUI(memoryItems);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // Form Settings
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Name = "MemoryForm";
            this.Text = "Memory Storage";

            // Resume layout
            this.ResumeLayout(false);
        }


        private void InitializeMemoryUI(ListView.ListViewItemCollection memoryItems)
        {
            memoryListView = new ListView
            {
                View = View.List,
                Dock = DockStyle.Top,
                Height = 150
            };

            foreach (ListViewItem item in memoryItems)
            {
                memoryListView.Items.Add((ListViewItem)item.Clone());
            }

            Button btnMPlus = new Button { Text = "M+", Dock = DockStyle.Left };
            Button btnMMinus = new Button { Text = "M-", Dock = DockStyle.Left };
            Button btnMC = new Button { Text = "MC", Dock = DockStyle.Left };

            btnMPlus.Click += (s, e) => ModifyMemory(1);
            btnMMinus.Click += (s, e) => ModifyMemory(-1);
            btnMC.Click += (s, e) =>
            {
                OnMemoryClear?.Invoke();
                memoryListView.Items.Clear();
            };

            Controls.Add(memoryListView);
            Controls.Add(btnMPlus);
            Controls.Add(btnMMinus);
            Controls.Add(btnMC);
        }

        private void ModifyMemory(int multiplier)
        {
            if (memoryListView.SelectedItems.Count > 0 && double.TryParse(memoryListView.SelectedItems[0].Text, out double value))
            {
                if (multiplier == 1)
                    OnMemoryAdd?.Invoke(value);
                else
                    OnMemorySubtract?.Invoke(value);
            }
        }
    }
}
