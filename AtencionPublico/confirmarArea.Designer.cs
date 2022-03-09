namespace AtencionPublico
{
    partial class frm_confirmarArea
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
            this.btn_si = new System.Windows.Forms.Button();
            this.btn_no = new System.Windows.Forms.Button();
            this.tbl_panel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_si
            // 
            this.btn_si.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_si.Location = new System.Drawing.Point(28, 54);
            this.btn_si.Name = "btn_si";
            this.btn_si.Size = new System.Drawing.Size(81, 35);
            this.btn_si.TabIndex = 0;
            this.btn_si.Text = "Sí";
            this.btn_si.UseVisualStyleBackColor = true;
            this.btn_si.Click += new System.EventHandler(this.btn_si_Click);
            // 
            // btn_no
            // 
            this.btn_no.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_no.Location = new System.Drawing.Point(140, 54);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(81, 35);
            this.btn_no.TabIndex = 1;
            this.btn_no.Text = "No, volver a graficar";
            this.btn_no.UseVisualStyleBackColor = true;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // tbl_panel
            // 
            this.tbl_panel.ColumnCount = 5;
            this.tbl_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbl_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tbl_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbl_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tbl_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tbl_panel.Controls.Add(this.btn_si, 1, 1);
            this.tbl_panel.Controls.Add(this.label1, 1, 0);
            this.tbl_panel.Controls.Add(this.btn_no, 3, 1);
            this.tbl_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_panel.Location = new System.Drawing.Point(0, 0);
            this.tbl_panel.Name = "tbl_panel";
            this.tbl_panel.RowCount = 2;
            this.tbl_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tbl_panel.Size = new System.Drawing.Size(250, 111);
            this.tbl_panel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tbl_panel.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(28, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "¿Desea confirmar el área de consulta?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_confirmarArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 111);
            this.Controls.Add(this.tbl_panel);
            this.Name = "frm_confirmarArea";
            this.Text = "Área de consulta";
            this.Load += new System.EventHandler(this.frm_confirmarArea_Load);
            this.tbl_panel.ResumeLayout(false);
            this.tbl_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_si;
        private System.Windows.Forms.Button btn_no;
        private System.Windows.Forms.TableLayoutPanel tbl_panel;
        private System.Windows.Forms.Label label1;
    }
}