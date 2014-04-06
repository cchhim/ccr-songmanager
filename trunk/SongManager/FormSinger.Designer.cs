namespace SongManager
{
    partial class FormSinger
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
            this.dgvListSinger = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtSinger = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.bNew = new DevComponents.DotNetBar.ButtonX();
            this.bUpdate = new DevComponents.DotNetBar.ButtonX();
            this.bSave = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSinger)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListSinger
            // 
            this.dgvListSinger.AllowUserToAddRows = false;
            this.dgvListSinger.AllowUserToDeleteRows = false;
            this.dgvListSinger.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListSinger.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListSinger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListSinger.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListSinger.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListSinger.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvListSinger.Location = new System.Drawing.Point(12, 147);
            this.dgvListSinger.Name = "dgvListSinger";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListSinger.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListSinger.RowHeadersVisible = false;
            this.dgvListSinger.RowTemplate.Height = 30;
            this.dgvListSinger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListSinger.Size = new System.Drawing.Size(302, 172);
            this.dgvListSinger.StandardTab = true;
            this.dgvListSinger.TabIndex = 12;
            this.dgvListSinger.Click += new System.EventHandler(this.dgvListSinger_Click);
            // 
            // txtSinger
            // 
            // 
            // 
            // 
            this.txtSinger.Border.Class = "TextBoxBorder";
            this.txtSinger.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSinger.Location = new System.Drawing.Point(83, 33);
            this.txtSinger.Name = "txtSinger";
            this.txtSinger.Size = new System.Drawing.Size(219, 32);
            this.txtSinger.TabIndex = 6;
            this.txtSinger.Enter += new System.EventHandler(this.txtSinger_Enter);
            // 
            // bNew
            // 
            this.bNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bNew.Cursor = System.Windows.Forms.Cursors.Default;
            this.bNew.Image = global::SongManager.Properties.Resources.New;
            this.bNew.Location = new System.Drawing.Point(200, 94);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(69, 30);
            this.bNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bNew.TabIndex = 5;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.bUpdate.Enabled = false;
            this.bUpdate.Image = global::SongManager.Properties.Resources.Edit;
            this.bUpdate.Location = new System.Drawing.Point(123, 94);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(69, 30);
            this.bUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bUpdate.TabIndex = 4;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bSave
            // 
            this.bSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.bSave.Image = global::SongManager.Properties.Resources.Save;
            this.bSave.Location = new System.Drawing.Point(46, 94);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(69, 30);
            this.bSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bSave.TabIndex = 1;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "អ្នកចំរៀង";
            // 
            // FormSinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 331);
            this.Controls.Add(this.dgvListSinger);
            this.Controls.Add(this.txtSinger);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSinger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "អ្នកចំរៀង";
            this.Load += new System.EventHandler(this.FormSinger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListSinger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvListSinger;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSinger;
        private DevComponents.DotNetBar.ButtonX bNew;
        private DevComponents.DotNetBar.ButtonX bUpdate;
        private DevComponents.DotNetBar.ButtonX bSave;
        private System.Windows.Forms.Label label1;


    }
}