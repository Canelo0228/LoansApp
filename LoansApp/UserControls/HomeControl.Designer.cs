namespace LoansApp.UserControls
{
    partial class HomeControl
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
            searchButton = new Button();
            parameterValue = new TextBox();
            Parameter = new ComboBox();
            label14 = new Label();
            dataGridView1 = new DataGridView();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.BackColor = SystemColors.Info;
            cancelButton.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelButton.Location = new Point(979, 94);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(143, 44);
            cancelButton.TabIndex = 55;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // searchButton
            // 
            searchButton.BackColor = SystemColors.Info;
            searchButton.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchButton.Location = new Point(844, 94);
            searchButton.Margin = new Padding(2);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(120, 44);
            searchButton.TabIndex = 53;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // parameterValue
            // 
            parameterValue.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parameterValue.Location = new Point(258, 100);
            parameterValue.Margin = new Padding(2);
            parameterValue.Name = "parameterValue";
            parameterValue.Size = new Size(384, 38);
            parameterValue.TabIndex = 52;
            // 
            // Parameter
            // 
            Parameter.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Parameter.FormattingEnabled = true;
            Parameter.Items.AddRange(new object[] { "Name", "Number", "TotalIncome", "Value" });
            Parameter.Location = new Point(22, 99);
            Parameter.Margin = new Padding(2);
            Parameter.Name = "Parameter";
            Parameter.Size = new Size(215, 39);
            Parameter.TabIndex = 51;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(16, 66);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(221, 26);
            label14.TabIndex = 50;
            label14.Text = "Search parameters:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 147);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(1100, 375);
            dataGridView1.TabIndex = 45;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = SystemColors.Info;
            deleteButton.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteButton.Location = new Point(969, 535);
            deleteButton.Margin = new Padding(2);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(153, 42);
            deleteButton.TabIndex = 56;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // HomeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(deleteButton);
            Controls.Add(cancelButton);
            Controls.Add(searchButton);
            Controls.Add(parameterValue);
            Controls.Add(Parameter);
            Controls.Add(label14);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "HomeControl";
            Size = new Size(1144, 644);
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox parameterValue;
        private System.Windows.Forms.ComboBox Parameter;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteButton;
    }
}
