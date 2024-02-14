namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    partial class ModificarEjemplarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarEjemplarForm));
            panelBanner = new Panel();
            labelTitulo = new Label();
            panelLogo = new Panel();
            panelBotones = new Panel();
            buttonCancelar = new Button();
            buttonAceptar = new Button();
            panelCampos = new Panel();
            comboBoxDisponibilidad = new ComboBox();
            textBoxFechaBaja = new TextBox();
            textBoxCodigo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            labelCodigo = new Label();
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
            labelTitulo.Anchor = AnchorStyles.Top;
            labelTitulo.AutoSize = true;
            labelTitulo.FlatStyle = FlatStyle.Flat;
            labelTitulo.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.Gainsboro;
            labelTitulo.Location = new Point(258, 39);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(193, 26);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Modificar Ejemplar";
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
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.FromArgb(37, 52, 57);
            panelBotones.Controls.Add(buttonCancelar);
            panelBotones.Controls.Add(buttonAceptar);
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.Location = new Point(0, 376);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(700, 46);
            panelBotones.TabIndex = 1;
            panelBotones.MouseDown += panelBotones_MouseDown;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.FlatStyle = FlatStyle.System;
            buttonCancelar.Location = new Point(611, 13);
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
            buttonAceptar.Location = new Point(523, 13);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(66, 22);
            buttonAceptar.TabIndex = 0;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            // 
            // panelCampos
            // 
            panelCampos.BackColor = Color.FromArgb(46, 61, 66);
            panelCampos.Controls.Add(comboBoxDisponibilidad);
            panelCampos.Controls.Add(textBoxFechaBaja);
            panelCampos.Controls.Add(textBoxCodigo);
            panelCampos.Controls.Add(label3);
            panelCampos.Controls.Add(label2);
            panelCampos.Controls.Add(labelCodigo);
            panelCampos.Dock = DockStyle.Fill;
            panelCampos.Location = new Point(0, 72);
            panelCampos.Name = "panelCampos";
            panelCampos.Size = new Size(700, 304);
            panelCampos.TabIndex = 2;
            panelCampos.MouseDown += panelCampos_MouseDown;
            // 
            // comboBoxDisponibilidad
            // 
            comboBoxDisponibilidad.FormattingEnabled = true;
            comboBoxDisponibilidad.Location = new Point(346, 154);
            comboBoxDisponibilidad.Name = "comboBoxDisponibilidad";
            comboBoxDisponibilidad.Size = new Size(142, 23);
            comboBoxDisponibilidad.TabIndex = 14;
            // 
            // textBoxFechaBaja
            // 
            textBoxFechaBaja.Location = new Point(346, 102);
            textBoxFechaBaja.Name = "textBoxFechaBaja";
            textBoxFechaBaja.Size = new Size(171, 23);
            textBoxFechaBaja.TabIndex = 12;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Location = new Point(346, 50);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(88, 23);
            textBoxCodigo.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(209, 104);
            label3.Name = "label3";
            label3.Size = new Size(99, 17);
            label3.TabIndex = 8;
            label3.Text = "Fecha de Baja";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(212, 160);
            label2.Name = "label2";
            label2.Size = new Size(96, 17);
            label2.TabIndex = 7;
            label2.Text = "Disponibilidad";
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelCodigo.ForeColor = Color.Snow;
            labelCodigo.Location = new Point(258, 53);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(52, 17);
            labelCodigo.TabIndex = 5;
            labelCodigo.Text = "Código";
            // 
            // ModificarEjemplarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(panelCampos);
            Controls.Add(panelBotones);
            Controls.Add(panelBanner);
            Name = "ModificarEjemplarForm";
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
        private System.Windows.Forms.TextBox textBoxFechaBaja;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.ComboBox comboBoxDisponibilidad;
    }
}