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
            number = new TextBox();
            label3 = new Label();
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
            cancelButton.Location = new Point(614, 513);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(180, 54);
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
            addButton.Location = new Point(357, 513);
            addButton.Margin = new Padding(2);
            addButton.Name = "addButton";
            addButton.Size = new Size(180, 54);
            addButton.TabIndex = 34;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += AddLoanButton;
            // 
            // value
            // 
            value.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            value.Location = new Point(615, 453);
            value.Margin = new Padding(2);
            value.Name = "value";
            value.Size = new Size(369, 38);
            value.TabIndex = 33;
            value.TextChanged += CalculateFees;
            value.KeyPress += OnlyNumbersAllow;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(620, 415);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(160, 31);
            label8.TabIndex = 32;
            label8.Text = "Loan Value";
            // 
            // capital
            // 
            capital.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            capital.Location = new Point(168, 453);
            capital.Margin = new Padding(2);
            capital.Name = "capital";
            capital.ReadOnly = true;
            capital.Size = new Size(369, 38);
            capital.TabIndex = 31;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(173, 415);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(106, 31);
            label7.TabIndex = 30;
            label7.Text = "Capital";
            // 
            // interest
            // 
            interest.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            interest.Location = new Point(615, 346);
            interest.Margin = new Padding(2);
            interest.Name = "interest";
            interest.Size = new Size(367, 38);
            interest.TabIndex = 29;
            interest.TextChanged += CalculateCapital;
            interest.KeyPress += OnlyNumbersAllow;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(620, 308);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(114, 31);
            label6.TabIndex = 28;
            label6.Text = "Interest";
            // 
            // totalIncome
            // 
            totalIncome.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalIncome.Location = new Point(168, 346);
            totalIncome.Margin = new Padding(2);
            totalIncome.Name = "totalIncome";
            totalIncome.Size = new Size(369, 38);
            totalIncome.TabIndex = 27;
            totalIncome.TextChanged += CalculateInterest;
            totalIncome.KeyPress += OnlyNumbersAllow;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(173, 308);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(183, 31);
            label5.TabIndex = 26;
            label5.Text = "Total Income";
            // 
            // payDay
            // 
            payDay.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payDay.Location = new Point(467, 244);
            payDay.Margin = new Padding(2);
            payDay.Name = "payDay";
            payDay.Size = new Size(218, 38);
            payDay.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(470, 206);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 31);
            label4.TabIndex = 24;
            label4.Text = "PayDay";
            // 
            // number
            // 
            number.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number.Location = new Point(168, 244);
            number.Margin = new Padding(2);
            number.Name = "number";
            number.Size = new Size(218, 38);
            number.TabIndex = 23;
            number.KeyPress += OnlyNumbersAllow;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(173, 206);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(30, 31);
            label3.TabIndex = 22;
            label3.Text = "#";
            // 
            // name
            // 
            name.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.Location = new Point(168, 139);
            name.Margin = new Padding(2);
            name.Multiline = true;
            name.Name = "name";
            name.Size = new Size(816, 43);
            name.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(173, 101);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 31);
            label2.TabIndex = 20;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(470, 58);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.MinimumSize = new Size(220, 28);
            label1.Name = "label1";
            label1.Size = new Size(222, 31);
            label1.TabIndex = 19;
            label1.Text = "Add a new Loan";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(768, 206);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(79, 31);
            label9.TabIndex = 36;
            label9.Text = "Fees";
            // 
            // fees
            // 
            fees.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fees.Location = new Point(764, 244);
            fees.Margin = new Padding(2);
            fees.Name = "fees";
            fees.ReadOnly = true;
            fees.Size = new Size(218, 38);
            fees.TabIndex = 37;
            // 
            // AddLoanControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            Controls.Add(number);
            Controls.Add(label3);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AddLoanControl";
            Size = new Size(1144, 593);
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
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox fees;
    }
}
