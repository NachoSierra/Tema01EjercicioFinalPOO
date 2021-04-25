
namespace Tema01EjercicioFinalPOO.Windows
{
    partial class FrmTriangulosEquilateros
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NuevoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EliminarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EditarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ActualizarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SalirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.FiltrarToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.lineaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rayasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colLados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBorde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPerimetro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuperficie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdenarToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.ascendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoToolStripButton,
            this.EliminarToolStripButton,
            this.EditarToolStripButton,
            this.toolStripSeparator1,
            this.ActualizarToolStripButton,
            this.FiltrarToolStripButton,
            this.toolStripSeparator2,
            this.OrdenarToolStripButton,
            this.SalirToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NuevoToolStripButton
            // 
            this.NuevoToolStripButton.Image = global::Tema01EjercicioFinalPOO.Windows.Properties.Resources.new_copy_40px;
            this.NuevoToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NuevoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoToolStripButton.Name = "NuevoToolStripButton";
            this.NuevoToolStripButton.Size = new System.Drawing.Size(46, 59);
            this.NuevoToolStripButton.Text = "Nuevo";
            this.NuevoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoToolStripButton.Click += new System.EventHandler(this.NuevoToolStripButton_Click);
            // 
            // EliminarToolStripButton
            // 
            this.EliminarToolStripButton.Image = global::Tema01EjercicioFinalPOO.Windows.Properties.Resources.trash_40px;
            this.EliminarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EliminarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EliminarToolStripButton.Name = "EliminarToolStripButton";
            this.EliminarToolStripButton.Size = new System.Drawing.Size(54, 59);
            this.EliminarToolStripButton.Text = "Eliminar";
            this.EliminarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EliminarToolStripButton.Click += new System.EventHandler(this.EliminarToolStripButton_Click);
            // 
            // EditarToolStripButton
            // 
            this.EditarToolStripButton.Image = global::Tema01EjercicioFinalPOO.Windows.Properties.Resources.edit_property_40px;
            this.EditarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarToolStripButton.Name = "EditarToolStripButton";
            this.EditarToolStripButton.Size = new System.Drawing.Size(44, 59);
            this.EditarToolStripButton.Text = "Editar";
            this.EditarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditarToolStripButton.Click += new System.EventHandler(this.EditarToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 62);
            // 
            // ActualizarToolStripButton
            // 
            this.ActualizarToolStripButton.Image = global::Tema01EjercicioFinalPOO.Windows.Properties.Resources.refresh_40px;
            this.ActualizarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ActualizarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ActualizarToolStripButton.Name = "ActualizarToolStripButton";
            this.ActualizarToolStripButton.Size = new System.Drawing.Size(63, 59);
            this.ActualizarToolStripButton.Text = "Actualizar";
            this.ActualizarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ActualizarToolStripButton.Click += new System.EventHandler(this.ActualizarToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 62);
            // 
            // SalirToolStripButton
            // 
            this.SalirToolStripButton.Image = global::Tema01EjercicioFinalPOO.Windows.Properties.Resources.exit_40px;
            this.SalirToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SalirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirToolStripButton.Name = "SalirToolStripButton";
            this.SalirToolStripButton.Size = new System.Drawing.Size(44, 59);
            this.SalirToolStripButton.Text = "Salir";
            this.SalirToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalirToolStripButton.Click += new System.EventHandler(this.SalirToolStripButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DatosDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 388);
            this.panel1.TabIndex = 1;
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLados,
            this.colBorde,
            this.colPerimetro,
            this.colSuperficie});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.RowHeadersVisible = false;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(800, 388);
            this.DatosDataGridView.TabIndex = 0;
            // 
            // FiltrarToolStripButton
            // 
            this.FiltrarToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineaToolStripMenuItem,
            this.puntosToolStripMenuItem,
            this.rayasToolStripMenuItem});
            this.FiltrarToolStripButton.Image = global::Tema01EjercicioFinalPOO.Windows.Properties.Resources.filter_40px;
            this.FiltrarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FiltrarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FiltrarToolStripButton.Name = "FiltrarToolStripButton";
            this.FiltrarToolStripButton.Size = new System.Drawing.Size(53, 59);
            this.FiltrarToolStripButton.Text = "Filtrar";
            this.FiltrarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // lineaToolStripMenuItem
            // 
            this.lineaToolStripMenuItem.Name = "lineaToolStripMenuItem";
            this.lineaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lineaToolStripMenuItem.Text = "Linea";
            this.lineaToolStripMenuItem.Click += new System.EventHandler(this.lineaToolStripMenuItem_Click);
            // 
            // puntosToolStripMenuItem
            // 
            this.puntosToolStripMenuItem.Name = "puntosToolStripMenuItem";
            this.puntosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.puntosToolStripMenuItem.Text = "Puntos";
            this.puntosToolStripMenuItem.Click += new System.EventHandler(this.puntosToolStripMenuItem_Click);
            // 
            // rayasToolStripMenuItem
            // 
            this.rayasToolStripMenuItem.Name = "rayasToolStripMenuItem";
            this.rayasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rayasToolStripMenuItem.Text = "Rayas";
            this.rayasToolStripMenuItem.Click += new System.EventHandler(this.rayasToolStripMenuItem_Click);
            // 
            // colLados
            // 
            this.colLados.HeaderText = "Lados";
            this.colLados.Name = "colLados";
            this.colLados.ReadOnly = true;
            this.colLados.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colBorde
            // 
            this.colBorde.HeaderText = "Borde";
            this.colBorde.Name = "colBorde";
            this.colBorde.ReadOnly = true;
            this.colBorde.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colPerimetro
            // 
            this.colPerimetro.HeaderText = "Perimetro";
            this.colPerimetro.Name = "colPerimetro";
            this.colPerimetro.ReadOnly = true;
            this.colPerimetro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSuperficie
            // 
            this.colSuperficie.HeaderText = "Superficie";
            this.colSuperficie.Name = "colSuperficie";
            this.colSuperficie.ReadOnly = true;
            this.colSuperficie.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OrdenarToolStripButton
            // 
            this.OrdenarToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendenteToolStripMenuItem,
            this.descendenteToolStripMenuItem});
            this.OrdenarToolStripButton.Image = global::Tema01EjercicioFinalPOO.Windows.Properties.Resources.descending_sorting_40px;
            this.OrdenarToolStripButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OrdenarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OrdenarToolStripButton.Name = "OrdenarToolStripButton";
            this.OrdenarToolStripButton.Size = new System.Drawing.Size(63, 59);
            this.OrdenarToolStripButton.Text = "Ordenar";
            this.OrdenarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // ascendenteToolStripMenuItem
            // 
            this.ascendenteToolStripMenuItem.Name = "ascendenteToolStripMenuItem";
            this.ascendenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ascendenteToolStripMenuItem.Text = "Ascendente";
            this.ascendenteToolStripMenuItem.Click += new System.EventHandler(this.ascendenteToolStripMenuItem_Click);
            // 
            // descendenteToolStripMenuItem
            // 
            this.descendenteToolStripMenuItem.Name = "descendenteToolStripMenuItem";
            this.descendenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.descendenteToolStripMenuItem.Text = "Descendente";
            this.descendenteToolStripMenuItem.Click += new System.EventHandler(this.descendenteToolStripMenuItem_Click);
            // 
            // FrmTriangulosEquilateros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmTriangulosEquilateros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Triangulos";
            this.Load += new System.EventHandler(this.FrmTriangulosEquilateros_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NuevoToolStripButton;
        private System.Windows.Forms.ToolStripButton EliminarToolStripButton;
        private System.Windows.Forms.ToolStripButton EditarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ActualizarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SalirToolStripButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.ToolStripDropDownButton FiltrarToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem lineaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rayasToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLados;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBorde;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPerimetro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSuperficie;
        private System.Windows.Forms.ToolStripDropDownButton OrdenarToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem ascendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendenteToolStripMenuItem;
    }
}

