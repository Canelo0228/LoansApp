namespace LoansApp
{
    partial class LoansForm
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
            panelMain = new Panel();
            menuStrip = new MenuStrip();
            Home = new ToolStripMenuItem();
            addLoan = new ToolStripMenuItem();
            updateLoan = new ToolStripMenuItem();
            loanPayments = new ToolStripMenuItem();
            loanRecords = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = SystemColors.Window;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1128, 605);
            panelMain.TabIndex = 0;
            // 
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.Info;
            menuStrip.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            menuStrip.GripMargin = new Padding(2);
            menuStrip.GripStyle = ToolStripGripStyle.Visible;
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { Home, addLoan, updateLoan, loanPayments, loanRecords });
            menuStrip.LayoutStyle = ToolStripLayoutStyle.Flow;
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(60, 2, 60, 2);
            menuStrip.RenderMode = ToolStripRenderMode.Professional;
            menuStrip.Size = new Size(1128, 40);
            menuStrip.TabIndex = 49;
            menuStrip.Text = "menuStrip2";
            // 
            // Home
            // 
            Home.Name = "Home";
            Home.Size = new Size(92, 36);
            Home.Text = "Home";
            Home.Click += GoToHome_Click;
            // 
            // addLoan
            // 
            addLoan.Name = "addLoan";
            addLoan.Size = new Size(132, 36);
            addLoan.Text = "Add Loan";
            addLoan.Click += AddLoan_Click;
            // 
            // updateLoan
            // 
            updateLoan.Name = "updateLoan";
            updateLoan.Size = new Size(167, 36);
            updateLoan.Text = "Update Loan";
            updateLoan.Click += UpdateLoan_Click;
            // 
            // loanPayments
            // 
            loanPayments.Name = "loanPayments";
            loanPayments.Size = new Size(136, 36);
            loanPayments.Text = "Payments";
            loanPayments.Click += AddPayment_Click;
            // 
            // loanRecords
            // 
            loanRecords.Name = "loanRecords";
            loanRecords.Size = new Size(113, 36);
            loanRecords.Text = "Records";
            loanRecords.Click += GoToLoansRecord_Click;
            // 
            // LoansForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 605);
            Controls.Add(menuStrip);
            Controls.Add(panelMain);
            Name = "LoansForm";
            Text = "Prestamos";
            Load += Loans_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMain;
        private MenuStrip menuStrip;
        private ToolStripMenuItem Home;
        private ToolStripMenuItem addLoan;
        private ToolStripMenuItem updateLoan;
        private ToolStripMenuItem loanPayments;
        private ToolStripMenuItem loanRecords;
    }
}