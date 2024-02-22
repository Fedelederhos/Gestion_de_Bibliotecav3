namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    partial class RegistrarDevolucionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarDevolucionForm));
            panelBanner = new Panel();
            labelTitulo = new Label();
            panel1 = new Panel();
            panelBotones = new Panel();
            buttonCancelar = new Button();
            buttonAceptar = new Button();
            panelCampos = new Panel();
            buttonBuscar = new Button();
            estadoComboBox = new ComboBox();
            codigoLabel = new TextBox();
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
            panelBanner.Controls.Add(panel1);
            panelBanner.Dock = DockStyle.Top;
            panelBanner.Location = new Point(0, 0);
            panelBanner.Margin = new Padding(2);
            panelBanner.Name = "panelBanner";
            panelBanner.Size = new Size(700, 73);
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
            labelTitulo.Margin = new Padding(2, 0, 2, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(214, 26);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Registrar Devolución";
            labelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(114, 73);
            panel1.TabIndex = 0;
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.FromArgb(37, 52, 57);
            panelBotones.Controls.Add(buttonCancelar);
            panelBotones.Controls.Add(buttonAceptar);
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.Location = new Point(0, 369);
            panelBotones.Margin = new Padding(2);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(700, 53);
            panelBotones.TabIndex = 1;
            panelBotones.MouseDown += panelBotones_MouseDown;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancelar.FlatStyle = FlatStyle.System;
            buttonCancelar.Location = new Point(611, 20);
            buttonCancelar.Margin = new Padding(2);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(65, 22);
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
            buttonAceptar.Margin = new Padding(2);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(65, 22);
            buttonAceptar.TabIndex = 0;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // panelCampos
            // 
            panelCampos.BackColor = Color.FromArgb(46, 61, 66);
            panelCampos.Controls.Add(buttonBuscar);
            panelCampos.Controls.Add(estadoComboBox);
            panelCampos.Controls.Add(codigoLabel);
            panelCampos.Controls.Add(label1);
            panelCampos.Controls.Add(labelIngrese);
            panelCampos.Dock = DockStyle.Fill;
            panelCampos.Location = new Point(0, 73);
            panelCampos.Margin = new Padding(2);
            panelCampos.Name = "panelCampos";
            panelCampos.Size = new Size(700, 296);
            panelCampos.TabIndex = 2;
            panelCampos.MouseDown += panelCampos_MouseDown;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(471, 67);
            buttonBuscar.Margin = new Padding(2);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(65, 27);
            buttonBuscar.TabIndex = 17;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // estadoComboBox
            // 
            estadoComboBox.FormattingEnabled = true;
            estadoComboBox.Items.AddRange(new object[] { " Bueno", " Regular", " Arruinado" });
            estadoComboBox.Location = new Point(304, 153);
            estadoComboBox.Margin = new Padding(2);
            estadoComboBox.Name = "estadoComboBox";
            estadoComboBox.Size = new Size(135, 23);
            estadoComboBox.TabIndex = 16;
            // 
            // codigoLabel
            // 
            codigoLabel.Location = new Point(304, 69);
            codigoLabel.Margin = new Padding(2);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new Size(135, 23);
            codigoLabel.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(191, 153);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 17);
            label1.TabIndex = 6;
            label1.Text = "Estado";
            // 
            // labelIngrese
            // 
            labelIngrese.AutoSize = true;
            labelIngrese.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelIngrese.ForeColor = Color.Snow;
            labelIngrese.Location = new Point(112, 71);
            labelIngrese.Margin = new Padding(2, 0, 2, 0);
            labelIngrese.Name = "labelIngrese";
            labelIngrese.Size = new Size(179, 17);
            labelIngrese.TabIndex = 5;
            labelIngrese.Text = "Ingrese código de ejemplar";
            // 
            // RegistrarDevolucionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(panelCampos);
            Controls.Add(panelBotones);
            Controls.Add(panelBanner);
            Margin = new Padding(2);
            Name = "RegistrarDevolucionForm";
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelIngrese;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.TextBox codigoLabel;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.Button buttonBuscar;
    }
}