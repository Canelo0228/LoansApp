namespace PrestamosApp.UserControls
{
    partial class RegistrarPagoControl
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
            aceptarButton = new Button();
            cantidad = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            year = new ComboBox();
            mes = new ComboBox();
            dia = new ComboBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            comboBox2 = new ComboBox();
            buscarPagoButton = new Button();
            comboBox1 = new ComboBox();
            name = new TextBox();
            number = new TextBox();
            label6 = new Label();
            label7 = new Label();
            cuotas = new TextBox();
            capital = new TextBox();
            balance = new TextBox();
            valor = new TextBox();
            interes = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // cancelarButton
            // 
            cancelarButton.BackColor = SystemColors.Info;
            cancelarButton.FlatStyle = FlatStyle.Flat;
            cancelarButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelarButton.Location = new Point(1010, 142);
            cancelarButton.Margin = new Padding(2);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(109, 48);
            cancelarButton.TabIndex = 22;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = false;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // aceptarButton
            // 
            aceptarButton.BackColor = SystemColors.Info;
            aceptarButton.FlatStyle = FlatStyle.Flat;
            aceptarButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aceptarButton.Location = new Point(1010, 74);
            aceptarButton.Margin = new Padding(2);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(109, 48);
            aceptarButton.TabIndex = 21;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = false;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // cantidad
            // 
            cantidad.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cantidad.Location = new Point(749, 159);
            cantidad.Margin = new Padding(2);
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
            cantidad.Size = new Size(190, 32);
            cantidad.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(749, 130);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(84, 26);
            label5.TabIndex = 19;
            label5.Text = "Monto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(507, 125);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 26);
            label4.TabIndex = 18;
            label4.Text = "Año:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(256, 124);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 26);
            label3.TabIndex = 17;
            label3.Text = "Mes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 122);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 26);
            label2.TabIndex = 16;
            label2.Text = "Dia:";
            // 
            // year
            // 
            year.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            year.FormattingEnabled = true;
            year.Items.AddRange(new object[] { "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028" });
            year.Location = new Point(500, 157);
            year.Margin = new Padding(2);
            year.Name = "year";
            year.Size = new Size(188, 33);
            year.TabIndex = 15;
            // 
            // mes
            // 
            mes.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mes.FormattingEnabled = true;
            mes.Items.AddRange(new object[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });
            mes.Location = new Point(255, 154);
            mes.Margin = new Padding(2);
            mes.Name = "mes";
            mes.Size = new Size(188, 33);
            mes.TabIndex = 14;
            // 
            // dia
            // 
            dia.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dia.FormattingEnabled = true;
            dia.Items.AddRange(new object[] { "9", "24" });
            dia.Location = new Point(20, 154);
            dia.Margin = new Padding(2);
            dia.Name = "dia";
            dia.Size = new Size(186, 33);
            dia.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 50);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(209, 31);
            label1.TabIndex = 12;
            label1.Text = "Registrar Pago";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 204);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(1094, 196);
            dataGridView1.TabIndex = 32;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(25, 475);
            dataGridView2.Margin = new Padding(2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 28;
            dataGridView2.Size = new Size(1095, 114);
            dataGridView2.TabIndex = 33;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Enero - Junio", "Julio - Diciembre" });
            comboBox2.Location = new Point(656, 424);
            comboBox2.Margin = new Padding(2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(229, 32);
            comboBox2.TabIndex = 36;
            // 
            // buscarPagoButton
            // 
            buscarPagoButton.BackColor = SystemColors.Info;
            buscarPagoButton.FlatStyle = FlatStyle.Flat;
            buscarPagoButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buscarPagoButton.Location = new Point(918, 420);
            buscarPagoButton.Margin = new Padding(2);
            buscarPagoButton.Name = "buscarPagoButton";
            buscarPagoButton.Size = new Size(202, 42);
            buscarPagoButton.TabIndex = 35;
            buscarPagoButton.Text = "Buscar pagos";
            buscarPagoButton.UseVisualStyleBackColor = false;
            buscarPagoButton.Click += buscarPagoButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028" });
            comboBox1.Location = new Point(539, 423);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(88, 32);
            comboBox1.TabIndex = 34;
            // 
            // name
            // 
            name.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name.Location = new Point(363, 82);
            name.Margin = new Padding(4, 3, 4, 3);
            name.Name = "name";
            name.ReadOnly = true;
            name.Size = new Size(426, 31);
            name.TabIndex = 37;
            // 
            // number
            // 
            number.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number.Location = new Point(826, 82);
            number.Margin = new Padding(4, 3, 4, 3);
            number.Name = "number";
            number.ReadOnly = true;
            number.Size = new Size(112, 31);
            number.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(368, 50);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(93, 25);
            label6.TabIndex = 39;
            label6.Text = "Nombre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(832, 50);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(25, 25);
            label7.TabIndex = 40;
            label7.Text = "#";
            // 
            // cuotas
            // 
            cuotas.Location = new Point(863, 612);
            cuotas.Margin = new Padding(4, 3, 4, 3);
            cuotas.Name = "cuotas";
            cuotas.Size = new Size(36, 23);
            cuotas.TabIndex = 41;
            cuotas.Visible = false;
            // 
            // capital
            // 
            capital.Location = new Point(907, 612);
            capital.Margin = new Padding(4, 3, 4, 3);
            capital.Name = "capital";
            capital.Size = new Size(36, 23);
            capital.TabIndex = 42;
            capital.Visible = false;
            // 
            // balance
            // 
            balance.Location = new Point(951, 612);
            balance.Margin = new Padding(4, 3, 4, 3);
            balance.Name = "balance";
            balance.Size = new Size(39, 23);
            balance.TabIndex = 43;
            balance.Visible = false;
            // 
            // valor
            // 
            valor.Location = new Point(1010, 612);
            valor.Margin = new Padding(4, 3, 4, 3);
            valor.Name = "valor";
            valor.Size = new Size(36, 23);
            valor.TabIndex = 44;
            valor.Visible = false;
            // 
            // interes
            // 
            interes.Location = new Point(1071, 612);
            interes.Margin = new Padding(4, 3, 4, 3);
            interes.Name = "interes";
            interes.Size = new Size(48, 23);
            interes.TabIndex = 45;
            interes.Visible = false;
            // 
            // RegistrarPagoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(interes);
            Controls.Add(valor);
            Controls.Add(balance);
            Controls.Add(capital);
            Controls.Add(cuotas);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(number);
            Controls.Add(name);
            Controls.Add(comboBox2);
            Controls.Add(buscarPagoButton);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(cantidad);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(year);
            Controls.Add(mes);
            Controls.Add(dia);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "RegistrarPagoControl";
            Size = new Size(1144, 644);
            Load += RegistrarPagoControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox year;
        private System.Windows.Forms.ComboBox mes;
        private System.Windows.Forms.ComboBox dia;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button buscarPagoButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox cuotas;
        private System.Windows.Forms.TextBox capital;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.TextBox interes;
    }
}
