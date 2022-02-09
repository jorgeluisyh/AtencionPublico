namespace AtencionPublico
{
    partial class Modulos
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_modulos_controles = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_modulos = new System.Windows.Forms.Label();
            this.cbx_modulos = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pgb_modulos = new System.Windows.Forms.ProgressBar();
            this.pnl_modulos_form = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlp_modulos_controles.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Controls.Add(this.tlp_modulos_controles, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pnl_modulos_form, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(343, 569);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tlp_modulos_controles
            // 
            this.tlp_modulos_controles.ColumnCount = 2;
            this.tlp_modulos_controles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_modulos_controles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_modulos_controles.Controls.Add(this.lbl_modulos, 0, 0);
            this.tlp_modulos_controles.Controls.Add(this.cbx_modulos, 0, 1);
            this.tlp_modulos_controles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_modulos_controles.Location = new System.Drawing.Point(10, 10);
            this.tlp_modulos_controles.Margin = new System.Windows.Forms.Padding(2);
            this.tlp_modulos_controles.Name = "tlp_modulos_controles";
            this.tlp_modulos_controles.RowCount = 2;
            this.tlp_modulos_controles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_modulos_controles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_modulos_controles.Size = new System.Drawing.Size(323, 41);
            this.tlp_modulos_controles.TabIndex = 2;
            // 
            // lbl_modulos
            // 
            this.lbl_modulos.AutoSize = true;
            this.tlp_modulos_controles.SetColumnSpan(this.lbl_modulos, 2);
            this.lbl_modulos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_modulos.Location = new System.Drawing.Point(2, 7);
            this.lbl_modulos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_modulos.Name = "lbl_modulos";
            this.lbl_modulos.Size = new System.Drawing.Size(319, 13);
            this.lbl_modulos.TabIndex = 0;
            this.lbl_modulos.Text = "Seleccionar módulo";
            // 
            // cbx_modulos
            // 
            this.tlp_modulos_controles.SetColumnSpan(this.cbx_modulos, 2);
            this.cbx_modulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_modulos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_modulos.FormattingEnabled = true;
            this.cbx_modulos.Location = new System.Drawing.Point(2, 22);
            this.cbx_modulos.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_modulos.Name = "cbx_modulos";
            this.cbx_modulos.Size = new System.Drawing.Size(319, 21);
            this.cbx_modulos.TabIndex = 1;
            this.cbx_modulos.SelectedIndexChanged += new System.EventHandler(this.cbx_modulos_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.Controls.Add(this.pgb_modulos, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 531);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(323, 28);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // pgb_modulos
            // 
            this.pgb_modulos.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.SetColumnSpan(this.pgb_modulos, 2);
            this.pgb_modulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgb_modulos.Location = new System.Drawing.Point(2, 2);
            this.pgb_modulos.Margin = new System.Windows.Forms.Padding(2);
            this.pgb_modulos.Name = "pgb_modulos";
            this.pgb_modulos.Size = new System.Drawing.Size(319, 24);
            this.pgb_modulos.TabIndex = 0;
            // 
            // pnl_modulos_form
            // 
            this.pnl_modulos_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_modulos_form.Location = new System.Drawing.Point(10, 55);
            this.pnl_modulos_form.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_modulos_form.Name = "pnl_modulos_form";
            this.pnl_modulos_form.Size = new System.Drawing.Size(323, 472);
            this.pnl_modulos_form.TabIndex = 1;
            // 
            // Modulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(343, 569);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Modulos";
            this.Text = "Modulos";
            this.Load += new System.EventHandler(this.Modulos_Load);
            this.Resize += new System.EventHandler(this.Modulos_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlp_modulos_controles.ResumeLayout(false);
            this.tlp_modulos_controles.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ProgressBar pgb_modulos;
        private System.Windows.Forms.Panel pnl_modulos_form;
        private System.Windows.Forms.TableLayoutPanel tlp_modulos_controles;
        private System.Windows.Forms.Label lbl_modulos;
        private System.Windows.Forms.ComboBox cbx_modulos;
    }
}