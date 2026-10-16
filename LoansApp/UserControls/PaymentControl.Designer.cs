namespace LoansApp.UserControls
{
    partial class PaymentControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CancelButton = new Button();
            AddButton = new Button();
            Income = new TextBox();
            label5 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            backButton = new Button();
            nextButton = new Button();
            name = new TextBox();
            label8 = new Label();
            feesLeft = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.BackColor = SystemColors.Info;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelButton.Location = new Point(1323, 602);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(269, 80);
            CancelButton.TabIndex = 22;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = SystemColors.Info;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddButton.Location = new Point(1323, 492);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(269, 80);
            AddButton.TabIndex = 21;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // Income
            // 
            Income.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Income.Location = new Point(593, 236);
            Income.Name = "Income";
            Income.ReadOnly = true;
            Income.Size = new Size(356, 44);
            Income.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(593, 188);
            label5.Name = "label5";
            label5.Size = new Size(287, 37);
            label5.TabIndex = 19;
            label5.Text = "Payment Amount:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(643, 87);
            label1.Name = "label1";
            label1.Size = new Size(289, 46);
            label1.TabIndex = 12;
            label1.Text = "Loan Payment";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 320);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(1264, 653);
            dataGridView1.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(36, 188);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(274, 37);
            label6.TabIndex = 39;
            label6.Text = "Customer Name:";
            // 
            // backButton
            // 
            backButton.BackColor = SystemColors.Window;
            backButton.BackgroundImage = Properties.Resources.back;
            backButton.BackgroundImageLayout = ImageLayout.Stretch;
            backButton.FlatStyle = FlatStyle.Popup;
            backButton.Location = new Point(1323, 717);
            backButton.Margin = new Padding(4, 5, 4, 5);
            backButton.Name = "backButton";
            backButton.Size = new Size(113, 100);
            backButton.TabIndex = 46;
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // nextButton
            // 
            nextButton.BackColor = SystemColors.Window;
            nextButton.BackgroundImage = Properties.Resources.next;
            nextButton.BackgroundImageLayout = ImageLayout.Stretch;
            nextButton.FlatStyle = FlatStyle.Popup;
            nextButton.Location = new Point(1479, 717);
            nextButton.Margin = new Padding(4, 5, 4, 5);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(113, 100);
            nextButton.TabIndex = 47;
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // name
            // 
            name.AcceptsReturn = true;
            name.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.Location = new Point(36, 237);
            name.Margin = new Padding(4, 5, 4, 5);
            name.Name = "name";
            name.ReadOnly = true;
            name.Size = new Size(507, 43);
            name.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1011, 188);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(168, 37);
            label8.TabIndex = 49;
            label8.Text = "Fees Left:";
            // 
            // feesLeft
            // 
            feesLeft.BackColor = SystemColors.Control;
            feesLeft.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            feesLeft.Location = new Point(1011, 235);
            feesLeft.Margin = new Padding(4, 5, 4, 5);
            feesLeft.Name = "feesLeft";
            feesLeft.ReadOnly = true;
            feesLeft.Size = new Size(289, 43);
            feesLeft.TabIndex = 50;
            // 
            // PaymentControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(feesLeft);
            Controls.Add(label8);
            Controls.Add(name);
            Controls.Add(nextButton);
            Controls.Add(backButton);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(CancelButton);
            Controls.Add(AddButton);
            Controls.Add(Income);
            Controls.Add(label5);
            Controls.Add(label1);
            Margin = new Padding(6, 5, 6, 5);
            Name = "PaymentControl";
            Size = new Size(1634, 1073);
            Load += AddPaymentControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox Income;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private Button backButton;
        private Button nextButton;
        private TextBox name;
        private Label label8;
        private TextBox feesLeft;
    }
}
