namespace SuperSAD
{
    partial class Main
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
            this.usersList = new System.Windows.Forms.ListBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.deletingGif = new System.Windows.Forms.PictureBox();
            this.gifShadow = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.deletingGif)).BeginInit();
            this.SuspendLayout();
            // 
            // usersList
            // 
            this.usersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersList.FormattingEnabled = true;
            this.usersList.IntegralHeight = false;
            this.usersList.ItemHeight = 15;
            this.usersList.Location = new System.Drawing.Point(0, 0);
            this.usersList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.usersList.Name = "usersList";
            this.usersList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.usersList.Size = new System.Drawing.Size(324, 247);
            this.usersList.TabIndex = 0;
            // 
            // washBtn
            // 
            this.deleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deleteBtn.Location = new System.Drawing.Point(0, 247);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deleteBtn.Name = "washBtn";
            this.deleteBtn.Size = new System.Drawing.Size(324, 53);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // deletingGif
            // 
            this.deletingGif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deletingGif.BackColor = System.Drawing.Color.White;
            this.deletingGif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deletingGif.Enabled = false;
            this.deletingGif.Image = global::SuperSAD.Properties.Resources.delete;
            this.deletingGif.Location = new System.Drawing.Point(10, 93);
            this.deletingGif.Name = "deletingGif";
            this.deletingGif.Size = new System.Drawing.Size(304, 60);
            this.deletingGif.TabIndex = 3;
            this.deletingGif.TabStop = false;
            // 
            // gifShadow
            // 
            this.gifShadow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gifShadow.BackColor = System.Drawing.Color.DarkGray;
            this.gifShadow.Location = new System.Drawing.Point(15, 98);
            this.gifShadow.Name = "gifShadow";
            this.gifShadow.Size = new System.Drawing.Size(304, 60);
            this.gifShadow.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 300);
            this.Controls.Add(this.usersList);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.deletingGif);
            this.Controls.Add(this.gifShadow);
            this.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuperSAD";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deletingGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox usersList;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.PictureBox deletingGif;
        private System.Windows.Forms.Panel gifShadow;
    }
}

