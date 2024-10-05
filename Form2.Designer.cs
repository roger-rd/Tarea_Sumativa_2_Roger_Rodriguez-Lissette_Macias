namespace Tarea_Sumativa_2_Roger_Rodriguez_Lissette_Macias
{
    partial class FormRUT
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
            this.labelNMatricula = new System.Windows.Forms.Label();
            this.labelRUT = new System.Windows.Forms.Label();
            this.labelNombres = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNota1 = new System.Windows.Forms.Label();
            this.labelNota2 = new System.Windows.Forms.Label();
            this.txtNMatricula = new System.Windows.Forms.TextBox();
            this.txtRUT = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CÓDIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATRICULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTA2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROMEDIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNMatricula
            // 
            this.labelNMatricula.AutoSize = true;
            this.labelNMatricula.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNMatricula.Location = new System.Drawing.Point(44, 47);
            this.labelNMatricula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNMatricula.Name = "labelNMatricula";
            this.labelNMatricula.Size = new System.Drawing.Size(91, 17);
            this.labelNMatricula.TabIndex = 0;
            this.labelNMatricula.Text = "N.- Matricula:";
            // 
            // labelRUT
            // 
            this.labelRUT.AutoSize = true;
            this.labelRUT.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRUT.Location = new System.Drawing.Point(433, 47);
            this.labelRUT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRUT.Name = "labelRUT";
            this.labelRUT.Size = new System.Drawing.Size(36, 17);
            this.labelRUT.TabIndex = 0;
            this.labelRUT.Text = "RUT:";
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombres.Location = new System.Drawing.Point(44, 86);
            this.labelNombres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(67, 17);
            this.labelNombres.TabIndex = 0;
            this.labelNombres.Text = "Nombres:";
            this.labelNombres.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.Location = new System.Drawing.Point(433, 86);
            this.labelApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(69, 17);
            this.labelApellido.TabIndex = 0;
            this.labelApellido.Text = "Apellidos:";
            this.labelApellido.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelNota1
            // 
            this.labelNota1.AutoSize = true;
            this.labelNota1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNota1.Location = new System.Drawing.Point(44, 123);
            this.labelNota1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNota1.Name = "labelNota1";
            this.labelNota1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNota1.Size = new System.Drawing.Size(52, 17);
            this.labelNota1.TabIndex = 0;
            this.labelNota1.Text = "Nota 1:";
            this.labelNota1.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelNota2
            // 
            this.labelNota2.AutoSize = true;
            this.labelNota2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNota2.Location = new System.Drawing.Point(433, 123);
            this.labelNota2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNota2.Name = "labelNota2";
            this.labelNota2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNota2.Size = new System.Drawing.Size(52, 17);
            this.labelNota2.TabIndex = 0;
            this.labelNota2.Text = "Nota 2:";
            this.labelNota2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNMatricula
            // 
            this.txtNMatricula.Location = new System.Drawing.Point(136, 49);
            this.txtNMatricula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNMatricula.Name = "txtNMatricula";
            this.txtNMatricula.Size = new System.Drawing.Size(223, 20);
            this.txtNMatricula.TabIndex = 1;
            // 
            // txtRUT
            // 
            this.txtRUT.Location = new System.Drawing.Point(506, 46);
            this.txtRUT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRUT.Name = "txtRUT";
            this.txtRUT.Size = new System.Drawing.Size(228, 20);
            this.txtRUT.TabIndex = 2;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(136, 86);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(223, 20);
            this.txtNombres.TabIndex = 3;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(506, 88);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(228, 20);
            this.txtApellidos.TabIndex = 4;
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(136, 120);
            this.txtNota1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(60, 20);
            this.txtNota1.TabIndex = 5;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(506, 122);
            this.txtNota2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(60, 20);
            this.txtNota2.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(141, 180);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 34);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Location = new System.Drawing.Point(245, 180);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 34);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(350, 180);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(87, 34);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(454, 180);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 34);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(556, 164);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(94, 58);
            this.btnCerrar.TabIndex = 11;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CÓDIGO,
            this.MATRICULA,
            this.RUT,
            this.NOMBRES,
            this.APELLIDOS,
            this.NOTA1,
            this.NOTA2,
            this.PROMEDIO});
            this.dataGridView1.Location = new System.Drawing.Point(9, 240);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(788, 206);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CÓDIGO
            // 
            this.CÓDIGO.HeaderText = "CÓDIGO";
            this.CÓDIGO.MinimumWidth = 6;
            this.CÓDIGO.Name = "CÓDIGO";
            this.CÓDIGO.Width = 125;
            // 
            // MATRICULA
            // 
            this.MATRICULA.HeaderText = "MATRICULA";
            this.MATRICULA.MinimumWidth = 6;
            this.MATRICULA.Name = "MATRICULA";
            this.MATRICULA.Width = 125;
            // 
            // RUT
            // 
            this.RUT.HeaderText = "RUT";
            this.RUT.MinimumWidth = 6;
            this.RUT.Name = "RUT";
            this.RUT.Width = 125;
            // 
            // NOMBRES
            // 
            this.NOMBRES.HeaderText = "NOMBRES";
            this.NOMBRES.MinimumWidth = 6;
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.Width = 125;
            // 
            // APELLIDOS
            // 
            this.APELLIDOS.HeaderText = "APELLIDOS";
            this.APELLIDOS.MinimumWidth = 6;
            this.APELLIDOS.Name = "APELLIDOS";
            this.APELLIDOS.Width = 125;
            // 
            // NOTA1
            // 
            this.NOTA1.HeaderText = "NOTA 1";
            this.NOTA1.MinimumWidth = 6;
            this.NOTA1.Name = "NOTA1";
            this.NOTA1.Width = 125;
            // 
            // NOTA2
            // 
            this.NOTA2.HeaderText = "NOTA 2";
            this.NOTA2.MinimumWidth = 6;
            this.NOTA2.Name = "NOTA2";
            this.NOTA2.Width = 125;
            // 
            // PROMEDIO
            // 
            this.PROMEDIO.HeaderText = "PROMEDIO";
            this.PROMEDIO.MinimumWidth = 6;
            this.PROMEDIO.Name = "PROMEDIO";
            this.PROMEDIO.Width = 125;
            // 
            // FormRUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 457);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtRUT);
            this.Controls.Add(this.txtNMatricula);
            this.Controls.Add(this.labelNota2);
            this.Controls.Add(this.labelNota1);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombres);
            this.Controls.Add(this.labelRUT);
            this.Controls.Add(this.labelNMatricula);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormRUT";
            this.Text = "Registro de Estudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNMatricula;
        private System.Windows.Forms.Label labelRUT;
        private System.Windows.Forms.Label labelNombres;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNota1;
        private System.Windows.Forms.Label labelNota2;
        private System.Windows.Forms.TextBox txtNMatricula;
        private System.Windows.Forms.TextBox txtRUT;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CÓDIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATRICULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTA2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROMEDIO;
    }
}