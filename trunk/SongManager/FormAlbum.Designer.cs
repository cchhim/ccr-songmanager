namespace SongManager
{
    partial class FormAlbum
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bAddSongType = new DevComponents.DotNetBar.ButtonX();
            this.bAddProduction = new DevComponents.DotNetBar.ButtonX();
            this.label4 = new System.Windows.Forms.Label();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.chkSongType = new System.Windows.Forms.CheckBox();
            this.chkProduction = new System.Windows.Forms.CheckBox();
            this.cboProduction = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboSongType = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.bNew = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.dgvAlbum = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.label2 = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.txtAlbumNum = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "ផលិតកម្ម";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "ប្រភេទចំរៀង";
            // 
            // bAddSongType
            // 
            this.bAddSongType.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bAddSongType.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bAddSongType.Image = global::SongManager.Properties.Resources.Add;
            this.bAddSongType.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.bAddSongType.Location = new System.Drawing.Point(362, 96);
            this.bAddSongType.Name = "bAddSongType";
            this.bAddSongType.Size = new System.Drawing.Size(38, 29);
            this.bAddSongType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bAddSongType.TabIndex = 4;
            this.bAddSongType.Click += new System.EventHandler(this.bAddSongType_Click);
            // 
            // bAddProduction
            // 
            this.bAddProduction.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bAddProduction.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bAddProduction.Image = global::SongManager.Properties.Resources.Add;
            this.bAddProduction.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.bAddProduction.Location = new System.Drawing.Point(362, 62);
            this.bAddProduction.Name = "bAddProduction";
            this.bAddProduction.Size = new System.Drawing.Size(38, 29);
            this.bAddProduction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bAddProduction.TabIndex = 2;
            this.bAddProduction.Click += new System.EventHandler(this.bAddProduction_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(19, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "ច្រោះទិន្នន័យ";
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.chkSongType);
            this.groupPanel2.Controls.Add(this.chkProduction);
            this.groupPanel2.Location = new System.Drawing.Point(13, 205);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(389, 53);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.Class = "";
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.Class = "";
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.Class = "";
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 16;
            // 
            // chkSongType
            // 
            this.chkSongType.AutoSize = true;
            this.chkSongType.Location = new System.Drawing.Point(221, 9);
            this.chkSongType.Name = "chkSongType";
            this.chkSongType.Size = new System.Drawing.Size(94, 28);
            this.chkSongType.TabIndex = 9;
            this.chkSongType.Text = "ប្រភេទចំរៀង";
            this.chkSongType.UseVisualStyleBackColor = true;
            // 
            // chkProduction
            // 
            this.chkProduction.AutoSize = true;
            this.chkProduction.Location = new System.Drawing.Point(70, 9);
            this.chkProduction.Name = "chkProduction";
            this.chkProduction.Size = new System.Drawing.Size(79, 28);
            this.chkProduction.TabIndex = 8;
            this.chkProduction.Text = "ផលិតកម្ម";
            this.chkProduction.UseVisualStyleBackColor = true;
            // 
            // cboProduction
            // 
            this.cboProduction.DisplayMember = "Text";
            this.cboProduction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboProduction.FormattingEnabled = true;
            this.cboProduction.ItemHeight = 26;
            this.cboProduction.Location = new System.Drawing.Point(113, 59);
            this.cboProduction.Name = "cboProduction";
            this.cboProduction.Size = new System.Drawing.Size(243, 32);
            this.cboProduction.Sorted = true;
            this.cboProduction.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboProduction.TabIndex = 1;
            this.cboProduction.WatermarkText = "--Select Production--";
            this.cboProduction.SelectedIndexChanged += new System.EventHandler(this.cboProduction_SelectedIndexChanged);
            // 
            // cboSongType
            // 
            this.cboSongType.DisplayMember = "Text";
            this.cboSongType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSongType.FormattingEnabled = true;
            this.cboSongType.ItemHeight = 26;
            this.cboSongType.Location = new System.Drawing.Point(113, 96);
            this.cboSongType.Name = "cboSongType";
            this.cboSongType.Size = new System.Drawing.Size(243, 32);
            this.cboSongType.Sorted = true;
            this.cboSongType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboSongType.TabIndex = 3;
            this.cboSongType.WatermarkText = "--Select--";
            this.cboSongType.SelectedIndexChanged += new System.EventHandler(this.cboSongType_SelectedIndexChanged);
            // 
            // bNew
            // 
            this.bNew.Image = global::SongManager.Properties.Resources.New;
            this.bNew.Location = new System.Drawing.Point(256, 149);
            this.bNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(75, 33);
            this.bNew.TabIndex = 7;
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Enabled = false;
            this.bUpdate.Image = global::SongManager.Properties.Resources.Edit;
            this.bUpdate.Location = new System.Drawing.Point(174, 149);
            this.bUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 33);
            this.bUpdate.TabIndex = 6;
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // dgvAlbum
            // 
            this.dgvAlbum.AllowUserToAddRows = false;
            this.dgvAlbum.AllowUserToDeleteRows = false;
            this.dgvAlbum.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlbum.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlbum.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAlbum.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAlbum.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvAlbum.Location = new System.Drawing.Point(12, 276);
            this.dgvAlbum.Name = "dgvAlbum";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlbum.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAlbum.RowHeadersVisible = false;
            this.dgvAlbum.RowTemplate.Height = 30;
            this.dgvAlbum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlbum.Size = new System.Drawing.Size(395, 215);
            this.dgvAlbum.StandardTab = true;
            this.dgvAlbum.TabIndex = 11;
            this.dgvAlbum.TabStop = false;
            this.dgvAlbum.Click += new System.EventHandler(this.dgvAlbum_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "លេខអាល់ប៊ុម";
            // 
            // bSave
            // 
            this.bSave.Image = global::SongManager.Properties.Resources.Save;
            this.bSave.Location = new System.Drawing.Point(90, 149);
            this.bSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 33);
            this.bSave.TabIndex = 5;
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // txtAlbumNum
            // 
            this.txtAlbumNum.Location = new System.Drawing.Point(113, 18);
            this.txtAlbumNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAlbumNum.Name = "txtAlbumNum";
            this.txtAlbumNum.Size = new System.Drawing.Size(289, 32);
            this.txtAlbumNum.TabIndex = 0;
            this.txtAlbumNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAlbumNum.Enter += new System.EventHandler(this.txtAlbumNum_Enter);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "លេខរៀង";
            this.Column1.Name = "Column1";
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "លេខអាល់ប៊ុម";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ផលិតកម្ម";
            this.Column3.Name = "Column3";
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ប្រភេទ";
            this.Column4.Name = "Column4";
            // 
            // FormAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(419, 503);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.cboProduction);
            this.Controls.Add(this.cboSongType);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bAddProduction);
            this.Controls.Add(this.bAddSongType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAlbumNum);
            this.Controls.Add(this.dgvAlbum);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAlbum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Album";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion   

        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvAlbum;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.TextBox txtAlbumNum;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboProduction;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboSongType;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.CheckBox chkSongType;
        private System.Windows.Forms.CheckBox chkProduction;
        private DevComponents.DotNetBar.ButtonX bAddSongType;
        private DevComponents.DotNetBar.ButtonX bAddProduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;

    }
}

