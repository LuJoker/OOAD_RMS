namespace OOAD_RMS
{
    partial class TestDetailInfo
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
            this._testNameLabel = new System.Windows.Forms.Label();
            this._testDescriptionLabel = new System.Windows.Forms.Label();
            this._testReqLabel = new System.Windows.Forms.Label();
            this._testReqInfo = new System.Windows.Forms.CheckedListBox();
            this._okButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._testNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._testDescriptionLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._testReqLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._testReqInfo, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this._okButton, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _testNameLabel
            // 
            this._testNameLabel.AutoSize = true;
            this._testNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._testNameLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._testNameLabel.Location = new System.Drawing.Point(3, 0);
            this._testNameLabel.Name = "_testNameLabel";
            this._testNameLabel.Size = new System.Drawing.Size(278, 40);
            this._testNameLabel.TabIndex = 1;
            this._testNameLabel.Text = "label1";
            this._testNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _testDescriptionLabel
            // 
            this._testDescriptionLabel.AutoSize = true;
            this._testDescriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._testDescriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._testDescriptionLabel.Location = new System.Drawing.Point(3, 40);
            this._testDescriptionLabel.Name = "_testDescriptionLabel";
            this._testDescriptionLabel.Size = new System.Drawing.Size(278, 40);
            this._testDescriptionLabel.TabIndex = 2;
            this._testDescriptionLabel.Text = "label2";
            this._testDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _testReqLabel
            // 
            this._testReqLabel.AutoSize = true;
            this._testReqLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._testReqLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._testReqLabel.Location = new System.Drawing.Point(3, 80);
            this._testReqLabel.Name = "_testReqLabel";
            this._testReqLabel.Size = new System.Drawing.Size(278, 25);
            this._testReqLabel.TabIndex = 3;
            this._testReqLabel.Text = "完成測試的需求:";
            this._testReqLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // _testReqInfo
            // 
            this._testReqInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._testReqInfo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._testReqInfo.FormattingEnabled = true;
            this._testReqInfo.Location = new System.Drawing.Point(3, 108);
            this._testReqInfo.Name = "_testReqInfo";
            this._testReqInfo.Size = new System.Drawing.Size(278, 115);
            this._testReqInfo.TabIndex = 4;
            this._testReqInfo.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.FormatTestReqInfo);
            // 
            // _okButton
            // 
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._okButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._okButton.Location = new System.Drawing.Point(3, 229);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(278, 29);
            this._okButton.TabIndex = 5;
            this._okButton.Text = "確認";
            this._okButton.UseVisualStyleBackColor = true;
            this._okButton.Click += new System.EventHandler(this.ClickOkButton);
            // 
            // TestDetailInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TestDetailInfo";
            this.Text = "TestDetailInfo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label _testNameLabel;
        private System.Windows.Forms.Label _testDescriptionLabel;
        private System.Windows.Forms.Label _testReqLabel;
        private System.Windows.Forms.CheckedListBox _testReqInfo;
        private System.Windows.Forms.Button _okButton;
    }
}