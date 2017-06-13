namespace OOAD_RMS
{
    partial class UserCheckList
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
            this._userCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this._OKBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _userCheckedListBox
            // 
            this._userCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._userCheckedListBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._userCheckedListBox.FormattingEnabled = true;
            this._userCheckedListBox.Location = new System.Drawing.Point(-1, 1);
            this._userCheckedListBox.Name = "_userCheckedListBox";
            this._userCheckedListBox.Size = new System.Drawing.Size(120, 220);
            this._userCheckedListBox.TabIndex = 0;
            // 
            // _OKBtn
            // 
            this._OKBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._OKBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._OKBtn.Location = new System.Drawing.Point(-1, 223);
            this._OKBtn.Name = "_OKBtn";
            this._OKBtn.Size = new System.Drawing.Size(120, 37);
            this._OKBtn.TabIndex = 1;
            this._OKBtn.Text = "OK";
            this._OKBtn.UseVisualStyleBackColor = true;
            this._OKBtn.Click += new System.EventHandler(this.ClickOKBtn);
            // 
            // UserCheckList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 258);
            this.Controls.Add(this._OKBtn);
            this.Controls.Add(this._userCheckedListBox);
            this.Name = "UserCheckList";
            this.Text = "UserCheckList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox _userCheckedListBox;
        private System.Windows.Forms.Button _OKBtn;
    }
}