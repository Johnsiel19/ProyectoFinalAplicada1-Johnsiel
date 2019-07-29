namespace ProyectoFinalAplicada1_JohnsielCastanos.UI.Registros
{
    partial class rProducto
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
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductoIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CostonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PrecionumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProductoItbisnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProveedorcomboBox = new System.Windows.Forms.ComboBox();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.ExistenciatextBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostonumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecionumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoItbisnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(137, 84);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(291, 22);
            this.DescripciontextBox.TabIndex = 1;
            this.DescripciontextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescripciontextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ProductoId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Existencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "ProductoItbis";
            // 
            // ProductoIdnumericUpDown
            // 
            this.ProductoIdnumericUpDown.Location = new System.Drawing.Point(137, 25);
            this.ProductoIdnumericUpDown.Name = "ProductoIdnumericUpDown";
            this.ProductoIdnumericUpDown.Size = new System.Drawing.Size(88, 22);
            this.ProductoIdnumericUpDown.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Proveedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Costo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(133, 433);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Fecha";
            // 
            // CostonumericUpDown
            // 
            this.CostonumericUpDown.DecimalPlaces = 2;
            this.CostonumericUpDown.Location = new System.Drawing.Point(137, 310);
            this.CostonumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.CostonumericUpDown.Name = "CostonumericUpDown";
            this.CostonumericUpDown.Size = new System.Drawing.Size(88, 22);
            this.CostonumericUpDown.TabIndex = 5;
            // 
            // PrecionumericUpDown
            // 
            this.PrecionumericUpDown.DecimalPlaces = 2;
            this.PrecionumericUpDown.Location = new System.Drawing.Point(137, 368);
            this.PrecionumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.PrecionumericUpDown.Name = "PrecionumericUpDown";
            this.PrecionumericUpDown.Size = new System.Drawing.Size(88, 22);
            this.PrecionumericUpDown.TabIndex = 6;
            // 
            // ProductoItbisnumericUpDown
            // 
            this.ProductoItbisnumericUpDown.DecimalPlaces = 2;
            this.ProductoItbisnumericUpDown.Location = new System.Drawing.Point(137, 253);
            this.ProductoItbisnumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ProductoItbisnumericUpDown.Name = "ProductoItbisnumericUpDown";
            this.ProductoItbisnumericUpDown.Size = new System.Drawing.Size(88, 22);
            this.ProductoItbisnumericUpDown.TabIndex = 4;
            // 
            // ProveedorcomboBox
            // 
            this.ProveedorcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProveedorcomboBox.FormattingEnabled = true;
            this.ProveedorcomboBox.Location = new System.Drawing.Point(136, 139);
            this.ProveedorcomboBox.Name = "ProveedorcomboBox";
            this.ProveedorcomboBox.Size = new System.Drawing.Size(240, 24);
            this.ProveedorcomboBox.TabIndex = 2;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(136, 428);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(292, 22);
            this.FechadateTimePicker.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 433);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 53;
            this.label9.Text = "Fecha";
            // 
            // ExistenciatextBox
            // 
            this.ExistenciatextBox.Location = new System.Drawing.Point(137, 200);
            this.ExistenciatextBox.Name = "ExistenciatextBox";
            this.ExistenciatextBox.ReadOnly = true;
            this.ExistenciatextBox.Size = new System.Drawing.Size(100, 22);
            this.ExistenciatextBox.TabIndex = 55;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ProyectoFinalAplicada1_JohnsielCastanos.Properties.Resources.add_insert_plus_1588;
            this.button1.Location = new System.Drawing.Point(388, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 39);
            this.button1.TabIndex = 54;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::ProyectoFinalAplicada1_JohnsielCastanos.Properties.Resources.nuevo;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(29, 498);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(80, 71);
            this.Nuevobutton.TabIndex = 9;
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
            this.Buscarbutton.Location = new System.Drawing.Point(241, 13);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(46, 44);
            this.Buscarbutton.TabIndex = 52;
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::ProyectoFinalAplicada1_JohnsielCastanos.Properties.Resources.eliminar;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(348, 498);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(80, 71);
            this.Eliminarbutton.TabIndex = 10;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::ProyectoFinalAplicada1_JohnsielCastanos.Properties.Resources.guardar;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(188, 498);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(80, 71);
            this.Guardarbutton.TabIndex = 8;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // rProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 593);
            this.Controls.Add(this.ExistenciatextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.ProveedorcomboBox);
            this.Controls.Add(this.ProductoItbisnumericUpDown);
            this.Controls.Add(this.PrecionumericUpDown);
            this.Controls.Add(this.CostonumericUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProductoIdnumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescripciontextBox);
            this.Name = "rProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Producto";
            ((System.ComponentModel.ISupportInitialize)(this.ProductoIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostonumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecionumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoItbisnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ProductoIdnumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown CostonumericUpDown;
        private System.Windows.Forms.NumericUpDown PrecionumericUpDown;
        private System.Windows.Forms.NumericUpDown ProductoItbisnumericUpDown;
        private System.Windows.Forms.ComboBox ProveedorcomboBox;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ExistenciatextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}