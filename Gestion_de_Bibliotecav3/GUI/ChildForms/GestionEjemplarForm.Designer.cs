namespace Gestion_de_Biblioteca.GUI.ChildForms
{
    partial class GestionEjemplarForm
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
            buttonModificar = new Button();
            textBusqueda = new TextBox();
            buttonBuscar = new Button();
            labelIngrese = new Label();
            buttonEliminar = new Button();
            buttonNuevo = new Button();
            gridEjemplar = new DataGridView();
            isbn = new DataGridViewTextBoxColumn();
            codigo = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            fechaAlta = new DataGridViewTextBoxColumn();
            fechaBaja = new DataGridViewTextBoxColumn();
            disponibilidad = new DataGridViewTextBoxColumn();
            label1 = new Label();
            textBox1 = new TextBox();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridEjemplar).BeginInit();
            SuspendLayout();
            // 
            // panelTabla
            // 
            panelTabla.BackColor = Color.FromArgb(46, 61, 66);
            panelTabla.Controls.Add(textBox1);
            panelTabla.Controls.Add(label1);
            panelTabla.Controls.Add(buttonModificar);
            panelTabla.Controls.Add(textBusqueda);
            panelTabla.Controls.Add(buttonBuscar);
            panelTabla.Controls.Add(labelIngrese);
            panelTabla.Controls.Add(buttonEliminar);
            panelTabla.Controls.Add(buttonNuevo);
            panelTabla.Controls.Add(gridEjemplar);
            panelTabla.Dock = DockStyle.Fill;
            panelTabla.Location = new Point(0, 0);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(800, 474);
            panelTabla.TabIndex = 1;
            // 
            // buttonModificar
            // 
            buttonModificar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonModificar.Location = new Point(34, 140);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(171, 38);
            buttonModificar.TabIndex = 7;
            buttonModificar.Text = "Modificar Ejemplar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // textBusqueda
            // 
            textBusqueda.BackColor = Color.Gainsboro;
            textBusqueda.Location = new Point(359, 40);
            textBusqueda.Margin = new Padding(1);
            textBusqueda.Name = "textBusqueda";
            textBusqueda.Size = new Size(83, 23);
            textBusqueda.TabIndex = 6;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBuscar.Location = new Point(683, 38);
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
            labelIngrese.Location = new Point(234, 40);
            labelIngrese.Name = "labelIngrese";
            labelIngrese.Size = new Size(121, 17);
            labelIngrese.TabIndex = 4;
            labelIngrese.Text = "Ingrese un codigo";
            // 
            // buttonEliminar
            // 
            buttonEliminar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEliminar.Location = new Point(34, 202);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(171, 38);
            buttonEliminar.TabIndex = 3;
            buttonEliminar.Text = "Eliminar Ejemplar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNuevo.Location = new Point(34, 81);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(171, 38);
            buttonNuevo.TabIndex = 1;
            buttonNuevo.Text = "Nuevo Ejemplar";
            buttonNuevo.UseVisualStyleBackColor = true;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // gridEjemplar
            // 
            gridEjemplar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridEjemplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridEjemplar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridEjemplar.BackgroundColor = Color.FromArgb(37, 52, 57);
            gridEjemplar.BorderStyle = BorderStyle.None;
            gridEjemplar.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridEjemplar.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 45, 57);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 7.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridEjemplar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridEjemplar.ColumnHeadersHeight = 25;
            gridEjemplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridEjemplar.Columns.AddRange(new DataGridViewColumn[] { isbn, codigo, nombre, fechaAlta, fechaBaja, disponibilidad });
            gridEjemplar.EnableHeadersVisualStyles = false;
            gridEjemplar.GridColor = Color.FromArgb(30, 45, 57);
            gridEjemplar.Location = new Point(236, 81);
            gridEjemplar.Name = "gridEjemplar";
            gridEjemplar.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 52, 57);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridEjemplar.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridEjemplar.RowHeadersVisible = false;
            gridEjemplar.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 52, 57);
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 6.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(224, 224, 224);
            gridEjemplar.RowsDefaultCellStyle = dataGridViewCellStyle3;
            gridEjemplar.RowTemplate.Height = 24;
            gridEjemplar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridEjemplar.Size = new Size(528, 358);
            gridEjemplar.TabIndex = 0;
            // 
            // isbn
            // 
            isbn.HeaderText = "ISBN";
            isbn.Name = "isbn";
            isbn.Width = 59;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.MinimumWidth = 6;
            codigo.Name = "codigo";
            codigo.ReadOnly = true;
            codigo.Width = 70;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.Width = 73;
            // 
            // fechaAlta
            // 
            fechaAlta.HeaderText = "Fecha de Alta";
            fechaAlta.MinimumWidth = 6;
            fechaAlta.Name = "fechaAlta";
            fechaAlta.ReadOnly = true;
            fechaAlta.Width = 109;
            // 
            // fechaBaja
            // 
            fechaBaja.HeaderText = "Fecha de Baja";
            fechaBaja.MinimumWidth = 6;
            fechaBaja.Name = "fechaBaja";
            fechaBaja.ReadOnly = true;
            fechaBaja.Width = 112;
            // 
            // disponibilidad
            // 
            disponibilidad.HeaderText = "Disponibilidad";
            disponibilidad.MinimumWidth = 6;
            disponibilidad.Name = "disponibilidad";
            disponibilidad.ReadOnly = true;
            disponibilidad.Width = 110;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(458, 42);
            label1.Name = "label1";
            label1.Size = new Size(105, 17);
            label1.TabIndex = 8;
            label1.Text = "ISBN o Nombre";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.Location = new Point(567, 39);
            textBox1.Margin = new Padding(1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(99, 23);
            textBox1.TabIndex = 9;
            // 
            // GestionEjemplarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 474);
            Controls.Add(panelTabla);
            Name = "GestionEjemplarForm";
            Text = "Gestión de Ejemplares";
            panelTabla.ResumeLayout(false);
            panelTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridEjemplar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panelTabla;
        private System.Windows.Forms.DataGridView gridEjemplar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelIngrese;
        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.Button buttonModificar;
        private TextBox textBox1;
        private Label label1;
        private DataGridViewTextBoxColumn isbn;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn fechaAlta;
        private DataGridViewTextBoxColumn fechaBaja;
        private DataGridViewTextBoxColumn disponibilidad;
    }
}