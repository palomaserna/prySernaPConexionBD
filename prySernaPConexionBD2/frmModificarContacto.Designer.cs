namespace prySernaPConexionBD2
{
    partial class frmModificarContacto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblIndicador = new System.Windows.Forms.Label();
            this.grpModificarC = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTeléfono = new System.Windows.Forms.TextBox();
            this.lblTeléfono = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.numCodigo = new System.Windows.Forms.NumericUpDown();
            this.cmbCategorias = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCategorías = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.grpModificarC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIndicador
            // 
            this.lblIndicador.AutoSize = true;
            this.lblIndicador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIndicador.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            this.lblIndicador.Location = new System.Drawing.Point(19, 17);
            this.lblIndicador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIndicador.Name = "lblIndicador";
            this.lblIndicador.Size = new System.Drawing.Size(313, 20);
            this.lblIndicador.TabIndex = 20;
            this.lblIndicador.Text = "Complete los campos para agregar el contacto";
            // 
            // grpModificarC
            // 
            this.grpModificarC.Controls.Add(this.txtCorreo);
            this.grpModificarC.Controls.Add(this.txtTeléfono);
            this.grpModificarC.Controls.Add(this.lblTeléfono);
            this.grpModificarC.Controls.Add(this.lblCodigo);
            this.grpModificarC.Controls.Add(this.numCodigo);
            this.grpModificarC.Controls.Add(this.cmbCategorias);
            this.grpModificarC.Controls.Add(this.lblNombre);
            this.grpModificarC.Controls.Add(this.lblCategorías);
            this.grpModificarC.Controls.Add(this.txtNombre);
            this.grpModificarC.Controls.Add(this.lblApellido);
            this.grpModificarC.Controls.Add(this.lblCorreo);
            this.grpModificarC.Controls.Add(this.txtApellido);
            this.grpModificarC.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpModificarC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            this.grpModificarC.Location = new System.Drawing.Point(22, 51);
            this.grpModificarC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpModificarC.Name = "grpModificarC";
            this.grpModificarC.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpModificarC.Size = new System.Drawing.Size(369, 194);
            this.grpModificarC.TabIndex = 31;
            this.grpModificarC.TabStop = false;
            this.grpModificarC.Text = "Campos";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(7, 155);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(86, 21);
            this.txtCorreo.TabIndex = 29;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // txtTeléfono
            // 
            this.txtTeléfono.Location = new System.Drawing.Point(208, 95);
            this.txtTeléfono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTeléfono.Name = "txtTeléfono";
            this.txtTeléfono.Size = new System.Drawing.Size(86, 21);
            this.txtTeléfono.TabIndex = 28;
            this.txtTeléfono.TextChanged += new System.EventHandler(this.txtTeléfono_TextChanged);
            // 
            // lblTeléfono
            // 
            this.lblTeléfono.AutoSize = true;
            this.lblTeléfono.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeléfono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            this.lblTeléfono.Location = new System.Drawing.Point(208, 72);
            this.lblTeléfono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTeléfono.Name = "lblTeléfono";
            this.lblTeléfono.Size = new System.Drawing.Size(50, 16);
            this.lblTeléfono.TabIndex = 27;
            this.lblTeléfono.Text = "Teléfono ";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCodigo.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            this.lblCodigo.Location = new System.Drawing.Point(4, 20);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(41, 16);
            this.lblCodigo.TabIndex = 15;
            this.lblCodigo.Text = "Código";
            // 
            // numCodigo
            // 
            this.numCodigo.Location = new System.Drawing.Point(7, 36);
            this.numCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numCodigo.Name = "numCodigo";
            this.numCodigo.Size = new System.Drawing.Size(46, 21);
            this.numCodigo.TabIndex = 16;
            this.numCodigo.ValueChanged += new System.EventHandler(this.numCodigo_ValueChanged);
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(208, 154);
            this.cmbCategorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(82, 23);
            this.cmbCategorias.TabIndex = 26;
            this.cmbCategorias.SelectedIndexChanged += new System.EventHandler(this.cmbCategorias_SelectedIndexChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            this.lblNombre.Location = new System.Drawing.Point(205, 20);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(45, 16);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCategorías
            // 
            this.lblCategorías.AutoSize = true;
            this.lblCategorías.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorías.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            this.lblCategorías.Location = new System.Drawing.Point(208, 128);
            this.lblCategorías.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategorías.Name = "lblCategorías";
            this.lblCategorías.Size = new System.Drawing.Size(61, 16);
            this.lblCategorías.TabIndex = 24;
            this.lblCategorías.Text = "Categorías";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(208, 36);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(86, 21);
            this.txtNombre.TabIndex = 18;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            this.lblApellido.Location = new System.Drawing.Point(4, 72);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(46, 16);
            this.lblApellido.TabIndex = 19;
            this.lblApellido.Text = "Apellido";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            this.lblCorreo.Location = new System.Drawing.Point(4, 128);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(40, 16);
            this.lblCorreo.TabIndex = 23;
            this.lblCorreo.Text = "Correo";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(7, 95);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(86, 21);
            this.txtApellido.TabIndex = 21;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(401, 215);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(81, 30);
            this.btnModificar.TabIndex = 30;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvContactos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContactos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContactos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContactos.EnableHeadersVisualStyles = false;
            this.dgvContactos.GridColor = System.Drawing.Color.Gray;
            this.dgvContactos.Location = new System.Drawing.Point(18, 257);
            this.dgvContactos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContactos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContactos.RowHeadersWidth = 62;
            this.dgvContactos.RowTemplate.Height = 28;
            this.dgvContactos.Size = new System.Drawing.Size(463, 252);
            this.dgvContactos.TabIndex = 32;
            this.dgvContactos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactos_CellDoubleClick);
            // 
            // frmModificarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(665, 487);
            this.Controls.Add(this.dgvContactos);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.grpModificarC);
            this.Controls.Add(this.lblIndicador);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmModificarContacto";
            this.Text = "ModificarContacto";
            this.Load += new System.EventHandler(this.frmModificarContacto_Load);
            this.grpModificarC.ResumeLayout(false);
            this.grpModificarC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIndicador;
        private System.Windows.Forms.GroupBox grpModificarC;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTeléfono;
        private System.Windows.Forms.Label lblTeléfono;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.NumericUpDown numCodigo;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCategorías;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvContactos;
    }
}