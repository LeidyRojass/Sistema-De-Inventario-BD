namespace Sistema_De_Inventario_BD.New.VISTA
{
    partial class PRODUCTOS
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
            this.BTMOSTRAR = new System.Windows.Forms.Button();
            this.BTBUSCAR = new System.Windows.Forms.Button();
            this.BTELIMINAR = new System.Windows.Forms.Button();
            this.DGVMOSTRARPROD = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BTAGREGAR = new System.Windows.Forms.Button();
            this.BTACTUALIZAR = new System.Windows.Forms.Button();
            this.TBPRODUCTO = new System.Windows.Forms.TextBox();
            this.TBPRECIO = new System.Windows.Forms.TextBox();
            this.TBSTOCK = new System.Windows.Forms.TextBox();
            this.TBMODPRODUCTO = new System.Windows.Forms.TextBox();
            this.TBMODPRECIO = new System.Windows.Forms.TextBox();
            this.TBMODSTOCK = new System.Windows.Forms.TextBox();
            this.TBMOSTRAR = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CBCATEGORIA = new System.Windows.Forms.ComboBox();
            this.CBPROVEEDOR = new System.Windows.Forms.ComboBox();
            this.TBIDPRODUCTO = new System.Windows.Forms.TextBox();
            this.TBMODID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CBMODPROVEEDOR = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CBMODCATEGORIA = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMOSTRARPROD)).BeginInit();
            this.SuspendLayout();
            // 
            // BTMOSTRAR
            // 
            this.BTMOSTRAR.Location = new System.Drawing.Point(986, 17);
            this.BTMOSTRAR.Name = "BTMOSTRAR";
            this.BTMOSTRAR.Size = new System.Drawing.Size(151, 51);
            this.BTMOSTRAR.TabIndex = 0;
            this.BTMOSTRAR.Text = "MOSTRAR";
            this.BTMOSTRAR.UseVisualStyleBackColor = true;
            this.BTMOSTRAR.Click += new System.EventHandler(this.BTMOSTRAR_Click);
            // 
            // BTBUSCAR
            // 
            this.BTBUSCAR.Location = new System.Drawing.Point(164, 17);
            this.BTBUSCAR.Name = "BTBUSCAR";
            this.BTBUSCAR.Size = new System.Drawing.Size(161, 51);
            this.BTBUSCAR.TabIndex = 1;
            this.BTBUSCAR.Text = "BUSCAR";
            this.BTBUSCAR.UseVisualStyleBackColor = true;
            this.BTBUSCAR.Click += new System.EventHandler(this.BTBUSCAR_Click);
            // 
            // BTELIMINAR
            // 
            this.BTELIMINAR.Location = new System.Drawing.Point(1108, 198);
            this.BTELIMINAR.Name = "BTELIMINAR";
            this.BTELIMINAR.Size = new System.Drawing.Size(122, 48);
            this.BTELIMINAR.TabIndex = 2;
            this.BTELIMINAR.Text = "ELIMINAR";
            this.BTELIMINAR.UseVisualStyleBackColor = true;
            this.BTELIMINAR.Click += new System.EventHandler(this.BTELIMINAR_Click);
            // 
            // DGVMOSTRARPROD
            // 
            this.DGVMOSTRARPROD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMOSTRARPROD.Location = new System.Drawing.Point(198, 104);
            this.DGVMOSTRARPROD.Name = "DGVMOSTRARPROD";
            this.DGVMOSTRARPROD.RowHeadersWidth = 51;
            this.DGVMOSTRARPROD.RowTemplate.Height = 24;
            this.DGVMOSTRARPROD.Size = new System.Drawing.Size(875, 324);
            this.DGVMOSTRARPROD.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOMBRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 582);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "PRECIO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 640);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "STOCK:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(811, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "NOMBRE:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(811, 582);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "PRECIO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(816, 640);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "STOCK:";
            // 
            // BTAGREGAR
            // 
            this.BTAGREGAR.Location = new System.Drawing.Point(228, 724);
            this.BTAGREGAR.Name = "BTAGREGAR";
            this.BTAGREGAR.Size = new System.Drawing.Size(156, 57);
            this.BTAGREGAR.TabIndex = 10;
            this.BTAGREGAR.Text = "AGREGAR";
            this.BTAGREGAR.UseVisualStyleBackColor = true;
            this.BTAGREGAR.Click += new System.EventHandler(this.BTAGREGAR_Click);
            // 
            // BTACTUALIZAR
            // 
            this.BTACTUALIZAR.Location = new System.Drawing.Point(936, 742);
            this.BTACTUALIZAR.Name = "BTACTUALIZAR";
            this.BTACTUALIZAR.Size = new System.Drawing.Size(137, 51);
            this.BTACTUALIZAR.TabIndex = 11;
            this.BTACTUALIZAR.Text = "ACTUALIZAR";
            this.BTACTUALIZAR.UseVisualStyleBackColor = true;
            this.BTACTUALIZAR.Click += new System.EventHandler(this.BTACTUALIZAR_Click);
            // 
            // TBPRODUCTO
            // 
            this.TBPRODUCTO.Location = new System.Drawing.Point(164, 519);
            this.TBPRODUCTO.Name = "TBPRODUCTO";
            this.TBPRODUCTO.Size = new System.Drawing.Size(317, 22);
            this.TBPRODUCTO.TabIndex = 12;
            // 
            // TBPRECIO
            // 
            this.TBPRECIO.Location = new System.Drawing.Point(164, 579);
            this.TBPRECIO.Name = "TBPRECIO";
            this.TBPRECIO.Size = new System.Drawing.Size(317, 22);
            this.TBPRECIO.TabIndex = 13;
            // 
            // TBSTOCK
            // 
            this.TBSTOCK.Location = new System.Drawing.Point(164, 634);
            this.TBSTOCK.Name = "TBSTOCK";
            this.TBSTOCK.Size = new System.Drawing.Size(317, 22);
            this.TBSTOCK.TabIndex = 14;
            // 
            // TBMODPRODUCTO
            // 
            this.TBMODPRODUCTO.Location = new System.Drawing.Point(902, 519);
            this.TBMODPRODUCTO.Name = "TBMODPRODUCTO";
            this.TBMODPRODUCTO.Size = new System.Drawing.Size(317, 22);
            this.TBMODPRODUCTO.TabIndex = 15;
            // 
            // TBMODPRECIO
            // 
            this.TBMODPRECIO.Location = new System.Drawing.Point(902, 573);
            this.TBMODPRECIO.Name = "TBMODPRECIO";
            this.TBMODPRECIO.Size = new System.Drawing.Size(317, 22);
            this.TBMODPRECIO.TabIndex = 16;
            // 
            // TBMODSTOCK
            // 
            this.TBMODSTOCK.Location = new System.Drawing.Point(902, 634);
            this.TBMODSTOCK.Name = "TBMODSTOCK";
            this.TBMODSTOCK.Size = new System.Drawing.Size(317, 22);
            this.TBMODSTOCK.TabIndex = 17;
            // 
            // TBMOSTRAR
            // 
            this.TBMOSTRAR.Location = new System.Drawing.Point(365, 31);
            this.TBMOSTRAR.Name = "TBMOSTRAR";
            this.TBMOSTRAR.Size = new System.Drawing.Size(564, 22);
            this.TBMOSTRAR.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "ID PRODUCTO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(526, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "ID PROVEEDOR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(534, 525);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "ID CATEGORIA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(777, 477);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "ID PRODUCTO:";
            // 
            // CBCATEGORIA
            // 
            this.CBCATEGORIA.FormattingEnabled = true;
            this.CBCATEGORIA.Location = new System.Drawing.Point(529, 560);
            this.CBCATEGORIA.Name = "CBCATEGORIA";
            this.CBCATEGORIA.Size = new System.Drawing.Size(163, 24);
            this.CBCATEGORIA.TabIndex = 23;
            // 
            // CBPROVEEDOR
            // 
            this.CBPROVEEDOR.FormattingEnabled = true;
            this.CBPROVEEDOR.Location = new System.Drawing.Point(529, 477);
            this.CBPROVEEDOR.Name = "CBPROVEEDOR";
            this.CBPROVEEDOR.Size = new System.Drawing.Size(163, 24);
            this.CBPROVEEDOR.TabIndex = 24;
            // 
            // TBIDPRODUCTO
            // 
            this.TBIDPRODUCTO.Location = new System.Drawing.Point(164, 471);
            this.TBIDPRODUCTO.Name = "TBIDPRODUCTO";
            this.TBIDPRODUCTO.Size = new System.Drawing.Size(317, 22);
            this.TBIDPRODUCTO.TabIndex = 25;
            // 
            // TBMODID
            // 
            this.TBMODID.Location = new System.Drawing.Point(902, 471);
            this.TBMODID.Name = "TBMODID";
            this.TBMODID.Size = new System.Drawing.Size(317, 22);
            this.TBMODID.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(619, 687);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "ID PROVEEDOR";
            // 
            // CBMODPROVEEDOR
            // 
            this.CBMODPROVEEDOR.FormattingEnabled = true;
            this.CBMODPROVEEDOR.Location = new System.Drawing.Point(753, 682);
            this.CBMODPROVEEDOR.Name = "CBMODPROVEEDOR";
            this.CBMODPROVEEDOR.Size = new System.Drawing.Size(163, 24);
            this.CBMODPROVEEDOR.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(933, 682);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "ID CATEGORIA";
            // 
            // CBMODCATEGORIA
            // 
            this.CBMODCATEGORIA.FormattingEnabled = true;
            this.CBMODCATEGORIA.Location = new System.Drawing.Point(1056, 679);
            this.CBMODCATEGORIA.Name = "CBMODCATEGORIA";
            this.CBMODCATEGORIA.Size = new System.Drawing.Size(163, 24);
            this.CBMODCATEGORIA.TabIndex = 30;
            // 
            // PRODUCTOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1242, 805);
            this.Controls.Add(this.CBMODCATEGORIA);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CBMODPROVEEDOR);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TBMODID);
            this.Controls.Add(this.TBIDPRODUCTO);
            this.Controls.Add(this.CBPROVEEDOR);
            this.Controls.Add(this.CBCATEGORIA);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TBMOSTRAR);
            this.Controls.Add(this.TBMODSTOCK);
            this.Controls.Add(this.TBMODPRECIO);
            this.Controls.Add(this.TBMODPRODUCTO);
            this.Controls.Add(this.TBSTOCK);
            this.Controls.Add(this.TBPRECIO);
            this.Controls.Add(this.TBPRODUCTO);
            this.Controls.Add(this.BTACTUALIZAR);
            this.Controls.Add(this.BTAGREGAR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVMOSTRARPROD);
            this.Controls.Add(this.BTELIMINAR);
            this.Controls.Add(this.BTBUSCAR);
            this.Controls.Add(this.BTMOSTRAR);
            this.Name = "PRODUCTOS";
            this.Text = "PRODUCTOScs";
            this.Load += new System.EventHandler(this.PRODUCTOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMOSTRARPROD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTMOSTRAR;
        private System.Windows.Forms.Button BTBUSCAR;
        private System.Windows.Forms.Button BTELIMINAR;
        private System.Windows.Forms.DataGridView DGVMOSTRARPROD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTAGREGAR;
        private System.Windows.Forms.Button BTACTUALIZAR;
        private System.Windows.Forms.TextBox TBPRODUCTO;
        private System.Windows.Forms.TextBox TBPRECIO;
        private System.Windows.Forms.TextBox TBSTOCK;
        private System.Windows.Forms.TextBox TBMODPRODUCTO;
        private System.Windows.Forms.TextBox TBMODPRECIO;
        private System.Windows.Forms.TextBox TBMODSTOCK;
        private System.Windows.Forms.TextBox TBMOSTRAR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CBCATEGORIA;
        private System.Windows.Forms.ComboBox CBPROVEEDOR;
        private System.Windows.Forms.TextBox TBIDPRODUCTO;
        private System.Windows.Forms.TextBox TBMODID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CBMODPROVEEDOR;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CBMODCATEGORIA;
    }
}