namespace RegistroUniversitario.UI.Consultas.Registros
{
    partial class rEstudiantes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EstudianteIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BalanceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.FechaIngresodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NombresTextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EstudianteId";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FechaIngreso";
            // 
            // EstudianteIdnumericUpDown
            // 
            this.EstudianteIdnumericUpDown.Location = new System.Drawing.Point(179, 53);
            this.EstudianteIdnumericUpDown.Name = "EstudianteIdnumericUpDown";
            this.EstudianteIdnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.EstudianteIdnumericUpDown.TabIndex = 4;
            // 
            // BalanceNumericUpDown
            // 
            this.BalanceNumericUpDown.Location = new System.Drawing.Point(179, 210);
            this.BalanceNumericUpDown.Name = "BalanceNumericUpDown";
            this.BalanceNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.BalanceNumericUpDown.TabIndex = 5;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(69, 294);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(69, 25);
            this.Nuevobutton.TabIndex = 6;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(285, 294);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(69, 25);
            this.Eliminarbutton.TabIndex = 7;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(169, 294);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(69, 25);
            this.Guardarbutton.TabIndex = 8;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            // 
            // FechaIngresodateTimePicker
            // 
            this.FechaIngresodateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaIngresodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaIngresodateTimePicker.Location = new System.Drawing.Point(179, 106);
            this.FechaIngresodateTimePicker.Name = "FechaIngresodateTimePicker";
            this.FechaIngresodateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.FechaIngresodateTimePicker.TabIndex = 9;
            // 
            // NombresTextBox
            // 
            this.NombresTextBox.Location = new System.Drawing.Point(179, 160);
            this.NombresTextBox.Name = "NombresTextBox";
            this.NombresTextBox.Size = new System.Drawing.Size(120, 20);
            this.NombresTextBox.TabIndex = 10;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(327, 48);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(69, 25);
            this.Buscarbutton.TabIndex = 11;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            // 
            // rEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 341);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.NombresTextBox);
            this.Controls.Add(this.FechaIngresodateTimePicker);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.BalanceNumericUpDown);
            this.Controls.Add(this.EstudianteIdnumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rEstudiantes";
            this.Text = "rEstudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown EstudianteIdnumericUpDown;
        private System.Windows.Forms.NumericUpDown BalanceNumericUpDown;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.DateTimePicker FechaIngresodateTimePicker;
        private System.Windows.Forms.TextBox NombresTextBox;
        private System.Windows.Forms.Button Buscarbutton;
    }
}