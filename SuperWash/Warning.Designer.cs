namespace SuperWash
{
    partial class Warning
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warning));
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.titleLbl = new System.Windows.Forms.Label();
            this.RTB = new System.Windows.Forms.RichTextBox();
            this.quitBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.credToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logoBox
            // 
            this.logoBox.Location = new System.Drawing.Point(73, 17);
            this.logoBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(48, 48);
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            this.credToolTip.SetToolTip(this.logoBox, "Written by Dylan Bickerstaff 2019");
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(122, 21);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(125, 21);
            this.titleLbl.TabIndex = 1;
            this.titleLbl.Text = "Super Wash";
            // 
            // RTB
            // 
            this.RTB.Location = new System.Drawing.Point(0, 68);
            this.RTB.Name = "RTB";
            this.RTB.ReadOnly = true;
            this.RTB.Size = new System.Drawing.Size(324, 199);
            this.RTB.TabIndex = 2;
            this.RTB.Text = resources.GetString("RTB.Text");
            // 
            // quitBtn
            // 
            this.quitBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.quitBtn.Location = new System.Drawing.Point(5, 272);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(75, 23);
            this.quitBtn.TabIndex = 3;
            this.quitBtn.Text = "Yikes!";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nextBtn.Location = new System.Drawing.Point(244, 272);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.Text = "OK";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.Next_Click);
            // 
            // credToolTip
            // 
            this.credToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.credToolTip.ToolTipTitle = "About SuperWash";
            // 
            // Warning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 300);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.RTB);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.logoBox);
            this.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Warning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperWash: Warning!";
            this.Load += new System.EventHandler(this.Warning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.RichTextBox RTB;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.ToolTip credToolTip;
    }
}