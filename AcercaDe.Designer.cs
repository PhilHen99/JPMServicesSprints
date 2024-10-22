namespace Formularios_H3
{
    partial class AcercaDe
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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCopiarInfo = new Button();
            btnInfoSistema = new Button();
            btnDxDiag = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Microsoft Sans Serif", 20F);
            materialLabel1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialLabel1.Location = new Point(56, 39);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(247, 31);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "Acerca del Sistema";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveBorder;
            groupBox1.Controls.Add(listBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnDxDiag);
            groupBox1.Controls.Add(btnInfoSistema);
            groupBox1.Controls.Add(btnCopiarInfo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(38, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(760, 364);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 25);
            label1.Name = "label1";
            label1.Size = new Size(236, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del dispositivo: DESKTOP-052FD7N";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 40);
            label2.Name = "label2";
            label2.Size = new Size(386, 15);
            label2.TabIndex = 1;
            label2.Text = "Identificador de dispositivo: BA650ACD-1670-40A6-B77C-6297323D458D";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 56);
            label3.Name = "label3";
            label3.Size = new Size(385, 15);
            label3.TabIndex = 2;
            label3.Text = "Tipo de sistema: Sistema operativo de 64 bits, procesador basado en x64";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(454, 26);
            label4.Name = "label4";
            label4.Size = new Size(239, 45);
            label4.TabIndex = 3;
            label4.Text = "Microsoft .NET Framework Version 4.8.03752\n© 2017 Microsoft Corporation.\nTodos los derechos reservados.";
            // 
            // btnCopiarInfo
            // 
            btnCopiarInfo.Location = new Point(614, 139);
            btnCopiarInfo.Name = "btnCopiarInfo";
            btnCopiarInfo.Size = new Size(127, 23);
            btnCopiarInfo.TabIndex = 4;
            btnCopiarInfo.Text = "Copiar Info.";
            btnCopiarInfo.UseVisualStyleBackColor = true;
            // 
            // btnInfoSistema
            // 
            btnInfoSistema.Location = new Point(614, 168);
            btnInfoSistema.Name = "btnInfoSistema";
            btnInfoSistema.Size = new Size(127, 23);
            btnInfoSistema.TabIndex = 5;
            btnInfoSistema.Text = "info. del sistema";
            btnInfoSistema.UseVisualStyleBackColor = true;
            // 
            // btnDxDiag
            // 
            btnDxDiag.Location = new Point(614, 197);
            btnDxDiag.Name = "btnDxDiag";
            btnDxDiag.Size = new Size(127, 23);
            btnDxDiag.TabIndex = 6;
            btnDxDiag.Text = "Dx Diag";
            btnDxDiag.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(614, 314);
            button1.Name = "button1";
            button1.Size = new Size(127, 23);
            button1.TabIndex = 7;
            button1.Text = "Aceptar";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.AccessibleRole = AccessibleRole.ScrollBar;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(22, 139);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(553, 199);
            listBox1.TabIndex = 8;
            // 
            // AcercaDe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 488);
            Controls.Add(groupBox1);
            Controls.Add(materialLabel1);
            Name = "AcercaDe";
            Text = "AcercaDe";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button btnDxDiag;
        private Button btnInfoSistema;
        private Button btnCopiarInfo;
        private Label label4;
        private Label label3;
        private Button button1;
        private ListBox listBox1;
    }
}