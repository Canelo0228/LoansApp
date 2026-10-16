namespace LoansApp.UserControls
{
    partial class AddLoanControl
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
            cancelButton = new Button();
            addButton = new Button();
            value = new TextBox();
            label8 = new Label();
            capital = new TextBox();
            label7 = new Label();
            interest = new TextBox();
            label6 = new Label();
            totalIncome = new TextBox();
            label5 = new Label();
            payDay = new TextBox();
            label4 = new Label();
            name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            fees = new TextBox();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.BackColor = SystemColors.Info;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelButton.Location = new Point(877, 855);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(257, 90);
            cancelButton.TabIndex = 35;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += CancelButton;
            // 
            // addButton
            // 
            addButton.BackColor = SystemColors.Info;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.Location = new Point(510, 855);
            addButton.Name = "addButton";
            addButton.Size = new Size(257, 90);
            addButton.TabIndex = 34;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += AddLoanButton;
            // 
            // value
            // 
            value.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            value.Location = new Point(879, 755);
            value.Name = "value";
            value.Size = new Size(525, 53);
            value.TabIndex = 33;
            value.TextChanged += CalculateFees;
            value.KeyPress += OnlyNumbersAllow;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(886, 692);
            label8.Name = "label8";
            label8.Size = new Size(440, 47);
            label8.TabIndex = 32;
            label8.Text = "Original Loan Amount";
            // 
            // capital
            // 
            capital.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            capital.Location = new Point(240, 755);
            capital.Name = "capital";
            capital.ReadOnly = true;
            capital.Size = new Size(525, 53);
            capital.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(247, 692);
            label7.Name = "label7";
            label7.Size = new Size(354, 47);
            label7.TabIndex = 30;
            label7.Text = "Monthly Principal";
            // 
            // interest
            // 
            interest.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            interest.Location = new Point(879, 577);
            interest.Name = "interest";
            interest.Size = new Size(523, 53);
            interest.TabIndex = 29;
            interest.TextChanged += CalculateCapital;
            interest.KeyPress += OnlyNumbersAllow;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(886, 513);
            label6.Name = "label6";
            label6.Size = new Size(329, 47);
            label6.TabIndex = 28;
            label6.Text = "Monthly Interest";
            // 
            // totalIncome
            // 
            totalIncome.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalIncome.Location = new Point(240, 577);
            totalIncome.Name = "totalIncome";
            totalIncome.Size = new Size(525, 53);
            totalIncome.TabIndex = 27;
            totalIncome.TextChanged += CalculateInterest;
            totalIncome.KeyPress += OnlyNumbersAllow;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(247, 513);
            label5.Name = "label5";
            label5.Size = new Size(325, 47);
            label5.TabIndex = 26;
            label5.Text = "Monthly Income";
            // 
            // payDay
            // 
            payDay.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payDay.Location = new Point(236, 407);
            payDay.Name = "payDay";
            payDay.Size = new Size(529, 53);
            payDay.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(240, 343);
            label4.Name = "label4";
            label4.Size = new Size(278, 47);
            label4.TabIndex = 24;
            label4.Text = "Payment Day";
            // 
            // name
            // 
            name.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.Location = new Point(240, 232);
            name.Multiline = true;
            name.Name = "name";
            name.Size = new Size(1164, 69);
            name.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(247, 168);
            label2.Name = "label2";
            label2.Size = new Size(333, 47);
            label2.TabIndex = 20;
            label2.Text = "Customer Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(671, 97);
            label1.MinimumSize = new Size(314, 47);
            label1.Name = "label1";
            label1.Size = new Size(331, 47);
            label1.TabIndex = 19;
            label1.Text = "Add a new Loan";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(886, 343);
            label9.Name = "label9";
            label9.Size = new Size(116, 47);
            label9.TabIndex = 36;
            label9.Text = "Fees";
            // 
            // fees
            // 
            fees.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fees.Location = new Point(880, 407);
            fees.Name = "fees";
            fees.ReadOnly = true;
            fees.Size = new Size(524, 53);
            fees.TabIndex = 37;
            // 
            // AddLoanControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(fees);
            Controls.Add(label9);
            Controls.Add(cancelButton);
            Controls.Add(addButton);
            Controls.Add(value);
            Controls.Add(label8);
            Controls.Add(capital);
            Controls.Add(label7);
            Controls.Add(interest);
            Controls.Add(label6);
            Controls.Add(totalIncome);
            Controls.Add(label5);
            Controls.Add(payDay);
            Controls.Add(label4);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(6, 5, 6, 5);
            Name = "AddLoanControl";
            Size = new Size(1634, 988);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox capital;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox interest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalIncome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox payDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox fees;
    }
}
