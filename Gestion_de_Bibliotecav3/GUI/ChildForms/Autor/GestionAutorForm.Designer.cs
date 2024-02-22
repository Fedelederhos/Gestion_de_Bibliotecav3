namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    partial class GestionAutorForm
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
            autorDataGrid = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)autorDataGrid).BeginInit();
            SuspendLayout();
            // 
            // panelTabla
            // 
            panelTabla.BackColor = Color.FromArgb(46, 61, 66);
            panelTabla.Controls.Add(textBusqueda);
            panelTabla.Controls.Add(buttonBuscar);
            panelTabla.Controls.Add(labelIngrese);
            panelTabla.Controls.Add(autorDataGrid);
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
            textBusqueda.Location = new Point(274, 43);
            textBusqueda.Margin = new Padding(1);
            textBusqueda.Name = "textBusqueda";
            textBusqueda.Size = new Size(293, 23);
            textBusqueda.TabIndex = 6;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBuscar.Location = new Point(583, 39);
            buttonBuscar.Margin = new Padding(2);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(89, 27);
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
            labelIngrese.Location = new Point(131, 43);
            labelIngrese.Margin = new Padding(2, 0, 2, 0);
            labelIngrese.Name = "labelIngrese";
            labelIngrese.Size = new Size(121, 17);
            labelIngrese.TabIndex = 4;
            labelIngrese.Text = "Ingrese un campo";
            // 
            // autorDataGrid
            // 
            autorDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            autorDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            autorDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            autorDataGrid.BackgroundColor = Color.FromArgb(37, 52, 57);
            autorDataGrid.BorderStyle = BorderStyle.None;
            autorDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            autorDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 45, 57);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            autorDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            autorDataGrid.ColumnHeadersHeight = 25;
            autorDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            autorDataGrid.Columns.AddRange(new DataGridViewColumn[] { codigo, nombre });
            autorDataGrid.EnableHeadersVisualStyles = false;
            autorDataGrid.GridColor = Color.FromArgb(30, 45, 57);
            autorDataGrid.Location = new Point(134, 81);
            autorDataGrid.Margin = new Padding(2);
            autorDataGrid.Name = "autorDataGrid";
            autorDataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 52, 57);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            autorDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            autorDataGrid.RowHeadersVisible = false;
            autorDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 52, 57);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 6.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(224, 224, 224);
            autorDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            autorDataGrid.RowTemplate.Height = 24;
            autorDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            autorDataGrid.Size = new Size(539, 358);
            autorDataGrid.TabIndex = 0;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.Width = 70;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.Width = 73;
            // 
            // GestionAutorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 474);
            Controls.Add(panelTabla);
            Margin = new Padding(2);
            Name = "GestionAutorForm";
            Text = "Gestión de Autores";
            panelTabla.ResumeLayout(false);
            panelTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)autorDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.DataGridView autorDataGrid;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelIngrese;
        private System.Windows.Forms.TextBox textBusqueda;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn nombre;
    }
}