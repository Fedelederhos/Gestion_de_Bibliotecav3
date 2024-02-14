namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    partial class GestionPrestamoForm
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
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panelTabla = new Panel();
            textBusqueda = new TextBox();
            buttonBuscar = new Button();
            labelIngrese = new Label();
            buttonEliminar = new Button();
            buttonNuevo = new Button();
            gridPrestamos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            fechaEntrega = new DataGridViewTextBoxColumn();
            fechaVencimiento = new DataGridViewTextBoxColumn();
            fechaDevolucion = new DataGridViewTextBoxColumn();
            notificacion = new DataGridViewTextBoxColumn();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridPrestamos).BeginInit();
            SuspendLayout();
            // 
            // panelTabla
            // 
            panelTabla.BackColor = Color.FromArgb(46, 61, 66);
            panelTabla.Controls.Add(textBusqueda);
            panelTabla.Controls.Add(buttonBuscar);
            panelTabla.Controls.Add(labelIngrese);
            panelTabla.Controls.Add(buttonEliminar);
            panelTabla.Controls.Add(buttonNuevo);
            panelTabla.Controls.Add(gridPrestamos);
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
            textBusqueda.Location = new Point(453, 40);
            textBusqueda.Margin = new Padding(1);
            textBusqueda.Name = "textBusqueda";
            textBusqueda.Size = new Size(209, 23);
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
            labelIngrese.Size = new Size(185, 17);
            labelIngrese.TabIndex = 4;
            labelIngrese.Text = "Ingrese un nombre o código";
            // 
            // buttonEliminar
            // 
            buttonEliminar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEliminar.Location = new Point(34, 145);
            buttonEliminar.Margin = new Padding(2);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(170, 38);
            buttonEliminar.TabIndex = 3;
            buttonEliminar.Text = "Eliminar Préstamo";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNuevo.Location = new Point(34, 81);
            buttonNuevo.Margin = new Padding(2);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(170, 38);
            buttonNuevo.TabIndex = 1;
            buttonNuevo.Text = "Nuevo Prestamo";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // gridPrestamos
            // 
            gridPrestamos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridPrestamos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridPrestamos.BackgroundColor = Color.FromArgb(37, 52, 57);
            gridPrestamos.BorderStyle = BorderStyle.None;
            gridPrestamos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridPrestamos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(30, 45, 57);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 7.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridPrestamos.ColumnHeadersHeight = 25;
            gridPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridPrestamos.Columns.AddRange(new DataGridViewColumn[] { id, fechaEntrega, fechaVencimiento, fechaDevolucion, notificacion });
            gridPrestamos.EnableHeadersVisualStyles = false;
            gridPrestamos.GridColor = Color.FromArgb(30, 45, 57);
            gridPrestamos.Location = new Point(237, 81);
            gridPrestamos.Margin = new Padding(2);
            gridPrestamos.Name = "gridPrestamos";
            gridPrestamos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(37, 52, 57);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            gridPrestamos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            gridPrestamos.RowHeadersVisible = false;
            gridPrestamos.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(37, 52, 57);
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 6.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(224, 224, 224);
            gridPrestamos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            gridPrestamos.RowTemplate.Height = 24;
            gridPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridPrestamos.Size = new Size(527, 358);
            gridPrestamos.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 44;
            // 
            // fechaEntrega
            // 
            fechaEntrega.HeaderText = "Fecha de Entrega";
            fechaEntrega.MinimumWidth = 6;
            fechaEntrega.Name = "fechaEntrega";
            fechaEntrega.ReadOnly = true;
            fechaEntrega.Width = 131;
            // 
            // fechaVencimiento
            // 
            fechaVencimiento.HeaderText = "Fecha de Vencimiento";
            fechaVencimiento.MinimumWidth = 6;
            fechaVencimiento.Name = "fechaVencimiento";
            fechaVencimiento.ReadOnly = true;
            fechaVencimiento.Width = 155;
            // 
            // fechaDevolucion
            // 
            fechaDevolucion.HeaderText = "Fecha de Devolución";
            fechaDevolucion.MinimumWidth = 6;
            fechaDevolucion.Name = "fechaDevolucion";
            fechaDevolucion.ReadOnly = true;
            fechaDevolucion.Width = 150;
            // 
            // notificacion
            // 
            notificacion.HeaderText = "Notificación";
            notificacion.MinimumWidth = 6;
            notificacion.Name = "notificacion";
            notificacion.Width = 96;
            // 
            // GestionPrestamoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 474);
            Controls.Add(panelTabla);
            Margin = new Padding(2);
            Name = "GestionPrestamoForm";
            Text = "Gestión de Préstamos";
            panelTabla.ResumeLayout(false);
            panelTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridPrestamos).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.DataGridView gridPrestamos;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelIngrese;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn notificacion;
    }
}