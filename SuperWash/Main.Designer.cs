namespace SuperWash
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
            this.washBtn = new System.Windows.Forms.Button();
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
            this.usersList.Size = new System.Drawing.Size(309, 282);
            this.usersList.TabIndex = 0;
            // 
            // washBtn
            // 
            this.washBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.washBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.washBtn.Location = new System.Drawing.Point(0, 282);
            this.washBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.washBtn.Name = "washBtn";
            this.washBtn.Size = new System.Drawing.Size(309, 53);
            this.washBtn.TabIndex = 2;
            this.washBtn.Text = "Wash";
            this.washBtn.UseVisualStyleBackColor = true;
            this.washBtn.Click += new System.EventHandler(this.washBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 335);
            this.Controls.Add(this.washBtn);
            this.Controls.Add(this.usersList);
            this.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "SuperWash";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox usersList;
        private System.Windows.Forms.Button washBtn;
    }
}

