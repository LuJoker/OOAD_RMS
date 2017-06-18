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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.86498F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.13502F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel1.Controls.Add(this._okBtn, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this._requirementNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._requirementNameTxt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._requirementDescriptionLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._requirementDescriptionTxt, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(446, 274);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _okBtn
            // 
            this._okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this._okBtn.Location = new System.Drawing.Point(362, 239);
            this._okBtn.Margin = new System.Windows.Forms.Padding(5);
            this._okBtn.Name = "_okBtn";
            this._okBtn.Size = new System.Drawing.Size(79, 30);
            this._okBtn.TabIndex = 2;
            this._okBtn.Text = "確定";
            this._okBtn.UseVisualStyleBackColor = true;
            // 
            // _requirementNameLabel
            // 
            this._requirementNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._requirementNameLabel.AutoSize = true;
            this._requirementNameLabel.Location = new System.Drawing.Point(5, 8);
            this._requirementNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._requirementNameLabel.Name = "_requirementNameLabel";
            this._requirementNameLabel.Size = new System.Drawing.Size(73, 20);
            this._requirementNameLabel.TabIndex = 1;
            this._requirementNameLabel.Text = "需求名稱";
            // 
            // _requirementNameTxt
            // 
            this._requirementNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this._requirementNameTxt, 2);
            this._requirementNameTxt.Location = new System.Drawing.Point(88, 5);
            this._requirementNameTxt.Margin = new System.Windows.Forms.Padding(5);
            this._requirementNameTxt.Name = "_requirementNameTxt";
            this._requirementNameTxt.Size = new System.Drawing.Size(353, 29);
            this._requirementNameTxt.TabIndex = 0;
            // 
            // _requirementDescriptionLabel
            // 
            this._requirementDescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._requirementDescriptionLabel.AutoSize = true;
            this._requirementDescriptionLabel.Location = new System.Drawing.Point(5, 40);
            this._requirementDescriptionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._requirementDescriptionLabel.Name = "_requirementDescriptionLabel";
            this._requirementDescriptionLabel.Size = new System.Drawing.Size(73, 20);
            this._requirementDescriptionLabel.TabIndex = 3;
            this._requirementDescriptionLabel.Text = "需求描述";
            // 
            // _requirementDescriptionTxt
            // 
            this.tableLayoutPanel1.SetColumnSpan(this._requirementDescriptionTxt, 3);
            this._requirementDescriptionTxt.Location = new System.Drawing.Point(5, 70);
            this._requirementDescriptionTxt.Margin = new System.Windows.Forms.Padding(5);
            this._requirementDescriptionTxt.Multiline = true;
            this._requirementDescriptionTxt.Name = "_requirementDescriptionTxt";
            this._requirementDescriptionTxt.Size = new System.Drawing.Size(436, 159);
            this._requirementDescriptionTxt.TabIndex = 1;
            // 
            // ShowAddRequirementDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 274);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
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