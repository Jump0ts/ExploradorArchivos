namespace ExploradordeArchivos
{
    partial class explorador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(explorador));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.vistaArbol = new System.Windows.Forms.TreeView();
            this.listaImagenPeq = new System.Windows.Forms.ImageList(this.components);
            this.vistaArchivos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuOpciones = new System.Windows.Forms.MenuStrip();
            this.vistaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.iconosPequenosTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.iconosGrandesTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.listaTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.salirTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.listaImagenGrande = new System.Windows.Forms.ImageList(this.components);
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1046, 469);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(1046, 502);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuOpciones);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.vistaArbol);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.vistaArchivos);
            this.splitContainer1.Size = new System.Drawing.Size(1046, 469);
            this.splitContainer1.SplitterDistance = 348;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // vistaArbol
            // 
            this.vistaArbol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vistaArbol.ImageIndex = 0;
            this.vistaArbol.ImageList = this.listaImagenPeq;
            this.vistaArbol.Location = new System.Drawing.Point(0, 0);
            this.vistaArbol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vistaArbol.Name = "vistaArbol";
            this.vistaArbol.SelectedImageIndex = 0;
            this.vistaArbol.Size = new System.Drawing.Size(348, 469);
            this.vistaArbol.TabIndex = 0;
            this.vistaArbol.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.vistaArbol_NodeMouseClick);
            // 
            // listaImagenPeq
            // 
            this.listaImagenPeq.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaImagenPeq.ImageStream")));
            this.listaImagenPeq.TransparentColor = System.Drawing.Color.Transparent;
            this.listaImagenPeq.Images.SetKeyName(0, "Folder");
            this.listaImagenPeq.Images.SetKeyName(1, "File");
            this.listaImagenPeq.Images.SetKeyName(2, "imagen.png");
            this.listaImagenPeq.Images.SetKeyName(3, "documentos.png");
            this.listaImagenPeq.Images.SetKeyName(4, "ejecutable.png");
            this.listaImagenPeq.Images.SetKeyName(5, "ficherotexto.png");
            this.listaImagenPeq.Images.SetKeyName(6, "java.png");
            this.listaImagenPeq.Images.SetKeyName(7, "musica.png");
            this.listaImagenPeq.Images.SetKeyName(8, "pdf.png");
            this.listaImagenPeq.Images.SetKeyName(9, "rar.jpg");
            this.listaImagenPeq.Images.SetKeyName(10, "video.png");
            // 
            // vistaArchivos
            // 
            this.vistaArchivos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.vistaArchivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vistaArchivos.HideSelection = false;
            this.vistaArchivos.LargeImageList = this.listaImagenGrande;
            this.vistaArchivos.Location = new System.Drawing.Point(0, 0);
            this.vistaArchivos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vistaArchivos.Name = "vistaArchivos";
            this.vistaArchivos.Size = new System.Drawing.Size(692, 469);
            this.vistaArchivos.SmallImageList = this.listaImagenPeq;
            this.vistaArchivos.TabIndex = 0;
            this.vistaArchivos.UseCompatibleStateImageBehavior = false;
            this.vistaArchivos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tipo";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Última Modificación";
            // 
            // menuOpciones
            // 
            this.menuOpciones.Dock = System.Windows.Forms.DockStyle.None;
            this.menuOpciones.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuOpciones.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vistaTSMI,
            this.salirTSMI});
            this.menuOpciones.Location = new System.Drawing.Point(0, 0);
            this.menuOpciones.Name = "menuOpciones";
            this.menuOpciones.Size = new System.Drawing.Size(1046, 33);
            this.menuOpciones.TabIndex = 0;
            this.menuOpciones.Text = "menuStrip1";
            // 
            // vistaTSMI
            // 
            this.vistaTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconosPequenosTSMI,
            this.iconosGrandesTSMI,
            this.listaTSMI,
            this.detalleTSMI});
            this.vistaTSMI.Name = "vistaTSMI";
            this.vistaTSMI.Size = new System.Drawing.Size(66, 29);
            this.vistaTSMI.Text = "Vista";
            // 
            // iconosPequenosTSMI
            // 
            this.iconosPequenosTSMI.Name = "iconosPequenosTSMI";
            this.iconosPequenosTSMI.Size = new System.Drawing.Size(270, 34);
            this.iconosPequenosTSMI.Text = "Iconos pequeños";
            this.iconosPequenosTSMI.Click += new System.EventHandler(this.iconosPequeñosToolStripMenuItem_Click);
            // 
            // iconosGrandesTSMI
            // 
            this.iconosGrandesTSMI.Name = "iconosGrandesTSMI";
            this.iconosGrandesTSMI.Size = new System.Drawing.Size(270, 34);
            this.iconosGrandesTSMI.Text = "Iconos grandes";
            this.iconosGrandesTSMI.Click += new System.EventHandler(this.iconosGrandesTSMI_Click);
            // 
            // listaTSMI
            // 
            this.listaTSMI.Name = "listaTSMI";
            this.listaTSMI.Size = new System.Drawing.Size(270, 34);
            this.listaTSMI.Text = "Lista";
            this.listaTSMI.Click += new System.EventHandler(this.listaTSMI_Click);
            // 
            // detalleTSMI
            // 
            this.detalleTSMI.Name = "detalleTSMI";
            this.detalleTSMI.Size = new System.Drawing.Size(270, 34);
            this.detalleTSMI.Text = "Detalle";
            this.detalleTSMI.Click += new System.EventHandler(this.detalleTSMI_Click);
            // 
            // salirTSMI
            // 
            this.salirTSMI.Name = "salirTSMI";
            this.salirTSMI.Size = new System.Drawing.Size(61, 29);
            this.salirTSMI.Text = "Salir";
            this.salirTSMI.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // listaImagenGrande
            // 
            this.listaImagenGrande.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaImagenGrande.ImageStream")));
            this.listaImagenGrande.TransparentColor = System.Drawing.Color.Transparent;
            this.listaImagenGrande.Images.SetKeyName(0, "Folder");
            this.listaImagenGrande.Images.SetKeyName(1, "File");
            this.listaImagenGrande.Images.SetKeyName(2, "imagen.png");
            this.listaImagenGrande.Images.SetKeyName(3, "documentos.png");
            this.listaImagenGrande.Images.SetKeyName(4, "ejecutable.png");
            this.listaImagenGrande.Images.SetKeyName(5, "ficherotexto.png");
            this.listaImagenGrande.Images.SetKeyName(6, "java.png");
            this.listaImagenGrande.Images.SetKeyName(7, "musica.png");
            this.listaImagenGrande.Images.SetKeyName(8, "pdf.png");
            this.listaImagenGrande.Images.SetKeyName(9, "rar.jpg");
            this.listaImagenGrande.Images.SetKeyName(10, "video.png");
            // 
            // explorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 502);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuOpciones;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "explorador";
            this.Text = "Explorador de Archivos";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuOpciones.ResumeLayout(false);
            this.menuOpciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView vistaArbol;
        private System.Windows.Forms.ListView vistaArchivos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ImageList listaImagenPeq;
        private System.Windows.Forms.MenuStrip menuOpciones;
        private System.Windows.Forms.ToolStripMenuItem vistaTSMI;
        private System.Windows.Forms.ToolStripMenuItem iconosPequenosTSMI;
        private System.Windows.Forms.ToolStripMenuItem iconosGrandesTSMI;
        private System.Windows.Forms.ToolStripMenuItem listaTSMI;
        private System.Windows.Forms.ToolStripMenuItem detalleTSMI;
        private System.Windows.Forms.ToolStripMenuItem salirTSMI;
        private System.Windows.Forms.ImageList listaImagenGrande;
    }
}

