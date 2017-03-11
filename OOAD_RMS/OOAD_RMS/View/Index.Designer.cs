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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._addProjectBtn = new System.Windows.Forms.Button();
            this._projectExistLabel = new System.Windows.Forms.Label();
            this._projectGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._projectGridView)).BeginInit();
            this.SuspendLayout();
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
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.18487F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.81512F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(478, 284);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // _addProjectBtn
            // 
            this._addProjectBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this._addProjectBtn.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._addProjectBtn.Location = new System.Drawing.Point(3, 243);
            this._addProjectBtn.Name = "_addProjectBtn";
            this._addProjectBtn.Size = new System.Drawing.Size(96, 38);
            this._addProjectBtn.TabIndex = 0;
            this._addProjectBtn.Text = "新增專案";
            this._addProjectBtn.UseVisualStyleBackColor = true;
            this._addProjectBtn.Click += new System.EventHandler(this.ClickAddBtn);
            // 
            // _projectExistLabel
            // 
            this._projectExistLabel.AutoSize = true;
            this._projectExistLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this._projectExistLabel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._projectExistLabel.Location = new System.Drawing.Point(3, 0);
            this._projectExistLabel.Name = "_projectExistLabel";
            this._projectExistLabel.Size = new System.Drawing.Size(69, 29);
            this._projectExistLabel.TabIndex = 1;
            this._projectExistLabel.Text = "現有專案";
            this._projectExistLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _projectGridView
            // 
            this._projectGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._projectGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._projectGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._projectGridView.Location = new System.Drawing.Point(3, 32);
            this._projectGridView.Name = "_projectGridView";
            this._projectGridView.RowTemplate.Height = 24;
            this._projectGridView.Size = new System.Drawing.Size(472, 205);
            this._projectGridView.TabIndex = 2;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 284);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "Index";
            this.Text = "Index";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._projectGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Button _addProjectBtn;
        private System.Windows.Forms.Label _projectExistLabel;
        private System.Windows.Forms.DataGridView _projectGridView;
    }
}