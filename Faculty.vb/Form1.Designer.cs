
namespace Faculty.vb
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUrgencyLevel = new System.Windows.Forms.ComboBox();
            this.txtDeviceDetails = new System.Windows.Forms.TextBox();
            this.txtProblemDescription = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device Details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Problem Description:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(562, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Urgency Level:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbUrgencyLevel
            // 
            this.cmbUrgencyLevel.FormattingEnabled = true;
            this.cmbUrgencyLevel.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cmbUrgencyLevel.Location = new System.Drawing.Point(519, 259);
            this.cmbUrgencyLevel.Name = "cmbUrgencyLevel";
            this.cmbUrgencyLevel.Size = new System.Drawing.Size(192, 24);
            this.cmbUrgencyLevel.TabIndex = 3;
            // 
            // txtDeviceDetails
            // 
            this.txtDeviceDetails.Location = new System.Drawing.Point(475, 12);
            this.txtDeviceDetails.Multiline = true;
            this.txtDeviceDetails.Name = "txtDeviceDetails";
            this.txtDeviceDetails.Size = new System.Drawing.Size(280, 68);
            this.txtDeviceDetails.TabIndex = 4;
            // 
            // txtProblemDescription
            // 
            this.txtProblemDescription.Location = new System.Drawing.Point(475, 116);
            this.txtProblemDescription.Multiline = true;
            this.txtProblemDescription.Name = "txtProblemDescription";
            this.txtProblemDescription.Size = new System.Drawing.Size(280, 69);
            this.txtProblemDescription.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(915, 349);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(163, 52);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtProblemDescription);
            this.Controls.Add(this.txtDeviceDetails);
            this.Controls.Add(this.cmbUrgencyLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "IssueReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUrgencyLevel;
        private System.Windows.Forms.TextBox txtDeviceDetails;
        private System.Windows.Forms.TextBox txtProblemDescription;
        private System.Windows.Forms.Button btnSubmit;
    }
}

