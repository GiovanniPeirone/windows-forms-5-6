namespace FormulariodeUsuarioyContraseña
{
    partial class Form1
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
            textBoxNombre = new TextBox();
            textBoxcontraseña = new TextBox();
            label1 = new Label();
            label2 = new Label();
            InicialSecion = new Button();
            intentos = new Label();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(63, 117);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(192, 23);
            textBoxNombre.TabIndex = 0;
            // 
            // textBoxcontraseña
            // 
            textBoxcontraseña.Location = new Point(63, 170);
            textBoxcontraseña.Name = "textBoxcontraseña";
            textBoxcontraseña.Size = new Size(192, 23);
            textBoxcontraseña.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 96);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 2;
            label1.Text = "nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 152);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "contraseña";
            // 
            // InicialSecion
            // 
            InicialSecion.Location = new Point(63, 215);
            InicialSecion.Name = "InicialSecion";
            InicialSecion.Size = new Size(192, 23);
            InicialSecion.TabIndex = 4;
            InicialSecion.Text = "iniciar secion";
            InicialSecion.UseVisualStyleBackColor = true;
            InicialSecion.Click += InicialSecion_Click;
            // 
            // intentos
            // 
            intentos.AutoSize = true;
            intentos.Location = new Point(68, 297);
            intentos.Name = "intentos";
            intentos.Size = new Size(65, 15);
            intentos.TabIndex = 5;
            intentos.Text = "intentos : 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 354);
            Controls.Add(intentos);
            Controls.Add(InicialSecion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxcontraseña);
            Controls.Add(textBoxNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombre;
        private TextBox textBoxcontraseña;
        private Label label1;
        private Label label2;
        private Button InicialSecion;
        private Label intentos;
    }
}
