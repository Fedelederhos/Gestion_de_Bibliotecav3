namespace Gestion_de_Bibliotecav3.GUI.LogIn
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            panelLogo = new Panel();
            panelDesktop = new Panel();
            labelUsuario = new Label();
            labelContrasenia = new Label();
            buttonAceptar = new Button();
            buttonCancelar = new Button();
            textBoxUsuario = new TextBox();
            textBoxContrasenia = new TextBox();
            panelDesktop.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(37, 52, 57);
            panelLogo.BackgroundImage = (Image)resources.GetObject("panelLogo.BackgroundImage");
            panelLogo.BackgroundImageLayout = ImageLayout.Zoom;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            panelLogo.ForeColor = SystemColors.ControlText;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(800, 93);
            panelLogo.TabIndex = 1;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(46, 61, 66);
            panelDesktop.Controls.Add(textBoxContrasenia);
            panelDesktop.Controls.Add(textBoxUsuario);
            panelDesktop.Controls.Add(buttonCancelar);
            panelDesktop.Controls.Add(buttonAceptar);
            panelDesktop.Controls.Add(labelContrasenia);
            panelDesktop.Controls.Add(labelUsuario);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(0, 93);
            panelDesktop.Margin = new Padding(2);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(800, 357);
            panelDesktop.TabIndex = 3;
            // 
            // labelUsuario
            // 
            labelUsuario.Anchor = AnchorStyles.None;
            labelUsuario.AutoSize = true;
            labelUsuario.FlatStyle = FlatStyle.Flat;
            labelUsuario.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsuario.ForeColor = Color.Gainsboro;
            labelUsuario.Location = new Point(253, 74);
            labelUsuario.Margin = new Padding(2, 0, 2, 0);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(87, 26);
            labelUsuario.TabIndex = 1;
            labelUsuario.Text = "Usuario";
            labelUsuario.TextAlign = ContentAlignment.MiddleCenter;
            labelUsuario.Click += this.labelUsuario_Click;
            // 
            // labelContrasenia
            // 
            labelContrasenia.Anchor = AnchorStyles.None;
            labelContrasenia.AutoSize = true;
            labelContrasenia.FlatStyle = FlatStyle.Flat;
            labelContrasenia.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelContrasenia.ForeColor = Color.Gainsboro;
            labelContrasenia.Location = new Point(216, 167);
            labelContrasenia.Margin = new Padding(2, 0, 2, 0);
            labelContrasenia.Name = "labelContrasenia";
            labelContrasenia.Size = new Size(124, 26);
            labelContrasenia.TabIndex = 2;
            labelContrasenia.Text = "Contraseña";
            labelContrasenia.TextAlign = ContentAlignment.MiddleCenter;
            labelContrasenia.Click += this.labelContrasenia_Click;
            // 
            // buttonAceptar
            // 
            buttonAceptar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAceptar.Location = new Point(256, 273);
            buttonAceptar.Margin = new Padding(2);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(89, 27);
            buttonAceptar.TabIndex = 6;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(449, 273);
            buttonCancelar.Margin = new Padding(2);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(89, 27);
            buttonCancelar.TabIndex = 7;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = Color.LightGray;
            textBoxUsuario.Location = new Point(357, 77);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(217, 23);
            textBoxUsuario.TabIndex = 8;
            textBoxUsuario.TextChanged += this.textBoxUsuario_TextChanged;
            // 
            // textBoxContrasenia
            // 
            textBoxContrasenia.BackColor = Color.LightGray;
            textBoxContrasenia.Location = new Point(357, 170);
            textBoxContrasenia.Name = "textBoxContrasenia";
            textBoxContrasenia.Size = new Size(217, 23);
            textBoxContrasenia.TabIndex = 9;
            textBoxContrasenia.UseSystemPasswordChar = true;
            textBoxContrasenia.TextChanged += textBoxContrasenia_TextChanged;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelDesktop);
            Controls.Add(panelLogo);
            Name = "LogIn";
            Text = "LogIn";
            Load += LogIn_Load;
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogo;
        private Panel panelDesktop;
        private Label labelContrasenia;
        private Label labelUsuario;
        private TextBox textBoxContrasenia;
        private TextBox textBoxUsuario;
        private Button buttonCancelar;
        private Button buttonAceptar;
    }
}