namespace PrestamosApp.UserControls
{
    partial class RegistrarPrestamoControl
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
            agregarButton = new Button();
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
            label9 = new Label();
            cuotas = new TextBox();
            SuspendLayout();
            // 
            // cancelarButton
            // 
            cancelarButton.BackColor = SystemColors.Info;
            cancelarButton.FlatStyle = FlatStyle.Flat;
            cancelarButton.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelarButton.Location = new Point(614, 513);
            cancelarButton.Margin = new Padding(2);
            cancelarButton.Name = "cancelarButton";
            cancelarButton.Size = new Size(180, 54);
            cancelarButton.TabIndex = 35;
            cancelarButton.Text = "Cancelar";
            cancelarButton.UseVisualStyleBackColor = false;
            cancelarButton.Click += cancelarButton_Click;
            // 
            // agregarButton
            // 
            agregarButton.BackColor = SystemColors.Info;
            agregarButton.FlatStyle = FlatStyle.Flat;
            agregarButton.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            agregarButton.Location = new Point(357, 513);
            agregarButton.Margin = new Padding(2);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(180, 54);
            agregarButton.TabIndex = 34;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = false;
            agregarButton.Click += agregarButton_Click;
            // 
            // valor
            // 
            valor.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            valor.Location = new Point(615, 453);
            valor.Margin = new Padding(2);
            valor.Name = "valor";
            valor.Size = new Size(369, 38);
            valor.TabIndex = 33;
            valor.TextChanged += CalcularCuotasTotal;
            valor.KeyPress += valor_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(620, 415);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(214, 31);
            label8.TabIndex = 32;
            label8.Text = "Valor Prestamo";
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
            // interes
            // 
            interes.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            interes.Location = new Point(615, 346);
            interes.Margin = new Padding(2);
            interes.Name = "interes";
            interes.Size = new Size(367, 38);
            interes.TabIndex = 29;
            interes.TextChanged += CalcularCapital;
            interes.KeyPress += interes_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(620, 308);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(105, 31);
            label6.TabIndex = 28;
            label6.Text = "Interes";
            // 
            // cobro
            // 
            cobro.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cobro.Location = new Point(168, 346);
            cobro.Margin = new Padding(2);
            cobro.Name = "cobro";
            cobro.Size = new Size(369, 38);
            cobro.TabIndex = 27;
            cobro.TextChanged += CalcularCuotasTotal;
            cobro.KeyPress += cobro_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(173, 308);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(167, 31);
            label5.TabIndex = 26;
            label5.Text = "Cobro Total";
            // 
            // dia
            // 
            dia.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dia.Location = new Point(467, 244);
            dia.Margin = new Padding(2);
            dia.Name = "dia";
            dia.Size = new Size(218, 38);
            dia.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(470, 206);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(170, 31);
            label4.TabIndex = 24;
            label4.Text = "Dia de pago";
            // 
            // number
            // 
            number.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            number.Location = new Point(168, 244);
            number.Margin = new Padding(2);
            number.Name = "number";
            number.Size = new Size(218, 38);
            number.TabIndex = 23;
            number.KeyPress += number_KeyPress;
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
            label2.Size = new Size(116, 31);
            label2.TabIndex = 20;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(403, 62);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.MinimumSize = new Size(320, 28);
            label1.Name = "label1";
            label1.Size = new Size(353, 31);
            label1.TabIndex = 19;
            label1.Text = "Registrar nuevo Prestamo";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(768, 206);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(107, 31);
            label9.TabIndex = 36;
            label9.Text = "Cuotas";
            // 
            // cuotas
            // 
            cuotas.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuotas.Location = new Point(764, 244);
            cuotas.Margin = new Padding(2);
            cuotas.Name = "cuotas";
            cuotas.ReadOnly = true;
            cuotas.Size = new Size(218, 38);
            cuotas.TabIndex = 37;
            cuotas.KeyPress += cuotas_KeyPress;
            // 
            // RegistrarPrestamoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cuotas);
            Controls.Add(label9);
            Controls.Add(cancelarButton);
            Controls.Add(agregarButton);
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
            Name = "RegistrarPrestamoControl";
            Size = new Size(1144, 593);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button agregarButton;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cuotas;
    }
}
