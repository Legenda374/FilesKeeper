using FilesKeeper.DataBase.Interface;
using FilesKeeper.DataBase.Models;
using FilesKeeper.DataBase.Providers;
using FilesKeeper.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilesKeeper
{
    public partial class FilesKeeperForm : Form
    {
        IDBProvider DataBaseProvider;

        public FilesKeeperForm()
        {
            InitializeComponent();
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            DataBaseProvider = new SQLiteProvider(connectionString);
        }

        private async void FilesKeeperForm_Load(object sender, EventArgs e)
        {
            var files = await DataBaseProvider.GetListFiles();

            foreach (var file in files)
                _AddNewItemToList(file);
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            using (var uploadForm = new UploadFileForm(DataBaseProvider))
                if (uploadForm.ShowDialog() == DialogResult.OK)
                    _AddNewItemToList(uploadForm.NewFile);
        }

        private void _AddNewItemToList(FileModel fileModel)
        {
            ListViewItem row = new ListViewItem(new string[]
                      {
                        fileModel.Id.ToString(),
                        fileModel.Name,
                        fileModel.Extension,
                        fileModel.OriginalName,
                        fileModel.Compressed? Resource.Yes : Resource.No,
                        fileModel.FullSize.ToString(),
                        fileModel.CompressedSize.ToString(),
                      });
            row.Tag = fileModel;
            FilesListView.Items.Add(row);
        }

        private void FilesListView_DoubleClick(object sender, EventArgs e)
        {
            using (var saveForm = new SaveFileForm(DataBaseProvider, (FileModel)FilesListView.SelectedItems[0].Tag))
                saveForm.ShowDialog();
        }
    }
}
