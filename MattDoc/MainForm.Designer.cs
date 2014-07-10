namespace MattDoc
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
            this.filePickerDialog = new System.Windows.Forms.OpenFileDialog();
            this.browseButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.fileList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // filePickerDialog
            // 
            this.filePickerDialog.Multiselect = true;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(326, 25);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 0;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(326, 279);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(107, 23);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "Save To 1 PDF";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // fileList
            // 
            this.fileList.FormattingEnabled = true;
            this.fileList.Location = new System.Drawing.Point(13, 25);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(307, 277);
            this.fileList.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 326);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.browseButton);
            this.Name = "MainForm";
            this.Text = "MattDoc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog filePickerDialog;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.ListBox fileList;
    }
}

