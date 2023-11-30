namespace Sistema_De_Inventario_BD.New.VISTA
{
    partial class PROVEEDORES
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
            this.components = new System.ComponentModel.Container();
            this.BTBUSCAR = new System.Windows.Forms.Button();
            this.BTMOSTRAR = new System.Windows.Forms.Button();
            this.DGVMOSTRARPROV = new System.Windows.Forms.DataGridView();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTELIMINAR = new System.Windows.Forms.Button();
            this.TBMOSTRAR = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TBNOMBRE = new System.Windows.Forms.TextBox();
            this.TBTELEFONO = new System.Windows.Forms.TextBox();
            this.TBDIRECCION = new System.Windows.Forms.TextBox();
            this.TBMODPROVEEDOR = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TBMODTELEFONO = new System.Windows.Forms.TextBox();
            this.TBMODDIRECCION = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMOSTRARPROV)).BeginInit();
            this.SuspendLayout();
            // 
            // BTBUSCAR
            // 
            this.BTBUSCAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTBUSCAR.Location = new System.Drawing.Point(133, 20);
            this.BTBUSCAR.Name = "BTBUSCAR";
            this.BTBUSCAR.Size = new System.Drawing.Size(135, 64);
            this.BTBUSCAR.TabIndex = 0;
            this.BTBUSCAR.Text = "BUSCAR";
            this.BTBUSCAR.UseVisualStyleBackColor = false;
            this.BTBUSCAR.Click += new System.EventHandler(this.BTBUSCAR_Click);
            // 
            // BTMOSTRAR
            // 
            this.BTMOSTRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTMOSTRAR.Location = new System.Drawing.Point(1026, 20);
            this.BTMOSTRAR.Name = "BTMOSTRAR";
            this.BTMOSTRAR.Size = new System.Drawing.Size(140, 64);
            this.BTMOSTRAR.TabIndex = 1;
            this.BTMOSTRAR.Text = "MOSTRAR";
            this.BTMOSTRAR.UseVisualStyleBackColor = false;
            this.BTMOSTRAR.Click += new System.EventHandler(this.BTMOSTRAR_Click);
            // 
            // DGVMOSTRARPROV
            // 
            this.DGVMOSTRARPROV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMOSTRARPROV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBRE,
            this.TELEFONO,
            this.DIRECCION});
            this.DGVMOSTRARPROV.Location = new System.Drawing.Point(184, 90);
            this.DGVMOSTRARPROV.Name = "DGVMOSTRARPROV";
            this.DGVMOSTRARPROV.RowHeadersWidth = 51;
            this.DGVMOSTRARPROV.RowTemplate.Height = 24;
            this.DGVMOSTRARPROV.Size = new System.Drawing.Size(889, 408);
            this.DGVMOSTRARPROV.TabIndex = 2;
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
            // BTELIMINAR
            // 
            this.BTELIMINAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BTELIMINAR.Location = new System.Drawing.Point(1142, 224);
            this.BTELIMINAR.Name = "BTELIMINAR";
            this.BTELIMINAR.Size = new System.Drawing.Size(116, 59);
            this.BTELIMINAR.TabIndex = 3;
            this.BTELIMINAR.Text = "ELIMINAR";
            this.BTELIMINAR.UseVisualStyleBackColor = false;
            this.BTELIMINAR.Click += new System.EventHandler(this.BTELIMINAR_Click);
            // 
            // TBMOSTRAR
            // 
            this.TBMOSTRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TBMOSTRAR.Location = new System.Drawing.Point(303, 45);
            this.TBMOSTRAR.Name = "TBMOSTRAR";
            this.TBMOSTRAR.Size = new System.Drawing.Size(671, 22);
            this.TBMOSTRAR.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.Location = new System.Drawing.Point(260, 785);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 60);
            this.button4.TabIndex = 5;
            this.button4.Text = "AGREGAR";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button5.Location = new System.Drawing.Point(994, 785);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 59);
            this.button5.TabIndex = 6;
            this.button5.Text = "ACTUALIZAR";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 617);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 663);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "TELEFONO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 706);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "DIRECCION:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(730, 706);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "DIRECCION:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(730, 663);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "TELEFONO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(730, 617);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "NOMBRE:";
            // 
            // TBNOMBRE
            // 
            this.TBNOMBRE.Location = new System.Drawing.Point(156, 617);
            this.TBNOMBRE.Name = "TBNOMBRE";
            this.TBNOMBRE.Size = new System.Drawing.Size(402, 22);
            this.TBNOMBRE.TabIndex = 13;
            // 
            // TBTELEFONO
            // 
            this.TBTELEFONO.Location = new System.Drawing.Point(156, 663);
            this.TBTELEFONO.Name = "TBTELEFONO";
            this.TBTELEFONO.Size = new System.Drawing.Size(402, 22);
            this.TBTELEFONO.TabIndex = 14;
            // 
            // TBDIRECCION
            // 
            this.TBDIRECCION.Location = new System.Drawing.Point(156, 706);
            this.TBDIRECCION.Name = "TBDIRECCION";
            this.TBDIRECCION.Size = new System.Drawing.Size(402, 22);
            this.TBDIRECCION.TabIndex = 15;
            // 
            // TBMODPROVEEDOR
            // 
            this.TBMODPROVEEDOR.Location = new System.Drawing.Point(834, 614);
            this.TBMODPROVEEDOR.Name = "TBMODPROVEEDOR";
            this.TBMODPROVEEDOR.Size = new System.Drawing.Size(392, 22);
            this.TBMODPROVEEDOR.TabIndex = 16;
            // 
            // TBMODTELEFONO
            // 
            this.TBMODTELEFONO.Location = new System.Drawing.Point(836, 660);
            this.TBMODTELEFONO.Name = "TBMODTELEFONO";
            this.TBMODTELEFONO.Size = new System.Drawing.Size(390, 22);
            this.TBMODTELEFONO.TabIndex = 17;
            // 
            // TBMODDIRECCION
            // 
            this.TBMODDIRECCION.Location = new System.Drawing.Point(836, 703);
            this.TBMODDIRECCION.Name = "TBMODDIRECCION";
            this.TBMODDIRECCION.Size = new System.Drawing.Size(393, 22);
            this.TBMODDIRECCION.TabIndex = 18;
            // 
            // PROVEEDORES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1284, 856);
            this.Controls.Add(this.TBMODDIRECCION);
            this.Controls.Add(this.TBMODTELEFONO);
            this.Controls.Add(this.TBMODPROVEEDOR);
            this.Controls.Add(this.TBDIRECCION);
            this.Controls.Add(this.TBTELEFONO);
            this.Controls.Add(this.TBNOMBRE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.TBMOSTRAR);
            this.Controls.Add(this.BTELIMINAR);
            this.Controls.Add(this.DGVMOSTRARPROV);
            this.Controls.Add(this.BTMOSTRAR);
            this.Controls.Add(this.BTBUSCAR);
            this.Name = "PROVEEDORES";
            this.Text = "PROVEEDORES";
            this.Load += new System.EventHandler(this.PROVEEDORES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMOSTRARPROV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTBUSCAR;
        private System.Windows.Forms.Button BTMOSTRAR;
        private System.Windows.Forms.DataGridView DGVMOSTRARPROV;
        private System.Windows.Forms.Button BTELIMINAR;
        private System.Windows.Forms.TextBox TBMOSTRAR;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBNOMBRE;
        private System.Windows.Forms.TextBox TBTELEFONO;
        private System.Windows.Forms.TextBox TBDIRECCION;
        private System.Windows.Forms.TextBox TBMODPROVEEDOR;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TBMODTELEFONO;
        private System.Windows.Forms.TextBox TBMODDIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
    }
}