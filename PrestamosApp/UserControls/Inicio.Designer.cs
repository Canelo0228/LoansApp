namespace PrestamosApp.UserControls
{
    partial class Inicio
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
            cancelarButton = new Button();
            buscarButton = new Button();
            valorParametro = new TextBox();
            parametro = new ComboBox();
            label14 = new Label();
            dataGridView1 = new DataGridView();
            eliminarButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cancelarButton
            // 
            cancelarButton.BackColor = SystemColors.Info;
            cancelarButton.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            cancelarButton.FlatStyle = FlatStyle.Flat;
            cancelarButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelarButton.Location = new Point(887, 94);
            cancelarButton.Margin = new Padding(2);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(235, 44);
            cancelarButton.TabIndex = 55;
            cancelarButton.Text = "Cancelar busqueda";
            cancelarButton.UseVisualStyleBackColor = false;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // buscarButton
            // 
            buscarButton.BackColor = SystemColors.Info;
            buscarButton.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            buscarButton.FlatStyle = FlatStyle.Flat;
            buscarButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buscarButton.Location = new Point(753, 94);
            buscarButton.Margin = new Padding(2);
            buscarButton.Name = "buscarButton";
            buscarButton.Size = new Size(120, 44);
            buscarButton.TabIndex = 53;
            buscarButton.Text = "Buscar";
            buscarButton.UseVisualStyleBackColor = false;
            buscarButton.Click += buscarButton_Click;
            // 
            // valorParametro
            // 
            valorParametro.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            valorParametro.Location = new Point(190, 100);
            valorParametro.Margin = new Padding(2);
            valorParametro.Name = "valorParametro";
            valorParametro.Size = new Size(384, 38);
            valorParametro.TabIndex = 52;
            // 
            // parametro
            // 
            parametro.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parametro.FormattingEnabled = true;
            parametro.Items.AddRange(new object[] { "NOMBRE", "#", "COBRO TOTAL", "VALOR" });
            parametro.Location = new Point(22, 105);
            parametro.Margin = new Padding(2);
            parametro.Name = "parametro";
            parametro.Size = new Size(150, 28);
            parametro.TabIndex = 51;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(16, 66);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(134, 26);
            label14.TabIndex = 50;
            label14.Text = "Buscar por:";
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
            // eliminarButton
            // 
            eliminarButton.BackColor = SystemColors.Info;
            eliminarButton.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            eliminarButton.FlatStyle = FlatStyle.Flat;
            eliminarButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            eliminarButton.Location = new Point(869, 535);
            eliminarButton.Margin = new Padding(2);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(253, 42);
            eliminarButton.TabIndex = 56;
            eliminarButton.Text = "Eliminar prestamo";
            eliminarButton.UseVisualStyleBackColor = false;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(eliminarButton);
            Controls.Add(cancelarButton);
            Controls.Add(buscarButton);
            Controls.Add(valorParametro);
            Controls.Add(parametro);
            Controls.Add(label14);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Inicio";
            Size = new Size(1144, 644);
            Load += Inicio_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.TextBox valorParametro;
        private System.Windows.Forms.ComboBox parametro;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button eliminarButton;
    }
}
