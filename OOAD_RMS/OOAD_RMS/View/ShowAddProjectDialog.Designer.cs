namespace OOAD_RMS
{
    partial class ShowAddProjectDialog
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
            this._okBtn = new System.Windows.Forms.Button();
            this._projectNameLabel = new System.Windows.Forms.Label();
            this._projectNameTxt = new System.Windows.Forms.TextBox();
            this._projectDescriptionLabel = new System.Windows.Forms.Label();
            this._projectDescriptionTxt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.33123F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.66877F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.Controls.Add(this._okBtn, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this._projectNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._projectNameTxt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._projectDescriptionLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._projectDescriptionTxt, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 173F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(443, 268);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _okBtn
            // 
            this._okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this._okBtn.Location = new System.Drawing.Point(365, 234);
            this._okBtn.Name = "_okBtn";
            this._okBtn.Size = new System.Drawing.Size(75, 31);
            this._okBtn.TabIndex = 0;
            this._okBtn.Text = "確定";
            this._okBtn.UseVisualStyleBackColor = true;
            this._okBtn.Click += new System.EventHandler(this.ClickOkBtn);
            // 
            // _projectNameLabel
            // 
            this._projectNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._projectNameLabel.AutoSize = true;
            this._projectNameLabel.Location = new System.Drawing.Point(3, 8);
            this._projectNameLabel.Name = "_projectNameLabel";
            this._projectNameLabel.Size = new System.Drawing.Size(53, 12);
            this._projectNameLabel.TabIndex = 1;
            this._projectNameLabel.Text = "專案名稱";
            // 
            // _projectNameTxt
            // 
            this._projectNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this._projectNameTxt, 2);
            this._projectNameTxt.Location = new System.Drawing.Point(116, 3);
            this._projectNameTxt.Name = "_projectNameTxt";
            this._projectNameTxt.Size = new System.Drawing.Size(324, 22);
            this._projectNameTxt.TabIndex = 2;
            // 
            // _projectDescriptionLabel
            // 
            this._projectDescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._projectDescriptionLabel.AutoSize = true;
            this._projectDescriptionLabel.Location = new System.Drawing.Point(3, 37);
            this._projectDescriptionLabel.Name = "_projectDescriptionLabel";
            this._projectDescriptionLabel.Size = new System.Drawing.Size(53, 12);
            this._projectDescriptionLabel.TabIndex = 3;
            this._projectDescriptionLabel.Text = "專案描述";
            // 
            // _projectDescriptionTxt
            // 
            this.tableLayoutPanel1.SetColumnSpan(this._projectDescriptionTxt, 3);
            this._projectDescriptionTxt.Location = new System.Drawing.Point(3, 61);
            this._projectDescriptionTxt.Multiline = true;
            this._projectDescriptionTxt.Name = "_projectDescriptionTxt";
            this._projectDescriptionTxt.Size = new System.Drawing.Size(434, 167);
            this._projectDescriptionTxt.TabIndex = 4;
            // 
            // ShowAddProjectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 268);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ShowAddProjectDialog";
            this.Text = "ShowAddProjectDialog";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button _okBtn;
        private System.Windows.Forms.Label _projectNameLabel;
        private System.Windows.Forms.TextBox _projectNameTxt;
        private System.Windows.Forms.Label _projectDescriptionLabel;
        private System.Windows.Forms.TextBox _projectDescriptionTxt;
    }
}