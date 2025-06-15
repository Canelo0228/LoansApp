namespace LoansApp.UserControls
{
    partial class UpdateLoanControl
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
            updateButton = new Button();
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
            number = new TextBox();
            label3 = new Label();
            name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            fees = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.BackColor = SystemColors.Info;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelButton.Location = new Point(610, 524);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(180, 54);
            cancelButton.TabIndex = 52;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = SystemColors.Info;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateButton.Location = new Point(345, 524);
            updateButton.Margin = new Padding(2);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(180, 54);
            updateButton.TabIndex = 51;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // value
            // 
            value.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            value.Location = new Point(610, 454);
            value.Margin = new Padding(2);
            value.Name = "value";
            value.Size = new Size(361, 38);
            value.TabIndex = 50;
            value.TextChanged += CalculateFees;
            value.KeyPress += OnlyNumbersAllow;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(615, 416);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(160, 31);
            label8.TabIndex = 49;
            label8.Text = "Loan Value";
            // 
            // capital
            // 
            capital.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            capital.Location = new Point(155, 454);
            capital.Margin = new Padding(2);
            capital.Name = "capital";
            capital.ReadOnly = true;
            capital.Size = new Size(369, 38);
            capital.TabIndex = 48;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(160, 416);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(106, 31);
            label7.TabIndex = 47;
            label7.Text = "Capital";
            // 
            // interest
            // 
            interest.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            interest.Location = new Point(610, 350);
            interest.Margin = new Padding(2);
            interest.Name = "interest";
            interest.Size = new Size(361, 38);
            interest.TabIndex = 46;
            interest.TextChanged += CalculateCapital;
            interest.KeyPress += OnlyNumbersAllow;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(615, 312);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(114, 31);
            label6.TabIndex = 45;
            label6.Text = "Interest";
            // 
            // totalIncome
            // 
            totalIncome.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalIncome.Location = new Point(155, 350);
            totalIncome.Margin = new Padding(2);
            totalIncome.Name = "totalIncome";
            totalIncome.Size = new Size(369, 38);
            totalIncome.TabIndex = 44;
            totalIncome.TextChanged += CalculateInterest;
            totalIncome.KeyPress += OnlyNumbersAllow;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(155, 312);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(219, 31);
            label5.TabIndex = 43;
            label5.Text = "Monthly Income";
            // 
            // payDay
            // 
            payDay.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payDay.Location = new Point(440, 245);
            payDay.Margin = new Padding(2);
            payDay.Name = "payDay";
            payDay.Size = new Size(242, 38);
            payDay.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(445, 207);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 31);
            label4.TabIndex = 41;
            label4.Text = "PayDay";
            // 
            // number
            // 
            number.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number.Location = new Point(155, 245);
            number.Margin = new Padding(2);
            number.Name = "number";
            number.Size = new Size(242, 38);
            number.TabIndex = 40;
            number.KeyPress += OnlyNumbersAllow;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(160, 207);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(158, 31);
            label3.TabIndex = 39;
            label3.Text = "# - Number";
            // 
            // name
            // 
            name.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.Location = new Point(155, 145);
            name.Margin = new Padding(2);
            name.Name = "name";
            name.Size = new Size(816, 38);
            name.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(160, 107);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 31);
            label2.TabIndex = 37;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(483, 71);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.MinimumSize = new Size(320, 28);
            label1.Name = "label1";
            label1.Size = new Size(320, 31);
            label1.TabIndex = 36;
            label1.Text = "Update Loan";
            // 
            // fees
            // 
            fees.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fees.Location = new Point(729, 245);
            fees.Margin = new Padding(2);
            fees.Name = "fees";
            fees.ReadOnly = true;
            fees.Size = new Size(242, 38);
            fees.TabIndex = 54;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(740, 207);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(79, 31);
            label9.TabIndex = 53;
            label9.Text = "Fees";
            // 
            // UpdateLoanControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(fees);
            Controls.Add(label9);
            Controls.Add(cancelButton);
            Controls.Add(updateButton);
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
            Controls.Add(number);
            Controls.Add(label3);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UpdateLoanControl";
            Size = new Size(1144, 644);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateButton;
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
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fees;
        private System.Windows.Forms.Label label9;
    }
}
