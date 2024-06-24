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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.mViewToolBar = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpVH = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.ToolBarNew = new System.Windows.Forms.ToolStripButton();
            this.ToolBarOpen = new System.Windows.Forms.ToolStripButton();
            this.ToolBarSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolBarFont = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolBarPlus = new System.Windows.Forms.ToolStripButton();
            this.ToolBarMinus = new System.Windows.Forms.ToolStripButton();
            this.ToolBarReset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolBarHelp = new System.Windows.Forms.ToolStripButton();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.ToolBar.SuspendLayout();
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
            this.mFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
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
            this.mFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mFileNew.Size = new System.Drawing.Size(348, 32);
            this.mFileNew.Text = "New";
            this.mFileNew.Click += new System.EventHandler(this.mFileNew_Click);
            // 
            // mFileNW
            // 
            this.mFileNW.Name = "mFileNW";
            this.mFileNW.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.mFileNW.Size = new System.Drawing.Size(348, 32);
            this.mFileNW.Text = "New Window";
            this.mFileNW.Click += new System.EventHandler(this.mFileNW_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(345, 6);
            // 
            // mFileOpen
            // 
            this.mFileOpen.Name = "mFileOpen";
            this.mFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mFileOpen.Size = new System.Drawing.Size(348, 32);
            this.mFileOpen.Text = "Open";
            this.mFileOpen.Click += new System.EventHandler(this.mFileOpen_Click);
            // 
            // mFileSave
            // 
            this.mFileSave.Name = "mFileSave";
            this.mFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mFileSave.Size = new System.Drawing.Size(348, 32);
            this.mFileSave.Text = "Save";
            this.mFileSave.Click += new System.EventHandler(this.mFileSave_Click);
            // 
            // mFileSA
            // 
            this.mFileSA.Name = "mFileSA";
            this.mFileSA.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mFileSA.Size = new System.Drawing.Size(348, 32);
            this.mFileSA.Text = "Save As";
            this.mFileSA.Click += new System.EventHandler(this.mFileSA_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(345, 6);
            // 
            // mFileExit
            // 
            this.mFileExit.Name = "mFileExit";
            this.mFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mFileExit.Size = new System.Drawing.Size(348, 32);
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
            this.mEditUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mEditUndo.Size = new System.Drawing.Size(269, 32);
            this.mEditUndo.Text = "Undo";
            this.mEditUndo.Click += new System.EventHandler(this.mEditUndo_Click);
            // 
            // mEditRedo
            // 
            this.mEditRedo.Name = "mEditRedo";
            this.mEditRedo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.mEditRedo.Size = new System.Drawing.Size(269, 32);
            this.mEditRedo.Text = "Redo";
            this.mEditRedo.Click += new System.EventHandler(this.mEditRedo_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(266, 6);
            // 
            // mEditCut
            // 
            this.mEditCut.Name = "mEditCut";
            this.mEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mEditCut.Size = new System.Drawing.Size(269, 32);
            this.mEditCut.Text = "Cut";
            this.mEditCut.Click += new System.EventHandler(this.mEditCut_Click);
            // 
            // mEditCopy
            // 
            this.mEditCopy.Name = "mEditCopy";
            this.mEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mEditCopy.Size = new System.Drawing.Size(269, 32);
            this.mEditCopy.Text = "Copy";
            this.mEditCopy.Click += new System.EventHandler(this.mEditCopy_Click);
            // 
            // mEditPaste
            // 
            this.mEditPaste.Name = "mEditPaste";
            this.mEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mEditPaste.Size = new System.Drawing.Size(269, 32);
            this.mEditPaste.Text = "Paste";
            this.mEditPaste.Click += new System.EventHandler(this.mEditPaste_Click);
            // 
            // mEditDelete
            // 
            this.mEditDelete.Name = "mEditDelete";
            this.mEditDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mEditDelete.Size = new System.Drawing.Size(269, 32);
            this.mEditDelete.Text = "Delete";
            this.mEditDelete.Click += new System.EventHandler(this.mEditDelete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(266, 6);
            // 
            // mEditDH
            // 
            this.mEditDH.Name = "mEditDH";
            this.mEditDH.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mEditDH.Size = new System.Drawing.Size(269, 32);
            this.mEditDH.Text = "Date/Hour";
            this.mEditDH.Click += new System.EventHandler(this.mEditDH_Click);
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
            this.mFormatALW.CheckOnClick = true;
            this.mFormatALW.Name = "mFormatALW";
            this.mFormatALW.Size = new System.Drawing.Size(321, 32);
            this.mFormatALW.Text = "Automatic line wrapping";
            this.mFormatALW.Click += new System.EventHandler(this.mFormatALW_Click);
            // 
            // mFormatFont
            // 
            this.mFormatFont.Name = "mFormatFont";
            this.mFormatFont.Size = new System.Drawing.Size(321, 32);
            this.mFormatFont.Text = "Font...";
            this.mFormatFont.Click += new System.EventHandler(this.mFormatFont_Click);
            // 
            // mView
            // 
            this.mView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mViewZoom,
            this.mViewStatusBar,
            this.mViewToolBar});
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
            this.mViewZoomEnlarge.ShortcutKeyDisplayString = "Crtl + Plus";
            this.mViewZoomEnlarge.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.mViewZoomEnlarge.Size = new System.Drawing.Size(289, 32);
            this.mViewZoomEnlarge.Text = "Enlarge";
            this.mViewZoomEnlarge.Click += new System.EventHandler(this.mViewZoomEnlarge_Click);
            // 
            // mViewZoomReduce
            // 
            this.mViewZoomReduce.Name = "mViewZoomReduce";
            this.mViewZoomReduce.ShortcutKeyDisplayString = "Ctrl + Minus";
            this.mViewZoomReduce.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.mViewZoomReduce.Size = new System.Drawing.Size(289, 32);
            this.mViewZoomReduce.Text = "Reduce";
            this.mViewZoomReduce.Click += new System.EventHandler(this.mViewZoomReduce_Click);
            // 
            // mViewZoomRestore
            // 
            this.mViewZoomRestore.Name = "mViewZoomRestore";
            this.mViewZoomRestore.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.mViewZoomRestore.Size = new System.Drawing.Size(289, 32);
            this.mViewZoomRestore.Text = "Restore";
            this.mViewZoomRestore.Click += new System.EventHandler(this.mViewZoomRestore_Click);
            // 
            // mViewStatusBar
            // 
            this.mViewStatusBar.Checked = true;
            this.mViewStatusBar.CheckOnClick = true;
            this.mViewStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mViewStatusBar.Name = "mViewStatusBar";
            this.mViewStatusBar.Size = new System.Drawing.Size(188, 32);
            this.mViewStatusBar.Text = "Status Bar";
            this.mViewStatusBar.Click += new System.EventHandler(this.mViewStatusBar_Click);
            // 
            // mViewToolBar
            // 
            this.mViewToolBar.Checked = true;
            this.mViewToolBar.CheckOnClick = true;
            this.mViewToolBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mViewToolBar.Name = "mViewToolBar";
            this.mViewToolBar.Size = new System.Drawing.Size(188, 32);
            this.mViewToolBar.Text = "Tool Bar";
            this.mViewToolBar.Click += new System.EventHandler(this.mViewToolBar_Click);
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
            this.mHelpVH.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mHelpVH.Size = new System.Drawing.Size(224, 32);
            this.mHelpVH.Text = "View Help";
            this.mHelpVH.Click += new System.EventHandler(this.mHelpVH_Click);
            // 
            // mHelpAbout
            // 
            this.mHelpAbout.Name = "mHelpAbout";
            this.mHelpAbout.Size = new System.Drawing.Size(224, 32);
            this.mHelpAbout.Text = "About";
            this.mHelpAbout.Click += new System.EventHandler(this.mHelpAbout_Click);
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 527);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(782, 26);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "100%";
            // 
            // statusBarLabel
            // 
            this.statusBarLabel.Name = "statusBarLabel";
            this.statusBarLabel.Size = new System.Drawing.Size(49, 20);
            this.statusBarLabel.Text = "100 %";
            // 
            // ToolBar
            // 
            this.ToolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBarNew,
            this.ToolBarOpen,
            this.ToolBarSave,
            this.toolStripSeparator5,
            this.ToolBarFont,
            this.toolStripSeparator6,
            this.ToolBarPlus,
            this.ToolBarMinus,
            this.ToolBarReset,
            this.toolStripSeparator7,
            this.ToolBarHelp});
            this.ToolBar.Location = new System.Drawing.Point(0, 36);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(782, 30);
            this.ToolBar.TabIndex = 2;
            this.ToolBar.Text = "toolStrip1";
            // 
            // ToolBarNew
            // 
            this.ToolBarNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolBarNew.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolBarNew.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ToolBarNew.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarNew.Image")));
            this.ToolBarNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarNew.Name = "ToolBarNew";
            this.ToolBarNew.Size = new System.Drawing.Size(29, 27);
            this.ToolBarNew.Text = "N";
            this.ToolBarNew.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.ToolBarNew.ToolTipText = "New";
            this.ToolBarNew.Click += new System.EventHandler(this.mFileNew_Click);
            // 
            // ToolBarOpen
            // 
            this.ToolBarOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolBarOpen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolBarOpen.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ToolBarOpen.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarOpen.Image")));
            this.ToolBarOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarOpen.Name = "ToolBarOpen";
            this.ToolBarOpen.Size = new System.Drawing.Size(29, 27);
            this.ToolBarOpen.Text = "O";
            this.ToolBarOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.ToolBarOpen.ToolTipText = "Open";
            this.ToolBarOpen.Click += new System.EventHandler(this.mFileOpen_Click);
            // 
            // ToolBarSave
            // 
            this.ToolBarSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolBarSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolBarSave.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ToolBarSave.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarSave.Image")));
            this.ToolBarSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarSave.Name = "ToolBarSave";
            this.ToolBarSave.Size = new System.Drawing.Size(29, 27);
            this.ToolBarSave.Text = "S";
            this.ToolBarSave.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.ToolBarSave.ToolTipText = "Save";
            this.ToolBarSave.Click += new System.EventHandler(this.mFileSave_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 30);
            // 
            // ToolBarFont
            // 
            this.ToolBarFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolBarFont.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolBarFont.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ToolBarFont.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarFont.Image")));
            this.ToolBarFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarFont.Name = "ToolBarFont";
            this.ToolBarFont.Size = new System.Drawing.Size(29, 27);
            this.ToolBarFont.Text = "A";
            this.ToolBarFont.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.ToolBarFont.ToolTipText = "Format Font";
            this.ToolBarFont.Click += new System.EventHandler(this.mFormatFont_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 30);
            // 
            // ToolBarPlus
            // 
            this.ToolBarPlus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolBarPlus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolBarPlus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ToolBarPlus.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarPlus.Image")));
            this.ToolBarPlus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarPlus.Name = "ToolBarPlus";
            this.ToolBarPlus.Size = new System.Drawing.Size(29, 27);
            this.ToolBarPlus.Text = "+";
            this.ToolBarPlus.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.ToolBarPlus.ToolTipText = "Zoom +";
            this.ToolBarPlus.Click += new System.EventHandler(this.mViewZoomEnlarge_Click);
            // 
            // ToolBarMinus
            // 
            this.ToolBarMinus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolBarMinus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolBarMinus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ToolBarMinus.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarMinus.Image")));
            this.ToolBarMinus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarMinus.Name = "ToolBarMinus";
            this.ToolBarMinus.Size = new System.Drawing.Size(29, 27);
            this.ToolBarMinus.Text = "-";
            this.ToolBarMinus.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.ToolBarMinus.ToolTipText = "Zoom -";
            this.ToolBarMinus.Click += new System.EventHandler(this.mViewZoomReduce_Click);
            // 
            // ToolBarReset
            // 
            this.ToolBarReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolBarReset.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolBarReset.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ToolBarReset.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarReset.Image")));
            this.ToolBarReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarReset.Name = "ToolBarReset";
            this.ToolBarReset.Size = new System.Drawing.Size(29, 27);
            this.ToolBarReset.Text = "R";
            this.ToolBarReset.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.ToolBarReset.ToolTipText = "Zoom reset ";
            this.ToolBarReset.Click += new System.EventHandler(this.mViewZoomRestore_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 30);
            // 
            // ToolBarHelp
            // 
            this.ToolBarHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolBarHelp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolBarHelp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ToolBarHelp.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarHelp.Image")));
            this.ToolBarHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarHelp.Name = "ToolBarHelp";
            this.ToolBarHelp.Size = new System.Drawing.Size(29, 27);
            this.ToolBarHelp.Text = "H";
            this.ToolBarHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.ToolBarHelp.ToolTipText = "Help";
            this.ToolBarHelp.Click += new System.EventHandler(this.mHelpVH_Click);
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(0, 66);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(782, 461);
            this.txtContent.TabIndex = 4;
            this.txtContent.Text = "";
            this.txtContent.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TXTEditor";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
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
        private System.Windows.Forms.ToolStripStatusLabel statusBarLabel;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripButton ToolBarNew;
        private System.Windows.Forms.ToolStripButton ToolBarOpen;
        private System.Windows.Forms.ToolStripButton ToolBarSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton ToolBarFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton ToolBarPlus;
        private System.Windows.Forms.ToolStripButton ToolBarMinus;
        private System.Windows.Forms.ToolStripButton ToolBarReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton ToolBarHelp;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.ToolStripMenuItem mViewToolBar;
    }
}

