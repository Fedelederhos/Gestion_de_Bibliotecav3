namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    partial class GestionLibroForm
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            panelTabla = new Panel();
            textBusqueda = new TextBox();
            buttonBuscar = new Button();
            labelIngrese = new Label();
            gridLibros = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            isbn = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            autor = new DataGridViewTextBoxColumn();
            fechaPublicacion = new DataGridViewTextBoxColumn();
            editorial = new DataGridViewTextBoxColumn();
            categoria = new DataGridViewTextBoxColumn();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridLibros).BeginInit();
            SuspendLayout();
            // 
            // panelTabla
            // 
            panelTabla.BackColor = Color.FromArgb(46, 61, 66);
            panelTabla.Controls.Add(textBusqueda);
            panelTabla.Controls.Add(buttonBuscar);
            panelTabla.Controls.Add(labelIngrese);
            panelTabla.Controls.Add(gridLibros);
            panelTabla.Dock = DockStyle.Fill;
            panelTabla.Location = new Point(0, 0);
            panelTabla.Margin = new Padding(2);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(800, 474);
            panelTabla.TabIndex = 1;
            // 
            // textBusqueda
            // 
            textBusqueda.BackColor = Color.Gainsboro;
            textBusqueda.Location = new Point(412, 40);
            textBusqueda.Margin = new Padding(1);
            textBusqueda.Name = "textBusqueda";
            textBusqueda.Size = new Size(250, 23);
            textBusqueda.TabIndex = 6;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBuscar.Location = new Point(674, 37);
            buttonBuscar.Margin = new Padding(2);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(89, 24);
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
            labelIngrese.Location = new Point(233, 40);
            labelIngrese.Margin = new Padding(2, 0, 2, 0);
            labelIngrese.Name = "labelIngrese";
            labelIngrese.Size = new Size(176, 17);
            labelIngrese.TabIndex = 4;
            labelIngrese.Text = "Ingrese un ISBN o Nombre";
            // 
            // gridLibros
            // 
            gridLibros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridLibros.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridLibros.BackgroundColor = Color.FromArgb(37, 52, 57);
            gridLibros.BorderStyle = BorderStyle.None;
            gridLibros.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridLibros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(30, 45, 57);
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 7.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            gridLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            gridLibros.ColumnHeadersHeight = 25;
            gridLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridLibros.Columns.AddRange(new DataGridViewColumn[] { id, isbn, nombre, autor, fechaPublicacion, editorial, categoria });
            gridLibros.EnableHeadersVisualStyles = false;
            gridLibros.GridColor = Color.FromArgb(30, 45, 57);
            gridLibros.Location = new Point(236, 81);
            gridLibros.Margin = new Padding(2);
            gridLibros.Name = "gridLibros";
            gridLibros.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(37, 52, 57);
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            gridLibros.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            gridLibros.RowHeadersVisible = false;
            gridLibros.RowHeadersWidth = 51;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(37, 52, 57);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 6.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(224, 224, 224);
            gridLibros.RowsDefaultCellStyle = dataGridViewCellStyle9;
            gridLibros.RowTemplate.Height = 24;
            gridLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridLibros.Size = new Size(527, 358);
            gridLibros.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 44;
            // 
            // isbn
            // 
            isbn.HeaderText = "ISBN";
            isbn.MinimumWidth = 6;
            isbn.Name = "isbn";
            isbn.ReadOnly = true;
            isbn.Width = 59;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 73;
            // 
            // autor
            // 
            autor.HeaderText = "Autor";
            autor.MinimumWidth = 6;
            autor.Name = "autor";
            autor.ReadOnly = true;
            autor.Width = 61;
            // 
            // fechaPublicacion
            // 
            fechaPublicacion.HeaderText = "Fecha de Publicación";
            fechaPublicacion.MinimumWidth = 6;
            fechaPublicacion.Name = "fechaPublicacion";
            fechaPublicacion.ReadOnly = true;
            fechaPublicacion.Width = 151;
            // 
            // editorial
            // 
            editorial.HeaderText = "Editorial";
            editorial.MinimumWidth = 6;
            editorial.Name = "editorial";
            editorial.ReadOnly = true;
            editorial.Width = 77;
            // 
            // categoria
            // 
            categoria.HeaderText = "Categoria";
            categoria.MinimumWidth = 6;
            categoria.Name = "categoria";
            categoria.ReadOnly = true;
            categoria.Width = 85;
            // 
            // GestionLibroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 474);
            Controls.Add(panelTabla);
            Margin = new Padding(2);
            Name = "GestionLibroForm";
            Text = "Gestión de Libros";
            panelTabla.ResumeLayout(false);
            panelTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.DataGridView gridLibros;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelIngrese;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPublicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
    }
}
