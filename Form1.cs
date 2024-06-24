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
            mFileSave.Enabled = true;
            Text = Application.ProductName;
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
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open...";
            dialog.Filter = "rich text file|*.rtf|text|*.txt|all|*.*";

            DialogResult result = dialog.ShowDialog();
            if (result != DialogResult.Cancel && result != DialogResult.Abort)
            {
                if (File.Exists(dialog.FileName))
                {
                    FileInfo file = new FileInfo(dialog.FileName);
                    Text = Application.ProductName + " - " + file.Name;

                    Manager.FolderPath = file.DirectoryName + "\\";
                    Manager.FileName = file.Name.Remove(file.Name.LastIndexOf("."));
                    Manager.FileExt = file.Extension;

                    StreamReader stream = null;

                    try
                    {
                        stream = new StreamReader(file.FullName, true);
                        txtContent.Text = stream.ReadToEnd();
                        mFileSave.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unsupported file format. \n" + ex.Message);
                    }
                    finally
                    {
                        stream.Close();
                    }
                }
            }
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
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Save As...";
            dialog.Filter = "rich text file |*.rtf|text|*.txt|all|*.*";
            dialog.CheckFileExists = false;
            dialog.CheckPathExists = true;

            var result = dialog.ShowDialog();

            if (result != DialogResult.Cancel && result != DialogResult.Abort)
            {
                SaveFile(dialog.FileName);
            }
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

                Text = Application.ProductName + " - " + file.Name;

                mFileSave.Enabled = false;
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

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            mFileSave.Enabled = true;
        }

        #endregion

        #region Menu Edit
        private void mEditUndo_Click(object sender, EventArgs e)
        {
            txtContent.Undo();
        }

        private void mEditRedo_Click(object sender, EventArgs e)
        {
            txtContent.Redo();
        }

        private void mEditCut_Click(object sender, EventArgs e)
        {
            txtContent.Cut();
        }

        private void mEditCopy_Click(object sender, EventArgs e)
        {
            txtContent.Copy();
        }

        private void mEditPaste_Click(object sender, EventArgs e)
        {
            txtContent.Paste();
        }

        private void mEditDelete_Click(object sender, EventArgs e)
        {
            txtContent.Text = txtContent.Text.Remove(txtContent.SelectionStart, txtContent.SelectedText.Length);
        }

        private void mEditDH_Click(object sender, EventArgs e)
        {
            int index = txtContent.SelectionStart;
            string datehour = DateTime.Now.ToString();

            if (index == txtContent.Text.Length)
            {
                txtContent.Text = txtContent.Text + datehour;
                txtContent.SelectionStart = index + datehour.Length;
                return;
            }

            string temp = "";
            for (int i = 0; i < txtContent.Text.Length; i++)
            {
                if (i == txtContent.SelectionStart)
                {
                    temp += datehour;
                    temp += txtContent.Text[i];
                }
                else
                {
                    temp += txtContent.Text[i];
                }
            }

            txtContent.Text = temp;
            txtContent.SelectionStart = index + datehour.Length;
        }

        #endregion

        #region Menu Format
        private void mFormatALW_Click(object sender, EventArgs e)
        {
            txtContent.WordWrap = mFormatALW.Checked;
        }

        private void mFormatFont_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowColor = true;
            font.ShowEffects = true;

            font.Font = txtContent.Font;
            font.Color = txtContent.ForeColor;

            DialogResult result = font.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtContent.Font = font.Font;
                txtContent.ForeColor = font.Color;  
            }
        }
        #endregion

        #region Menu View
        private void mViewZoomEnlarge_Click(object sender, EventArgs e)
        {
            txtContent.ZoomFactor += 0.10f;
            RefreshStatusBar(txtContent.ZoomFactor);
        }

        private void mViewZoomReduce_Click(object sender, EventArgs e)
        {
            txtContent.ZoomFactor -= 0.10f;
            RefreshStatusBar(txtContent.ZoomFactor);
        }

        private void mViewZoomRestore_Click(object sender, EventArgs e)
        {
            txtContent.ZoomFactor = 1;
            RefreshStatusBar(txtContent.ZoomFactor);
        }

        private void mViewStatusBar_Click(object sender, EventArgs e)
        {
            statusBar.Visible = mViewStatusBar.Checked;
        }

        private void RefreshStatusBar(float zoom)
        {
            statusBarLabel.Text = $"{Math.Round(zoom * 100)}%";
        }
        #endregion

        #region Menu Help
        private void mHelpVH_Click(object sender, EventArgs e)
        {
            FormHelp f = new FormHelp();
            f.Show(); 
        }

        private void mHelpAbout_Click(object sender, EventArgs e)
        {
            FormAbout fs = new FormAbout();
            fs.Show();
        }
        #endregion
    }
}
