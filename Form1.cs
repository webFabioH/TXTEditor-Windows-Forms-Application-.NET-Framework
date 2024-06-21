using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TXTEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Menu File
        private void mFileNew_Click(object sender, EventArgs e)
        {
            txtContent.Clear(); 
        }

        private void mFileNW_Click(object sender, EventArgs e)
        {
            //Form1 f = new Form1();
            //f.Show();

            Thread t = new Thread(() => Application.Run(new Form1()));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        private void mFileOpen_Click(object sender, EventArgs e)
        {

        }

        private void mFileSave_Click(object sender, EventArgs e)
        {
            if (File.Exists(Manager.FilePath))
            {
                SaveFile(Manager.FilePath);
            }
            else
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Title = "Save...";
                dialog.Filter = "rich text file |*.rtf|text|*.txt|all|*.*";
                dialog.CheckFileExists = false;
                dialog.CheckPathExists = true;
                
                var result  = dialog.ShowDialog();

                if (result != DialogResult.Cancel && result != DialogResult.Abort)
                {
                    SaveFile(dialog.FileName);
                }
            }
        }

        private void mFileSA_Click(object sender, EventArgs e)
        {

        }

        private void SaveFile(string path)
        {
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter(path, false);
                writer.Write(txtContent.Text);

                FileInfo file = new FileInfo(path);
                Manager.FolderPath = file.DirectoryName + "\\";
                Manager.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
                Manager.FileExt = file.Extension;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Saving File: \n" + ex.Message);
            }
            finally
            {
                writer.Close();
            }

        }

        private void mFileExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you really want to leave?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

    }
}
