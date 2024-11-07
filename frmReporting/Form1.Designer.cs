
namespace frmReporting
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dgIssueReport = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResolutionTime = new System.Windows.Forms.TextBox();
            this.txtTechnicianFeedback = new System.Windows.Forms.TextBox();
            this.btnFetchReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgIssueReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Issue ID:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "IssueID",
            "Device"});
            this.comboBox1.Location = new System.Drawing.Point(145, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(292, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // dgIssueReport
            // 
            this.dgIssueReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIssueReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgIssueReport.Location = new System.Drawing.Point(32, 79);
            this.dgIssueReport.Name = "dgIssueReport";
            this.dgIssueReport.RowHeadersWidth = 51;
            this.dgIssueReport.RowTemplate.Height = 24;
            this.dgIssueReport.Size = new System.Drawing.Size(572, 387);
            this.dgIssueReport.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "IssueID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Resolution Time";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "TechnicianFeedback";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resolution Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(644, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Technician Feedback:";
            // 
            // txtResolutionTime
            // 
            this.txtResolutionTime.Location = new System.Drawing.Point(638, 99);
            this.txtResolutionTime.Multiline = true;
            this.txtResolutionTime.Name = "txtResolutionTime";
            this.txtResolutionTime.Size = new System.Drawing.Size(507, 134);
            this.txtResolutionTime.TabIndex = 5;
            // 
            // txtTechnicianFeedback
            // 
            this.txtTechnicianFeedback.Location = new System.Drawing.Point(638, 267);
            this.txtTechnicianFeedback.Multiline = true;
            this.txtTechnicianFeedback.Name = "txtTechnicianFeedback";
            this.txtTechnicianFeedback.Size = new System.Drawing.Size(508, 138);
            this.txtTechnicianFeedback.TabIndex = 6;
            // 
            // btnFetchReport
            // 
            this.btnFetchReport.Location = new System.Drawing.Point(798, 427);
            this.btnFetchReport.Name = "btnFetchReport";
            this.btnFetchReport.Size = new System.Drawing.Size(163, 38);
            this.btnFetchReport.TabIndex = 7;
            this.btnFetchReport.Text = "Fetch Report";
            this.btnFetchReport.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 485);
            this.Controls.Add(this.btnFetchReport);
            this.Controls.Add(this.txtTechnicianFeedback);
            this.Controls.Add(this.txtResolutionTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgIssueReport);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgIssueReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dgIssueReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResolutionTime;
        private System.Windows.Forms.TextBox txtTechnicianFeedback;
        private System.Windows.Forms.Button btnFetchReport;
    }
}

