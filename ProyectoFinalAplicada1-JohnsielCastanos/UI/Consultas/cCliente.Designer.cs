﻿namespace ProyectoFinalAplicada1_JohnsielCastanos.UI.Consultas
{
    partial class cCliente
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
            this.FiltroFecha = new System.Windows.Forms.CheckBox();
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Elegirbutton = new System.Windows.Forms.Button();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.Consultarbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiltroFecha
            // 
            this.FiltroFecha.AutoSize = true;
            this.FiltroFecha.Location = new System.Drawing.Point(0, 0);
            this.FiltroFecha.Name = "FiltroFecha";
            this.FiltroFecha.Size = new System.Drawing.Size(103, 21);
            this.FiltroFecha.TabIndex = 64;
            this.FiltroFecha.Text = "Usar Fecha";
            this.FiltroFecha.UseVisualStyleBackColor = true;
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.AllowUserToAddRows = false;
            this.ConsultadataGridView.AllowUserToDeleteRows = false;
            this.ConsultadataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(13, 91);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.ReadOnly = true;
            this.ConsultadataGridView.RowTemplate.Height = 24;
            this.ConsultadataGridView.Size = new System.Drawing.Size(841, 302);
            this.ConsultadataGridView.TabIndex = 63;
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(490, 54);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(239, 22);
            this.CriteriotextBox.TabIndex = 62;
            this.CriteriotextBox.TextChanged += new System.EventHandler(this.CriteriotextBox_TextChanged);
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Items.AddRange(new object[] {
            "Todo",
            "Id",
            "Nombre",
            "UsuarioId",
            "Direccion"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(359, 52);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(121, 24);
            this.FiltrocomboBox.TabIndex = 61;
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(169, 46);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(135, 22);
            this.HastadateTimePicker.TabIndex = 60;
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(1, 46);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(137, 22);
            this.DesdedateTimePicker.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "Criterio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Filtro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 56;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Desde";
            // 
            // Elegirbutton
            // 
            this.Elegirbutton.AutoSize = true;
            this.Elegirbutton.FlatAppearance.BorderSize = 0;
            this.Elegirbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Elegirbutton.Image = global::ProyectoFinalAplicada1_JohnsielCastanos.Properties.Resources.one_finger_click_black_hand_symbol_icon_icons_com_64350;
            this.Elegirbutton.Location = new System.Drawing.Point(12, 414);
            this.Elegirbutton.Name = "Elegirbutton";
            this.Elegirbutton.Size = new System.Drawing.Size(39, 41);
            this.Elegirbutton.TabIndex = 80;
            this.Elegirbutton.UseVisualStyleBackColor = true;
            this.Elegirbutton.Visible = false;
            this.Elegirbutton.Click += new System.EventHandler(this.Elegirbutton_Click);
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.AutoSize = true;
            this.Imprimirbutton.FlatAppearance.BorderSize = 0;
            this.Imprimirbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Imprimirbutton.Image = global::ProyectoFinalAplicada1_JohnsielCastanos.Properties.Resources.print_102332;
            this.Imprimirbutton.Location = new System.Drawing.Point(808, 421);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(46, 43);
            this.Imprimirbutton.TabIndex = 54;
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
            // 
            // Consultarbutton
            // 
            this.Consultarbutton.Image = global::ProyectoFinalAplicada1_JohnsielCastanos.Properties.Resources.search_locate_find_13974;
            this.Consultarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Consultarbutton.Location = new System.Drawing.Point(745, 41);
            this.Consultarbutton.Name = "Consultarbutton";
            this.Consultarbutton.Size = new System.Drawing.Size(109, 35);
            this.Consultarbutton.TabIndex = 53;
            this.Consultarbutton.Text = "Consultar";
            this.Consultarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Consultarbutton.UseVisualStyleBackColor = true;
            this.Consultarbutton.Click += new System.EventHandler(this.Consultarbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HastadateTimePicker);
            this.groupBox1.Controls.Add(this.DesdedateTimePicker);
            this.groupBox1.Controls.Add(this.FiltroFecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 83);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            // 
            // cCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 476);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Elegirbutton);
            this.Controls.Add(this.ConsultadataGridView);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.Consultarbutton);
            this.Name = "cCliente";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Clientes";
            this.Load += new System.EventHandler(this.CCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox FiltroFecha;
        private System.Windows.Forms.DataGridView ConsultadataGridView;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.Button Consultarbutton;
        private System.Windows.Forms.Button Elegirbutton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}