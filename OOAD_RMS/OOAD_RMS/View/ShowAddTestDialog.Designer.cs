namespace OOAD_RMS
{
    partial class ShowAddTestDialog
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
            this._testNameLabel = new System.Windows.Forms.Label();
            this._testNameTxt = new System.Windows.Forms.TextBox();
            this._requirementDescriptionLabel = new System.Windows.Forms.Label();
            this._testDescriptionTxt = new System.Windows.Forms.TextBox();
            this._testRequirementComboBox = new System.Windows.Forms.ComboBox();
            this._editRequirementList = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.33123F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.66877F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.Controls.Add(this._okBtn, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this._testNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._testNameTxt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._requirementDescriptionLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._testDescriptionTxt, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._testRequirementComboBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this._editRequirementList, 0, 3);
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
            this._okBtn.Click += new System.EventHandler(this._okBtn_Click);
            // 
            // _testNameLabel
            // 
            this._testNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._testNameLabel.AutoSize = true;
            this._testNameLabel.Location = new System.Drawing.Point(3, 8);
            this._testNameLabel.Name = "_testNameLabel";
            this._testNameLabel.Size = new System.Drawing.Size(53, 12);
            this._testNameLabel.TabIndex = 1;
            this._testNameLabel.Text = "測試名稱";
            // 
            // _testNameTxt
            // 
            this._testNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this._testNameTxt, 2);
            this._testNameTxt.Location = new System.Drawing.Point(113, 3);
            this._testNameTxt.Name = "_testNameTxt";
            this._testNameTxt.Size = new System.Drawing.Size(327, 22);
            this._testNameTxt.TabIndex = 2;
            // 
            // _requirementDescriptionLabel
            // 
            this._requirementDescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._requirementDescriptionLabel.AutoSize = true;
            this._requirementDescriptionLabel.Location = new System.Drawing.Point(3, 37);
            this._requirementDescriptionLabel.Name = "_requirementDescriptionLabel";
            this._requirementDescriptionLabel.Size = new System.Drawing.Size(53, 12);
            this._requirementDescriptionLabel.TabIndex = 3;
            this._requirementDescriptionLabel.Text = "測試描述";
            // 
            // _testDescriptionTxt
            // 
            this.tableLayoutPanel1.SetColumnSpan(this._testDescriptionTxt, 3);
            this._testDescriptionTxt.Location = new System.Drawing.Point(3, 61);
            this._testDescriptionTxt.Multiline = true;
            this._testDescriptionTxt.Name = "_testDescriptionTxt";
            this._testDescriptionTxt.Size = new System.Drawing.Size(434, 167);
            this._testDescriptionTxt.TabIndex = 4;
            // 
            // _testRequirementComboBox
            // 
            this._testRequirementComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this._testRequirementComboBox.FormattingEnabled = true;
            this._testRequirementComboBox.Location = new System.Drawing.Point(113, 234);
            this._testRequirementComboBox.Name = "_testRequirementComboBox";
            this._testRequirementComboBox.Size = new System.Drawing.Size(121, 20);
            this._testRequirementComboBox.TabIndex = 5;
            // 
            // _editRequirementList
            // 
            this._editRequirementList.Dock = System.Windows.Forms.DockStyle.Left;
            this._editRequirementList.Location = new System.Drawing.Point(3, 234);
            this._editRequirementList.Name = "_editRequirementList";
            this._editRequirementList.Size = new System.Drawing.Size(82, 31);
            this._editRequirementList.TabIndex = 6;
            this._editRequirementList.Text = "選擇需求";
            this._editRequirementList.UseVisualStyleBackColor = true;
            this._editRequirementList.Click += new System.EventHandler(this._editRequirementList_Click);
            // 
            // ShowAddTestDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 268);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ShowAddTestDialog";
            this.Text = "ShowAddRequirementDialog";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button _okBtn;
        private System.Windows.Forms.Label _testNameLabel;
        private System.Windows.Forms.TextBox _testNameTxt;
        private System.Windows.Forms.Label _requirementDescriptionLabel;
        private System.Windows.Forms.TextBox _testDescriptionTxt;
        private System.Windows.Forms.ComboBox _testRequirementComboBox;
        private System.Windows.Forms.Button _editRequirementList;
    }
}