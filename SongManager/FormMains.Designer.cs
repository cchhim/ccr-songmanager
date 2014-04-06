namespace SongManager
{
    partial class FormMains
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMains));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.cboNewSongType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboNewAlbum = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblSearchFound = new System.Windows.Forms.Label();
            this.lblSongCountAll = new System.Windows.Forms.Label();
            this.bPrevious = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.bPause = new System.Windows.Forms.Button();
            this.bPlay = new System.Windows.Forms.Button();
            this.txtSearchSinger = new System.Windows.Forms.TextBox();
            this.txtSearchTitle = new System.Windows.Forms.TextBox();
            this.winPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.txtSearchFileType = new System.Windows.Forms.TextBox();
            this.txtSearchCadance = new System.Windows.Forms.TextBox();
            this.txtSearchProduction = new System.Windows.Forms.TextBox();
            this.dgvPlayList = new System.Windows.Forms.DataGridView();
            this.Column23 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStriptPlayList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsMenuItemRemoveItemPlayList = new System.Windows.Forms.ToolStripMenuItem();
            this.dgListSong = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.conMenuScriptListSong = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsMenuItemPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemAddPlayList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemFileTarget = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuItemSendTo = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bNew = new DevComponents.DotNetBar.ButtonX();
            this.bUpdate = new DevComponents.DotNetBar.ButtonX();
            this.bSave = new DevComponents.DotNetBar.ButtonX();
            this.dgListSongCurrentAlbum = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bBrowse = new DevComponents.DotNetBar.ButtonX();
            this.txtPath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.bAddCadance = new DevComponents.DotNetBar.ButtonX();
            this.bAddAlbum = new DevComponents.DotNetBar.ButtonX();
            this.bAddSongType = new DevComponents.DotNetBar.ButtonX();
            this.bAddProduction = new DevComponents.DotNetBar.ButtonX();
            this.bAddSinger = new DevComponents.DotNetBar.ButtonX();
            this.cboCadance = new System.Windows.Forms.ComboBox();
            this.cboAlbum = new System.Windows.Forms.ComboBox();
            this.cboSongType = new System.Windows.Forms.ComboBox();
            this.cboProduction = new System.Windows.Forms.ComboBox();
            this.cboSinger = new System.Windows.Forms.ComboBox();
            this.txtTitle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayList)).BeginInit();
            this.contextMenuStriptPlayList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListSong)).BeginInit();
            this.conMenuScriptListSong.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListSongCurrentAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1062, 654);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.buttonX1);
            this.tabPage1.Controls.Add(this.cboNewSongType);
            this.tabPage1.Controls.Add(this.cboNewAlbum);
            this.tabPage1.Controls.Add(this.lblSearchFound);
            this.tabPage1.Controls.Add(this.lblSongCountAll);
            this.tabPage1.Controls.Add(this.bPrevious);
            this.tabPage1.Controls.Add(this.bNext);
            this.tabPage1.Controls.Add(this.bPause);
            this.tabPage1.Controls.Add(this.bPlay);
            this.tabPage1.Controls.Add(this.txtSearchSinger);
            this.tabPage1.Controls.Add(this.txtSearchTitle);
            this.tabPage1.Controls.Add(this.winPlayer);
            this.tabPage1.Controls.Add(this.txtSearchFileType);
            this.tabPage1.Controls.Add(this.txtSearchCadance);
            this.tabPage1.Controls.Add(this.txtSearchProduction);
            this.tabPage1.Controls.Add(this.dgvPlayList);
            this.tabPage1.Controls.Add(this.dgListSong);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1054, 617);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "តារាងបទចំរៀង";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::SongManager.Properties.Resources.Add;
            this.buttonX1.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.buttonX1.Location = new System.Drawing.Point(584, 567);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(45, 31);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 12;
            // 
            // cboNewSongType
            // 
            this.cboNewSongType.DisplayMember = "Text";
            this.cboNewSongType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNewSongType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNewSongType.FormattingEnabled = true;
            this.cboNewSongType.ItemHeight = 26;
            this.cboNewSongType.Location = new System.Drawing.Point(810, 6);
            this.cboNewSongType.Name = "cboNewSongType";
            this.cboNewSongType.Size = new System.Drawing.Size(81, 32);
            this.cboNewSongType.Sorted = true;
            this.cboNewSongType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboNewSongType.TabIndex = 11;
            this.cboNewSongType.WatermarkColor = System.Drawing.Color.Silver;
            this.cboNewSongType.WatermarkFont = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNewSongType.WatermarkText = "ប្រភេទចំរៀង";
            this.cboNewSongType.SelectedIndexChanged += new System.EventHandler(this.cboNewSongType_SelectedIndexChanged);
            // 
            // cboNewAlbum
            // 
            this.cboNewAlbum.DisplayMember = "Text";
            this.cboNewAlbum.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboNewAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNewAlbum.FormattingEnabled = true;
            this.cboNewAlbum.ItemHeight = 26;
            this.cboNewAlbum.Location = new System.Drawing.Point(697, 6);
            this.cboNewAlbum.Name = "cboNewAlbum";
            this.cboNewAlbum.Size = new System.Drawing.Size(107, 32);
            this.cboNewAlbum.Sorted = true;
            this.cboNewAlbum.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboNewAlbum.TabIndex = 10;
            this.cboNewAlbum.WatermarkColor = System.Drawing.Color.Silver;
            this.cboNewAlbum.WatermarkFont = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNewAlbum.WatermarkText = "អាល់ប៊ុមថ្មី";
            this.cboNewAlbum.SelectedIndexChanged += new System.EventHandler(this.cboNewAlbum_SelectedIndexChanged);
            // 
            // lblSearchFound
            // 
            this.lblSearchFound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSearchFound.AutoSize = true;
            this.lblSearchFound.Location = new System.Drawing.Point(262, 574);
            this.lblSearchFound.Name = "lblSearchFound";
            this.lblSearchFound.Size = new System.Drawing.Size(89, 24);
            this.lblSearchFound.TabIndex = 9;
            this.lblSearchFound.Text = "រកឃើយចំនួន :";
            // 
            // lblSongCountAll
            // 
            this.lblSongCountAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSongCountAll.AutoSize = true;
            this.lblSongCountAll.Location = new System.Drawing.Point(7, 574);
            this.lblSongCountAll.Name = "lblSongCountAll";
            this.lblSongCountAll.Size = new System.Drawing.Size(93, 24);
            this.lblSongCountAll.TabIndex = 9;
            this.lblSongCountAll.Text = "ចំនួនបទចំរៀង :";
            // 
            // bPrevious
            // 
            this.bPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPrevious.BackColor = System.Drawing.Color.Transparent;
            this.bPrevious.Enabled = false;
            this.bPrevious.Image = global::SongManager.Properties.Resources.Previous16x16;
            this.bPrevious.Location = new System.Drawing.Point(695, 387);
            this.bPrevious.Name = "bPrevious";
            this.bPrevious.Size = new System.Drawing.Size(28, 28);
            this.bPrevious.TabIndex = 8;
            this.bPrevious.UseVisualStyleBackColor = false;
            this.bPrevious.Click += new System.EventHandler(this.bPrevious_Click);
            // 
            // bNext
            // 
            this.bNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bNext.BackColor = System.Drawing.Color.Transparent;
            this.bNext.Enabled = false;
            this.bNext.Image = global::SongManager.Properties.Resources.Next16x16;
            this.bNext.Location = new System.Drawing.Point(722, 387);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(28, 28);
            this.bNext.TabIndex = 7;
            this.bNext.UseVisualStyleBackColor = false;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // bPause
            // 
            this.bPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPause.BackColor = System.Drawing.Color.Transparent;
            this.bPause.Enabled = false;
            this.bPause.Image = global::SongManager.Properties.Resources.Pause16x16;
            this.bPause.Location = new System.Drawing.Point(668, 387);
            this.bPause.Name = "bPause";
            this.bPause.Size = new System.Drawing.Size(28, 28);
            this.bPause.TabIndex = 6;
            this.bPause.UseVisualStyleBackColor = false;
            this.bPause.Click += new System.EventHandler(this.bPause_Click);
            // 
            // bPlay
            // 
            this.bPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bPlay.BackColor = System.Drawing.Color.Transparent;
            this.bPlay.Enabled = false;
            this.bPlay.Image = global::SongManager.Properties.Resources.Play16x16;
            this.bPlay.Location = new System.Drawing.Point(640, 387);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(28, 28);
            this.bPlay.TabIndex = 5;
            this.bPlay.UseVisualStyleBackColor = false;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // txtSearchSinger
            // 
            this.txtSearchSinger.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSinger.ForeColor = System.Drawing.Color.Silver;
            this.txtSearchSinger.Location = new System.Drawing.Point(183, 6);
            this.txtSearchSinger.Name = "txtSearchSinger";
            this.txtSearchSinger.Size = new System.Drawing.Size(148, 32);
            this.txtSearchSinger.TabIndex = 4;
            this.txtSearchSinger.Text = "ស្វែងរកអ្នកចំរៀង";
            this.txtSearchSinger.Click += new System.EventHandler(this.txtSearchSinger_Click);
            this.txtSearchSinger.Enter += new System.EventHandler(this.txtSearchSinger_Enter);
            this.txtSearchSinger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchSinger_KeyPress);
            this.txtSearchSinger.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchSinger_KeyUp);
            // 
            // txtSearchTitle
            // 
            this.txtSearchTitle.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTitle.ForeColor = System.Drawing.Color.Silver;
            this.txtSearchTitle.Location = new System.Drawing.Point(7, 6);
            this.txtSearchTitle.Name = "txtSearchTitle";
            this.txtSearchTitle.Size = new System.Drawing.Size(170, 32);
            this.txtSearchTitle.TabIndex = 3;
            this.txtSearchTitle.Text = "ស្វែងរកចំណងជើងបទចំរៀង";
            this.txtSearchTitle.Click += new System.EventHandler(this.txtSearchTitle_Click);
            this.txtSearchTitle.Enter += new System.EventHandler(this.txtSearchTitle_Enter);
            this.txtSearchTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchTitle_KeyPress);
            this.txtSearchTitle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // winPlayer
            // 
            this.winPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.winPlayer.Enabled = true;
            this.winPlayer.Location = new System.Drawing.Point(635, 46);
            this.winPlayer.Name = "winPlayer";
            this.winPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("winPlayer.OcxState")));
            this.winPlayer.Size = new System.Drawing.Size(416, 374);
            this.winPlayer.TabIndex = 0;
            // 
            // txtSearchFileType
            // 
            this.txtSearchFileType.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFileType.ForeColor = System.Drawing.Color.Silver;
            this.txtSearchFileType.Location = new System.Drawing.Point(566, 7);
            this.txtSearchFileType.Name = "txtSearchFileType";
            this.txtSearchFileType.Size = new System.Drawing.Size(125, 32);
            this.txtSearchFileType.TabIndex = 4;
            this.txtSearchFileType.Text = "ស្វែងរកប្រភេទឯកសារ";
            this.txtSearchFileType.Click += new System.EventHandler(this.txtSearchFileType_Click);
            this.txtSearchFileType.Enter += new System.EventHandler(this.txtSearchFileType_Enter);
            this.txtSearchFileType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchFileType_KeyPress);
            this.txtSearchFileType.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchFileType_KeyUp);
            // 
            // txtSearchCadance
            // 
            this.txtSearchCadance.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCadance.ForeColor = System.Drawing.Color.Silver;
            this.txtSearchCadance.Location = new System.Drawing.Point(461, 6);
            this.txtSearchCadance.Name = "txtSearchCadance";
            this.txtSearchCadance.Size = new System.Drawing.Size(97, 32);
            this.txtSearchCadance.TabIndex = 4;
            this.txtSearchCadance.Text = "ស្វែងរកចង្វាក់";
            this.txtSearchCadance.Click += new System.EventHandler(this.textBox1_Click);
            this.txtSearchCadance.Enter += new System.EventHandler(this.txtSearchCadance_Enter);
            this.txtSearchCadance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchCadance_KeyPress);
            this.txtSearchCadance.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchCadance_KeyUp);
            // 
            // txtSearchProduction
            // 
            this.txtSearchProduction.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduction.ForeColor = System.Drawing.Color.Silver;
            this.txtSearchProduction.Location = new System.Drawing.Point(338, 6);
            this.txtSearchProduction.Name = "txtSearchProduction";
            this.txtSearchProduction.Size = new System.Drawing.Size(117, 32);
            this.txtSearchProduction.TabIndex = 4;
            this.txtSearchProduction.Text = "ស្វែងរកផលិតកម្ម";
            this.txtSearchProduction.Click += new System.EventHandler(this.txtSearchProduction_Click);
            this.txtSearchProduction.Enter += new System.EventHandler(this.txtSearchProduction_Enter);
            this.txtSearchProduction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchProduction_KeyPress);
            this.txtSearchProduction.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchProduction_KeyUp);
            // 
            // dgvPlayList
            // 
            this.dgvPlayList.AllowUserToAddRows = false;
            this.dgvPlayList.AllowUserToDeleteRows = false;
            this.dgvPlayList.AllowUserToResizeColumns = false;
            this.dgvPlayList.AllowUserToResizeRows = false;
            this.dgvPlayList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlayList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlayList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlayList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column23,
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column22});
            this.dgvPlayList.ContextMenuStrip = this.contextMenuStriptPlayList;
            this.dgvPlayList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPlayList.Location = new System.Drawing.Point(635, 426);
            this.dgvPlayList.Name = "dgvPlayList";
            this.dgvPlayList.RowHeadersVisible = false;
            this.dgvPlayList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlayList.Size = new System.Drawing.Size(418, 183);
            this.dgvPlayList.TabIndex = 2;
            this.dgvPlayList.Click += new System.EventHandler(this.dgvPlayList_Click);
            // 
            // Column23
            // 
            this.Column23.HeaderText = "កំពុងលេង";
            this.Column23.Name = "Column23";
            // 
            // Column19
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column19.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column19.HeaderText = "លេខ​រៀង";
            this.Column19.Name = "Column19";
            // 
            // Column20
            // 
            this.Column20.HeaderText = "ចំណងជើង";
            this.Column20.Name = "Column20";
            // 
            // Column21
            // 
            this.Column21.HeaderText = "អ្នកចំរៀង";
            this.Column21.Name = "Column21";
            // 
            // Column22
            // 
            this.Column22.HeaderText = "Column22";
            this.Column22.Name = "Column22";
            this.Column22.Visible = false;
            // 
            // contextMenuStriptPlayList
            // 
            this.contextMenuStriptPlayList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemRemoveItemPlayList});
            this.contextMenuStriptPlayList.Name = "contextMenuStriptPlayList";
            this.contextMenuStriptPlayList.Size = new System.Drawing.Size(195, 32);
            // 
            // tsMenuItemRemoveItemPlayList
            // 
            this.tsMenuItemRemoveItemPlayList.Enabled = false;
            this.tsMenuItemRemoveItemPlayList.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsMenuItemRemoveItemPlayList.Image = global::SongManager.Properties.Resources.Remove;
            this.tsMenuItemRemoveItemPlayList.Name = "tsMenuItemRemoveItemPlayList";
            this.tsMenuItemRemoveItemPlayList.Size = new System.Drawing.Size(194, 28);
            this.tsMenuItemRemoveItemPlayList.Text = "លុបចេញពីតារាងលេង";
            this.tsMenuItemRemoveItemPlayList.Click += new System.EventHandler(this.tsMenuItemRemoveItemPlayList_Click);
            // 
            // dgListSong
            // 
            this.dgListSong.AllowDrop = true;
            this.dgListSong.AllowUserToAddRows = false;
            this.dgListSong.AllowUserToDeleteRows = false;
            this.dgListSong.AllowUserToResizeColumns = false;
            this.dgListSong.AllowUserToResizeRows = false;
            this.dgListSong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgListSong.BackgroundColor = System.Drawing.Color.White;
            this.dgListSong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListSong.ContextMenuStrip = this.conMenuScriptListSong;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgListSong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgListSong.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgListSong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgListSong.Location = new System.Drawing.Point(7, 44);
            this.dgListSong.Name = "dgListSong";
            this.dgListSong.RowHeadersVisible = false;
            this.dgListSong.RowTemplate.Height = 30;
            this.dgListSong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListSong.Size = new System.Drawing.Size(622, 515);
            this.dgListSong.TabIndex = 1;
            this.dgListSong.Click += new System.EventHandler(this.dgListSong_Click);
            this.dgListSong.DoubleClick += new System.EventHandler(this.dgListSong_DoubleClick);
            // 
            // conMenuScriptListSong
            // 
            this.conMenuScriptListSong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemPlay,
            this.tsMenuItemAddPlayList,
            this.tsMenuItemFileTarget,
            this.tsMenuItemSendTo});
            this.conMenuScriptListSong.Name = "conMenuScriptListSong";
            this.conMenuScriptListSong.Size = new System.Drawing.Size(241, 116);
            // 
            // tsMenuItemPlay
            // 
            this.tsMenuItemPlay.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsMenuItemPlay.Image = global::SongManager.Properties.Resources.play;
            this.tsMenuItemPlay.Name = "tsMenuItemPlay";
            this.tsMenuItemPlay.Size = new System.Drawing.Size(240, 28);
            this.tsMenuItemPlay.Text = "លេងបទចំរៀង";
            this.tsMenuItemPlay.Click += new System.EventHandler(this.tsMenuItemPlay_Click);
            // 
            // tsMenuItemAddPlayList
            // 
            this.tsMenuItemAddPlayList.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsMenuItemAddPlayList.Image = global::SongManager.Properties.Resources.PlayList;
            this.tsMenuItemAddPlayList.Name = "tsMenuItemAddPlayList";
            this.tsMenuItemAddPlayList.Size = new System.Drawing.Size(240, 28);
            this.tsMenuItemAddPlayList.Text = "បញ្ចូលទៅ តារាងលេងបទចំរៀង";
            this.tsMenuItemAddPlayList.Click += new System.EventHandler(this.tsMenuItemAddPlayList_Click);
            // 
            // tsMenuItemFileTarget
            // 
            this.tsMenuItemFileTarget.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsMenuItemFileTarget.Name = "tsMenuItemFileTarget";
            this.tsMenuItemFileTarget.Size = new System.Drawing.Size(240, 28);
            this.tsMenuItemFileTarget.Text = "ទៅកាន់ទីតាំងបទចំរៀង";
            this.tsMenuItemFileTarget.Click += new System.EventHandler(this.tsMenuItemFileTarget_Click);
            // 
            // tsMenuItemSendTo
            // 
            this.tsMenuItemSendTo.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsMenuItemSendTo.Name = "tsMenuItemSendTo";
            this.tsMenuItemSendTo.Size = new System.Drawing.Size(240, 28);
            this.tsMenuItemSendTo.Text = "ផ្ញើរទៅកាន់";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bNew);
            this.tabPage2.Controls.Add(this.bUpdate);
            this.tabPage2.Controls.Add(this.bSave);
            this.tabPage2.Controls.Add(this.dgListSongCurrentAlbum);
            this.tabPage2.Controls.Add(this.bBrowse);
            this.tabPage2.Controls.Add(this.txtPath);
            this.tabPage2.Controls.Add(this.bAddCadance);
            this.tabPage2.Controls.Add(this.bAddAlbum);
            this.tabPage2.Controls.Add(this.bAddSongType);
            this.tabPage2.Controls.Add(this.bAddProduction);
            this.tabPage2.Controls.Add(this.bAddSinger);
            this.tabPage2.Controls.Add(this.cboCadance);
            this.tabPage2.Controls.Add(this.cboAlbum);
            this.tabPage2.Controls.Add(this.cboSongType);
            this.tabPage2.Controls.Add(this.cboProduction);
            this.tabPage2.Controls.Add(this.cboSinger);
            this.tabPage2.Controls.Add(this.txtTitle);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1054, 617);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "បញ្ជូលបទចំរៀង";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bNew
            // 
            this.bNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bNew.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bNew.Cursor = System.Windows.Forms.Cursors.Default;
            this.bNew.Image = global::SongManager.Properties.Resources.New;
            this.bNew.Location = new System.Drawing.Point(345, 297);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(69, 30);
            this.bNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bNew.TabIndex = 14;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.bUpdate.Enabled = false;
            this.bUpdate.Image = global::SongManager.Properties.Resources.Edit;
            this.bUpdate.Location = new System.Drawing.Point(268, 297);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(69, 30);
            this.bUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bUpdate.TabIndex = 13;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bSave
            // 
            this.bSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.bSave.Image = global::SongManager.Properties.Resources.Save;
            this.bSave.Location = new System.Drawing.Point(191, 297);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(69, 30);
            this.bSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bSave.TabIndex = 12;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // dgListSongCurrentAlbum
            // 
            this.dgListSongCurrentAlbum.AllowUserToAddRows = false;
            this.dgListSongCurrentAlbum.AllowUserToDeleteRows = false;
            this.dgListSongCurrentAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgListSongCurrentAlbum.BackgroundColor = System.Drawing.Color.White;
            this.dgListSongCurrentAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListSongCurrentAlbum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column17});
            this.dgListSongCurrentAlbum.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgListSongCurrentAlbum.Location = new System.Drawing.Point(75, 333);
            this.dgListSongCurrentAlbum.Name = "dgListSongCurrentAlbum";
            this.dgListSongCurrentAlbum.RowHeadersVisible = false;
            this.dgListSongCurrentAlbum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListSongCurrentAlbum.Size = new System.Drawing.Size(885, 219);
            this.dgListSongCurrentAlbum.TabIndex = 7;
            this.dgListSongCurrentAlbum.TabStop = false;
            this.dgListSongCurrentAlbum.Click += new System.EventHandler(this.dgListSongCurrentAlbum_Click);
            // 
            // Column1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.HeaderText = "លេខរៀង";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ចំណងជើង";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "អ្នកចំរៀង";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ផលិតកម្ម";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ប្រភេទ";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "លេខអ៊ាល់ប៊ុម";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ចង្វាក់";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ប្រភេទឯកសារ";
            this.Column8.Name = "Column8";
            // 
            // Column17
            // 
            this.Column17.HeaderText = "ទីតាំង";
            this.Column17.Name = "Column17";
            // 
            // bBrowse
            // 
            this.bBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bBrowse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bBrowse.Image = global::SongManager.Properties.Resources.Add;
            this.bBrowse.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.bBrowse.Location = new System.Drawing.Point(462, 250);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(45, 31);
            this.bBrowse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bBrowse.TabIndex = 11;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtPath.Border.Class = "TextBoxBorder";
            this.txtPath.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPath.Location = new System.Drawing.Point(206, 249);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(250, 32);
            this.txtPath.TabIndex = 5;
            this.txtPath.TabStop = false;
            // 
            // bAddCadance
            // 
            this.bAddCadance.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bAddCadance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bAddCadance.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bAddCadance.Image = global::SongManager.Properties.Resources.Add;
            this.bAddCadance.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.bAddCadance.Location = new System.Drawing.Point(462, 212);
            this.bAddCadance.Name = "bAddCadance";
            this.bAddCadance.Size = new System.Drawing.Size(45, 31);
            this.bAddCadance.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bAddCadance.TabIndex = 10;
            this.bAddCadance.Click += new System.EventHandler(this.bAddCadance_Click);
            // 
            // bAddAlbum
            // 
            this.bAddAlbum.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bAddAlbum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bAddAlbum.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bAddAlbum.Image = global::SongManager.Properties.Resources.Add;
            this.bAddAlbum.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.bAddAlbum.Location = new System.Drawing.Point(462, 172);
            this.bAddAlbum.Name = "bAddAlbum";
            this.bAddAlbum.Size = new System.Drawing.Size(45, 31);
            this.bAddAlbum.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bAddAlbum.TabIndex = 8;
            this.bAddAlbum.Click += new System.EventHandler(this.bAddAlbum_Click);
            // 
            // bAddSongType
            // 
            this.bAddSongType.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bAddSongType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bAddSongType.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bAddSongType.Image = global::SongManager.Properties.Resources.Add;
            this.bAddSongType.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.bAddSongType.Location = new System.Drawing.Point(462, 134);
            this.bAddSongType.Name = "bAddSongType";
            this.bAddSongType.Size = new System.Drawing.Size(45, 31);
            this.bAddSongType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bAddSongType.TabIndex = 6;
            this.bAddSongType.Click += new System.EventHandler(this.bAddSongType_Click);
            // 
            // bAddProduction
            // 
            this.bAddProduction.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bAddProduction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bAddProduction.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bAddProduction.Image = global::SongManager.Properties.Resources.Add;
            this.bAddProduction.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.bAddProduction.Location = new System.Drawing.Point(462, 96);
            this.bAddProduction.Name = "bAddProduction";
            this.bAddProduction.Size = new System.Drawing.Size(45, 31);
            this.bAddProduction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bAddProduction.TabIndex = 4;
            this.bAddProduction.Click += new System.EventHandler(this.AddProductionClick);
            // 
            // bAddSinger
            // 
            this.bAddSinger.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bAddSinger.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bAddSinger.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bAddSinger.Image = global::SongManager.Properties.Resources.Add;
            this.bAddSinger.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.bAddSinger.Location = new System.Drawing.Point(462, 58);
            this.bAddSinger.Name = "bAddSinger";
            this.bAddSinger.Size = new System.Drawing.Size(45, 31);
            this.bAddSinger.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bAddSinger.TabIndex = 2;
            this.bAddSinger.Click += new System.EventHandler(this.AddSingerClick);
            // 
            // cboCadance
            // 
            this.cboCadance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboCadance.DropDownHeight = 200;
            this.cboCadance.FormattingEnabled = true;
            this.cboCadance.IntegralHeight = false;
            this.cboCadance.Location = new System.Drawing.Point(206, 211);
            this.cboCadance.Name = "cboCadance";
            this.cboCadance.Size = new System.Drawing.Size(250, 32);
            this.cboCadance.Sorted = true;
            this.cboCadance.TabIndex = 9;
            // 
            // cboAlbum
            // 
            this.cboAlbum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboAlbum.DropDownHeight = 200;
            this.cboAlbum.FormattingEnabled = true;
            this.cboAlbum.IntegralHeight = false;
            this.cboAlbum.Location = new System.Drawing.Point(206, 171);
            this.cboAlbum.Name = "cboAlbum";
            this.cboAlbum.Size = new System.Drawing.Size(250, 32);
            this.cboAlbum.Sorted = true;
            this.cboAlbum.TabIndex = 7;
            this.cboAlbum.SelectedIndexChanged += new System.EventHandler(this.cboAlbum_SelectedIndexChanged);
            // 
            // cboSongType
            // 
            this.cboSongType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboSongType.DropDownHeight = 200;
            this.cboSongType.FormattingEnabled = true;
            this.cboSongType.IntegralHeight = false;
            this.cboSongType.Location = new System.Drawing.Point(206, 133);
            this.cboSongType.Name = "cboSongType";
            this.cboSongType.Size = new System.Drawing.Size(250, 32);
            this.cboSongType.Sorted = true;
            this.cboSongType.TabIndex = 5;
            this.cboSongType.SelectedIndexChanged += new System.EventHandler(this.cboSongType_SelectedIndexChanged);
            // 
            // cboProduction
            // 
            this.cboProduction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboProduction.DropDownHeight = 200;
            this.cboProduction.FormattingEnabled = true;
            this.cboProduction.IntegralHeight = false;
            this.cboProduction.Location = new System.Drawing.Point(206, 95);
            this.cboProduction.Name = "cboProduction";
            this.cboProduction.Size = new System.Drawing.Size(250, 32);
            this.cboProduction.Sorted = true;
            this.cboProduction.TabIndex = 3;
            // 
            // cboSinger
            // 
            this.cboSinger.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboSinger.DropDownHeight = 200;
            this.cboSinger.FormattingEnabled = true;
            this.cboSinger.IntegralHeight = false;
            this.cboSinger.Location = new System.Drawing.Point(206, 57);
            this.cboSinger.Name = "cboSinger";
            this.cboSinger.Size = new System.Drawing.Size(250, 32);
            this.cboSinger.Sorted = true;
            this.cboSinger.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtTitle.Border.Class = "TextBoxBorder";
            this.txtTitle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTitle.Location = new System.Drawing.Point(206, 19);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(301, 32);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Enter += new System.EventHandler(this.txtTitle_Enter);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "ទីតាំង";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "អាល់ប៊ុម";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "ចង្វាក់";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "ប្រភេទ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "អ្នកចំរៀង";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "ផលិតកម្ម";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ចំណងជើងបទចំរៀង";
            // 
            // FormMains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 713);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1020, 751);
            this.Name = "FormMains";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Song Manager 2.0";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.winPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayList)).EndInit();
            this.contextMenuStriptPlayList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListSong)).EndInit();
            this.conMenuScriptListSong.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListSongCurrentAlbum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtSearchSinger;
        private System.Windows.Forms.TextBox txtSearchTitle;
        private AxWMPLib.AxWindowsMediaPlayer winPlayer;
        private System.Windows.Forms.TextBox txtSearchProduction;
        private System.Windows.Forms.DataGridView dgvPlayList;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgListSong;
        private System.Windows.Forms.TabPage tabPage2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboProduction;
        private DevComponents.DotNetBar.ButtonX bAddSongType;
        private DevComponents.DotNetBar.ButtonX bAddProduction;
        private DevComponents.DotNetBar.ButtonX bAddSinger;
        private System.Windows.Forms.ComboBox cboSongType;
        private DevComponents.DotNetBar.ButtonX bBrowse;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPath;
        private DevComponents.DotNetBar.ButtonX bAddCadance;
        private DevComponents.DotNetBar.ButtonX bAddAlbum;
        private System.Windows.Forms.ComboBox cboCadance;
        private System.Windows.Forms.ComboBox cboAlbum;
        private System.Windows.Forms.DataGridView dgListSongCurrentAlbum;
        private DevComponents.DotNetBar.ButtonX bNew;
        private DevComponents.DotNetBar.ButtonX bUpdate;
        private DevComponents.DotNetBar.ButtonX bSave;
        private System.Windows.Forms.ComboBox cboSinger;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.ContextMenuStrip conMenuScriptListSong;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemPlay;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemAddPlayList;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemFileTarget;
        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.Button bPause;
        private System.Windows.Forms.Button bPrevious;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemSendTo;
        private System.Windows.Forms.Label lblSearchFound;
        private System.Windows.Forms.Label lblSongCountAll;
        private System.Windows.Forms.TextBox txtSearchFileType;
        private System.Windows.Forms.TextBox txtSearchCadance;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
        private System.Windows.Forms.ContextMenuStrip contextMenuStriptPlayList;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemRemoveItemPlayList;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboNewAlbum;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboNewSongType;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}