namespace prySernaPConexionBD2
{
    partial class frmAgregarContacto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblIndicador = new System.Windows.Forms.Label();
            this.grpAgregarC = new System.Windows.Forms.GroupBox();
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.grpAgregarC.SuspendLayout();
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
            this.lblIndicador.Location = new System.Drawing.Point(18, 18);
            this.lblIndicador.Name = "lblIndicador";
            this.lblIndicador.Size = new System.Drawing.Size(465, 29);
            this.lblIndicador.TabIndex = 19;
            this.lblIndicador.Text = "Complete los campos para agregar el contacto";
            // 
            // grpAgregarC
            // 
            this.grpAgregarC.Controls.Add(this.txtCorreo);
            this.grpAgregarC.Controls.Add(this.txtTeléfono);
            this.grpAgregarC.Controls.Add(this.lblTeléfono);
            this.grpAgregarC.Controls.Add(this.lblCodigo);
            this.grpAgregarC.Controls.Add(this.numCodigo);
            this.grpAgregarC.Controls.Add(this.cmbCategorias);
            this.grpAgregarC.Controls.Add(this.lblNombre);
            this.grpAgregarC.Controls.Add(this.lblCategorías);
            this.grpAgregarC.Controls.Add(this.txtNombre);
            this.grpAgregarC.Controls.Add(this.lblApellido);
            this.grpAgregarC.Controls.Add(this.lblCorreo);
            this.grpAgregarC.Controls.Add(this.txtApellido);
            this.grpAgregarC.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAgregarC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            this.grpAgregarC.Location = new System.Drawing.Point(70, 61);
            this.grpAgregarC.Name = "grpAgregarC";
            this.grpAgregarC.Size = new System.Drawing.Size(553, 299);
            this.grpAgregarC.TabIndex = 30;
            this.grpAgregarC.TabStop = false;
            this.grpAgregarC.Text = "Campos";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(10, 238);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(127, 27);
            this.txtCorreo.TabIndex = 29;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // txtTeléfono
            // 
            this.txtTeléfono.Location = new System.Drawing.Point(312, 146);
            this.txtTeléfono.Name = "txtTeléfono";
            this.txtTeléfono.Size = new System.Drawing.Size(127, 27);
            this.txtTeléfono.TabIndex = 28;
            this.txtTeléfono.TextChanged += new System.EventHandler(this.txtTeléfono_TextChanged);
            // 
            // lblTeléfono
            // 
            this.lblTeléfono.AutoSize = true;
            this.lblTeléfono.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeléfono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            this.lblTeléfono.Location = new System.Drawing.Point(312, 110);
            this.lblTeléfono.Name = "lblTeléfono";
            this.lblTeléfono.Size = new System.Drawing.Size(75, 22);
            this.lblTeléfono.TabIndex = 27;
            this.lblTeléfono.Text = "Teléfono ";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCodigo.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            this.lblCodigo.Location = new System.Drawing.Point(6, 31);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(61, 22);
            this.lblCodigo.TabIndex = 15;
            this.lblCodigo.Text = "Código";
            // 
            // numCodigo
            // 
            this.numCodigo.Location = new System.Drawing.Point(10, 56);
            this.numCodigo.Name = "numCodigo";
            this.numCodigo.Size = new System.Drawing.Size(69, 27);
            this.numCodigo.TabIndex = 16;
            this.numCodigo.ValueChanged += new System.EventHandler(this.numCodigo_ValueChanged);
            // 
            // cmbCategorias
            // 
            this.cmbCategorias.FormattingEnabled = true;
            this.cmbCategorias.Location = new System.Drawing.Point(312, 237);
            this.cmbCategorias.Name = "cmbCategorias";
            this.cmbCategorias.Size = new System.Drawing.Size(121, 28);
            this.cmbCategorias.TabIndex = 26;
            this.cmbCategorias.SelectedIndexChanged += new System.EventHandler(this.cmbCategorias_SelectedIndexChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            this.lblNombre.Location = new System.Drawing.Point(308, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 22);
            this.lblNombre.TabIndex = 17;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCategorías
            // 
            this.lblCategorías.AutoSize = true;
            this.lblCategorías.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorías.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            this.lblCategorías.Location = new System.Drawing.Point(312, 197);
            this.lblCategorías.Name = "lblCategorías";
            this.lblCategorías.Size = new System.Drawing.Size(89, 22);
            this.lblCategorías.TabIndex = 24;
            this.lblCategorías.Text = "Categorías";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(312, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(127, 27);
            this.txtNombre.TabIndex = 18;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            this.lblApellido.Location = new System.Drawing.Point(6, 110);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(70, 22);
            this.lblApellido.TabIndex = 19;
            this.lblApellido.Text = "Apellido";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            this.lblCorreo.Location = new System.Drawing.Point(6, 197);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(59, 22);
            this.lblCorreo.TabIndex = 23;
            this.lblCorreo.Text = "Correo";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(10, 146);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(127, 27);
            this.txtApellido.TabIndex = 21;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            this.btnAgregar.Enabled = false;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(644, 314);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 46);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvContactos
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContactos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContactos.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvContactos.EnableHeadersVisualStyles = false;
            this.dgvContactos.GridColor = System.Drawing.Color.Gray;
            this.dgvContactos.Location = new System.Drawing.Point(70, 388);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(131)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContactos.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvContactos.RowHeadersWidth = 62;
            this.dgvContactos.RowTemplate.Height = 28;
            this.dgvContactos.Size = new System.Drawing.Size(695, 387);
            this.dgvContactos.TabIndex = 27;
            // 
            // frmAgregarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(972, 794);
            this.Controls.Add(this.dgvContactos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.grpAgregarC);
            this.Controls.Add(this.lblIndicador);
            this.Name = "frmAgregarContacto";
            this.Text = "frmAgregarContacto";
            this.Load += new System.EventHandler(this.frmAgregarContacto_Load);
            this.grpAgregarC.ResumeLayout(false);
            this.grpAgregarC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIndicador;
        private System.Windows.Forms.GroupBox grpAgregarC;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.NumericUpDown numCodigo;
        private System.Windows.Forms.ComboBox cmbCategorias;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCategorías;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.Label lblTeléfono;
        private System.Windows.Forms.TextBox txtTeléfono;
        private System.Windows.Forms.TextBox txtCorreo;
    }
}