namespace reportApp
{
    partial class Form1
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
            this.CustomerList = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PDF = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerList
            // 
            this.CustomerList.AutoSize = true;
            this.CustomerList.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerList.Location = new System.Drawing.Point(13, 9);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(133, 25);
            this.CustomerList.TabIndex = 0;
            this.CustomerList.Text = "Customer List";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PDF);
            this.panel1.Controls.Add(this.View);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Location = new System.Drawing.Point(18, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 106);
            this.panel1.TabIndex = 1;
            // 
            // PDF
            // 
            this.PDF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDF.Location = new System.Drawing.Point(88, 61);
            this.PDF.Name = "PDF";
            this.PDF.Size = new System.Drawing.Size(75, 35);
            this.PDF.TabIndex = 3;
            this.PDF.Text = "PDF";
            this.PDF.UseVisualStyleBackColor = true;
            this.PDF.Click += new System.EventHandler(this.PDF_Click);
            // 
            // View
            // 
            this.View.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View.Location = new System.Drawing.Point(9, 61);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(73, 35);
            this.View.TabIndex = 2;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(7, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 25);
            this.textBox1.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(4, 12);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(48, 17);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search";
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "reportApp.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(18, 159);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(654, 249);
            this.reportViewer1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 420);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CustomerList);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PDF;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Search;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}

