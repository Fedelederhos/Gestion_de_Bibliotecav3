
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnGestionEditoriales = new System.Windows.Forms.Button();
            this.btnGestionCategorias = new System.Windows.Forms.Button();
            this.btnGestionAutores = new System.Windows.Forms.Button();
            this.btnGestionEjemplares = new System.Windows.Forms.Button();
            this.btnGestionLibros = new System.Windows.Forms.Button();
            this.btnGestionPrestamos = new System.Windows.Forms.Button();
            this.btnGestionUsuario = new System.Windows.Forms.Button();
            this.btnRegistrarDevolucion = new System.Windows.Forms.Button();
            this.btnNuevoPrestamo = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelBaner = new System.Windows.Forms.Panel();
            this.buttonCloseChildForm = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMenu.SuspendLayout();
            this.panelBaner.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.panelMenu.Controls.Add(this.btnGestionEditoriales);
            this.panelMenu.Controls.Add(this.btnGestionCategorias);
            this.panelMenu.Controls.Add(this.btnGestionAutores);
            this.panelMenu.Controls.Add(this.btnGestionEjemplares);
            this.panelMenu.Controls.Add(this.btnGestionLibros);
            this.panelMenu.Controls.Add(this.btnGestionPrestamos);
            this.panelMenu.Controls.Add(this.btnGestionUsuario);
            this.panelMenu.Controls.Add(this.btnRegistrarDevolucion);
            this.panelMenu.Controls.Add(this.btnNuevoPrestamo);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(188, 531);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuPrincipal_MouseDown);
            // 
            // btnGestionEditoriales
            // 
            this.btnGestionEditoriales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionEditoriales.FlatAppearance.BorderSize = 0;
            this.btnGestionEditoriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionEditoriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.btnGestionEditoriales.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGestionEditoriales.Location = new System.Drawing.Point(0, 409);
            this.btnGestionEditoriales.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGestionEditoriales.Name = "btnGestionEditoriales";
            this.btnGestionEditoriales.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnGestionEditoriales.Size = new System.Drawing.Size(188, 41);
            this.btnGestionEditoriales.TabIndex = 9;
            this.btnGestionEditoriales.Text = "Gestión de Editoriales";
            this.btnGestionEditoriales.UseVisualStyleBackColor = true;
            this.btnGestionEditoriales.Click += new System.EventHandler(this.btnGestionEditoriales_Click);
            // 
            // btnGestionCategorias
            // 
            this.btnGestionCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionCategorias.FlatAppearance.BorderSize = 0;
            this.btnGestionCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.btnGestionCategorias.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGestionCategorias.Location = new System.Drawing.Point(0, 368);
            this.btnGestionCategorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGestionCategorias.Name = "btnGestionCategorias";
            this.btnGestionCategorias.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnGestionCategorias.Size = new System.Drawing.Size(188, 41);
            this.btnGestionCategorias.TabIndex = 8;
            this.btnGestionCategorias.Text = "Gestión de Categorías";
            this.btnGestionCategorias.UseVisualStyleBackColor = true;
            this.btnGestionCategorias.Click += new System.EventHandler(this.btnGestionCategorias_Click);
            // 
            // btnGestionAutores
            // 
            this.btnGestionAutores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionAutores.FlatAppearance.BorderSize = 0;
            this.btnGestionAutores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.btnGestionAutores.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGestionAutores.Location = new System.Drawing.Point(0, 327);
            this.btnGestionAutores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGestionAutores.Name = "btnGestionAutores";
            this.btnGestionAutores.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnGestionAutores.Size = new System.Drawing.Size(188, 41);
            this.btnGestionAutores.TabIndex = 7;
            this.btnGestionAutores.Text = "Gestión de Autores";
            this.btnGestionAutores.UseVisualStyleBackColor = true;
            this.btnGestionAutores.Click += new System.EventHandler(this.btnGestionAutores_Click);
            // 
            // btnGestionEjemplares
            // 
            this.btnGestionEjemplares.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionEjemplares.FlatAppearance.BorderSize = 0;
            this.btnGestionEjemplares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionEjemplares.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.btnGestionEjemplares.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGestionEjemplares.Location = new System.Drawing.Point(0, 286);
            this.btnGestionEjemplares.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGestionEjemplares.Name = "btnGestionEjemplares";
            this.btnGestionEjemplares.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnGestionEjemplares.Size = new System.Drawing.Size(188, 41);
            this.btnGestionEjemplares.TabIndex = 6;
            this.btnGestionEjemplares.Text = "Gestión de Ejemplares";
            this.btnGestionEjemplares.UseVisualStyleBackColor = true;
            this.btnGestionEjemplares.Click += new System.EventHandler(this.btnGestionEjemplares_Click);
            // 
            // btnGestionLibros
            // 
            this.btnGestionLibros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionLibros.FlatAppearance.BorderSize = 0;
            this.btnGestionLibros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.btnGestionLibros.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGestionLibros.Location = new System.Drawing.Point(0, 245);
            this.btnGestionLibros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGestionLibros.Name = "btnGestionLibros";
            this.btnGestionLibros.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnGestionLibros.Size = new System.Drawing.Size(188, 41);
            this.btnGestionLibros.TabIndex = 5;
            this.btnGestionLibros.Text = "Gestión de Libros";
            this.btnGestionLibros.UseVisualStyleBackColor = true;
            this.btnGestionLibros.Click += new System.EventHandler(this.btnGestionLibros_Click);
            // 
            // btnGestionPrestamos
            // 
            this.btnGestionPrestamos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionPrestamos.FlatAppearance.BorderSize = 0;
            this.btnGestionPrestamos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.btnGestionPrestamos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGestionPrestamos.Location = new System.Drawing.Point(0, 204);
            this.btnGestionPrestamos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGestionPrestamos.Name = "btnGestionPrestamos";
            this.btnGestionPrestamos.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnGestionPrestamos.Size = new System.Drawing.Size(188, 41);
            this.btnGestionPrestamos.TabIndex = 4;
            this.btnGestionPrestamos.Text = "Gestión de Préstamos";
            this.btnGestionPrestamos.UseVisualStyleBackColor = true;
            this.btnGestionPrestamos.Click += new System.EventHandler(this.btnGestionPrestamos_Click);
            // 
            // btnGestionUsuario
            // 
            this.btnGestionUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionUsuario.FlatAppearance.BorderSize = 0;
            this.btnGestionUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.btnGestionUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGestionUsuario.Location = new System.Drawing.Point(0, 163);
            this.btnGestionUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGestionUsuario.Name = "btnGestionUsuario";
            this.btnGestionUsuario.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnGestionUsuario.Size = new System.Drawing.Size(188, 41);
            this.btnGestionUsuario.TabIndex = 3;
            this.btnGestionUsuario.Text = "Gestión de Usuarios";
            this.btnGestionUsuario.UseVisualStyleBackColor = true;
            this.btnGestionUsuario.Click += new System.EventHandler(this.btnGestionUsuario_Click);
            // 
            // btnRegistrarDevolucion
            // 
            this.btnRegistrarDevolucion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarDevolucion.FlatAppearance.BorderSize = 0;
            this.btnRegistrarDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.btnRegistrarDevolucion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRegistrarDevolucion.Location = new System.Drawing.Point(0, 122);
            this.btnRegistrarDevolucion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrarDevolucion.Name = "btnRegistrarDevolucion";
            this.btnRegistrarDevolucion.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnRegistrarDevolucion.Size = new System.Drawing.Size(188, 41);
            this.btnRegistrarDevolucion.TabIndex = 2;
            this.btnRegistrarDevolucion.Text = "Registrar Devolución";
            this.btnRegistrarDevolucion.UseVisualStyleBackColor = true;
            this.btnRegistrarDevolucion.Click += new System.EventHandler(this.btnRegistrarDevolucion_Click);
            // 
            // btnNuevoPrestamo
            // 
            this.btnNuevoPrestamo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevoPrestamo.FlatAppearance.BorderSize = 0;
            this.btnNuevoPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.btnNuevoPrestamo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNuevoPrestamo.Location = new System.Drawing.Point(0, 81);
            this.btnNuevoPrestamo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevoPrestamo.Name = "btnNuevoPrestamo";
            this.btnNuevoPrestamo.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnNuevoPrestamo.Size = new System.Drawing.Size(188, 41);
            this.btnNuevoPrestamo.TabIndex = 1;
            this.btnNuevoPrestamo.Text = "Nuevo Préstamo";
            this.btnNuevoPrestamo.UseVisualStyleBackColor = true;
            this.btnNuevoPrestamo.Click += new System.EventHandler(this.btnNuevoPrestamo_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(188, 81);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuPrincipal_MouseDown);
            // 
            // panelBaner
            // 
            this.panelBaner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.panelBaner.Controls.Add(this.buttonCloseChildForm);
            this.panelBaner.Controls.Add(this.buttonMinimize);
            this.panelBaner.Controls.Add(this.buttonMaximize);
            this.panelBaner.Controls.Add(this.buttonClose);
            this.panelBaner.Controls.Add(this.labelTitulo);
            this.panelBaner.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBaner.Location = new System.Drawing.Point(188, 0);
            this.panelBaner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBaner.Name = "panelBaner";
            this.panelBaner.Size = new System.Drawing.Size(698, 81);
            this.panelBaner.TabIndex = 1;
            this.panelBaner.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBaner_MouseDown);
            // 
            // buttonCloseChildForm
            // 
            this.buttonCloseChildForm.FlatAppearance.BorderSize = 0;
            this.buttonCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCloseChildForm.Location = new System.Drawing.Point(19, 22);
            this.buttonCloseChildForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCloseChildForm.Name = "buttonCloseChildForm";
            this.buttonCloseChildForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonCloseChildForm.Size = new System.Drawing.Size(41, 45);
            this.buttonCloseChildForm.TabIndex = 3;
            this.buttonCloseChildForm.Text = "X";
            this.buttonCloseChildForm.UseVisualStyleBackColor = true;
            this.buttonCloseChildForm.Click += new System.EventHandler(this.buttonCloseChildForm_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMinimize.Location = new System.Drawing.Point(611, 2);
            this.buttonMinimize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(22, 24);
            this.buttonMinimize.TabIndex = 2;
            this.buttonMinimize.Text = "O";
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMaximize.Location = new System.Drawing.Point(642, 2);
            this.buttonMaximize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(22, 24);
            this.buttonMaximize.TabIndex = 2;
            this.buttonMaximize.Text = "O";
            this.buttonMaximize.UseVisualStyleBackColor = true;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonClose.Location = new System.Drawing.Point(673, 2);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(22, 24);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "O";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitulo.Location = new System.Drawing.Point(234, 41);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(242, 26);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Próximos Vencimientos";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(66)))));
            this.panelDesktop.Controls.Add(this.dataGrid);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(188, 81);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(698, 450);
            this.panelDesktop.TabIndex = 2;
            this.panelDesktop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDesktop_MouseDown);
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid.ColumnHeadersHeight = 25;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuario,
            this.isbn,
            this.fechaVencimiento});
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGrid.Location = new System.Drawing.Point(153, 21);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(379, 371);
            this.dataGrid.TabIndex = 1;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // usuario
            // 
            this.usuario.HeaderText = "USUARIO";
            this.usuario.MinimumWidth = 6;
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 106;
            // 
            // isbn
            // 
            this.isbn.HeaderText = "ISBN";
            this.isbn.MinimumWidth = 6;
            this.isbn.Name = "isbn";
            this.isbn.ReadOnly = true;
            this.isbn.Width = 70;
            // 
            // fechaVencimiento
            // 
            this.fechaVencimiento.HeaderText = "FECHA DE VENCIMIENTO";
            this.fechaVencimiento.MinimumWidth = 6;
            this.fechaVencimiento.Name = "fechaVencimiento";
            this.fechaVencimiento.ReadOnly = true;
            this.fechaVencimiento.Width = 233;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 531);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelBaner);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuPrincipal_MouseDown);
            this.panelMenu.ResumeLayout(false);
            this.panelBaner.ResumeLayout(false);
            this.panelBaner.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnNuevoPrestamo;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnGestionEditoriales;
        private System.Windows.Forms.Button btnGestionCategorias;
        private System.Windows.Forms.Button btnGestionAutores;
        private System.Windows.Forms.Button btnGestionEjemplares;
        private System.Windows.Forms.Button btnGestionLibros;
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
    }
}

