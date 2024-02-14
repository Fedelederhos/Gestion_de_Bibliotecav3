namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    partial class NuevoPrestamoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoPrestamoForm));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panelBanner = new Panel();
            labelTitulo = new Label();
            panel1 = new Panel();
            panelBotones = new Panel();
            buttonCancelar = new Button();
            buttonAceptar = new Button();
            panelCampos = new Panel();
            label2 = new Label();
            button1 = new Button();
            textBoxDNI = new TextBox();
            label1 = new Label();
            gridEjemplares = new DataGridView();
            isbn = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            codigo = new DataGridViewTextBoxColumn();
            editorial = new DataGridViewTextBoxColumn();
            buttonBuscar = new Button();
            textBox1 = new TextBox();
            labelIngrese = new Label();
            panelBanner.SuspendLayout();
            panelBotones.SuspendLayout();
            panelCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridEjemplares).BeginInit();
            SuspendLayout();
            // 
            // panelBanner
            // 
            panelBanner.BackColor = Color.FromArgb(37, 52, 57);
            panelBanner.Controls.Add(labelTitulo);
            panelBanner.Controls.Add(panel1);
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
            labelTitulo.Size = new Size(175, 26);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Nuevo Préstamo";
            labelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(114, 72);
            panel1.TabIndex = 0;
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
            panelCampos.Controls.Add(label2);
            panelCampos.Controls.Add(button1);
            panelCampos.Controls.Add(textBoxDNI);
            panelCampos.Controls.Add(label1);
            panelCampos.Controls.Add(gridEjemplares);
            panelCampos.Controls.Add(buttonBuscar);
            panelCampos.Controls.Add(textBox1);
            panelCampos.Controls.Add(labelIngrese);
            panelCampos.Dock = DockStyle.Fill;
            panelCampos.Location = new Point(0, 72);
            panelCampos.Name = "panelCampos";
            panelCampos.Size = new Size(700, 298);
            panelCampos.TabIndex = 2;
            panelCampos.MouseDown += panelCampos_MouseDown;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(100, 279);
            label2.Name = "label2";
            label2.Size = new Size(152, 17);
            label2.TabIndex = 17;
            label2.Text = "Fecha de Vencimiento:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.Location = new Point(523, 188);
            button1.Name = "button1";
            button1.Size = new Size(66, 26);
            button1.TabIndex = 16;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Anchor = AnchorStyles.Bottom;
            textBoxDNI.Location = new Point(284, 190);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(216, 23);
            textBoxDNI.TabIndex = 15;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(100, 192);
            label1.Name = "label1";
            label1.Size = new Size(151, 17);
            label1.TabIndex = 14;
            label1.Text = "Ingresar DNI o nombre";
            // 
            // gridEjemplares
            // 
            gridEjemplares.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridEjemplares.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridEjemplares.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridEjemplares.BackgroundColor = Color.Gainsboro;
            gridEjemplares.BorderStyle = BorderStyle.None;
            gridEjemplares.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridEjemplares.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(30, 45, 57);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridEjemplares.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridEjemplares.ColumnHeadersHeight = 25;
            gridEjemplares.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridEjemplares.Columns.AddRange(new DataGridViewColumn[] { isbn, nombre, codigo, editorial });
            gridEjemplares.EnableHeadersVisualStyles = false;
            gridEjemplares.GridColor = Color.Gainsboro;
            gridEjemplares.Location = new Point(103, 72);
            gridEjemplares.Name = "gridEjemplares";
            gridEjemplares.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Gainsboro;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            gridEjemplares.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            gridEjemplares.RowHeadersVisible = false;
            gridEjemplares.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = Color.Gainsboro;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 6.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(224, 224, 224);
            gridEjemplares.RowsDefaultCellStyle = dataGridViewCellStyle6;
            gridEjemplares.RowTemplate.Height = 24;
            gridEjemplares.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridEjemplares.Size = new Size(486, 75);
            gridEjemplares.TabIndex = 13;
            // 
            // isbn
            // 
            isbn.HeaderText = "ISBN";
            isbn.MinimumWidth = 6;
            isbn.Name = "isbn";
            isbn.ReadOnly = true;
            isbn.Width = 70;
            // 
            // nombre
            // 
            nombre.HeaderText = "NOMBRE";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 105;
            // 
            // codigo
            // 
            codigo.HeaderText = "CÓDIGO";
            codigo.MinimumWidth = 6;
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            codigo.Width = 99;
            // 
            // editorial
            // 
            editorial.HeaderText = "EDITORIAL";
            editorial.MinimumWidth = 6;
            editorial.Name = "editorial";
            editorial.ReadOnly = true;
            editorial.Width = 117;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Anchor = AnchorStyles.Top;
            buttonBuscar.Location = new Point(523, 29);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(66, 26);
            buttonBuscar.TabIndex = 12;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.Location = new Point(284, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 23);
            textBox1.TabIndex = 10;
            // 
            // labelIngrese
            // 
            labelIngrese.Anchor = AnchorStyles.Top;
            labelIngrese.AutoSize = true;
            labelIngrese.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelIngrese.ForeColor = Color.Snow;
            labelIngrese.Location = new Point(100, 32);
            labelIngrese.Name = "labelIngrese";
            labelIngrese.Size = new Size(159, 17);
            labelIngrese.TabIndex = 5;
            labelIngrese.Text = "Ingresar ISBN o nombre";
            // 
            // NuevoPrestamoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(panelCampos);
            Controls.Add(panelBotones);
            Controls.Add(panelBanner);
            Name = "NuevoPrestamoForm";
            Text = "Alta de Libro";
            panelBanner.ResumeLayout(false);
            panelBanner.PerformLayout();
            panelBotones.ResumeLayout(false);
            panelCampos.ResumeLayout(false);
            panelCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridEjemplares).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelBanner;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panelCampos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelIngrese;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView gridEjemplares;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorial;
    }
}