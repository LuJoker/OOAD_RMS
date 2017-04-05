namespace OOAD_RMS
{
    partial class ShowAddRequirementDialog
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
            this._requirementNameLabel = new System.Windows.Forms.Label();
            this._requirementNameTxt = new System.Windows.Forms.TextBox();
            this._requirementDescriptionLabel = new System.Windows.Forms.Label();
            this._requirementDescriptionTxt = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.33123F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.66877F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.Controls.Add(this._okBtn, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this._requirementNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._requirementNameTxt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._requirementDescriptionLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._requirementDescriptionTxt, 0, 2);
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
            // _requirementNameLabel
            // 
            this._requirementNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._requirementNameLabel.AutoSize = true;
            this._requirementNameLabel.Location = new System.Drawing.Point(3, 8);
            this._requirementNameLabel.Name = "_requirementNameLabel";
            this._requirementNameLabel.Size = new System.Drawing.Size(53, 12);
            this._requirementNameLabel.TabIndex = 1;
            this._requirementNameLabel.Text = "需求名稱";
            // 
            // _requirementNameTxt
            // 
            this._requirementNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this._requirementNameTxt, 2);
            this._requirementNameTxt.Location = new System.Drawing.Point(115, 3);
            this._requirementNameTxt.Name = "_requirementNameTxt";
            this._requirementNameTxt.Size = new System.Drawing.Size(325, 22);
            this._requirementNameTxt.TabIndex = 2;
            // 
            // _requirementDescriptionLabel
            // 
            this._requirementDescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._requirementDescriptionLabel.AutoSize = true;
            this._requirementDescriptionLabel.Location = new System.Drawing.Point(3, 37);
            this._requirementDescriptionLabel.Name = "_requirementDescriptionLabel";
            this._requirementDescriptionLabel.Size = new System.Drawing.Size(53, 12);
            this._requirementDescriptionLabel.TabIndex = 3;
            this._requirementDescriptionLabel.Text = "需求描述";
            // 
            // _requirementDescriptionTxt
            // 
            this.tableLayoutPanel1.SetColumnSpan(this._requirementDescriptionTxt, 3);
            this._requirementDescriptionTxt.Location = new System.Drawing.Point(3, 61);
            this._requirementDescriptionTxt.Multiline = true;
            this._requirementDescriptionTxt.Name = "_requirementDescriptionTxt";
            this._requirementDescriptionTxt.Size = new System.Drawing.Size(434, 167);
            this._requirementDescriptionTxt.TabIndex = 4;
            // 
            // ShowAddRequirementDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 268);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ShowAddRequirementDialog";
            this.Text = "ShowAddRequirementDialog";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button _okBtn;
        private System.Windows.Forms.Label _requirementNameLabel;
        private System.Windows.Forms.TextBox _requirementNameTxt;
        private System.Windows.Forms.Label _requirementDescriptionLabel;
        private System.Windows.Forms.TextBox _requirementDescriptionTxt;
    }
}