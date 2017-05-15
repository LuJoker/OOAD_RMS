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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.03412F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.96588F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this._okBtn, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this._testNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._testNameTxt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._requirementDescriptionLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._testDescriptionTxt, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._testRequirementComboBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this._editRequirementList, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.06061F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.93939F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 312);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _okBtn
            // 
            this._okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this._okBtn.Location = new System.Drawing.Point(386, 275);
            this._okBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this._okBtn.Name = "_okBtn";
            this._okBtn.Size = new System.Drawing.Size(71, 32);
            this._okBtn.TabIndex = 3;
            this._okBtn.Text = "確定";
            this._okBtn.UseVisualStyleBackColor = true;
            this._okBtn.Click += new System.EventHandler(this.ClickOkBtn);
            // 
            // _testNameLabel
            // 
            this._testNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._testNameLabel.AutoSize = true;
            this._testNameLabel.Location = new System.Drawing.Point(5, 8);
            this._testNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._testNameLabel.Name = "_testNameLabel";
            this._testNameLabel.Size = new System.Drawing.Size(73, 20);
            this._testNameLabel.TabIndex = 1;
            this._testNameLabel.Text = "測試名稱";
            // 
            // _testNameTxt
            // 
            this._testNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this._testNameTxt, 2);
            this._testNameTxt.Location = new System.Drawing.Point(108, 5);
            this._testNameTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this._testNameTxt.Name = "_testNameTxt";
            this._testNameTxt.Size = new System.Drawing.Size(349, 29);
            this._testNameTxt.TabIndex = 0;
            // 
            // _requirementDescriptionLabel
            // 
            this._requirementDescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._requirementDescriptionLabel.AutoSize = true;
            this._requirementDescriptionLabel.Location = new System.Drawing.Point(5, 41);
            this._requirementDescriptionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this._requirementDescriptionLabel.Name = "_requirementDescriptionLabel";
            this._requirementDescriptionLabel.Size = new System.Drawing.Size(73, 20);
            this._requirementDescriptionLabel.TabIndex = 3;
            this._requirementDescriptionLabel.Text = "測試描述";
            // 
            // _testDescriptionTxt
            // 
            this.tableLayoutPanel1.SetColumnSpan(this._testDescriptionTxt, 3);
            this._testDescriptionTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this._testDescriptionTxt.Location = new System.Drawing.Point(5, 71);
            this._testDescriptionTxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this._testDescriptionTxt.Multiline = true;
            this._testDescriptionTxt.Name = "_testDescriptionTxt";
            this._testDescriptionTxt.Size = new System.Drawing.Size(452, 194);
            this._testDescriptionTxt.TabIndex = 1;
            // 
            // _testRequirementComboBox
            // 
            this._testRequirementComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._testRequirementComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._testRequirementComboBox.FormattingEnabled = true;
            this._testRequirementComboBox.Location = new System.Drawing.Point(108, 275);
            this._testRequirementComboBox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this._testRequirementComboBox.Name = "_testRequirementComboBox";
            this._testRequirementComboBox.Size = new System.Drawing.Size(199, 28);
            this._testRequirementComboBox.TabIndex = 5;
            // 
            // _editRequirementList
            // 
            this._editRequirementList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._editRequirementList.Location = new System.Drawing.Point(5, 275);
            this._editRequirementList.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this._editRequirementList.Name = "_editRequirementList";
            this._editRequirementList.Size = new System.Drawing.Size(93, 32);
            this._editRequirementList.TabIndex = 2;
            this._editRequirementList.Text = "選擇需求";
            this._editRequirementList.UseVisualStyleBackColor = true;
            this._editRequirementList.Click += new System.EventHandler(this.ClickEditRequirementList);
            // 
            // ShowAddTestDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 312);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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