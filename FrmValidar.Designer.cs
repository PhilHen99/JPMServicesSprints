namespace Formularios_H3
{
    partial class FrmValidar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmValidar));
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnValidar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 73);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuario";
            txtUsuario.Size = new Size(265, 23);
            txtUsuario.TabIndex = 2;
            txtUsuario.Text = "usuario";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(12, 131);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PlaceholderText = "Senha";
            txtContraseña.Size = new Size(265, 23);
            txtContraseña.TabIndex = 3;
            txtContraseña.Text = "clave";
            // 
            // btnValidar
            // 
            btnValidar.BackColor = SystemColors.ActiveCaption;
            btnValidar.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnValidar.FlatStyle = FlatStyle.Flat;
            btnValidar.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnValidar.Location = new Point(12, 193);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(127, 37);
            btnValidar.TabIndex = 4;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = false;
            btnValidar.Click += btnValidar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ActiveCaption;
            btnCancelar.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Sitka Banner", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(145, 193);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(132, 37);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmValidar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(648, 403);
            Controls.Add(btnCancelar);
            Controls.Add(btnValidar);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmValidar";
            Text = "Form1";
            Load += FrmValidar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnValidar;
        private Button btnCancelar;
    }
}
