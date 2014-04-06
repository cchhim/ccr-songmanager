namespace SongManager
{
    partial class FormSongType
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListSongType = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtSongType = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.bNew = new DevComponents.DotNetBar.ButtonX();
            this.bUpdate = new DevComponents.DotNetBar.ButtonX();
            this.bSave = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSongType)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListSongType
            // 
            this.dgvListSongType.AllowUserToAddRows = false;
            this.dgvListSongType.AllowUserToDeleteRows = false;
            this.dgvListSongType.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListSongType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListSongType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListSongType.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListSongType.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListSongType.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvListSongType.Location = new System.Drawing.Point(24, 141);
            this.dgvListSongType.Name = "dgvListSongType";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListSongType.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListSongType.RowHeadersVisible = false;
            this.dgvListSongType.RowTemplate.Height = 30;
            this.dgvListSongType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListSongType.Size = new System.Drawing.Size(298, 137);
            this.dgvListSongType.StandardTab = true;
            this.dgvListSongType.TabIndex = 18;
            this.dgvListSongType.Click += new System.EventHandler(this.dgvListSongType_Click);
            // 
            // txtSongType
            // 
            // 
            // 
            // 
            this.txtSongType.Border.Class = "TextBoxBorder";
            this.txtSongType.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSongType.Location = new System.Drawing.Point(121, 26);
            this.txtSongType.Name = "txtSongType";
            this.txtSongType.Size = new System.Drawing.Size(176, 32);
            this.txtSongType.TabIndex = 0;
            // 
            // bNew
            // 
            this.bNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bNew.Cursor = System.Windows.Forms.Cursors.Default;
            this.bNew.Image = global::SongManager.Properties.Resources.New;
            this.bNew.Location = new System.Drawing.Point(208, 87);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(69, 30);
            this.bNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bNew.TabIndex = 16;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.bUpdate.Image = global::SongManager.Properties.Resources.Edit;
            this.bUpdate.Location = new System.Drawing.Point(131, 87);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(69, 30);
            this.bUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bUpdate.TabIndex = 15;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bSave
            // 
            this.bSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.bSave.Image = global::SongManager.Properties.Resources.Save;
            this.bSave.Location = new System.Drawing.Point(54, 87);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(69, 30);
            this.bSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bSave.TabIndex = 14;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "ប្រភេទចំរៀង";
            // 
            // FormSongType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 302);
            this.Controls.Add(this.dgvListSongType);
            this.Controls.Add(this.txtSongType);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSongType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ប្រភេទចំរៀង";
            this.Load += new System.EventHandler(this.FormSongType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSongType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvListSongType;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSongType;
        private DevComponents.DotNetBar.ButtonX bNew;
        private DevComponents.DotNetBar.ButtonX bUpdate;
        private DevComponents.DotNetBar.ButtonX bSave;
        private System.Windows.Forms.Label label1;

    }
}