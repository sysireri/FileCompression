
namespace FileCompression
{
    partial class FrmMain
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
            this.txtFileToZip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butBrowse = new System.Windows.Forms.Button();
            this.DlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGZFile = new System.Windows.Forms.TextBox();
            this.ButGZFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFileToZip
            // 
            this.txtFileToZip.Location = new System.Drawing.Point(90, 33);
            this.txtFileToZip.Name = "txtFileToZip";
            this.txtFileToZip.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtFileToZip.Size = new System.Drawing.Size(624, 20);
            this.txtFileToZip.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File to Zip :";
            // 
            // butBrowse
            // 
            this.butBrowse.Location = new System.Drawing.Point(720, 27);
            this.butBrowse.Name = "butBrowse";
            this.butBrowse.Size = new System.Drawing.Size(68, 30);
            this.butBrowse.TabIndex = 2;
            this.butBrowse.Text = "Browse";
            this.butBrowse.UseVisualStyleBackColor = true;
            this.butBrowse.Click += new System.EventHandler(this.butBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "GZ File :";
            // 
            // txtGZFile
            // 
            this.txtGZFile.Location = new System.Drawing.Point(90, 75);
            this.txtGZFile.Name = "txtGZFile";
            this.txtGZFile.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtGZFile.Size = new System.Drawing.Size(624, 20);
            this.txtGZFile.TabIndex = 3;
            // 
            // ButGZFile
            // 
            this.ButGZFile.Location = new System.Drawing.Point(720, 69);
            this.ButGZFile.Name = "ButGZFile";
            this.ButGZFile.Size = new System.Drawing.Size(68, 30);
            this.ButGZFile.TabIndex = 5;
            this.ButGZFile.Text = "GZ File";
            this.ButGZFile.UseVisualStyleBackColor = true;
            this.ButGZFile.Click += new System.EventHandler(this.ButGZFile_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 116);
            this.Controls.Add(this.ButGZFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGZFile);
            this.Controls.Add(this.butBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileToZip);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileToZip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butBrowse;
        private System.Windows.Forms.OpenFileDialog DlgOpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGZFile;
        private System.Windows.Forms.Button ButGZFile;
    }
}