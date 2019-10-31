namespace GeneradordeMetodos
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.txtTabla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.Grilla2 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnGenerarClase = new System.Windows.Forms.Button();
            this.txtMeodos = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.chkNulo = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(33, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(11, 93);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkNulo);
            this.groupBox3.Controls.Add(this.cmbTipo);
            this.groupBox3.Controls.Add(this.txtMeodos);
            this.groupBox3.Controls.Add(this.btnGenerarClase);
            this.groupBox3.Controls.Add(this.btnQuitar);
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Controls.Add(this.Grilla2);
            this.groupBox3.Controls.Add(this.Grilla);
            this.groupBox3.Controls.Add(this.txtTabla);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(716, 461);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Grilla
            // 
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Location = new System.Drawing.Point(27, 133);
            this.Grilla.Name = "Grilla";
            this.Grilla.Size = new System.Drawing.Size(162, 221);
            this.Grilla.TabIndex = 2;
            this.Grilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtTabla
            // 
            this.txtTabla.Location = new System.Drawing.Point(21, 63);
            this.txtTabla.Name = "txtTabla";
            this.txtTabla.Size = new System.Drawing.Size(151, 23);
            this.txtTabla.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabla";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(33, 104);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 35);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // Grilla2
            // 
            this.Grilla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla2.Location = new System.Drawing.Point(330, 133);
            this.Grilla2.Name = "Grilla2";
            this.Grilla2.Size = new System.Drawing.Size(162, 221);
            this.Grilla2.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(203, 163);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 35);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = ">>";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(203, 204);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 35);
            this.btnQuitar.TabIndex = 5;
            this.btnQuitar.Text = "<<";
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnGenerarClase
            // 
            this.btnGenerarClase.Location = new System.Drawing.Point(330, 360);
            this.btnGenerarClase.Name = "btnGenerarClase";
            this.btnGenerarClase.Size = new System.Drawing.Size(75, 35);
            this.btnGenerarClase.TabIndex = 6;
            this.btnGenerarClase.Text = "Generar Clase";
            this.btnGenerarClase.UseVisualStyleBackColor = true;
            this.btnGenerarClase.Click += new System.EventHandler(this.btnGenerarClase_Click);
            // 
            // txtMeodos
            // 
            this.txtMeodos.Location = new System.Drawing.Point(557, 133);
            this.txtMeodos.Multiline = true;
            this.txtMeodos.Name = "txtMeodos";
            this.txtMeodos.Size = new System.Drawing.Size(153, 262);
            this.txtMeodos.TabIndex = 7;
            this.txtMeodos.TextChanged += new System.EventHandler(this.txtMeodos_TextChanged);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(203, 133);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 24);
            this.cmbTipo.TabIndex = 8;
            // 
            // chkNulo
            // 
            this.chkNulo.AutoSize = true;
            this.chkNulo.Location = new System.Drawing.Point(203, 254);
            this.chkNulo.Name = "chkNulo";
            this.chkNulo.Size = new System.Drawing.Size(56, 21);
            this.chkNulo.TabIndex = 9;
            this.chkNulo.Text = "Nulo";
            this.chkNulo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(740, 485);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView Grilla;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView Grilla2;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtMeodos;
        private System.Windows.Forms.Button btnGenerarClase;
        private System.Windows.Forms.CheckBox chkNulo;
    }
}

