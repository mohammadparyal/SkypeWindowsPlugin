namespace Plugin
{
    partial class MainForm
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
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.attachedBtn = new System.Windows.Forms.Button();
            this.loggedAsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Location = new System.Drawing.Point(12, 71);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.ScrollAlwaysVisible = true;
            this.outputListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.outputListBox.Size = new System.Drawing.Size(582, 329);
            this.outputListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logged As: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Logs:";
            // 
            // attachedBtn
            // 
            this.attachedBtn.Location = new System.Drawing.Point(473, 12);
            this.attachedBtn.Name = "attachedBtn";
            this.attachedBtn.Size = new System.Drawing.Size(121, 23);
            this.attachedBtn.TabIndex = 3;
            this.attachedBtn.Text = "Attach with skype";
            this.attachedBtn.UseVisualStyleBackColor = true;
            this.attachedBtn.Click += new System.EventHandler(this.attachedBtn_Click);
            // 
            // loggedAsLbl
            // 
            this.loggedAsLbl.AutoSize = true;
            this.loggedAsLbl.Location = new System.Drawing.Point(83, 8);
            this.loggedAsLbl.Name = "loggedAsLbl";
            this.loggedAsLbl.Size = new System.Drawing.Size(0, 13);
            this.loggedAsLbl.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 412);
            this.Controls.Add(this.loggedAsLbl);
            this.Controls.Add(this.attachedBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputListBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Plugin";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button attachedBtn;
        private System.Windows.Forms.Label loggedAsLbl;
    }
}