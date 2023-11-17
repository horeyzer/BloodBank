namespace Blood_Bank
{
    partial class Menu
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
            this.labelBloodBank1 = new System.Windows.Forms.Label();
            this.buttonAddDonor1 = new System.Windows.Forms.Button();
            this.buttonShowRecords1 = new System.Windows.Forms.Button();
            this.buttonInfo1 = new System.Windows.Forms.Button();
            this.buttonExit1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBloodBank1
            // 
            this.labelBloodBank1.AutoSize = true;
            this.labelBloodBank1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBloodBank1.Location = new System.Drawing.Point(70, 30);
            this.labelBloodBank1.Name = "labelBloodBank1";
            this.labelBloodBank1.Size = new System.Drawing.Size(145, 29);
            this.labelBloodBank1.TabIndex = 0;
            this.labelBloodBank1.Text = "Blood bank";
            // 
            // buttonAddDonor1
            // 
            this.buttonAddDonor1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddDonor1.Location = new System.Drawing.Point(12, 72);
            this.buttonAddDonor1.Name = "buttonAddDonor1";
            this.buttonAddDonor1.Size = new System.Drawing.Size(128, 50);
            this.buttonAddDonor1.TabIndex = 1;
            this.buttonAddDonor1.Text = "Add donor";
            this.buttonAddDonor1.UseVisualStyleBackColor = true;
            this.buttonAddDonor1.Click += new System.EventHandler(this.buttonAddDonor1_Click);
            // 
            // buttonShowRecords1
            // 
            this.buttonShowRecords1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowRecords1.Location = new System.Drawing.Point(149, 72);
            this.buttonShowRecords1.Name = "buttonShowRecords1";
            this.buttonShowRecords1.Size = new System.Drawing.Size(128, 50);
            this.buttonShowRecords1.TabIndex = 2;
            this.buttonShowRecords1.Text = "Show records";
            this.buttonShowRecords1.UseVisualStyleBackColor = true;
            this.buttonShowRecords1.Click += new System.EventHandler(this.buttonShowRecords1_Click);
            // 
            // buttonInfo1
            // 
            this.buttonInfo1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo1.Location = new System.Drawing.Point(12, 176);
            this.buttonInfo1.Name = "buttonInfo1";
            this.buttonInfo1.Size = new System.Drawing.Size(37, 23);
            this.buttonInfo1.TabIndex = 3;
            this.buttonInfo1.Text = "info";
            this.buttonInfo1.UseVisualStyleBackColor = true;
            this.buttonInfo1.Click += new System.EventHandler(this.buttonInfo1_Click);
            // 
            // buttonExit1
            // 
            this.buttonExit1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit1.Location = new System.Drawing.Point(55, 176);
            this.buttonExit1.Name = "buttonExit1";
            this.buttonExit1.Size = new System.Drawing.Size(222, 23);
            this.buttonExit1.TabIndex = 4;
            this.buttonExit1.Text = "exit";
            this.buttonExit1.UseVisualStyleBackColor = true;
            this.buttonExit1.Click += new System.EventHandler(this.buttonExit1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(289, 211);
            this.Controls.Add(this.buttonExit1);
            this.Controls.Add(this.buttonInfo1);
            this.Controls.Add(this.buttonShowRecords1);
            this.Controls.Add(this.buttonAddDonor1);
            this.Controls.Add(this.labelBloodBank1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Menu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBloodBank1;
        private System.Windows.Forms.Button buttonAddDonor1;
        private System.Windows.Forms.Button buttonShowRecords1;
        private System.Windows.Forms.Button buttonInfo1;
        private System.Windows.Forms.Button buttonExit1;
    }
}

