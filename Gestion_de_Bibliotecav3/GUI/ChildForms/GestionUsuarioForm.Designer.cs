namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    partial class GestionUsuarioForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panelTabla = new Panel();
            textBusqueda = new TextBox();
            buttonBuscar = new Button();
            labelIngrese = new Label();
            buttonModificar = new Button();
            buttonNuevo = new Button();
            gridUsuario = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            score = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            librosPrestados = new DataGridViewTextBoxColumn();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridUsuario).BeginInit();
            SuspendLayout();
            // 
            // panelTabla
            // 
            panelTabla.BackColor = Color.FromArgb(46, 61, 66);
            panelTabla.Controls.Add(textBusqueda);
            panelTabla.Controls.Add(buttonBuscar);
            panelTabla.Controls.Add(labelIngrese);
            panelTabla.Controls.Add(buttonModificar);
            panelTabla.Controls.Add(buttonNuevo);
            panelTabla.Controls.Add(gridUsuario);
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
            textBusqueda.Location = new Point(384, 40);
            textBusqueda.Margin = new Padding(1);
            textBusqueda.Name = "textBusqueda";
            textBusqueda.Size = new Size(278, 23);
            textBusqueda.TabIndex = 6;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBuscar.Location = new Point(687, 37);
            buttonBuscar.Margin = new Padding(2);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(89, 27);
            buttonBuscar.TabIndex = 5;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // labelIngrese
            // 
            labelIngrese.AutoSize = true;
            labelIngrese.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelIngrese.ForeColor = Color.Snow;
            labelIngrese.Location = new Point(232, 44);
            labelIngrese.Margin = new Padding(2, 0, 2, 0);
            labelIngrese.Name = "labelIngrese";
            labelIngrese.Size = new Size(127, 17);
            labelIngrese.TabIndex = 4;
            labelIngrese.Text = "Ingrese un nombre";
            // 
            // buttonModificar
            // 
            buttonModificar.Anchor = AnchorStyles.Left;
            buttonModificar.FlatStyle = FlatStyle.System;
            buttonModificar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonModificar.Location = new Point(34, 145);
            buttonModificar.Margin = new Padding(2);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(170, 38);
            buttonModificar.TabIndex = 2;
            buttonModificar.Text = "Modificar Usuario";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Anchor = AnchorStyles.Left;
            buttonNuevo.FlatStyle = FlatStyle.System;
            buttonNuevo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNuevo.Location = new Point(34, 81);
            buttonNuevo.Margin = new Padding(2);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(170, 38);
            buttonNuevo.TabIndex = 1;
            buttonNuevo.Text = "Nuevo Usuario";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // gridUsuario
            // 
            gridUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridUsuario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridUsuario.BackgroundColor = Color.FromArgb(37, 52, 57);
            gridUsuario.BorderStyle = BorderStyle.None;
            gridUsuario.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridUsuario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(30, 45, 57);
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 7.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridUsuario.ColumnHeadersHeight = 25;
            gridUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridUsuario.Columns.AddRange(new DataGridViewColumn[] { id, dni, nombre, score, direccion, telefono, email, librosPrestados });
            gridUsuario.EnableHeadersVisualStyles = false;
            gridUsuario.GridColor = Color.FromArgb(30, 45, 57);
            gridUsuario.Location = new Point(236, 81);
            gridUsuario.Margin = new Padding(2);
            gridUsuario.Name = "gridUsuario";
            gridUsuario.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(37, 52, 57);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            gridUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            gridUsuario.RowHeadersVisible = false;
            gridUsuario.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(37, 52, 57);
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 6.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(224, 224, 224);
            gridUsuario.RowsDefaultCellStyle = dataGridViewCellStyle6;
            gridUsuario.RowTemplate.Height = 24;
            gridUsuario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridUsuario.Size = new Size(527, 358);
            gridUsuario.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 44;
            // 
            // dni
            // 
            dni.HeaderText = "DNI";
            dni.MinimumWidth = 6;
            dni.Name = "dni";
            dni.ReadOnly = true;
            dni.Width = 52;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 73;
            // 
            // score
            // 
            score.HeaderText = "Score";
            score.MinimumWidth = 6;
            score.Name = "score";
            score.ReadOnly = true;
            score.Width = 63;
            // 
            // direccion
            // 
            direccion.HeaderText = "Dirección";
            direccion.MinimumWidth = 6;
            direccion.Name = "direccion";
            direccion.ReadOnly = true;
            direccion.Width = 83;
            // 
            // telefono
            // 
            telefono.HeaderText = "Teléfono";
            telefono.MinimumWidth = 6;
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            telefono.Width = 79;
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 61;
            // 
            // librosPrestados
            // 
            librosPrestados.HeaderText = "Libros Prestados";
            librosPrestados.MinimumWidth = 6;
            librosPrestados.Name = "librosPrestados";
            librosPrestados.ReadOnly = true;
            librosPrestados.Width = 125;
            // 
            // GestionUsuarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 474);
            Controls.Add(panelTabla);
            Margin = new Padding(2);
            Name = "GestionUsuarioForm";
            Text = "Gestión de Usuarios";
            panelTabla.ResumeLayout(false);
            panelTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.DataGridView gridUsuario;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelIngrese;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn librosPrestados;
        private System.Windows.Forms.TextBox textBusqueda;
    }
}