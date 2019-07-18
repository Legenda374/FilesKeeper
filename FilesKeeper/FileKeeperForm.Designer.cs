namespace FilesKeeper
{
    partial class FilesKeeperForm
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
            this.FilesListView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OriginalName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Extension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.Compressed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FullSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.СompressedSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // FilesListView
            // 
            this.FilesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.FileName,
            this.OriginalName,
            this.Extension,
            this.Compressed,
            this.FullSize,
            this.СompressedSize});
            this.FilesListView.FullRowSelect = true;
            this.FilesListView.GridLines = true;
            this.FilesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.FilesListView.HideSelection = false;
            this.FilesListView.Location = new System.Drawing.Point(12, 36);
            this.FilesListView.MultiSelect = false;
            this.FilesListView.Name = "FilesListView";
            this.FilesListView.Size = new System.Drawing.Size(850, 388);
            this.FilesListView.TabIndex = 2;
            this.FilesListView.UseCompatibleStateImageBehavior = false;
            this.FilesListView.View = System.Windows.Forms.View.Details;
            this.FilesListView.DoubleClick += new System.EventHandler(this.FilesListView_DoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 56;
            // 
            // FileName
            // 
            this.FileName.Text = "Имя";
            this.FileName.Width = 192;
            // 
            // OriginalName
            // 
            this.OriginalName.DisplayIndex = 3;
            this.OriginalName.Text = "Оригинальное имя файла";
            this.OriginalName.Width = 183;
            // 
            // Extension
            // 
            this.Extension.Text = "Расширение файла";
            this.Extension.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "File keeper";
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(737, 430);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(125, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Добавить файл";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Compressed
            // 
            this.Compressed.Text = "Сжат";
            this.Compressed.Width = 41;
            // 
            // FullSize
            // 
            this.FullSize.Text = "Полный размер";
            this.FullSize.Width = 97;
            // 
            // СompressedSize
            // 
            this.СompressedSize.Text = "Размер после сжатия";
            this.СompressedSize.Width = 131;
            // 
            // FilesKeeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 465);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilesListView);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FilesKeeperForm";
            this.Text = "FilesKeeperForm";
            this.Load += new System.EventHandler(this.FilesKeeperForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
          private System.Windows.Forms.ListView FilesListView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ColumnHeader Extension;
        private System.Windows.Forms.ColumnHeader OriginalName;
        private System.Windows.Forms.ColumnHeader Compressed;
        private System.Windows.Forms.ColumnHeader FullSize;
        private System.Windows.Forms.ColumnHeader СompressedSize;
    }
}