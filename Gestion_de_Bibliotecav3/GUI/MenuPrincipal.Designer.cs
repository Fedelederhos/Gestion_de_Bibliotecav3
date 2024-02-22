
namespace Gestion_de_Biblioteca
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelMenu = new Panel();
            btnGestionPrestamos = new Button();
            btnGestionUsuario = new Button();
            btnRegistrarDevolucion = new Button();
            btnNuevoPrestamo = new Button();
            panelLogo = new Panel();
            panelBaner = new Panel();
            buttonCloseChildForm = new Button();
            buttonMinimize = new Button();
            buttonMaximize = new Button();
            buttonClose = new Button();
            labelTitulo = new Label();
            panelDesktop = new Panel();
            dataGrid = new DataGridView();
            usuario = new DataGridViewTextBoxColumn();
            isbn = new DataGridViewTextBoxColumn();
            fechaVencimiento = new DataGridViewTextBoxColumn();
            btnGestionEjemplares = new Button();
            btnGestionAutores = new Button();
            btnGestionCategorias = new Button();
            btnGestionLibros = new Button();
            panelMenu.SuspendLayout();
            panelBaner.SuspendLayout();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(37, 52, 57);
            panelMenu.Controls.Add(btnGestionCategorias);
            panelMenu.Controls.Add(btnGestionAutores);
            panelMenu.Controls.Add(btnGestionEjemplares);
            panelMenu.Controls.Add(btnGestionLibros);
            panelMenu.Controls.Add(btnGestionPrestamos);
            panelMenu.Controls.Add(btnGestionUsuario);
            panelMenu.Controls.Add(btnRegistrarDevolucion);
            panelMenu.Controls.Add(btnNuevoPrestamo);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(219, 613);
            panelMenu.TabIndex = 0;
            panelMenu.MouseDown += MenuPrincipal_MouseDown;
            // 
            // btnGestionPrestamos
            // 
            btnGestionPrestamos.Dock = DockStyle.Top;
            btnGestionPrestamos.FlatAppearance.BorderSize = 0;
            btnGestionPrestamos.FlatStyle = FlatStyle.Flat;
            btnGestionPrestamos.Font = new Font("Microsoft Sans Serif", 11.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnGestionPrestamos.ForeColor = Color.Gainsboro;
            btnGestionPrestamos.Location = new Point(0, 234);
            btnGestionPrestamos.Margin = new Padding(2);
            btnGestionPrestamos.Name = "btnGestionPrestamos";
            btnGestionPrestamos.Padding = new Padding(10, 0, 0, 0);
            btnGestionPrestamos.Size = new Size(219, 47);
            btnGestionPrestamos.TabIndex = 4;
            btnGestionPrestamos.Text = "Gestión de Préstamos";
            btnGestionPrestamos.UseVisualStyleBackColor = true;
            btnGestionPrestamos.Click += btnGestionPrestamos_Click;
            // 
            // btnGestionUsuario
            // 
            btnGestionUsuario.Dock = DockStyle.Top;
            btnGestionUsuario.FlatAppearance.BorderSize = 0;
            btnGestionUsuario.FlatStyle = FlatStyle.Flat;
            btnGestionUsuario.Font = new Font("Microsoft Sans Serif", 11.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnGestionUsuario.ForeColor = Color.Gainsboro;
            btnGestionUsuario.Location = new Point(0, 187);
            btnGestionUsuario.Margin = new Padding(2);
            btnGestionUsuario.Name = "btnGestionUsuario";
            btnGestionUsuario.Padding = new Padding(10, 0, 0, 0);
            btnGestionUsuario.Size = new Size(219, 47);
            btnGestionUsuario.TabIndex = 3;
            btnGestionUsuario.Text = "Gestión de Usuarios";
            btnGestionUsuario.UseVisualStyleBackColor = true;
            btnGestionUsuario.Click += btnGestionUsuario_Click;
            // 
            // btnRegistrarDevolucion
            // 
            btnRegistrarDevolucion.Dock = DockStyle.Top;
            btnRegistrarDevolucion.FlatAppearance.BorderSize = 0;
            btnRegistrarDevolucion.FlatStyle = FlatStyle.Flat;
            btnRegistrarDevolucion.Font = new Font("Microsoft Sans Serif", 11.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistrarDevolucion.ForeColor = Color.Gainsboro;
            btnRegistrarDevolucion.Location = new Point(0, 140);
            btnRegistrarDevolucion.Margin = new Padding(2);
            btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            btnRegistrarDevolucion.Padding = new Padding(10, 0, 0, 0);
            btnRegistrarDevolucion.Size = new Size(219, 47);
            btnRegistrarDevolucion.TabIndex = 2;
            btnRegistrarDevolucion.Text = "Registrar Devolución";
            btnRegistrarDevolucion.UseVisualStyleBackColor = true;
            btnRegistrarDevolucion.Click += btnRegistrarDevolucion_Click;
            // 
            // btnNuevoPrestamo
            // 
            btnNuevoPrestamo.Dock = DockStyle.Top;
            btnNuevoPrestamo.FlatAppearance.BorderSize = 0;
            btnNuevoPrestamo.FlatStyle = FlatStyle.Flat;
            btnNuevoPrestamo.Font = new Font("Microsoft Sans Serif", 11.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnNuevoPrestamo.ForeColor = Color.Gainsboro;
            btnNuevoPrestamo.Location = new Point(0, 93);
            btnNuevoPrestamo.Margin = new Padding(2);
            btnNuevoPrestamo.Name = "btnNuevoPrestamo";
            btnNuevoPrestamo.Padding = new Padding(10, 0, 0, 0);
            btnNuevoPrestamo.Size = new Size(219, 47);
            btnNuevoPrestamo.TabIndex = 1;
            btnNuevoPrestamo.Text = "Nuevo Préstamo";
            btnNuevoPrestamo.UseVisualStyleBackColor = true;
            btnNuevoPrestamo.Click += btnNuevoPrestamo_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(37, 52, 57);
            panelLogo.BackgroundImage = (Image)resources.GetObject("panelLogo.BackgroundImage");
            panelLogo.BackgroundImageLayout = ImageLayout.Zoom;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            panelLogo.ForeColor = SystemColors.ControlText;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(219, 93);
            panelLogo.TabIndex = 0;
            panelLogo.MouseDown += MenuPrincipal_MouseDown;
            // 
            // panelBaner
            // 
            panelBaner.BackColor = Color.FromArgb(37, 52, 57);
            panelBaner.Controls.Add(buttonCloseChildForm);
            panelBaner.Controls.Add(buttonMinimize);
            panelBaner.Controls.Add(buttonMaximize);
            panelBaner.Controls.Add(buttonClose);
            panelBaner.Controls.Add(labelTitulo);
            panelBaner.Dock = DockStyle.Top;
            panelBaner.Location = new Point(219, 0);
            panelBaner.Margin = new Padding(2);
            panelBaner.Name = "panelBaner";
            panelBaner.Size = new Size(815, 93);
            panelBaner.TabIndex = 1;
            panelBaner.MouseDown += panelBaner_MouseDown;
            // 
            // buttonCloseChildForm
            // 
            buttonCloseChildForm.FlatAppearance.BorderSize = 0;
            buttonCloseChildForm.FlatStyle = FlatStyle.Flat;
            buttonCloseChildForm.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCloseChildForm.ForeColor = Color.Gainsboro;
            buttonCloseChildForm.Location = new Point(22, 25);
            buttonCloseChildForm.Margin = new Padding(2);
            buttonCloseChildForm.Name = "buttonCloseChildForm";
            buttonCloseChildForm.RightToLeft = RightToLeft.No;
            buttonCloseChildForm.Size = new Size(48, 52);
            buttonCloseChildForm.TabIndex = 3;
            buttonCloseChildForm.Text = "X";
            buttonCloseChildForm.UseVisualStyleBackColor = true;
            buttonCloseChildForm.Click += buttonCloseChildForm_Click;
            // 
            // buttonMinimize
            // 
            buttonMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMinimize.ForeColor = Color.Gainsboro;
            buttonMinimize.Location = new Point(714, 2);
            buttonMinimize.Margin = new Padding(2);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(26, 28);
            buttonMinimize.TabIndex = 2;
            buttonMinimize.Text = "O";
            buttonMinimize.UseVisualStyleBackColor = true;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // buttonMaximize
            // 
            buttonMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonMaximize.FlatAppearance.BorderSize = 0;
            buttonMaximize.FlatStyle = FlatStyle.Flat;
            buttonMaximize.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMaximize.ForeColor = Color.Gainsboro;
            buttonMaximize.Location = new Point(750, 2);
            buttonMaximize.Margin = new Padding(2);
            buttonMaximize.Name = "buttonMaximize";
            buttonMaximize.Size = new Size(26, 28);
            buttonMaximize.TabIndex = 2;
            buttonMaximize.Text = "O";
            buttonMaximize.UseVisualStyleBackColor = true;
            buttonMaximize.Click += buttonMaximize_Click;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClose.ForeColor = Color.Gainsboro;
            buttonClose.Location = new Point(786, 2);
            buttonClose.Margin = new Padding(2);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(26, 28);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "O";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.Anchor = AnchorStyles.None;
            labelTitulo.AutoSize = true;
            labelTitulo.FlatStyle = FlatStyle.Flat;
            labelTitulo.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.Gainsboro;
            labelTitulo.Location = new Point(273, 47);
            labelTitulo.Margin = new Padding(2, 0, 2, 0);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(242, 26);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Próximos Vencimientos";
            labelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(46, 61, 66);
            panelDesktop.Controls.Add(dataGrid);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(219, 93);
            panelDesktop.Margin = new Padding(2);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(815, 520);
            panelDesktop.TabIndex = 2;
            panelDesktop.MouseDown += panelDesktop_MouseDown;
            // 
            // dataGrid
            // 
            dataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGrid.BackgroundColor = Color.Gainsboro;
            dataGrid.BorderStyle = BorderStyle.None;
            dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 45, 57);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid.ColumnHeadersHeight = 25;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { usuario, isbn, fechaVencimiento });
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.GridColor = Color.Gainsboro;
            dataGrid.Location = new Point(178, 24);
            dataGrid.Margin = new Padding(2);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Gainsboro;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGrid.RowHeadersVisible = false;
            dataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.Gainsboro;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 6.5F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGrid.RowTemplate.Height = 24;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.Size = new Size(443, 429);
            dataGrid.TabIndex = 1;
            dataGrid.CellContentClick += dataGrid_CellContentClick;
            // 
            // usuario
            // 
            usuario.HeaderText = "USUARIO";
            usuario.MinimumWidth = 6;
            usuario.Name = "usuario";
            usuario.ReadOnly = true;
            usuario.Width = 106;
            // 
            // isbn
            // 
            isbn.HeaderText = "ISBN";
            isbn.MinimumWidth = 6;
            isbn.Name = "isbn";
            isbn.ReadOnly = true;
            isbn.Width = 70;
            // 
            // fechaVencimiento
            // 
            fechaVencimiento.HeaderText = "FECHA DE VENCIMIENTO";
            fechaVencimiento.MinimumWidth = 6;
            fechaVencimiento.Name = "fechaVencimiento";
            fechaVencimiento.ReadOnly = true;
            fechaVencimiento.Width = 233;
            // 
            // btnGestionEjemplares
            // 
            btnGestionEjemplares.Dock = DockStyle.Top;
            btnGestionEjemplares.FlatAppearance.BorderSize = 0;
            btnGestionEjemplares.FlatStyle = FlatStyle.Flat;
            btnGestionEjemplares.Font = new Font("Microsoft Sans Serif", 11.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnGestionEjemplares.ForeColor = Color.Gainsboro;
            btnGestionEjemplares.Location = new Point(0, 328);
            btnGestionEjemplares.Margin = new Padding(2);
            btnGestionEjemplares.Name = "btnGestionEjemplares";
            btnGestionEjemplares.Padding = new Padding(10, 0, 0, 0);
            btnGestionEjemplares.Size = new Size(219, 47);
            btnGestionEjemplares.TabIndex = 6;
            btnGestionEjemplares.Text = "Gestión de Ejemplares";
            btnGestionEjemplares.UseVisualStyleBackColor = true;
            btnGestionEjemplares.Click += btnGestionEjemplares_Click;
            // 
            // btnGestionAutores
            // 
            btnGestionAutores.Dock = DockStyle.Top;
            btnGestionAutores.FlatAppearance.BorderSize = 0;
            btnGestionAutores.FlatStyle = FlatStyle.Flat;
            btnGestionAutores.Font = new Font("Microsoft Sans Serif", 11.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnGestionAutores.ForeColor = Color.Gainsboro;
            btnGestionAutores.Location = new Point(0, 375);
            btnGestionAutores.Margin = new Padding(2);
            btnGestionAutores.Name = "btnGestionAutores";
            btnGestionAutores.Padding = new Padding(10, 0, 0, 0);
            btnGestionAutores.Size = new Size(219, 47);
            btnGestionAutores.TabIndex = 7;
            btnGestionAutores.Text = "Consulta según Autores";
            btnGestionAutores.UseVisualStyleBackColor = true;
            btnGestionAutores.Click += btnGestionAutores_Click;
            // 
            // btnGestionCategorias
            // 
            btnGestionCategorias.Dock = DockStyle.Top;
            btnGestionCategorias.FlatAppearance.BorderSize = 0;
            btnGestionCategorias.FlatStyle = FlatStyle.Flat;
            btnGestionCategorias.Font = new Font("Microsoft Sans Serif", 11.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnGestionCategorias.ForeColor = Color.Gainsboro;
            btnGestionCategorias.Location = new Point(0, 422);
            btnGestionCategorias.Margin = new Padding(2);
            btnGestionCategorias.Name = "btnGestionCategorias";
            btnGestionCategorias.Padding = new Padding(10, 0, 0, 0);
            btnGestionCategorias.Size = new Size(219, 47);
            btnGestionCategorias.TabIndex = 8;
            btnGestionCategorias.Text = "Consulta según Categorías";
            btnGestionCategorias.UseVisualStyleBackColor = true;
            btnGestionCategorias.Click += btnGestionCategorias_Click;
            // 
            // btnGestionLibros
            // 
            btnGestionLibros.Dock = DockStyle.Top;
            btnGestionLibros.FlatAppearance.BorderSize = 0;
            btnGestionLibros.FlatStyle = FlatStyle.Flat;
            btnGestionLibros.Font = new Font("Microsoft Sans Serif", 11.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnGestionLibros.ForeColor = Color.Gainsboro;
            btnGestionLibros.Location = new Point(0, 281);
            btnGestionLibros.Margin = new Padding(2);
            btnGestionLibros.Name = "btnGestionLibros";
            btnGestionLibros.Padding = new Padding(10, 0, 0, 0);
            btnGestionLibros.Size = new Size(219, 47);
            btnGestionLibros.TabIndex = 5;
            btnGestionLibros.Text = "Consulta de Libros";
            btnGestionLibros.UseVisualStyleBackColor = true;
            btnGestionLibros.Click += btnGestionLibros_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 613);
            Controls.Add(panelDesktop);
            Controls.Add(panelBaner);
            Controls.Add(panelMenu);
            Margin = new Padding(2);
            Name = "MenuPrincipal";
            Text = "Menu Principal";
            MouseDown += MenuPrincipal_MouseDown;
            panelMenu.ResumeLayout(false);
            panelBaner.ResumeLayout(false);
            panelBaner.PerformLayout();
            panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnNuevoPrestamo;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnGestionPrestamos;
        private System.Windows.Forms.Button btnGestionUsuario;
        private System.Windows.Forms.Button btnRegistrarDevolucion;
        private System.Windows.Forms.Panel panelBaner;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Button buttonCloseChildForm;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaVencimiento;
        private Button btnGestionCategorias;
        private Button btnGestionAutores;
        private Button btnGestionEjemplares;
        private Button btnGestionLibros;
    }
}

