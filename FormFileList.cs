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

namespace FileListToCopy
{
    public partial class FormFileList : Form
    {
        public FormFileList()
        {
            InitializeComponent();
        }

        private string source_dir = "";
        private string dest_dir = "";

        private void BtOpenText_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                FileInfo f = new FileInfo(dlg.FileName);
                source_dir = TxSrcDir.Text = f.DirectoryName;               
                LoadTextFile(f.FullName);

                
            }
            dlg.Dispose();
        }

        private void LoadTextFile(string fname)
        {
            try
            {
                StreamReader reader = new StreamReader(fname);
                String data = reader.ReadToEnd();
                TxListFile.Text = data;
                reader.Close();

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Load File", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void BtCopyToFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.SelectedPath = (dest_dir == "") ? source_dir : dest_dir;
           
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                dest_dir = dlg.SelectedPath;
                CopyToFolder(TxListFile.Text, TxSrcDir.Text, dest_dir);
            }

            dlg.Dispose();
        }

        private void LogResult(string t, string message)
        {
            TxResults.Text += DateTime.Now.ToShortTimeString() + " " + t + ": " + message + "\r\n";
        }

        private void CopyToFolder(string text, string src, string dest)
        {
            try
            {
                bool overwriting = ChOptionOverwriting.Checked;
                bool dontstop = ChOptionDontStop.Checked;

                DirectoryInfo src_dir = new DirectoryInfo(src);
                DirectoryInfo dest_dir = new DirectoryInfo(src);

                TabCont.SelectedIndex = 1;
                LogResult("start", "copy from " + src + " to " + dest_dir);

                StringReader reader = new StringReader(text);
                string line;
                int count = 0;
                int total = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    if ((line == "." || line == ".."))
                        continue;

                    string fname_src = src_dir.FullName + "\\" + line.Trim();
                    string fname_desc = dest + "\\" + line.Trim();
                                        
                    FileInfo fsrc = new FileInfo(fname_src);
                    FileInfo fdest = new FileInfo(fname_desc);


                    if (!fdest.Directory.Exists)
                    {
                        LogResult("create", "directory " + fdest.DirectoryName);
                        fdest.Directory.Create();
                    }

                    if ((!fdest.Exists) || overwriting)
                    {
                        try
                        {
                            if (fdest.Exists)
                            {
                                fdest.Delete();
                                LogResult("overwrite", line);
                            }
                            else
                            {
                                LogResult("copy", line);
                            }
                            fsrc.CopyTo(fdest.FullName);
                            count++;
                        }
                        catch(Exception fex)
                        {
                            if (!dontstop)
                                throw fex;
                        }                        
                    }
                    else
                    {
                        LogResult("skip", line);
                    }
                    total++;
                }

                LogResult("finished", "Copied: " + count.ToString() + " Total: " + total.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ToolStripMenuItemToggle_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).Checked = ! ((ToolStripMenuItem)sender).Checked;
        }
    }
}
