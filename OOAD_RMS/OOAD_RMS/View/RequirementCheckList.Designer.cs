namespace OOAD_RMS
{
    partial class RequirementCheckList
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
            this._requirementCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this._selectReOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _requirementCheckedListBox
            // 
            this._requirementCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._requirementCheckedListBox.FormattingEnabled = true;
            this._requirementCheckedListBox.Location = new System.Drawing.Point(0, 0);
            this._requirementCheckedListBox.Name = "_requirementCheckedListBox";
            this._requirementCheckedListBox.Size = new System.Drawing.Size(120, 309);
            this._requirementCheckedListBox.TabIndex = 0;
            // 
            // _selectReOk
            // 
            this._selectReOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._selectReOk.Location = new System.Drawing.Point(33, 274);
            this._selectReOk.Name = "_selectReOk";
            this._selectReOk.Size = new System.Drawing.Size(75, 23);
            this._selectReOk.TabIndex = 1;
            this._selectReOk.Text = "button1";
            this._selectReOk.UseVisualStyleBackColor = true;
            this._selectReOk.Click += new System.EventHandler(this.ClickSelectReOkClick);
            // 
            // RequirementCheckList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 309);
            this.Controls.Add(this._selectReOk);
            this.Controls.Add(this._requirementCheckedListBox);
            this.Name = "RequirementCheckList";
            this.Text = "RequirementCheckList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox _requirementCheckedListBox;
        private System.Windows.Forms.Button _selectReOk;
    }
}