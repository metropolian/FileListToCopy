namespace FileListToCopy
{
    partial class FormFileList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFileList));
            this.BtOpenText = new System.Windows.Forms.Button();
            this.TxListFile = new System.Windows.Forms.TextBox();
            this.BtCopyToFolder = new System.Windows.Forms.Button();
            this.TxSrcDir = new System.Windows.Forms.TextBox();
            this.TabCont = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TxResults = new System.Windows.Forms.TextBox();
            this.MenuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ChOptionOverwriting = new System.Windows.Forms.ToolStripMenuItem();
            this.ChOptionDontStop = new System.Windows.Forms.ToolStripMenuItem();
            this.BtOptions = new FileListToCopy.MenuButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TabCont.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.MenuOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtOpenText
            // 
            this.BtOpenText.Location = new System.Drawing.Point(424, 10);
            this.BtOpenText.Name = "BtOpenText";
            this.BtOpenText.Size = new System.Drawing.Size(166, 23);
            this.BtOpenText.TabIndex = 0;
            this.BtOpenText.Text = "Add Files from Text";
            this.BtOpenText.UseVisualStyleBackColor = true;
            this.BtOpenText.Click += new System.EventHandler(this.BtOpenText_Click);
            // 
            // TxListFile
            // 
            this.TxListFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxListFile.Location = new System.Drawing.Point(6, 6);
            this.TxListFile.Multiline = true;
            this.TxListFile.Name = "TxListFile";
            this.TxListFile.Size = new System.Drawing.Size(791, 468);
            this.TxListFile.TabIndex = 1;
            // 
            // BtCopyToFolder
            // 
            this.BtCopyToFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtCopyToFolder.Location = new System.Drawing.Point(596, 10);
            this.BtCopyToFolder.Name = "BtCopyToFolder";
            this.BtCopyToFolder.Size = new System.Drawing.Size(111, 23);
            this.BtCopyToFolder.TabIndex = 2;
            this.BtCopyToFolder.Text = "Copy to";
            this.BtCopyToFolder.UseVisualStyleBackColor = true;
            this.BtCopyToFolder.Click += new System.EventHandler(this.BtCopyToFolder_Click);
            // 
            // TxSrcDir
            // 
            this.TxSrcDir.Location = new System.Drawing.Point(127, 10);
            this.TxSrcDir.Name = "TxSrcDir";
            this.TxSrcDir.Size = new System.Drawing.Size(291, 26);
            this.TxSrcDir.TabIndex = 3;
            // 
            // TabCont
            // 
            this.TabCont.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabCont.Controls.Add(this.tabPage1);
            this.TabCont.Controls.Add(this.tabPage2);
            this.TabCont.Location = new System.Drawing.Point(12, 42);
            this.TabCont.Name = "TabCont";
            this.TabCont.SelectedIndex = 0;
            this.TabCont.Size = new System.Drawing.Size(811, 513);
            this.TabCont.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.TxListFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(803, 480);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "File Lists";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TxResults);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(803, 480);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Results";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TxResults
            // 
            this.TxResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxResults.Location = new System.Drawing.Point(6, 6);
            this.TxResults.Multiline = true;
            this.TxResults.Name = "TxResults";
            this.TxResults.Size = new System.Drawing.Size(791, 468);
            this.TxResults.TabIndex = 2;
            // 
            // MenuOptions
            // 
            this.MenuOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChOptionOverwriting,
            this.ChOptionDontStop});
            this.MenuOptions.Name = "MenuOptions";
            this.MenuOptions.Size = new System.Drawing.Size(168, 48);
            // 
            // ChOptionOverwriting
            // 
            this.ChOptionOverwriting.Name = "ChOptionOverwriting";
            this.ChOptionOverwriting.Size = new System.Drawing.Size(167, 22);
            this.ChOptionOverwriting.Text = "Overwrite File";
            this.ChOptionOverwriting.Click += new System.EventHandler(this.ToolStripMenuItemToggle_Click);
            // 
            // ChOptionDontStop
            // 
            this.ChOptionDontStop.Name = "ChOptionDontStop";
            this.ChOptionDontStop.Size = new System.Drawing.Size(167, 22);
            this.ChOptionDontStop.Text = "Don\'t stop if error";
            this.ChOptionDontStop.Click += new System.EventHandler(this.ToolStripMenuItemToggle_Click);
            // 
            // BtOptions
            // 
            this.BtOptions.Location = new System.Drawing.Point(713, 10);
            this.BtOptions.Menu = this.MenuOptions;
            this.BtOptions.Name = "BtOptions";
            this.BtOptions.Size = new System.Drawing.Size(106, 23);
            this.BtOptions.TabIndex = 5;
            this.BtOptions.Text = "Options";
            this.BtOptions.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Source Root:";
            // 
            // FormFileList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(835, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtOptions);
            this.Controls.Add(this.TabCont);
            this.Controls.Add(this.TxSrcDir);
            this.Controls.Add(this.BtCopyToFolder);
            this.Controls.Add(this.BtOpenText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormFileList";
            this.Text = "File list copy tool (by metropolian@live.com)";
            this.TabCont.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.MenuOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtOpenText;
        private System.Windows.Forms.TextBox TxListFile;
        private System.Windows.Forms.Button BtCopyToFolder;
        private System.Windows.Forms.TextBox TxSrcDir;
        private System.Windows.Forms.TabControl TabCont;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox TxResults;
        private MenuButton BtOptions;
        private System.Windows.Forms.ContextMenuStrip MenuOptions;
        private System.Windows.Forms.ToolStripMenuItem ChOptionOverwriting;
        private System.Windows.Forms.ToolStripMenuItem ChOptionDontStop;
        private System.Windows.Forms.Label label1;
    }
}