namespace OOAD_RMS
{
    partial class Index
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._addProjectBtn = new System.Windows.Forms.Button();
            this._projectExistLabel = new System.Windows.Forms.Label();
            this._projectGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._addRequirementBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._requirementGridView = new System.Windows.Forms.DataGridView();
            this._projectComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._addTestBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._testGridView = new System.Windows.Forms.DataGridView();
            this.RequirementsColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this._projectComboBoxTest = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._projectGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._requirementGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._testGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(478, 284);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel);
            this.tabPage1.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(470, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "專案管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this._addProjectBtn, 0, 2);
            this.tableLayoutPanel.Controls.Add(this._projectExistLabel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this._projectGridView, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.18487F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.81512F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(464, 252);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // _addProjectBtn
            // 
            this._addProjectBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this._addProjectBtn.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._addProjectBtn.Location = new System.Drawing.Point(3, 211);
            this._addProjectBtn.Name = "_addProjectBtn";
            this._addProjectBtn.Size = new System.Drawing.Size(96, 38);
            this._addProjectBtn.TabIndex = 0;
            this._addProjectBtn.Text = "新增專案";
            this._addProjectBtn.UseVisualStyleBackColor = true;
            this._addProjectBtn.Click += new System.EventHandler(this.ClickAddProjectBtn);
            // 
            // _projectExistLabel
            // 
            this._projectExistLabel.AutoSize = true;
            this._projectExistLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this._projectExistLabel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._projectExistLabel.Location = new System.Drawing.Point(3, 0);
            this._projectExistLabel.Name = "_projectExistLabel";
            this._projectExistLabel.Size = new System.Drawing.Size(69, 25);
            this._projectExistLabel.TabIndex = 1;
            this._projectExistLabel.Text = "現有專案";
            this._projectExistLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _projectGridView
            // 
            this._projectGridView.AllowUserToAddRows = false;
            this._projectGridView.AllowUserToDeleteRows = false;
            this._projectGridView.AllowUserToResizeColumns = false;
            this._projectGridView.AllowUserToResizeRows = false;
            this._projectGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._projectGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._projectGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._projectGridView.Location = new System.Drawing.Point(3, 28);
            this._projectGridView.Name = "_projectGridView";
            this._projectGridView.RowTemplate.Height = 24;
            this._projectGridView.Size = new System.Drawing.Size(458, 177);
            this._projectGridView.TabIndex = 2;
            this._projectGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectProjectGridViewEvent);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(470, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "需求管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 368F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this._addRequirementBtn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._requirementGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._projectComboBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.18487F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.81512F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 252);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // _addRequirementBtn
            // 
            this._addRequirementBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this._addRequirementBtn.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._addRequirementBtn.Location = new System.Drawing.Point(3, 211);
            this._addRequirementBtn.Name = "_addRequirementBtn";
            this._addRequirementBtn.Size = new System.Drawing.Size(90, 38);
            this._addRequirementBtn.TabIndex = 0;
            this._addRequirementBtn.Text = "新增需求";
            this._addRequirementBtn.UseVisualStyleBackColor = true;
            this._addRequirementBtn.Click += new System.EventHandler(this.ClickAddRequirementBtn);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "現有需求";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _requirementGridView
            // 
            this._requirementGridView.AllowUserToAddRows = false;
            this._requirementGridView.AllowUserToDeleteRows = false;
            this._requirementGridView.AllowUserToResizeColumns = false;
            this._requirementGridView.AllowUserToResizeRows = false;
            this._requirementGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._requirementGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this._requirementGridView, 2);
            this._requirementGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._requirementGridView.Location = new System.Drawing.Point(3, 28);
            this._requirementGridView.Name = "_requirementGridView";
            this._requirementGridView.RowTemplate.Height = 24;
            this._requirementGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this._requirementGridView.Size = new System.Drawing.Size(458, 177);
            this._requirementGridView.TabIndex = 2;
            this._requirementGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectRequirementGridViewEvent);
            // 
            // _projectComboBox
            // 
            this._projectComboBox.FormattingEnabled = true;
            this._projectComboBox.Location = new System.Drawing.Point(99, 3);
            this._projectComboBox.Name = "_projectComboBox";
            this._projectComboBox.Size = new System.Drawing.Size(121, 23);
            this._projectComboBox.TabIndex = 3;
            this._projectComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel2);
            this.tabPage3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(470, 258);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "測試管理";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.2766F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.7234F));
            this.tableLayoutPanel2.Controls.Add(this._addTestBtn, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this._testGridView, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this._projectComboBoxTest, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.18487F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.81512F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(470, 258);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // _addTestBtn
            // 
            this._addTestBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this._addTestBtn.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._addTestBtn.Location = new System.Drawing.Point(3, 217);
            this._addTestBtn.Name = "_addTestBtn";
            this._addTestBtn.Size = new System.Drawing.Size(94, 38);
            this._addTestBtn.TabIndex = 0;
            this._addTestBtn.Text = "新增測試";
            this._addTestBtn.UseVisualStyleBackColor = true;
            this._addTestBtn.Click += new System.EventHandler(this.ClickAddTestBtn);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "現有測試";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _testGridView
            // 
            this._testGridView.AllowUserToAddRows = false;
            this._testGridView.AllowUserToDeleteRows = false;
            this._testGridView.AllowUserToResizeColumns = false;
            this._testGridView.AllowUserToResizeRows = false;
            this._testGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._testGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._testGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RequirementsColumn});
            this.tableLayoutPanel2.SetColumnSpan(this._testGridView, 2);
            this._testGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._testGridView.Location = new System.Drawing.Point(3, 29);
            this._testGridView.Name = "_testGridView";
            this._testGridView.RowTemplate.Height = 24;
            this._testGridView.Size = new System.Drawing.Size(464, 182);
            this._testGridView.TabIndex = 2;
            this._testGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this._testGridView_DataBindingComplete);
            // 
            // RequirementsColumn
            // 
            this.RequirementsColumn.HeaderText = "Requirements";
            this.RequirementsColumn.Name = "RequirementsColumn";
            // 
            // _projectComboBoxTest
            // 
            this._projectComboBoxTest.FormattingEnabled = true;
            this._projectComboBoxTest.Location = new System.Drawing.Point(103, 3);
            this._projectComboBoxTest.Name = "_projectComboBoxTest";
            this._projectComboBoxTest.Size = new System.Drawing.Size(121, 25);
            this._projectComboBoxTest.TabIndex = 3;
            this._projectComboBoxTest.SelectedIndexChanged += new System.EventHandler(this.TestComboBoxSelectedIndexChanged);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 284);
            this.Controls.Add(this.tabControl1);
            this.Name = "Index";
            this.Text = "Index";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._projectGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._requirementGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._testGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button _addProjectBtn;
        private System.Windows.Forms.Label _projectExistLabel;
        private System.Windows.Forms.DataGridView _projectGridView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button _addRequirementBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView _requirementGridView;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button _addTestBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView _testGridView;
        private System.Windows.Forms.ComboBox _projectComboBox;
        private System.Windows.Forms.ComboBox _projectComboBoxTest;
        private System.Windows.Forms.DataGridViewComboBoxColumn RequirementsColumn;
    }
}