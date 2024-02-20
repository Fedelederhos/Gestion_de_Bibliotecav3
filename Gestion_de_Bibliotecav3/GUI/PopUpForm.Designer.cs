namespace Gestion_de_Bibliotecav3.GUI
{
    partial class PopUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUpForm));
            panelBanner = new Panel();
            panel1 = new Panel();
            panelCampos = new Panel();
            buttonAceptar = new Button();
            labelMensaje = new Label();
            panelBanner.SuspendLayout();
            panelCampos.SuspendLayout();
            SuspendLayout();
            // 
            // panelBanner
            // 
            panelBanner.BackColor = Color.FromArgb(37, 52, 57);
            panelBanner.Controls.Add(panel1);
            panelBanner.Dock = DockStyle.Top;
            panelBanner.Location = new Point(0, 0);
            panelBanner.Margin = new Padding(2);
            panelBanner.Name = "panelBanner";
            panelBanner.Size = new Size(645, 73);
            panelBanner.TabIndex = 1;
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
            // panelCampos
            // 
            panelCampos.BackColor = Color.FromArgb(46, 61, 66);
            panelCampos.Controls.Add(buttonAceptar);
            panelCampos.Controls.Add(labelMensaje);
            panelCampos.Dock = DockStyle.Fill;
            panelCampos.Location = new Point(0, 73);
            panelCampos.Margin = new Padding(2);
            panelCampos.Name = "panelCampos";
            panelCampos.Size = new Size(645, 313);
            panelCampos.TabIndex = 3;
            // 
            // buttonAceptar
            // 
            buttonAceptar.Location = new Point(549, 263);
            buttonAceptar.Margin = new Padding(2);
            buttonAceptar.Name = "buttonAceptar";
            buttonAceptar.Size = new Size(65, 27);
            buttonAceptar.TabIndex = 14;
            buttonAceptar.Text = "Aceptar";
            buttonAceptar.UseVisualStyleBackColor = true;
            buttonAceptar.Click += buttonAceptar_Click;
            // 
            // labelMensaje
            // 
            labelMensaje.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelMensaje.AutoSize = true;
            labelMensaje.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMensaje.ForeColor = Color.Snow;
            labelMensaje.Location = new Point(97, 65);
            labelMensaje.Margin = new Padding(2, 0, 2, 0);
            labelMensaje.MaximumSize = new Size(250, 100);
            labelMensaje.Name = "labelMensaje";
            labelMensaje.Size = new Size(76, 20);
            labelMensaje.TabIndex = 5;
            labelMensaje.Text = "Mensaje";
            // 
            // PopUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 386);
            Controls.Add(panelCampos);
            Controls.Add(panelBanner);
            Name = "PopUpForm";
            Text = "PopUpForm";
            panelBanner.ResumeLayout(false);
            panelCampos.ResumeLayout(false);
            panelCampos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBanner;
        private Label labelTitulo;
        private Panel panel1;
        private Panel panelCampos;
        private Button buttonAceptar;
        private Label labelMensaje;
    }
}