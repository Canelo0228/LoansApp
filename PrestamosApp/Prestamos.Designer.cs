namespace PrestamosApp
{
    partial class Prestamos
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMain = new Panel();
            menuStrip = new MenuStrip();
            Inicio = new ToolStripMenuItem();
            registrarPrestamo = new ToolStripMenuItem();
            editarPrestamo = new ToolStripMenuItem();
            registrarPago = new ToolStripMenuItem();
            historial = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = SystemColors.Window;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1128, 605);
            panelMain.TabIndex = 0;
            // 
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.Info;
            menuStrip.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            menuStrip.GripMargin = new Padding(2);
            menuStrip.GripStyle = ToolStripGripStyle.Visible;
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { Inicio, registrarPrestamo, editarPrestamo, registrarPago, historial });
            menuStrip.LayoutStyle = ToolStripLayoutStyle.Flow;
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(60, 2, 60, 2);
            menuStrip.RenderMode = ToolStripRenderMode.Professional;
            menuStrip.Size = new Size(1128, 40);
            menuStrip.TabIndex = 49;
            menuStrip.Text = "menuStrip2";
            // 
            // Inicio
            // 
            Inicio.Name = "Inicio";
            Inicio.Size = new Size(89, 36);
            Inicio.Text = "Inicio";
            Inicio.Click += Inicio_Click;
            // 
            // registrarPrestamo
            // 
            registrarPrestamo.Name = "registrarPrestamo";
            registrarPrestamo.Size = new Size(243, 36);
            registrarPrestamo.Text = "Registrar Prestamo";
            registrarPrestamo.Click += registrarPrestamo_Click;
            // 
            // editarPrestamo
            // 
            editarPrestamo.Name = "editarPrestamo";
            editarPrestamo.Size = new Size(208, 36);
            editarPrestamo.Text = "Editar Prestamo";
            editarPrestamo.Click += editarPrestamo_Click;
            // 
            // registrarPago
            // 
            registrarPago.Name = "registrarPago";
            registrarPago.Size = new Size(193, 36);
            registrarPago.Text = "Registrar Pago";
            registrarPago.Click += registrarPago_Click;
            // 
            // historial
            // 
            historial.Name = "historial";
            historial.Size = new Size(126, 36);
            historial.Text = "Historial";
            historial.Click += historial_Click;
            // 
            // Prestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 605);
            Controls.Add(menuStrip);
            Controls.Add(panelMain);
            Name = "Prestamos";
            Text = "Prestamos";
            Load += Prestamos_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMain;
        private MenuStrip menuStrip;
        private ToolStripMenuItem Inicio;
        private ToolStripMenuItem registrarPrestamo;
        private ToolStripMenuItem editarPrestamo;
        private ToolStripMenuItem registrarPago;
        private ToolStripMenuItem historial;
    }
}