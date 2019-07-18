using FilesKeeper.DataBase.Interface;
using FilesKeeper.DataBase.Models;
using FilesKeeper.Helpers;
using FilesKeeper.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilesKeeper
{
    public partial class UploadFileForm : Form
    {
        public FileModel NewFile
        {
            get;
            protected set;
        }


        IDBProvider _DBProvider;

        public UploadFileForm(IDBProvider dBProvider)
        {
            _DBProvider = dBProvider;

            InitializeComponent();
            ErrorProvider.SetIconPadding(PathTextBox, -20);
            ErrorProvider.SetIconPadding(NameTextBox, -20);
            BackgroundUploader.DoWork += BackgroundUploader_DoWork;
        }

        private async void BackgroundUploader_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Invoke(new Action(() =>
                {
                    ProgressUpload.MarqueeAnimationSpeed = 100;
                    MainGroupBox.Enabled = false;
                }));

                var bytes = File.ReadAllBytes(PathTextBox.Text);

                var fullSize = bytes.Length;

                if (CompressCheckBox.Checked)
                    bytes = CompressHelper.Compress(bytes);

                var compressedSize = bytes.Length;

                NewFile = await _DBProvider.SaveFile(NameTextBox.Text, Path.GetFileName(PathTextBox.Text), Path.GetExtension(PathTextBox.Text), CompressCheckBox.Checked, compressedSize, fullSize, bytes);
                NewFile.Compressed = CompressCheckBox.Checked;
                NewFile.FullSize = fullSize;
                NewFile.CompressedSize = compressedSize;
            }
            finally
            {
                Invoke(new Action(() =>
                {
                    ProgressUpload.MarqueeAnimationSpeed = 0;
                    MainGroupBox.Enabled = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }));
            }

        }

        private void SelectPathButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;

                PathTextBox.Text = openFileDialog.FileName;
                NameTextBox.Text = Path.GetFileNameWithoutExtension(PathTextBox.Text);
            }
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            BackgroundUploader.RunWorkerAsync();

        }


        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void PathTextBox_TextChanged(object sender, EventArgs e)
        {
            ValidateForm();
        }

        bool ValidateForm()
        {
            bool valid = true;

            ErrorProvider.SetError(PathTextBox, null);
            ErrorProvider.SetError(NameTextBox, null);

            if (string.IsNullOrWhiteSpace(PathTextBox.Text))
            {
                ErrorProvider.SetError(PathTextBox, Resource.PathFileIsEmpty);
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                ErrorProvider.SetError(NameTextBox, Resource.FileNameIsEmpty);
                valid = false;
            }

            return valid;
        }
    }
}
