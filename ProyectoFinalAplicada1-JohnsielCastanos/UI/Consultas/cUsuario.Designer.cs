﻿namespace ProyectoFinalAplicada1_JohnsielCastanos.Consultas
{
    partial class cUsuario
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.Consultarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::ProyectoFinalAplicada1_JohnsielCastanos.Properties.Resources.print_102332;
            this.button1.Location = new System.Drawing.Point(801, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 49);
            this.button1.TabIndex = 30;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FiltroFecha
            // 
            this.FiltroFecha.AutoSize = true;
            this.FiltroFecha.Location = new System.Drawing.Point(249, 45);
            this.FiltroFecha.Name = "FiltroFecha";
            this.FiltroFecha.Size = new System.Drawing.Size(109, 21);
            this.FiltroFecha.TabIndex = 52;
            this.FiltroFecha.Text = "Filtrar Fecha";
            this.FiltroFecha.UseVisualStyleBackColor = true;
            this.FiltroFecha.CheckedChanged += new System.EventHandler(this.FiltroFecha_CheckedChanged);
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.AllowUserToAddRows = false;
            this.ConsultadataGridView.AllowUserToDeleteRows = false;
            this.ConsultadataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(18, 81);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.ReadOnly = true;
            this.ConsultadataGridView.RowTemplate.Height = 24;
            this.ConsultadataGridView.Size = new System.Drawing.Size(841, 302);
            this.ConsultadataGridView.TabIndex = 51;
            this.ConsultadataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ConsultadataGridView_CellContentClick);
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(495, 44);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(239, 22);
            this.CriteriotextBox.TabIndex = 50;
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
            "Usuario",
            "NivelUsuario"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(364, 42);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(121, 24);
            this.FiltrocomboBox.TabIndex = 49;
            this.FiltrocomboBox.SelectedIndexChanged += new System.EventHandler(this.FiltrocomboBox_SelectedIndexChanged);
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(130, 44);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(108, 22);
            this.HastadateTimePicker.TabIndex = 48;
            this.HastadateTimePicker.ValueChanged += new System.EventHandler(this.HastadateTimePicker_ValueChanged);
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(18, 44);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(106, 22);
            this.DesdedateTimePicker.TabIndex = 47;
            this.DesdedateTimePicker.ValueChanged += new System.EventHandler(this.DesdedateTimePicker_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Criterio";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Filtro";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Hasta";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Desde";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Consultarbutton
            // 
            this.Consultarbutton.Image = global::ProyectoFinalAplicada1_JohnsielCastanos.Properties.Resources.search_locate_find_13974;
            this.Consultarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Consultarbutton.Location = new System.Drawing.Point(750, 37);
            this.Consultarbutton.Name = "Consultarbutton";
            this.Consultarbutton.Size = new System.Drawing.Size(109, 33);
            this.Consultarbutton.TabIndex = 24;
            this.Consultarbutton.Text = "Consultar";
            this.Consultarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Consultarbutton.UseVisualStyleBackColor = true;
            this.Consultarbutton.Click += new System.EventHandler(this.Consultarbutton_Click);
            // 
            // cUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 468);
            this.Controls.Add(this.FiltroFecha);
            this.Controls.Add(this.ConsultadataGridView);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Consultarbutton);
            this.Name = "cUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta  de Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Consultarbutton;
        private System.Windows.Forms.Button button1;
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
    }
}