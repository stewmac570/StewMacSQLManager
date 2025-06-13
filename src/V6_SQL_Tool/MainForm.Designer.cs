namespace V6_SQL_Tool
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.btnRunSql = new System.Windows.Forms.Button();
            this.btnExportCsv = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTraceId = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lstColumns = new System.Windows.Forms.ListView();
            this.lstTables = new System.Windows.Forms.ListBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.gridResults = new System.Windows.Forms.DataGridView();
            this.txtSql = new System.Windows.Forms.TextBox();
            this.panelTopBar.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.SystemColors.Control;
            this.panelTopBar.Controls.Add(this.btnRunSql);
            this.panelTopBar.Controls.Add(this.btnExportCsv);
            this.panelTopBar.Controls.Add(this.btnExportExcel);
            this.panelTopBar.Controls.Add(this.btnClear);
            this.panelTopBar.Controls.Add(this.btnTraceId);
            this.panelTopBar.Controls.Add(this.btnReload);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1200, 45);
            this.panelTopBar.TabIndex = 2;
            // 
            // btnRunSql
            // 
            this.btnRunSql.Location = new System.Drawing.Point(10, 7);
            this.btnRunSql.Name = "btnRunSql";
            this.btnRunSql.Size = new System.Drawing.Size(75, 30);
            this.btnRunSql.TabIndex = 0;
            this.btnRunSql.Text = "Run";
            // 
            // btnExportCsv
            // 
            this.btnExportCsv.Location = new System.Drawing.Point(90, 7);
            this.btnExportCsv.Name = "btnExportCsv";
            this.btnExportCsv.Size = new System.Drawing.Size(75, 30);
            this.btnExportCsv.TabIndex = 1;
            this.btnExportCsv.Text = "Export";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(170, 7);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(75, 30);
            this.btnExportExcel.TabIndex = 2;
            this.btnExportExcel.Text = "Excel";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(250, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            // 
            // btnTraceId
            // 
            this.btnTraceId.Location = new System.Drawing.Point(330, 7);
            this.btnTraceId.Name = "btnTraceId";
            this.btnTraceId.Size = new System.Drawing.Size(75, 30);
            this.btnTraceId.TabIndex = 4;
            this.btnTraceId.Text = "Trace ID";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(410, 7);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 30);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "Reload";
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.lstColumns);
            this.panelLeft.Controls.Add(this.lstTables);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 45);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(10);
            this.panelLeft.Size = new System.Drawing.Size(400, 655);
            this.panelLeft.TabIndex = 1;
            // 
            // lstColumns
            // 
            this.lstColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstColumns.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstColumns.HideSelection = false;
            this.lstColumns.Location = new System.Drawing.Point(200, 10);
            this.lstColumns.Name = "lstColumns";
            this.lstColumns.Size = new System.Drawing.Size(190, 635);
            this.lstColumns.TabIndex = 0;
            this.lstColumns.UseCompatibleStateImageBehavior = false;
            this.lstColumns.View = System.Windows.Forms.View.Details;
            // 
            // lstTables
            // 
            this.lstTables.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstTables.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstTables.ItemHeight = 15;
            this.lstTables.Location = new System.Drawing.Point(10, 10);
            this.lstTables.Name = "lstTables";
            this.lstTables.Size = new System.Drawing.Size(190, 635);
            this.lstTables.TabIndex = 1;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.gridResults);
            this.panelRight.Controls.Add(this.txtSql);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(400, 45);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(10);
            this.panelRight.Size = new System.Drawing.Size(800, 655);
            this.panelRight.TabIndex = 0;
            // 
            // gridResults
            // 
            this.gridResults.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridResults.Location = new System.Drawing.Point(10, 160);
            this.gridResults.Name = "gridResults";
            this.gridResults.Size = new System.Drawing.Size(780, 485);
            this.gridResults.TabIndex = 0;
            // 
            // txtSql
            // 
            this.txtSql.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSql.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtSql.Location = new System.Drawing.Point(10, 10);
            this.txtSql.Multiline = true;
            this.txtSql.Name = "txtSql";
            this.txtSql.Size = new System.Drawing.Size(780, 150);
            this.txtSql.TabIndex = 1;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTopBar);
            this.Name = "MainForm";
            this.Text = "V6 SQL Explorer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelTopBar.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
            this.ResumeLayout(false);

        }

        // === Controls ===

        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Button btnRunSql;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTraceId;
        private System.Windows.Forms.Button btnReload;

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.ListBox lstTables;
        private System.Windows.Forms.ListView lstColumns;

        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.TextBox txtSql;
        private System.Windows.Forms.DataGridView gridResults;
    }
}
