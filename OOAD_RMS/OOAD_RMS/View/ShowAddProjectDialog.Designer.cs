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
            this._projectNameLabel = new System.Windows.Forms.Label();
            this._projectNameTxt = new System.Windows.Forms.TextBox();
            this._projectDescriptionLabel = new System.Windows.Forms.Label();
            this._projectDescriptionTxt = new System.Windows.Forms.TextBox();
            this._okBtn = new System.Windows.Forms.Button();
            this._checkedUserComboBox = new System.Windows.Forms.ComboBox();
            this._selectUserBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.16456F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.83544F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.Controls.Add(this._projectNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._projectNameTxt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this._projectDescriptionLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._projectDescriptionTxt, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._okBtn, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this._checkedUserComboBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this._selectUserBtn, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.67442F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.32558F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(443, 268);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _projectNameLabel
            // 
            this._projectNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._projectNameLabel.AutoSize = true;
            this._projectNameLabel.Location = new System.Drawing.Point(3, 7);
            this._projectNameLabel.Name = "_projectNameLabel";
            this._projectNameLabel.Size = new System.Drawing.Size(73, 20);
            this._projectNameLabel.TabIndex = 1;
            this._projectNameLabel.Text = "專案名稱";
            // 
            // _projectNameTxt
            // 
            this._projectNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this._projectNameTxt, 2);
            this._projectNameTxt.Location = new System.Drawing.Point(96, 3);
            this._projectNameTxt.Name = "_projectNameTxt";
            this._projectNameTxt.Size = new System.Drawing.Size(344, 29);
            this._projectNameTxt.TabIndex = 0;
            // 
            // _projectDescriptionLabel
            // 
            this._projectDescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._projectDescriptionLabel.AutoSize = true;
            this._projectDescriptionLabel.Location = new System.Drawing.Point(3, 42);
            this._projectDescriptionLabel.Name = "_projectDescriptionLabel";
            this._projectDescriptionLabel.Size = new System.Drawing.Size(73, 20);
            this._projectDescriptionLabel.TabIndex = 3;
            this._projectDescriptionLabel.Text = "專案描述";
            // 
            // _projectDescriptionTxt
            // 
            this.tableLayoutPanel1.SetColumnSpan(this._projectDescriptionTxt, 3);
            this._projectDescriptionTxt.Location = new System.Drawing.Point(3, 74);
            this._projectDescriptionTxt.Multiline = true;
            this._projectDescriptionTxt.Name = "_projectDescriptionTxt";
            this._projectDescriptionTxt.Size = new System.Drawing.Size(434, 120);
            this._projectDescriptionTxt.TabIndex = 1;
            // 
            // _okBtn
            // 
            this._okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okBtn.Location = new System.Drawing.Point(365, 235);
            this._okBtn.Name = "_okBtn";
            this._okBtn.Size = new System.Drawing.Size(75, 30);
            this._okBtn.TabIndex = 2;
            this._okBtn.Text = "確定";
            this._okBtn.UseVisualStyleBackColor = true;
            // 
            // _checkedUserComboBox
            // 
            this._checkedUserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._checkedUserComboBox.FormattingEnabled = true;
            this._checkedUserComboBox.Location = new System.Drawing.Point(96, 200);
            this._checkedUserComboBox.Name = "_checkedUserComboBox";
            this._checkedUserComboBox.Size = new System.Drawing.Size(232, 28);
            this._checkedUserComboBox.TabIndex = 5;
            // 
            // _selectUserBtn
            // 
            this._selectUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._selectUserBtn.Location = new System.Drawing.Point(3, 200);
            this._selectUserBtn.Name = "_selectUserBtn";
            this._selectUserBtn.Size = new System.Drawing.Size(87, 29);
            this._selectUserBtn.TabIndex = 4;
            this._selectUserBtn.Text = "編輯成員";
            this._selectUserBtn.UseVisualStyleBackColor = true;
            this._selectUserBtn.Click += new System.EventHandler(this.ClickSelectUserBtn);
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
        private System.Windows.Forms.ComboBox _checkedUserComboBox;
        private System.Windows.Forms.Button _selectUserBtn;
    }
}