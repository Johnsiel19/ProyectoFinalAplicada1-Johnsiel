namespace ProyectoFinalAplicada1_JohnsielCastanos.UI.Reportes
{
    partial class ProductosReporte
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
            this.crystalReportProductos = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportProductos
            // 
            this.crystalReportProductos.ActiveViewIndex = 0;
            this.crystalReportProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportProductos.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportProductos.Location = new System.Drawing.Point(0, 0);
            this.crystalReportProductos.Name = "crystalReportProductos";
            this.crystalReportProductos.ReportSource = "C:\\Users\\William\\source\\repos\\ProyectoFinalAplicada1-JohnsielCastanos\\ProyectoFin" +
    "alAplicada1-JohnsielCastanos\\UI\\Reportes\\ListadoProductos.rpt";
            this.crystalReportProductos.Size = new System.Drawing.Size(800, 450);
            this.crystalReportProductos.TabIndex = 0;
            // 
            // ProductosReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportProductos);
            this.Name = "ProductosReporte";
            this.Text = "ProductosReporte";
            this.Load += new System.EventHandler(this.ProductosReporte_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportProductos;
    }
}