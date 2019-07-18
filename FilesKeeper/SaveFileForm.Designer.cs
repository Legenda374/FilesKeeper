namespace FilesKeeper
{
    partial class SaveFileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.SelectPathButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProgressUpload = new System.Windows.Forms.ProgressBar();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BackgroundUploader = new System.ComponentModel.BackgroundWorker();
            this.MainGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.MainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(6, 75);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(308, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(234, 105);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(80, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить ->";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PathTextBox
            // 
            this.PathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathTextBox.Location = new System.Drawing.Point(6, 32);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.ReadOnly = true;
            this.PathTextBox.Size = new System.Drawing.Size(269, 20);
            this.PathTextBox.TabIndex = 2;
            this.PathTextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
            // 
            // SelectPathButton
            // 
            this.SelectPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectPathButton.Location = new System.Drawing.Point(281, 31);
            this.SelectPathButton.Name = "SelectPathButton";
            this.SelectPathButton.Size = new System.Drawing.Size(33, 23);
            this.SelectPathButton.TabIndex = 3;
            this.SelectPathButton.Text = "...";
            this.SelectPathButton.UseVisualStyleBackColor = true;
            this.SelectPathButton.Click += new System.EventHandler(this.SelectPathButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Папка для сохранения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Имя файла:";
            // 
            // ProgressUpload
            // 
            this.ProgressUpload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressUpload.Location = new System.Drawing.Point(6, 105);
            this.ProgressUpload.MarqueeAnimationSpeed = 0;
            this.ProgressUpload.Name = "ProgressUpload";
            this.ProgressUpload.Size = new System.Drawing.Size(222, 23);
            this.ProgressUpload.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressUpload.TabIndex = 7;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainGroupBox.Controls.Add(this.label1);
            this.MainGroupBox.Controls.Add(this.ProgressUpload);
            this.MainGroupBox.Controls.Add(this.NameTextBox);
            this.MainGroupBox.Controls.Add(this.SaveButton);
            this.MainGroupBox.Controls.Add(this.label2);
            this.MainGroupBox.Controls.Add(this.PathTextBox);
            this.MainGroupBox.Controls.Add(this.SelectPathButton);
            this.MainGroupBox.Location = new System.Drawing.Point(5, -2);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Size = new System.Drawing.Size(325, 137);
            this.MainGroupBox.TabIndex = 8;
            this.MainGroupBox.TabStop = false;
            // 
            // SaveFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(334, 139);
            this.Controls.Add(this.MainGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SaveFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Сохранить файл с базы";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button SelectPathButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar ProgressUpload;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.ComponentModel.BackgroundWorker BackgroundUploader;
        private System.Windows.Forms.GroupBox MainGroupBox;
    }
}