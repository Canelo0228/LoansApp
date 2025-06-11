namespace PrestamosApp.UserControls
{
    partial class EditarPrestamoControl
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
            valor = new TextBox();
            label8 = new Label();
            capital = new TextBox();
            label7 = new Label();
            interes = new TextBox();
            label6 = new Label();
            cobro = new TextBox();
            label5 = new Label();
            dia = new TextBox();
            label4 = new Label();
            number = new TextBox();
            label3 = new Label();
            name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cuotas = new TextBox();
            label9 = new Label();
            SuspendLayout();
            // 
            // cancelarButton
            // 
            cancelarButton.BackColor = SystemColors.Info;
            cancelarButton.FlatStyle = FlatStyle.Flat;
            cancelarButton.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelarButton.Location = new Point(610, 524);
            cancelarButton.Margin = new Padding(2);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(180, 54);
            cancelarButton.TabIndex = 52;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = false;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // aceptarButton
            // 
            aceptarButton.BackColor = SystemColors.Info;
            aceptarButton.FlatStyle = FlatStyle.Flat;
            aceptarButton.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aceptarButton.Location = new Point(345, 524);
            aceptarButton.Margin = new Padding(2);
            aceptarButton.Name = "aceptarButton";
            aceptarButton.Size = new Size(180, 54);
            aceptarButton.TabIndex = 51;
            aceptarButton.Text = "Aceptar";
            aceptarButton.UseVisualStyleBackColor = false;
            aceptarButton.Click += aceptarButton_Click;
            // 
            // valor
            // 
            valor.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            valor.Location = new Point(610, 454);
            valor.Margin = new Padding(2);
            valor.Name = "valor";
            valor.Size = new Size(361, 38);
            valor.TabIndex = 50;
            valor.TextChanged += CalcularCuotasTotal;
            valor.KeyPress += valor_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(615, 416);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(214, 31);
            label8.TabIndex = 49;
            label8.Text = "Valor Prestamo";
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
            // interes
            // 
            interes.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            interes.Location = new Point(610, 350);
            interes.Margin = new Padding(2);
            interes.Name = "interes";
            interes.Size = new Size(361, 38);
            interes.TabIndex = 46;
            interes.TextChanged += CalcularCapital;
            interes.KeyPress += interes_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(615, 312);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(105, 31);
            label6.TabIndex = 45;
            label6.Text = "Interes";
            // 
            // cobro
            // 
            cobro.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cobro.Location = new Point(155, 350);
            cobro.Margin = new Padding(2);
            cobro.Name = "cobro";
            cobro.Size = new Size(369, 38);
            cobro.TabIndex = 44;
            cobro.TextChanged += CalcularCuotasTotal;
            cobro.KeyPress += cobro_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(155, 312);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(167, 31);
            label5.TabIndex = 43;
            label5.Text = "Cobro Total";
            // 
            // dia
            // 
            dia.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dia.Location = new Point(440, 245);
            dia.Margin = new Padding(2);
            dia.Name = "dia";
            dia.Size = new Size(242, 38);
            dia.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(445, 207);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(170, 31);
            label4.TabIndex = 41;
            label4.Text = "Dia de pago";
            // 
            // number
            // 
            number.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number.Location = new Point(155, 245);
            number.Margin = new Padding(2);
            number.Name = "number";
            number.Size = new Size(242, 38);
            number.TabIndex = 40;
            number.KeyPress += number_KeyPress;
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
            label3.Text = "# - Numero";
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
            label2.Size = new Size(116, 31);
            label2.TabIndex = 37;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(460, 70);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.MinimumSize = new Size(320, 28);
            label1.Name = "label1";
            label1.Size = new Size(320, 31);
            label1.TabIndex = 36;
            label1.Text = "Editar Prestamo";
            // 
            // cuotas
            // 
            cuotas.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuotas.Location = new Point(729, 245);
            cuotas.Margin = new Padding(2);
            cuotas.Name = "cuotas";
            cuotas.ReadOnly = true;
            cuotas.Size = new Size(242, 38);
            cuotas.TabIndex = 54;
            cuotas.KeyPress += cuotas_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(740, 207);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(107, 31);
            label9.TabIndex = 53;
            label9.Text = "Cuotas";
            // 
            // EditarPrestamoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cuotas);
            Controls.Add(label9);
            Controls.Add(cancelarButton);
            Controls.Add(aceptarButton);
            Controls.Add(valor);
            Controls.Add(label8);
            Controls.Add(capital);
            Controls.Add(label7);
            Controls.Add(interes);
            Controls.Add(label6);
            Controls.Add(cobro);
            Controls.Add(label5);
            Controls.Add(dia);
            Controls.Add(label4);
            Controls.Add(number);
            Controls.Add(label3);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "EditarPrestamoControl";
            Size = new Size(1144, 644);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox capital;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox interes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cobro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cuotas;
        private System.Windows.Forms.Label label9;
    }
}
