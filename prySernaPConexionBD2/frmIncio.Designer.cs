namespace prySernaPConexionBD2
{
    partial class frmIncio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comercioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comercioToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.contactosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1195, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comercioToolStripMenuItem
            // 
            this.comercioToolStripMenuItem.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comercioToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.comercioToolStripMenuItem.Name = "comercioToolStripMenuItem";
            this.comercioToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.comercioToolStripMenuItem.Text = "COMERCIO";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.verTodoToolStripMenuItem});
            this.productosToolStripMenuItem.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(123, 29);
            this.productosToolStripMenuItem.Text = "PRODUCTOS";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            this.agregarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.agregarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarToolStripMenuItem.Image")));
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            this.eliminarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.eliminarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem.Image")));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            this.modificarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.modificarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificarToolStripMenuItem.Image")));
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // contactosToolStripMenuItem
            // 
            this.contactosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.eliminarToolStripMenuItem1,
            this.modificarToolStripMenuItem1,
            this.verTodoToolStripMenuItem1});
            this.contactosToolStripMenuItem.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.contactosToolStripMenuItem.Name = "contactosToolStripMenuItem";
            this.contactosToolStripMenuItem.Size = new System.Drawing.Size(120, 29);
            this.contactosToolStripMenuItem.Text = "CONTACTOS";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            this.agregarToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.agregarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("agregarToolStripMenuItem1.Image")));
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(191, 34);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.agregarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            this.eliminarToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.eliminarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("eliminarToolStripMenuItem1.Image")));
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(191, 34);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            this.modificarToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.modificarToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("modificarToolStripMenuItem1.Image")));
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(191, 34);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarToolStripMenuItem1_Click);
            // 
            // verTodoToolStripMenuItem
            // 
            this.verTodoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            this.verTodoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.verTodoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verTodoToolStripMenuItem.Image")));
            this.verTodoToolStripMenuItem.Name = "verTodoToolStripMenuItem";
            this.verTodoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.verTodoToolStripMenuItem.Text = "Ver Todo";
            this.verTodoToolStripMenuItem.Click += new System.EventHandler(this.verTodoToolStripMenuItem_Click);
            // 
            // verTodoToolStripMenuItem1
            // 
            this.verTodoToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            this.verTodoToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.verTodoToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("verTodoToolStripMenuItem1.Image")));
            this.verTodoToolStripMenuItem1.Name = "verTodoToolStripMenuItem1";
            this.verTodoToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.verTodoToolStripMenuItem1.Text = "Ver Todo";
            this.verTodoToolStripMenuItem1.Click += new System.EventHandler(this.verTodoToolStripMenuItem1_Click);
            // 
            // frmIncio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1195, 703);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmIncio";
            this.Text = "frmIncio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmIncio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comercioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodoToolStripMenuItem1;
    }
}

