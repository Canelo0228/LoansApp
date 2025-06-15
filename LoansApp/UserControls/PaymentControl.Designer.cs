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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Year = new ComboBox();
            Month = new ComboBox();
            Day = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Number = new TextBox();
            label6 = new Label();
            label7 = new Label();
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
            CancelButton.Location = new Point(927, 455);
            CancelButton.Margin = new Padding(2);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(188, 48);
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
            AddButton.Location = new Point(927, 389);
            AddButton.Margin = new Padding(2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(188, 48);
            AddButton.TabIndex = 21;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // Income
            // 
            Income.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Income.Location = new Point(578, 141);
            Income.Margin = new Padding(2);
            Income.Name = "Income";
            Income.ReadOnly = true;
            Income.Size = new Size(160, 32);
            Income.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(578, 112);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(101, 26);
            label5.TabIndex = 19;
            label5.Text = "Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1045, 308);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 26);
            label4.TabIndex = 18;
            label4.Text = "Year:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1031, 239);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 26);
            label3.TabIndex = 17;
            label3.Text = "Month:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1054, 170);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 26);
            label2.TabIndex = 16;
            label2.Text = "Day:";
            // 
            // Year
            // 
            Year.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Year.FormattingEnabled = true;
            Year.Items.AddRange(new object[] { "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028" });
            Year.Location = new Point(927, 336);
            Year.Margin = new Padding(2);
            Year.Name = "Year";
            Year.Size = new Size(188, 33);
            Year.TabIndex = 15;
            // 
            // Month
            // 
            Month.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Month.FormattingEnabled = true;
            Month.Items.AddRange(new object[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });
            Month.Location = new Point(927, 267);
            Month.Margin = new Padding(2);
            Month.Name = "Month";
            Month.Size = new Size(188, 33);
            Month.TabIndex = 14;
            // 
            // Day
            // 
            Day.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Day.FormattingEnabled = true;
            Day.Items.AddRange(new object[] { "9", "24" });
            Day.Location = new Point(927, 198);
            Day.Margin = new Padding(2);
            Day.Name = "Day";
            Day.Size = new Size(188, 33);
            Day.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(450, 52);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 31);
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
            dataGridView1.Location = new Point(25, 192);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(885, 392);
            dataGridView1.TabIndex = 32;
            // 
            // Number
            // 
            Number.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Number.Location = new Point(403, 141);
            Number.Margin = new Padding(4, 3, 4, 3);
            Number.Name = "Number";
            Number.ReadOnly = true;
            Number.Size = new Size(160, 31);
            Number.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 113);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 25);
            label6.TabIndex = 39;
            label6.Text = "Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(403, 113);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(159, 25);
            label7.TabIndex = 40;
            label7.Text = "Loan Number:";
            // 
            // backButton
            // 
            backButton.BackColor = SystemColors.Window;
            backButton.BackgroundImage = Properties.Resources.back;
            backButton.BackgroundImageLayout = ImageLayout.Stretch;
            backButton.FlatStyle = FlatStyle.Popup;
            backButton.Location = new Point(927, 524);
            backButton.Name = "backButton";
            backButton.Size = new Size(79, 60);
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
            nextButton.Location = new Point(1036, 524);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(79, 60);
            nextButton.TabIndex = 47;
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // name
            // 
            name.AcceptsReturn = true;
            name.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.Location = new Point(25, 142);
            name.Name = "name";
            name.ReadOnly = true;
            name.Size = new Size(356, 31);
            name.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(750, 114);
            label8.Name = "label8";
            label8.Size = new Size(118, 25);
            label8.TabIndex = 49;
            label8.Text = "Fees Left:";
            // 
            // feesLeft
            // 
            feesLeft.BackColor = SystemColors.Control;
            feesLeft.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            feesLeft.Location = new Point(750, 142);
            feesLeft.Name = "feesLeft";
            feesLeft.ReadOnly = true;
            feesLeft.Size = new Size(160, 31);
            feesLeft.TabIndex = 50;
            // 
            // PaymentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(feesLeft);
            Controls.Add(label8);
            Controls.Add(name);
            Controls.Add(nextButton);
            Controls.Add(backButton);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(Number);
            Controls.Add(dataGridView1);
            Controls.Add(CancelButton);
            Controls.Add(AddButton);
            Controls.Add(Income);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Year);
            Controls.Add(Month);
            Controls.Add(Day);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PaymentControl";
            Size = new Size(1144, 644);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Year;
        private System.Windows.Forms.ComboBox Month;
        private System.Windows.Forms.ComboBox Day;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Button backButton;
        private Button nextButton;
        private TextBox name;
        private Label label8;
        private TextBox feesLeft;
    }
}
