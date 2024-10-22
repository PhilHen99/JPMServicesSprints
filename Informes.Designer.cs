namespace Formularios_H3
{
    partial class Informes
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
            label1 = new Label();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            comboBox2 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker2 = new DateTimePicker();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15F);
            label1.Location = new Point(253, 58);
            label1.Name = "label1";
            label1.Size = new Size(428, 25);
            label1.TabIndex = 1;
            label1.Text = "GENERADOR INFORMES DE FACTURACION";
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(42, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(853, 226);
            panel1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(199, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(256, 23);
            comboBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Underline);
            label2.Location = new Point(34, 22);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 2;
            label2.Text = "Seleccione Informe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Underline);
            label3.Location = new Point(544, 22);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 4;
            label3.Text = "Ordenar Por";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(658, 21);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(179, 23);
            comboBox2.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(173, 75);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(97, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Underline);
            label4.Location = new Point(34, 75);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 6;
            label4.Text = "Fecha Inicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Underline);
            label5.Location = new Point(360, 78);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 8;
            label5.Text = "Fecha Final";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(499, 78);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(97, 23);
            dateTimePicker2.TabIndex = 7;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(256, 168);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(83, 19);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "En Pantalla";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(417, 168);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(43, 19);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Pdf";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(544, 168);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(52, 19);
            radioButton3.TabIndex = 11;
            radioButton3.TabStop = true;
            radioButton3.Text = "Excel";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 14F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(527, 413);
            button1.Name = "button1";
            button1.Size = new Size(139, 37);
            button1.TabIndex = 5;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 14F);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(266, 413);
            button2.Name = "button2";
            button2.Size = new Size(172, 37);
            button2.TabIndex = 6;
            button2.Text = "Guardar Informe";
            button2.UseVisualStyleBackColor = true;
            // 
            // Informes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 579);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Informes";
            Text = "Informes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private ComboBox comboBox2;
        private Label label2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label5;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private Button button1;
        private Button button2;
    }
}