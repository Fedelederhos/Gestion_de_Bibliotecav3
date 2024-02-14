namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    partial class ModificarUsuarioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarUsuarioForm));
            panelBanner = new Panel();
            labelTitulo = new Label();
            panelLogo = new Panel();
            panelBotones = new Panel();
            buttonCancelar = new Button();
            buttonAceptar = new Button();
            panelCampos = new Panel();
            textBoxEmail = new TextBox();
            textBoxTelefono = new TextBox();
            textBoxDireccion = new TextBox();
            textBoxNombre = new TextBox();
            textBoxDNI = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            labelIngrese = new Label();
            panelBanner.SuspendLayout();
            panelBotones.SuspendLayout();
            panelCampos.SuspendLayout();
            SuspendLayout();
            // 
            // panelBanner
            // 
            panelBanner.BackColor = Color.FromArgb(37, 52, 57);
            panelBanner.Controls.Add(labelTitulo);
            panelBanner.Controls.Add(panelLogo);
            panelBanner.Dock = DockStyle.Top;
            panelBanner.Location = new Point(0, 0);
            panelBanner.Name = "panelBanner";
            panelBanner.Size = new Size(700, 72);
            panelBanner.TabIndex = 0;
            panelBanner.MouseDown += panelBanner_MouseDown;
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.None;
            labelTitulo.AutoSize = true;
            labelTitulo.FlatStyle = FlatStyle.Flat;
            labelTitulo.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.Gainsboro;
            labelTitulo.Location = new Point(258, 39);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(181, 26);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Modificar Usuario";
            labelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelLogo
            // 
            panelLogo.BackgroundImage = (Image)resources.GetObject("panelLogo.BackgroundImage");
            panelLogo.BackgroundImageLayout = ImageLayout.Center;
            panelLogo.Dock = DockStyle.Left;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(114, 72);
            panelLogo.TabIndex = 0;
            panelLogo.MouseDown += panel1_MouseDown;
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.FromArgb(37, 52, 57);
            panelBotones.Controls.Add(buttonCancelar);
            panelBotones.Controls.Add(buttonAceptar);
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.Location = new Point(0, 370);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(700, 52);
            panelBotones.TabIndex = 1;
            panelBotones.MouseDown += panelBotones_MouseDown;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.FlatStyle = FlatStyle.System;
            buttonCancelar.Location = new Point(611, 20);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(66, 22);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonAceptar
            // 
            buttonAceptar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonAceptar.FlatStyle = FlatStyle.System;
            buttonAceptar.Location = new Point(523, 20);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(66, 22);
            buttonAceptar.TabIndex = 0;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            // 
            // panelCampos
            // 
            panelCampos.BackColor = Color.FromArgb(46, 61, 66);
            panelCampos.Controls.Add(textBoxEmail);
            panelCampos.Controls.Add(textBoxTelefono);
            panelCampos.Controls.Add(textBoxDireccion);
            panelCampos.Controls.Add(textBoxNombre);
            panelCampos.Controls.Add(textBoxDNI);
            panelCampos.Controls.Add(label4);
            panelCampos.Controls.Add(label3);
            panelCampos.Controls.Add(label2);
            panelCampos.Controls.Add(label1);
            panelCampos.Controls.Add(labelIngrese);
            panelCampos.Dock = DockStyle.Fill;
            panelCampos.Location = new Point(0, 72);
            panelCampos.Name = "panelCampos";
            panelCampos.Size = new Size(700, 298);
            panelCampos.TabIndex = 2;
            panelCampos.MouseDown += panelCampos_MouseDown;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(327, 247);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(145, 23);
            textBoxEmail.TabIndex = 14;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(327, 189);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(145, 23);
            textBoxTelefono.TabIndex = 13;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(327, 134);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(171, 23);
            textBoxDireccion.TabIndex = 12;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(330, 81);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(168, 23);
            textBoxNombre.TabIndex = 11;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(330, 25);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(88, 23);
            textBoxDNI.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(243, 247);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 9;
            label4.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(222, 136);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 8;
            label3.Text = "Dirección";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(229, 191);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 7;
            label2.Text = "Teléfono";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(170, 81);
            label1.Name = "label1";
            label1.Size = new Size(119, 17);
            label1.TabIndex = 6;
            label1.Text = "Nombre completo";
            // 
            // labelIngrese
            // 
            labelIngrese.AutoSize = true;
            labelIngrese.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelIngrese.ForeColor = Color.Snow;
            labelIngrese.Location = new Point(260, 25);
            labelIngrese.Name = "labelIngrese";
            labelIngrese.Size = new Size(31, 17);
            labelIngrese.TabIndex = 5;
            labelIngrese.Text = "DNI";
            // 
            // ModificarUsuarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(panelCampos);
            Controls.Add(panelBotones);
            Controls.Add(panelBanner);
            Name = "ModificarUsuarioForm";
            Text = "AltaUsuarioForm";
            panelBanner.ResumeLayout(false);
            panelBanner.PerformLayout();
            panelBotones.ResumeLayout(false);
            panelCampos.ResumeLayout(false);
            panelCampos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelBanner;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panelCampos;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIngrese;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}