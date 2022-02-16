namespace AtencionPublico
{
    partial class formPantallaGigante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPantallaGigante));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tlpnl_carta = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_carta_o_nombre = new System.Windows.Forms.Label();
            this.rbtn_carta_codigo = new System.Windows.Forms.RadioButton();
            this.cbx_carta = new System.Windows.Forms.ComboBox();
            this.rbtn_carta_nombre = new System.Windows.Forms.RadioButton();
            this.btn_ver_cartas = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tlpnl_distrito = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_distrito = new System.Windows.Forms.Label();
            this.rbtn_distrito_ubigeo = new System.Windows.Forms.RadioButton();
            this.cbx_distrito = new System.Windows.Forms.ComboBox();
            this.rbtn_distrito_nombre = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tlpnl_carta.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tlpnl_distrito.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(457, 700);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opciones de Consulta:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(11, 41);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(435, 649);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tlpnl_carta);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(427, 620);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Carta Nacional";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tlpnl_carta
            // 
            this.tlpnl_carta.ColumnCount = 4;
            this.tlpnl_carta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tlpnl_carta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tlpnl_carta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpnl_carta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnl_carta.Controls.Add(this.lbl_carta_o_nombre, 0, 0);
            this.tlpnl_carta.Controls.Add(this.rbtn_carta_codigo, 1, 0);
            this.tlpnl_carta.Controls.Add(this.cbx_carta, 1, 1);
            this.tlpnl_carta.Controls.Add(this.rbtn_carta_nombre, 2, 0);
            this.tlpnl_carta.Controls.Add(this.btn_ver_cartas, 0, 1);
            this.tlpnl_carta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnl_carta.Location = new System.Drawing.Point(4, 4);
            this.tlpnl_carta.Margin = new System.Windows.Forms.Padding(4);
            this.tlpnl_carta.Name = "tlpnl_carta";
            this.tlpnl_carta.RowCount = 4;
            this.tlpnl_carta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpnl_carta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpnl_carta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpnl_carta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnl_carta.Size = new System.Drawing.Size(419, 612);
            this.tlpnl_carta.TabIndex = 0;
            // 
            // lbl_carta_o_nombre
            // 
            this.lbl_carta_o_nombre.AutoSize = true;
            this.lbl_carta_o_nombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_carta_o_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_carta_o_nombre.Location = new System.Drawing.Point(4, 0);
            this.lbl_carta_o_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_carta_o_nombre.Name = "lbl_carta_o_nombre";
            this.lbl_carta_o_nombre.Size = new System.Drawing.Size(105, 37);
            this.lbl_carta_o_nombre.TabIndex = 1;
            this.lbl_carta_o_nombre.Text = "Buscar por :";
            this.lbl_carta_o_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbtn_carta_codigo
            // 
            this.rbtn_carta_codigo.AutoSize = true;
            this.rbtn_carta_codigo.Checked = true;
            this.rbtn_carta_codigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtn_carta_codigo.Location = new System.Drawing.Point(117, 4);
            this.rbtn_carta_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_carta_codigo.Name = "rbtn_carta_codigo";
            this.rbtn_carta_codigo.Size = new System.Drawing.Size(99, 29);
            this.rbtn_carta_codigo.TabIndex = 2;
            this.rbtn_carta_codigo.TabStop = true;
            this.rbtn_carta_codigo.Text = "Código";
            this.rbtn_carta_codigo.UseVisualStyleBackColor = true;
            this.rbtn_carta_codigo.CheckedChanged += new System.EventHandler(this.rbtn_carta_codigo_CheckedChanged);
            // 
            // cbx_carta
            // 
            this.cbx_carta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_carta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tlpnl_carta.SetColumnSpan(this.cbx_carta, 2);
            this.cbx_carta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_carta.FormattingEnabled = true;
            this.cbx_carta.Location = new System.Drawing.Point(117, 41);
            this.cbx_carta.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_carta.Name = "cbx_carta";
            this.cbx_carta.Size = new System.Drawing.Size(259, 24);
            this.cbx_carta.TabIndex = 0;
            this.cbx_carta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // rbtn_carta_nombre
            // 
            this.rbtn_carta_nombre.AutoSize = true;
            this.rbtn_carta_nombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtn_carta_nombre.Location = new System.Drawing.Point(224, 4);
            this.rbtn_carta_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_carta_nombre.Name = "rbtn_carta_nombre";
            this.rbtn_carta_nombre.Size = new System.Drawing.Size(152, 29);
            this.rbtn_carta_nombre.TabIndex = 3;
            this.rbtn_carta_nombre.Text = "Nombre de Carta";
            this.rbtn_carta_nombre.UseVisualStyleBackColor = true;
            this.rbtn_carta_nombre.CheckedChanged += new System.EventHandler(this.rbtn_carta_nombre_CheckedChanged);
            // 
            // btn_ver_cartas
            // 
            this.btn_ver_cartas.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver_cartas.ImageIndex = 0;
            this.btn_ver_cartas.ImageList = this.imageList1;
            this.btn_ver_cartas.Location = new System.Drawing.Point(4, 41);
            this.btn_ver_cartas.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ver_cartas.Name = "btn_ver_cartas";
            this.btn_ver_cartas.Size = new System.Drawing.Size(100, 28);
            this.btn_ver_cartas.TabIndex = 4;
            this.btn_ver_cartas.Text = "Ver Cartas";
            this.btn_ver_cartas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ver_cartas.UseMnemonic = false;
            this.btn_ver_cartas.UseVisualStyleBackColor = true;
            this.btn_ver_cartas.Click += new System.EventHandler(this.btn_ver_cartas_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ic_malla.bmp");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tlpnl_distrito);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(427, 620);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Distrito";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(427, 620);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Coordenada";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(407, 620);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Derecho Minero";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tlpnl_distrito
            // 
            this.tlpnl_distrito.ColumnCount = 4;
            this.tlpnl_distrito.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tlpnl_distrito.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tlpnl_distrito.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tlpnl_distrito.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnl_distrito.Controls.Add(this.lbl_distrito, 0, 0);
            this.tlpnl_distrito.Controls.Add(this.rbtn_distrito_ubigeo, 1, 0);
            this.tlpnl_distrito.Controls.Add(this.cbx_distrito, 1, 1);
            this.tlpnl_distrito.Controls.Add(this.rbtn_distrito_nombre, 2, 0);
            this.tlpnl_distrito.Controls.Add(this.button1, 0, 1);
            this.tlpnl_distrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpnl_distrito.Location = new System.Drawing.Point(4, 4);
            this.tlpnl_distrito.Margin = new System.Windows.Forms.Padding(4);
            this.tlpnl_distrito.Name = "tlpnl_distrito";
            this.tlpnl_distrito.RowCount = 4;
            this.tlpnl_distrito.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpnl_distrito.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpnl_distrito.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tlpnl_distrito.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpnl_distrito.Size = new System.Drawing.Size(419, 612);
            this.tlpnl_distrito.TabIndex = 1;
            // 
            // lbl_distrito
            // 
            this.lbl_distrito.AutoSize = true;
            this.lbl_distrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_distrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_distrito.Location = new System.Drawing.Point(4, 0);
            this.lbl_distrito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_distrito.Name = "lbl_distrito";
            this.lbl_distrito.Size = new System.Drawing.Size(105, 37);
            this.lbl_distrito.TabIndex = 1;
            this.lbl_distrito.Text = "Buscar por :";
            this.lbl_distrito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbtn_distrito_ubigeo
            // 
            this.rbtn_distrito_ubigeo.AutoSize = true;
            this.rbtn_distrito_ubigeo.Checked = true;
            this.rbtn_distrito_ubigeo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtn_distrito_ubigeo.Location = new System.Drawing.Point(117, 4);
            this.rbtn_distrito_ubigeo.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_distrito_ubigeo.Name = "rbtn_distrito_ubigeo";
            this.rbtn_distrito_ubigeo.Size = new System.Drawing.Size(99, 29);
            this.rbtn_distrito_ubigeo.TabIndex = 2;
            this.rbtn_distrito_ubigeo.TabStop = true;
            this.rbtn_distrito_ubigeo.Text = "Ubigeo";
            this.rbtn_distrito_ubigeo.UseVisualStyleBackColor = true;
            // 
            // cbx_distrito
            // 
            this.cbx_distrito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbx_distrito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tlpnl_distrito.SetColumnSpan(this.cbx_distrito, 2);
            this.cbx_distrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_distrito.FormattingEnabled = true;
            this.cbx_distrito.Location = new System.Drawing.Point(117, 41);
            this.cbx_distrito.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_distrito.Name = "cbx_distrito";
            this.cbx_distrito.Size = new System.Drawing.Size(259, 24);
            this.cbx_distrito.TabIndex = 0;
            // 
            // rbtn_distrito_nombre
            // 
            this.rbtn_distrito_nombre.AutoSize = true;
            this.rbtn_distrito_nombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbtn_distrito_nombre.Location = new System.Drawing.Point(224, 4);
            this.rbtn_distrito_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.rbtn_distrito_nombre.Name = "rbtn_distrito_nombre";
            this.rbtn_distrito_nombre.Size = new System.Drawing.Size(152, 29);
            this.rbtn_distrito_nombre.TabIndex = 3;
            this.rbtn_distrito_nombre.Text = "Nombre de Distrito";
            this.rbtn_distrito_nombre.UseVisualStyleBackColor = true;
            this.rbtn_distrito_nombre.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(4, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ver Cartas";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // formPantallaGigante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 700);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formPantallaGigante";
            this.Text = "formPantallaGigante";
            this.Load += new System.EventHandler(this.formPantallaGigante_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tlpnl_carta.ResumeLayout(false);
            this.tlpnl_carta.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tlpnl_distrito.ResumeLayout(false);
            this.tlpnl_distrito.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tlpnl_carta;
        private System.Windows.Forms.ComboBox cbx_carta;
        private System.Windows.Forms.Label lbl_carta_o_nombre;
        private System.Windows.Forms.RadioButton rbtn_carta_codigo;
        private System.Windows.Forms.RadioButton rbtn_carta_nombre;
        private System.Windows.Forms.Button btn_ver_cartas;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tlpnl_distrito;
        private System.Windows.Forms.Label lbl_distrito;
        private System.Windows.Forms.RadioButton rbtn_distrito_ubigeo;
        private System.Windows.Forms.ComboBox cbx_distrito;
        private System.Windows.Forms.RadioButton rbtn_distrito_nombre;
        private System.Windows.Forms.Button button1;
    }
}