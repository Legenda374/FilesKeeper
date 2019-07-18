namespace FilesKeeper
{
    partial class UploadFileForm
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
            this.UploadButton = new System.Windows.Forms.Button();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.SelectPathButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CompressCheckBox = new System.Windows.Forms.CheckBox();
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
            this.NameTextBox.Size = new System.Drawing.Size(313, 20);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // UploadButton
            // 
            this.UploadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UploadButton.Location = new System.Drawing.Point(236, 124);
            this.UploadButton.Name = "UploadButton";
            this.UploadButton.Size = new System.Drawing.Size(83, 23);
            this.UploadButton.TabIndex = 1;
            this.UploadButton.Text = "Загрузить ->";
            this.UploadButton.UseVisualStyleBackColor = true;
            this.UploadButton.Click += new System.EventHandler(this.UploadButton_Click);
            // 
            // PathTextBox
            // 
            this.PathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathTextBox.Location = new System.Drawing.Point(6, 32);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.ReadOnly = true;
            this.PathTextBox.Size = new System.Drawing.Size(274, 20);
            this.PathTextBox.TabIndex = 2;
            this.PathTextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
            // 
            // SelectPathButton
            // 
            this.SelectPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectPathButton.Location = new System.Drawing.Point(286, 31);
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
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Путь к файлу:";
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
            // CompressCheckBox
            // 
            this.CompressCheckBox.AutoSize = true;
            this.CompressCheckBox.Checked = true;
            this.CompressCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CompressCheckBox.Location = new System.Drawing.Point(6, 101);
            this.CompressCheckBox.Name = "CompressCheckBox";
            this.CompressCheckBox.Size = new System.Drawing.Size(139, 17);
            this.CompressCheckBox.TabIndex = 6;
            this.CompressCheckBox.Text = "Использовать сжатие";
            this.CompressCheckBox.UseVisualStyleBackColor = true;
            // 
            // ProgressUpload
            // 
            this.ProgressUpload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressUpload.Location = new System.Drawing.Point(6, 124);
            this.ProgressUpload.MarqueeAnimationSpeed = 0;
            this.ProgressUpload.Name = "ProgressUpload";
            this.ProgressUpload.Size = new System.Drawing.Size(224, 23);
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
            this.MainGroupBox.Controls.Add(this.CompressCheckBox);
            this.MainGroupBox.Controls.Add(this.UploadButton);
            this.MainGroupBox.Controls.Add(this.label2);
            this.MainGroupBox.Controls.Add(this.PathTextBox);
            this.MainGroupBox.Controls.Add(this.SelectPathButton);
            this.MainGroupBox.Location = new System.Drawing.Point(5, -2);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Size = new System.Drawing.Size(325, 154);
            this.MainGroupBox.TabIndex = 8;
            this.MainGroupBox.TabStop = false;
            // 
            // UploadFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(334, 155);
            this.Controls.Add(this.MainGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UploadFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Загрузить файл в базу";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button UploadButton;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button SelectPathButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CompressCheckBox;
        private System.Windows.Forms.ProgressBar ProgressUpload;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.ComponentModel.BackgroundWorker BackgroundUploader;
        private System.Windows.Forms.GroupBox MainGroupBox;
    }
}