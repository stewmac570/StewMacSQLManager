using System;
using System.Windows.Forms;

namespace V6_SQL_Tool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Initial load logic goes here
            // (e.g., future SchemaExplorer.LoadTableList())
        }

        // Placeholder logic for txtSearch
        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search...";
                txtSearch.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void gridResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lstTables_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
