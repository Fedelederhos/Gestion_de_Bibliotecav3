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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelTabla = new Panel();
            textBusqueda = new TextBox();
            buttonBuscar = new Button();
            labelIngrese = new Label();
            buttonEliminar = new Button();
            buttonNuevo = new Button();
            gridPrestamos = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            codigo = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
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
            textBusqueda.Location = new Point(431, 37);
            textBusqueda.Margin = new Padding(1);
            textBusqueda.Name = "textBusqueda";
            textBusqueda.Size = new Size(218, 23);
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
            labelIngrese.Location = new Point(237, 41);
            labelIngrese.Margin = new Padding(2, 0, 2, 0);
            labelIngrese.Name = "labelIngrese";
            labelIngrese.Size = new Size(180, 17);
            labelIngrese.TabIndex = 4;
            labelIngrese.Text = "Ingrese un código o un DNI";
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 45, 57);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridPrestamos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridPrestamos.ColumnHeadersHeight = 25;
            gridPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridPrestamos.Columns.AddRange(new DataGridViewColumn[] { id, codigo, dni, fechaEntrega, fechaVencimiento, fechaDevolucion, notificacion });
            gridPrestamos.EnableHeadersVisualStyles = false;
            gridPrestamos.GridColor = Color.FromArgb(30, 45, 57);
            gridPrestamos.Location = new Point(237, 81);
            gridPrestamos.Margin = new Padding(2);
            gridPrestamos.Name = "gridPrestamos";
            gridPrestamos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 52, 57);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridPrestamos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridPrestamos.RowHeadersVisible = false;
            gridPrestamos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 52, 57);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 6.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(224, 224, 224);
            gridPrestamos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            gridPrestamos.RowTemplate.Height = 24;
            gridPrestamos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridPrestamos.Size = new Size(527, 358);
            gridPrestamos.TabIndex = 0;
            gridPrestamos.CellClick += gridPrestamos_CellClick;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 44;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.Name = "codigo";
            codigo.Width = 70;
            // 
            // dni
            // 
            dni.HeaderText = "DNI";
            dni.Name = "dni";
            dni.Width = 52;
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
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn fechaEntrega;
        private DataGridViewTextBoxColumn fechaVencimiento;
        private DataGridViewTextBoxColumn fechaDevolucion;
        private DataGridViewTextBoxColumn notificacion;
    }
}