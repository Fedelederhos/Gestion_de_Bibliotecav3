namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    partial class ConsultaCategoriaForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelTabla = new Panel();
            textBusqueda = new TextBox();
            buttonBuscar = new Button();
            labelIngrese = new Label();
            categoriasGrid = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            anioPublicacion = new DataGridViewTextBoxColumn();
            codigo = new DataGridViewTextBoxColumn();
            fechaAlta = new DataGridViewTextBoxColumn();
            fechaBaja = new DataGridViewTextBoxColumn();
            disponibilidad = new DataGridViewTextBoxColumn();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoriasGrid).BeginInit();
            SuspendLayout();
            // 
            // panelTabla
            // 
            panelTabla.BackColor = Color.FromArgb(46, 61, 66);
            panelTabla.Controls.Add(textBusqueda);
            panelTabla.Controls.Add(buttonBuscar);
            panelTabla.Controls.Add(labelIngrese);
            panelTabla.Controls.Add(categoriasGrid);
            panelTabla.Dock = DockStyle.Fill;
            panelTabla.Location = new Point(0, 0);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(800, 474);
            panelTabla.TabIndex = 1;
            // 
            // textBusqueda
            // 
            textBusqueda.BackColor = Color.Gainsboro;
            textBusqueda.Location = new Point(274, 43);
            textBusqueda.Margin = new Padding(1);
            textBusqueda.Name = "textBusqueda";
            textBusqueda.Size = new Size(294, 23);
            textBusqueda.TabIndex = 6;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBuscar.Location = new Point(584, 39);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(89, 26);
            buttonBuscar.TabIndex = 5;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // labelIngrese
            // 
            labelIngrese.AutoSize = true;
            labelIngrese.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelIngrese.ForeColor = Color.Snow;
            labelIngrese.Location = new Point(124, 45);
            labelIngrese.Name = "labelIngrese";
            labelIngrese.Size = new Size(146, 17);
            labelIngrese.TabIndex = 4;
            labelIngrese.Text = "Ingrese una categoría";
            // 
            // categoriasGrid
            // 
            categoriasGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categoriasGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            categoriasGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            categoriasGrid.BackgroundColor = Color.FromArgb(37, 52, 57);
            categoriasGrid.BorderStyle = BorderStyle.None;
            categoriasGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            categoriasGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 45, 57);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            categoriasGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            categoriasGrid.ColumnHeadersHeight = 25;
            categoriasGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            categoriasGrid.Columns.AddRange(new DataGridViewColumn[] { nombre });
            categoriasGrid.EnableHeadersVisualStyles = false;
            categoriasGrid.GridColor = Color.FromArgb(30, 45, 57);
            categoriasGrid.Location = new Point(134, 81);
            categoriasGrid.Name = "categoriasGrid";
            categoriasGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 52, 57);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            categoriasGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            categoriasGrid.RowHeadersVisible = false;
            categoriasGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 52, 57);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 6.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(224, 224, 224);
            categoriasGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            categoriasGrid.RowTemplate.Height = 24;
            categoriasGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            categoriasGrid.Size = new Size(539, 358);
            categoriasGrid.TabIndex = 0;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.Width = 73;
            // 
            // anioPublicacion
            // 
            anioPublicacion.HeaderText = "Año de publicación";
            anioPublicacion.Name = "anioPublicacion";
            anioPublicacion.Width = 138;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.Width = 70;
            // 
            // fechaAlta
            // 
            fechaAlta.HeaderText = "Fecha de Alta";
            fechaAlta.Name = "fechaAlta";
            fechaAlta.Width = 109;
            // 
            // fechaBaja
            // 
            fechaBaja.HeaderText = "Fecha de Baja";
            fechaBaja.Name = "fechaBaja";
            fechaBaja.Width = 112;
            // 
            // disponibilidad
            // 
            disponibilidad.HeaderText = "Disponibilidad";
            disponibilidad.Name = "disponibilidad";
            disponibilidad.Width = 110;
            // 
            // ConsultaCategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 474);
            Controls.Add(panelTabla);
            Name = "ConsultaCategoriaForm";
            Text = "Consulta según Categorías";
            panelTabla.ResumeLayout(false);
            panelTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)categoriasGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.DataGridView categoriasGrid;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelIngrese;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
    }
}