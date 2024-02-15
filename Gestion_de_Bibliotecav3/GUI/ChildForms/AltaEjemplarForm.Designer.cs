namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    partial class AltaEjemplarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaEjemplarForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelBanner = new Panel();
            labelTitulo = new Label();
            panel1 = new Panel();
            panelBotones = new Panel();
            buttonCancelar = new Button();
            buttonAceptar = new Button();
            panelCampos = new Panel();
            buttonBuscar = new Button();
            boxCodigo = new TextBox();
            label1 = new Label();
            gridEjemplar = new DataGridView();
            isbn = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            fechaVencimiento = new DataGridViewTextBoxColumn();
            boxISBNoNombre = new TextBox();
            labelIngrese = new Label();
            panelBanner.SuspendLayout();
            panelBotones.SuspendLayout();
            panelCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridEjemplar).BeginInit();
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
            labelTitulo.Anchor = AnchorStyles.Top;
            labelTitulo.AutoSize = true;
            labelTitulo.FlatStyle = FlatStyle.Flat;
            labelTitulo.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.Gainsboro;
            labelTitulo.Location = new Point(258, 39);
            labelTitulo.Margin = new Padding(2, 0, 2, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(173, 26);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Alta de Ejemplar";
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
            panelCampos.Controls.Add(boxCodigo);
            panelCampos.Controls.Add(label1);
            panelCampos.Controls.Add(gridEjemplar);
            panelCampos.Controls.Add(boxISBNoNombre);
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
            buttonBuscar.Location = new Point(504, 22);
            buttonBuscar.Margin = new Padding(2);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(65, 27);
            buttonBuscar.TabIndex = 14;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // boxCodigo
            // 
            boxCodigo.Location = new Point(318, 271);
            boxCodigo.Margin = new Padding(2);
            boxCodigo.Name = "boxCodigo";
            boxCodigo.Size = new Size(135, 23);
            boxCodigo.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(243, 271);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 17);
            label1.TabIndex = 12;
            label1.Text = "Código";
            // 
            // gridEjemplar
            // 
            gridEjemplar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridEjemplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridEjemplar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridEjemplar.BackgroundColor = Color.Gainsboro;
            gridEjemplar.BorderStyle = BorderStyle.None;
            gridEjemplar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridEjemplar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 45, 57);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridEjemplar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridEjemplar.ColumnHeadersHeight = 25;
            gridEjemplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridEjemplar.Columns.AddRange(new DataGridViewColumn[] { isbn, nombre, fechaVencimiento });
            gridEjemplar.EnableHeadersVisualStyles = false;
            gridEjemplar.GridColor = Color.Gainsboro;
            gridEjemplar.Location = new Point(107, 66);
            gridEjemplar.Margin = new Padding(2);
            gridEjemplar.Name = "gridEjemplar";
            gridEjemplar.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Gainsboro;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridEjemplar.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridEjemplar.RowHeadersVisible = false;
            gridEjemplar.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.Gainsboro;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 6.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(224, 224, 224);
            gridEjemplar.RowsDefaultCellStyle = dataGridViewCellStyle3;
            gridEjemplar.RowTemplate.Height = 24;
            gridEjemplar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridEjemplar.Size = new Size(463, 171);
            gridEjemplar.TabIndex = 11;
            gridEjemplar.CellClick += gridEjemplar_CellClick;
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
            // fechaVencimiento
            // 
            fechaVencimiento.HeaderText = "FECHA DE PUBLICACIÓN";
            fechaVencimiento.MinimumWidth = 6;
            fechaVencimiento.Name = "fechaVencimiento";
            fechaVencimiento.ReadOnly = true;
            fechaVencimiento.Width = 230;
            // 
            // boxISBNoNombre
            // 
            boxISBNoNombre.Location = new Point(264, 25);
            boxISBNoNombre.Margin = new Padding(2);
            boxISBNoNombre.Name = "boxISBNoNombre";
            boxISBNoNombre.Size = new Size(216, 23);
            boxISBNoNombre.TabIndex = 10;
            // 
            // labelIngrese
            // 
            labelIngrese.AutoSize = true;
            labelIngrese.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelIngrese.ForeColor = Color.Snow;
            labelIngrese.Location = new Point(75, 25);
            labelIngrese.Margin = new Padding(2, 0, 2, 0);
            labelIngrese.Name = "labelIngrese";
            labelIngrese.Size = new Size(159, 17);
            labelIngrese.TabIndex = 5;
            labelIngrese.Text = "Ingresar ISBN o nombre";
            // 
            // AltaEjemplarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(panelCampos);
            Controls.Add(panelBotones);
            Controls.Add(panelBanner);
            Margin = new Padding(2);
            Name = "AltaEjemplarForm";
            Text = "Alta de Libro";
            panelBanner.ResumeLayout(false);
            panelBanner.PerformLayout();
            panelBotones.ResumeLayout(false);
            panelCampos.ResumeLayout(false);
            panelCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridEjemplar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelBanner;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Panel panelCampos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox boxISBNoNombre;
        private System.Windows.Forms.Label labelIngrese;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.DataGridView gridEjemplar;
        private System.Windows.Forms.TextBox boxCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimiento;
    }
}