namespace ProyectoFinalAplicada1_JohnsielCastanos.UI.Registros
{
    partial class rEntradas
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductocomboBox = new System.Windows.Forms.ComboBox();
            this.EntradaIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProductoEntradanumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EntradaIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoEntradanumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "EntradaId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entrada";
            // 
            // ProductocomboBox
            // 
            this.ProductocomboBox.FormattingEnabled = true;
            this.ProductocomboBox.Location = new System.Drawing.Point(124, 93);
            this.ProductocomboBox.Name = "ProductocomboBox";
            this.ProductocomboBox.Size = new System.Drawing.Size(230, 24);
            this.ProductocomboBox.TabIndex = 2;
            // 
            // EntradaIdnumericUpDown
            // 
            this.EntradaIdnumericUpDown.Location = new System.Drawing.Point(124, 38);
            this.EntradaIdnumericUpDown.Name = "EntradaIdnumericUpDown";
            this.EntradaIdnumericUpDown.Size = new System.Drawing.Size(92, 22);
            this.EntradaIdnumericUpDown.TabIndex = 3;
            // 
            // ProductoEntradanumericUpDown
            // 
            this.ProductoEntradanumericUpDown.DecimalPlaces = 2;
            this.ProductoEntradanumericUpDown.Location = new System.Drawing.Point(124, 149);
            this.ProductoEntradanumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ProductoEntradanumericUpDown.Name = "ProductoEntradanumericUpDown";
            this.ProductoEntradanumericUpDown.Size = new System.Drawing.Size(92, 22);
            this.ProductoEntradanumericUpDown.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Producto";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(124, 208);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(230, 22);
            this.FechadateTimePicker.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 62;
            this.label4.Text = "Fecha";
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::ProyectoFinalAplicada1_JohnsielCastanos.Properties.Resources.nuevo;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(39, 285);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(80, 71);
            this.Nuevobutton.TabIndex = 59;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.FlatAppearance.BorderSize = 0;
            this.Buscarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscarbutton.Image = global::ProyectoFinalAplicada1_JohnsielCastanos.Properties.Resources.search_locate_find_13974;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(268, 24);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(45, 44);
            this.Buscarbutton.TabIndex = 61;
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::ProyectoFinalAplicada1_JohnsielCastanos.Properties.Resources.eliminar;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(274, 285);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(80, 71);
            this.Eliminarbutton.TabIndex = 60;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click_1);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::ProyectoFinalAplicada1_JohnsielCastanos.Properties.Resources.guardar;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(156, 285);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(80, 71);
            this.Guardarbutton.TabIndex = 58;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click_1);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // rEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 392);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductoEntradanumericUpDown);
            this.Controls.Add(this.EntradaIdnumericUpDown);
            this.Controls.Add(this.ProductocomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Entradas";
            ((System.ComponentModel.ISupportInitialize)(this.EntradaIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoEntradanumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ProductocomboBox;
        private System.Windows.Forms.NumericUpDown EntradaIdnumericUpDown;
        private System.Windows.Forms.NumericUpDown ProductoEntradanumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}