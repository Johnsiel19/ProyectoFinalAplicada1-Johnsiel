﻿namespace ProyectoFinalAplicada1_JohnsielCastanos.UI.Registros
{
    partial class rCobro
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
            this.label3 = new System.Windows.Forms.Label();
            this.VentacomboBox = new System.Windows.Forms.ComboBox();
            this.ClientecomboBox = new System.Windows.Forms.ComboBox();
            this.DechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MontoPagarnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CrobroIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MontoFacturatextBox = new System.Windows.Forms.TextBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MontoPagarnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrobroIdnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 109;
            this.label3.Text = "Monto a pagar";
            // 
            // VentacomboBox
            // 
            this.VentacomboBox.FormattingEnabled = true;
            this.VentacomboBox.Location = new System.Drawing.Point(92, 143);
            this.VentacomboBox.Name = "VentacomboBox";
            this.VentacomboBox.Size = new System.Drawing.Size(163, 24);
            this.VentacomboBox.TabIndex = 108;
            // 
            // ClientecomboBox
            // 
            this.ClientecomboBox.FormattingEnabled = true;
            this.ClientecomboBox.Location = new System.Drawing.Point(92, 90);
            this.ClientecomboBox.Name = "ClientecomboBox";
            this.ClientecomboBox.Size = new System.Drawing.Size(163, 24);
            this.ClientecomboBox.TabIndex = 107;
            this.ClientecomboBox.SelectedIndexChanged += new System.EventHandler(this.ClientecomboBox_SelectedIndexChanged);
            // 
            // DechadateTimePicker
            // 
            this.DechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DechadateTimePicker.Location = new System.Drawing.Point(420, 31);
            this.DechadateTimePicker.Name = "DechadateTimePicker";
            this.DechadateTimePicker.Size = new System.Drawing.Size(177, 22);
            this.DechadateTimePicker.TabIndex = 105;
            // 
            // MontoPagarnumericUpDown
            // 
            this.MontoPagarnumericUpDown.Location = new System.Drawing.Point(135, 199);
            this.MontoPagarnumericUpDown.Name = "MontoPagarnumericUpDown";
            this.MontoPagarnumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.MontoPagarnumericUpDown.TabIndex = 104;
            // 
            // CrobroIdnumericUpDown
            // 
            this.CrobroIdnumericUpDown.Location = new System.Drawing.Point(92, 34);
            this.CrobroIdnumericUpDown.Name = "CrobroIdnumericUpDown";
            this.CrobroIdnumericUpDown.Size = new System.Drawing.Size(73, 22);
            this.CrobroIdnumericUpDown.TabIndex = 103;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 102;
            this.label6.Text = "VentaId";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 101;
            this.label5.Text = "Fecha Cobro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 100;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 99;
            this.label1.Text = "CobroId";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 116;
            this.label7.Text = "Monto Factura";
            // 
            // MontoFacturatextBox
            // 
            this.MontoFacturatextBox.Location = new System.Drawing.Point(477, 200);
            this.MontoFacturatextBox.Name = "MontoFacturatextBox";
            this.MontoFacturatextBox.ReadOnly = true;
            this.MontoFacturatextBox.Size = new System.Drawing.Size(120, 22);
            this.MontoFacturatextBox.TabIndex = 115;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::ProyectoFinalAplicada1_JohnsielCastanos.Properties.Resources.nuevo;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(24, 282);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(80, 71);
            this.Nuevobutton.TabIndex = 112;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.FlatAppearance.BorderSize = 0;
            this.Buscarbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Buscarbutton.Image = global::ProyectoFinalAplicada1_JohnsielCastanos.Properties.Resources.search_locate_find_13974;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(184, 22);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(45, 44);
            this.Buscarbutton.TabIndex = 114;
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::ProyectoFinalAplicada1_JohnsielCastanos.Properties.Resources.eliminar;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(517, 282);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(80, 71);
            this.Eliminarbutton.TabIndex = 113;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::ProyectoFinalAplicada1_JohnsielCastanos.Properties.Resources.guardar;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(260, 282);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(80, 71);
            this.Guardarbutton.TabIndex = 111;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(420, 145);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 22);
            this.dateTimePicker1.TabIndex = 118;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 117;
            this.label8.Text = "Fecha Factura";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(305, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 120;
            this.label9.Text = "Balance Total";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(474, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(123, 22);
            this.textBox2.TabIndex = 119;
            // 
            // rCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 391);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MontoFacturatextBox);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VentacomboBox);
            this.Controls.Add(this.ClientecomboBox);
            this.Controls.Add(this.DechadateTimePicker);
            this.Controls.Add(this.MontoPagarnumericUpDown);
            this.Controls.Add(this.CrobroIdnumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rCobro";
            this.Text = "rCobro";
            ((System.ComponentModel.ISupportInitialize)(this.MontoPagarnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrobroIdnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox VentacomboBox;
        private System.Windows.Forms.ComboBox ClientecomboBox;
        private System.Windows.Forms.DateTimePicker DechadateTimePicker;
        private System.Windows.Forms.NumericUpDown MontoPagarnumericUpDown;
        private System.Windows.Forms.NumericUpDown CrobroIdnumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MontoFacturatextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
    }
}