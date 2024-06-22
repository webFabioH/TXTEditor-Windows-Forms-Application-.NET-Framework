namespace TXTEditor
{
    partial class Form1
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.mFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileNW = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileSA = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mEditDH = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatALW = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mView = new System.Windows.Forms.ToolStripMenuItem();
            this.mViewZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mViewZoomEnlarge = new System.Windows.Forms.ToolStripMenuItem();
            this.mViewZoomReduce = new System.Windows.Forms.ToolStripMenuItem();
            this.mViewZoomRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.mViewStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpVH = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarlabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFile,
            this.mEdit,
            this.mFormat,
            this.mView,
            this.mHelp});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(782, 36);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // mFile
            // 
            this.mFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileNew,
            this.mFileNW,
            this.toolStripSeparator1,
            this.mFileOpen,
            this.mFileSave,
            this.mFileSA,
            this.toolStripSeparator2,
            this.mFileExit});
            this.mFile.Name = "mFile";
            this.mFile.Size = new System.Drawing.Size(57, 32);
            this.mFile.Text = "File";
            // 
            // mFileNew
            // 
            this.mFileNew.Name = "mFileNew";
            this.mFileNew.Size = new System.Drawing.Size(220, 32);
            this.mFileNew.Text = "New";
            this.mFileNew.Click += new System.EventHandler(this.mFileNew_Click);
            // 
            // mFileNW
            // 
            this.mFileNW.Name = "mFileNW";
            this.mFileNW.Size = new System.Drawing.Size(220, 32);
            this.mFileNW.Text = "New Window";
            this.mFileNW.Click += new System.EventHandler(this.mFileNW_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
            // 
            // mFileOpen
            // 
            this.mFileOpen.Name = "mFileOpen";
            this.mFileOpen.Size = new System.Drawing.Size(220, 32);
            this.mFileOpen.Text = "Open";
            this.mFileOpen.Click += new System.EventHandler(this.mFileOpen_Click);
            // 
            // mFileSave
            // 
            this.mFileSave.Name = "mFileSave";
            this.mFileSave.Size = new System.Drawing.Size(220, 32);
            this.mFileSave.Text = "Save";
            this.mFileSave.Click += new System.EventHandler(this.mFileSave_Click);
            // 
            // mFileSA
            // 
            this.mFileSA.Name = "mFileSA";
            this.mFileSA.Size = new System.Drawing.Size(220, 32);
            this.mFileSA.Text = "Save As";
            this.mFileSA.Click += new System.EventHandler(this.mFileSA_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(217, 6);
            // 
            // mFileExit
            // 
            this.mFileExit.Name = "mFileExit";
            this.mFileExit.Size = new System.Drawing.Size(220, 32);
            this.mFileExit.Text = "Exit";
            this.mFileExit.Click += new System.EventHandler(this.mFileExit_Click);
            // 
            // mEdit
            // 
            this.mEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEditUndo,
            this.mEditRedo,
            this.toolStripSeparator3,
            this.mEditCut,
            this.mEditCopy,
            this.mEditPaste,
            this.mEditDelete,
            this.toolStripSeparator4,
            this.mEditDH});
            this.mEdit.Name = "mEdit";
            this.mEdit.Size = new System.Drawing.Size(60, 32);
            this.mEdit.Text = "Edit";
            // 
            // mEditUndo
            // 
            this.mEditUndo.Name = "mEditUndo";
            this.mEditUndo.Size = new System.Drawing.Size(194, 32);
            this.mEditUndo.Text = "Undo";
            // 
            // mEditRedo
            // 
            this.mEditRedo.Name = "mEditRedo";
            this.mEditRedo.Size = new System.Drawing.Size(194, 32);
            this.mEditRedo.Text = "Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(191, 6);
            // 
            // mEditCut
            // 
            this.mEditCut.Name = "mEditCut";
            this.mEditCut.Size = new System.Drawing.Size(194, 32);
            this.mEditCut.Text = "Cut";
            // 
            // mEditCopy
            // 
            this.mEditCopy.Name = "mEditCopy";
            this.mEditCopy.Size = new System.Drawing.Size(194, 32);
            this.mEditCopy.Text = "Copy";
            // 
            // mEditPaste
            // 
            this.mEditPaste.Name = "mEditPaste";
            this.mEditPaste.Size = new System.Drawing.Size(194, 32);
            this.mEditPaste.Text = "Paste";
            // 
            // mEditDelete
            // 
            this.mEditDelete.Name = "mEditDelete";
            this.mEditDelete.Size = new System.Drawing.Size(194, 32);
            this.mEditDelete.Text = "Delete";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(191, 6);
            // 
            // mEditDH
            // 
            this.mEditDH.Name = "mEditDH";
            this.mEditDH.Size = new System.Drawing.Size(194, 32);
            this.mEditDH.Text = "Date/Hour";
            // 
            // mFormat
            // 
            this.mFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFormatALW,
            this.mFormatFont});
            this.mFormat.Name = "mFormat";
            this.mFormat.Size = new System.Drawing.Size(90, 32);
            this.mFormat.Text = "Format";
            // 
            // mFormatALW
            // 
            this.mFormatALW.Name = "mFormatALW";
            this.mFormatALW.Size = new System.Drawing.Size(321, 32);
            this.mFormatALW.Text = "Automatic line wrapping";
            // 
            // mFormatFont
            // 
            this.mFormatFont.Name = "mFormatFont";
            this.mFormatFont.Size = new System.Drawing.Size(321, 32);
            this.mFormatFont.Text = "Font...";
            // 
            // mView
            // 
            this.mView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mViewZoom,
            this.mViewStatusBar});
            this.mView.Name = "mView";
            this.mView.Size = new System.Drawing.Size(70, 32);
            this.mView.Text = "View";
            // 
            // mViewZoom
            // 
            this.mViewZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mViewZoomEnlarge,
            this.mViewZoomReduce,
            this.mViewZoomRestore});
            this.mViewZoom.Name = "mViewZoom";
            this.mViewZoom.Size = new System.Drawing.Size(188, 32);
            this.mViewZoom.Text = "Zoom";
            // 
            // mViewZoomEnlarge
            // 
            this.mViewZoomEnlarge.Name = "mViewZoomEnlarge";
            this.mViewZoomEnlarge.Size = new System.Drawing.Size(166, 32);
            this.mViewZoomEnlarge.Text = "Enlarge";
            // 
            // mViewZoomReduce
            // 
            this.mViewZoomReduce.Name = "mViewZoomReduce";
            this.mViewZoomReduce.Size = new System.Drawing.Size(166, 32);
            this.mViewZoomReduce.Text = "Reduce";
            // 
            // mViewZoomRestore
            // 
            this.mViewZoomRestore.Name = "mViewZoomRestore";
            this.mViewZoomRestore.Size = new System.Drawing.Size(166, 32);
            this.mViewZoomRestore.Text = "Restore";
            // 
            // mViewStatusBar
            // 
            this.mViewStatusBar.Checked = true;
            this.mViewStatusBar.CheckOnClick = true;
            this.mViewStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mViewStatusBar.Name = "mViewStatusBar";
            this.mViewStatusBar.Size = new System.Drawing.Size(188, 32);
            this.mViewStatusBar.Text = "Status Bar";
            // 
            // mHelp
            // 
            this.mHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHelpVH,
            this.mHelpAbout});
            this.mHelp.Name = "mHelp";
            this.mHelp.Size = new System.Drawing.Size(69, 32);
            this.mHelp.Text = "Help";
            // 
            // mHelpVH
            // 
            this.mHelpVH.Name = "mHelpVH";
            this.mHelpVH.Size = new System.Drawing.Size(191, 32);
            this.mHelpVH.Text = "View Help";
            // 
            // mHelpAbout
            // 
            this.mHelpAbout.Name = "mHelpAbout";
            this.mHelpAbout.Size = new System.Drawing.Size(191, 32);
            this.mHelpAbout.Text = "About";
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarlabel});
            this.statusBar.Location = new System.Drawing.Point(0, 527);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(782, 26);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusBarlabel
            // 
            this.statusBarlabel.Name = "statusBarlabel";
            this.statusBarlabel.Size = new System.Drawing.Size(49, 20);
            this.statusBarlabel.Text = "100 %";
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(0, 36);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(782, 491);
            this.txtContent.TabIndex = 2;
            this.txtContent.Text = "";
            this.txtContent.TextChanged += new System.EventHandler(this.txtContent_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TXTEditor";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem mFile;
        private System.Windows.Forms.ToolStripMenuItem mEdit;
        private System.Windows.Forms.ToolStripMenuItem mFormat;
        private System.Windows.Forms.ToolStripMenuItem mView;
        private System.Windows.Forms.ToolStripMenuItem mHelp;
        private System.Windows.Forms.ToolStripMenuItem mFileNew;
        private System.Windows.Forms.ToolStripMenuItem mFileNW;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mFileSave;
        private System.Windows.Forms.ToolStripMenuItem mFileSA;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mFileExit;
        private System.Windows.Forms.ToolStripMenuItem mEditUndo;
        private System.Windows.Forms.ToolStripMenuItem mEditRedo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mEditCut;
        private System.Windows.Forms.ToolStripMenuItem mEditCopy;
        private System.Windows.Forms.ToolStripMenuItem mEditPaste;
        private System.Windows.Forms.ToolStripMenuItem mEditDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mEditDH;
        private System.Windows.Forms.ToolStripMenuItem mFormatALW;
        private System.Windows.Forms.ToolStripMenuItem mFormatFont;
        private System.Windows.Forms.ToolStripMenuItem mViewZoom;
        private System.Windows.Forms.ToolStripMenuItem mViewZoomEnlarge;
        private System.Windows.Forms.ToolStripMenuItem mViewZoomReduce;
        private System.Windows.Forms.ToolStripMenuItem mViewZoomRestore;
        private System.Windows.Forms.ToolStripMenuItem mViewStatusBar;
        private System.Windows.Forms.ToolStripMenuItem mHelpVH;
        private System.Windows.Forms.ToolStripMenuItem mHelpAbout;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusBarlabel;
        private System.Windows.Forms.RichTextBox txtContent;
    }
}

