using FilesKeeper.DataBase.Interface;
using FilesKeeper.DataBase.Models;
using FilesKeeper.Helpers;
using FilesKeeper.Resources;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace FilesKeeper
{
    public partial class SaveFileForm : Form
    {


        FileModel _FileToSave;
        IDBProvider _DBProvider;

        public SaveFileForm(IDBProvider dBProvider, FileModel saveFile)
        {
            InitializeComponent();

            _DBProvider = dBProvider;
            _FileToSave = saveFile;

            ErrorProvider.SetIconPadding(PathTextBox, -20);
            ErrorProvider.SetIconPadding(NameTextBox, -20);
            NameTextBox.Text = _FileToSave.Name;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
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


                _FileToSave = await _DBProvider.GetFile(_FileToSave.Id);

                if (_FileToSave.Compressed)
                    _FileToSave.ByteArray = CompressHelper.Decompress(_FileToSave.ByteArray);

                using (var fs = new FileStream(Path.Combine(PathTextBox.Text, NameTextBox.Text + _FileToSave.Extension), FileMode.Create, FileAccess.Write))
                {
                    fs.Write(_FileToSave.ByteArray, 0, _FileToSave.ByteArray.Length);
                }
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
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                PathTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
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
