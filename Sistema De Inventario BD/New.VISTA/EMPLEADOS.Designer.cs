namespace Sistema_De_Inventario_BD.New.VISTA
{
    partial class EMPLEADOS
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
            this.BTBUSCAR = new System.Windows.Forms.Button();
            this.BTMOSTRAR = new System.Windows.Forms.Button();
            this.BTAGREGAR = new System.Windows.Forms.Button();
            this.BTACTUALIZAR = new System.Windows.Forms.Button();
            this.BTELIMINAR = new System.Windows.Forms.Button();
            this.DGVMOSTRAREMPLEADO = new System.Windows.Forms.DataGridView();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TBMOSTRAR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBNOMBRE = new System.Windows.Forms.TextBox();
            this.TBTELEFONO = new System.Windows.Forms.TextBox();
            this.TBDIRECCION = new System.Windows.Forms.TextBox();
            this.TBMODNOMBRE = new System.Windows.Forms.TextBox();
            this.TBMODTELEFONO = new System.Windows.Forms.TextBox();
            this.TBMODDIRECCION = new System.Windows.Forms.TextBox();
            this.TBESTADO = new System.Windows.Forms.TextBox();
            this.TBMODESTADO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMOSTRAREMPLEADO)).BeginInit();
            this.SuspendLayout();
            // 
            // BTBUSCAR
            // 
            this.BTBUSCAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BTBUSCAR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTBUSCAR.Location = new System.Drawing.Point(45, 12);
            this.BTBUSCAR.Name = "BTBUSCAR";
            this.BTBUSCAR.Size = new System.Drawing.Size(108, 46);
            this.BTBUSCAR.TabIndex = 0;
            this.BTBUSCAR.Text = "BUSCAR";
            this.BTBUSCAR.UseVisualStyleBackColor = false;
            this.BTBUSCAR.Click += new System.EventHandler(this.BTBUSCAR_Click);
            // 
            // BTMOSTRAR
            // 
            this.BTMOSTRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BTMOSTRAR.Location = new System.Drawing.Point(1013, 12);
            this.BTMOSTRAR.Name = "BTMOSTRAR";
            this.BTMOSTRAR.Size = new System.Drawing.Size(111, 51);
            this.BTMOSTRAR.TabIndex = 1;
            this.BTMOSTRAR.Text = "MOSTRAR";
            this.BTMOSTRAR.UseVisualStyleBackColor = false;
            this.BTMOSTRAR.Click += new System.EventHandler(this.BTMOSTRAR_Click);
            // 
            // BTAGREGAR
            // 
            this.BTAGREGAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BTAGREGAR.Location = new System.Drawing.Point(159, 731);
            this.BTAGREGAR.Name = "BTAGREGAR";
            this.BTAGREGAR.Size = new System.Drawing.Size(117, 67);
            this.BTAGREGAR.TabIndex = 2;
            this.BTAGREGAR.Text = "AGREGAR";
            this.BTAGREGAR.UseVisualStyleBackColor = false;
            this.BTAGREGAR.Click += new System.EventHandler(this.BTAGREGAR_Click);
            // 
            // BTACTUALIZAR
            // 
            this.BTACTUALIZAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BTACTUALIZAR.Location = new System.Drawing.Point(895, 738);
            this.BTACTUALIZAR.Name = "BTACTUALIZAR";
            this.BTACTUALIZAR.Size = new System.Drawing.Size(127, 60);
            this.BTACTUALIZAR.TabIndex = 3;
            this.BTACTUALIZAR.Text = "ACTUALIZAR";
            this.BTACTUALIZAR.UseVisualStyleBackColor = false;
            this.BTACTUALIZAR.Click += new System.EventHandler(this.button4_Click);
            // 
            // BTELIMINAR
            // 
            this.BTELIMINAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BTELIMINAR.Location = new System.Drawing.Point(1058, 339);
            this.BTELIMINAR.Name = "BTELIMINAR";
            this.BTELIMINAR.Size = new System.Drawing.Size(128, 57);
            this.BTELIMINAR.TabIndex = 4;
            this.BTELIMINAR.Text = "ELIMINAR";
            this.BTELIMINAR.UseVisualStyleBackColor = false;
            this.BTELIMINAR.Click += new System.EventHandler(this.BTELIMINAR_Click);
            // 
            // DGVMOSTRAREMPLEADO
            // 
            this.DGVMOSTRAREMPLEADO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMOSTRAREMPLEADO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBRE,
            this.TELEFONO,
            this.DIRECCION,
            this.ESTADO});
            this.DGVMOSTRAREMPLEADO.Location = new System.Drawing.Point(197, 77);
            this.DGVMOSTRAREMPLEADO.Name = "DGVMOSTRAREMPLEADO";
            this.DGVMOSTRAREMPLEADO.RowHeadersWidth = 51;
            this.DGVMOSTRAREMPLEADO.RowTemplate.Height = 24;
            this.DGVMOSTRAREMPLEADO.Size = new System.Drawing.Size(786, 342);
            this.DGVMOSTRAREMPLEADO.TabIndex = 5;
            this.DGVMOSTRAREMPLEADO.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.MinimumWidth = 6;
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Width = 125;
            // 
            // TELEFONO
            // 
            this.TELEFONO.HeaderText = "TELEFONO";
            this.TELEFONO.MinimumWidth = 6;
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.Width = 125;
            // 
            // DIRECCION
            // 
            this.DIRECCION.HeaderText = "DIRECCION";
            this.DIRECCION.MinimumWidth = 6;
            this.DIRECCION.Name = "DIRECCION";
            this.DIRECCION.Width = 125;
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.MinimumWidth = 6;
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "NOMBRE:";
            // 
            // TBMOSTRAR
            // 
            this.TBMOSTRAR.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TBMOSTRAR.Location = new System.Drawing.Point(230, 24);
            this.TBMOSTRAR.Name = "TBMOSTRAR";
            this.TBMOSTRAR.Size = new System.Drawing.Size(709, 22);
            this.TBMOSTRAR.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 526);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "TELEFONO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 576);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "DIREECION:";
            // 
            // TBNOMBRE
            // 
            this.TBNOMBRE.Location = new System.Drawing.Point(134, 484);
            this.TBNOMBRE.Name = "TBNOMBRE";
            this.TBNOMBRE.Size = new System.Drawing.Size(277, 22);
            this.TBNOMBRE.TabIndex = 10;
            // 
            // TBTELEFONO
            // 
            this.TBTELEFONO.Location = new System.Drawing.Point(130, 526);
            this.TBTELEFONO.Name = "TBTELEFONO";
            this.TBTELEFONO.Size = new System.Drawing.Size(281, 22);
            this.TBTELEFONO.TabIndex = 11;
            // 
            // TBDIRECCION
            // 
            this.TBDIRECCION.Location = new System.Drawing.Point(127, 576);
            this.TBDIRECCION.Name = "TBDIRECCION";
            this.TBDIRECCION.Size = new System.Drawing.Size(284, 22);
            this.TBDIRECCION.TabIndex = 12;
            // 
            // TBMODNOMBRE
            // 
            this.TBMODNOMBRE.Location = new System.Drawing.Point(862, 487);
            this.TBMODNOMBRE.Name = "TBMODNOMBRE";
            this.TBMODNOMBRE.Size = new System.Drawing.Size(345, 22);
            this.TBMODNOMBRE.TabIndex = 13;
            // 
            // TBMODTELEFONO
            // 
            this.TBMODTELEFONO.Location = new System.Drawing.Point(862, 529);
            this.TBMODTELEFONO.Name = "TBMODTELEFONO";
            this.TBMODTELEFONO.Size = new System.Drawing.Size(345, 22);
            this.TBMODTELEFONO.TabIndex = 14;
            // 
            // TBMODDIRECCION
            // 
            this.TBMODDIRECCION.Location = new System.Drawing.Point(862, 573);
            this.TBMODDIRECCION.Name = "TBMODDIRECCION";
            this.TBMODDIRECCION.Size = new System.Drawing.Size(345, 22);
            this.TBMODDIRECCION.TabIndex = 15;
            // 
            // TBESTADO
            // 
            this.TBESTADO.Location = new System.Drawing.Point(130, 626);
            this.TBESTADO.Name = "TBESTADO";
            this.TBESTADO.Size = new System.Drawing.Size(281, 22);
            this.TBESTADO.TabIndex = 16;
            // 
            // TBMODESTADO
            // 
            this.TBMODESTADO.Location = new System.Drawing.Point(862, 620);
            this.TBMODESTADO.Name = "TBMODESTADO";
            this.TBMODESTADO.Size = new System.Drawing.Size(345, 22);
            this.TBMODESTADO.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 632);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "ESTADO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(731, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "NOMBRE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(731, 532);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "TELEFONO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(731, 576);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "DIRECCION:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(734, 626);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "ESTADO:";
            // 
            // EMPLEADOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1219, 810);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBMODESTADO);
            this.Controls.Add(this.TBESTADO);
            this.Controls.Add(this.TBMODDIRECCION);
            this.Controls.Add(this.TBMODTELEFONO);
            this.Controls.Add(this.TBMODNOMBRE);
            this.Controls.Add(this.TBDIRECCION);
            this.Controls.Add(this.TBTELEFONO);
            this.Controls.Add(this.TBNOMBRE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBMOSTRAR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVMOSTRAREMPLEADO);
            this.Controls.Add(this.BTELIMINAR);
            this.Controls.Add(this.BTACTUALIZAR);
            this.Controls.Add(this.BTAGREGAR);
            this.Controls.Add(this.BTMOSTRAR);
            this.Controls.Add(this.BTBUSCAR);
            this.Name = "EMPLEADOS";
            this.Text = "EMPLEADOScs";
            this.Load += new System.EventHandler(this.EMPLEADOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMOSTRAREMPLEADO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTBUSCAR;
        private System.Windows.Forms.Button BTMOSTRAR;
        private System.Windows.Forms.Button BTAGREGAR;
        private System.Windows.Forms.Button BTACTUALIZAR;
        private System.Windows.Forms.Button BTELIMINAR;
        private System.Windows.Forms.DataGridView DGVMOSTRAREMPLEADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBMOSTRAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBNOMBRE;
        private System.Windows.Forms.TextBox TBTELEFONO;
        private System.Windows.Forms.TextBox TBDIRECCION;
        private System.Windows.Forms.TextBox TBMODNOMBRE;
        private System.Windows.Forms.TextBox TBMODTELEFONO;
        private System.Windows.Forms.TextBox TBMODDIRECCION;
        private System.Windows.Forms.TextBox TBESTADO;
        private System.Windows.Forms.TextBox TBMODESTADO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}