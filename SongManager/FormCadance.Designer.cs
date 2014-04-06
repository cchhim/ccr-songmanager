namespace SongManager
{
    partial class FormCadance
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
            this.dgvListCadence = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtCadence = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.bNew = new DevComponents.DotNetBar.ButtonX();
            this.bUpdate = new DevComponents.DotNetBar.ButtonX();
            this.bSave = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCadence)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListCadence
            // 
            this.dgvListCadence.AllowUserToAddRows = false;
            this.dgvListCadence.AllowUserToDeleteRows = false;
            this.dgvListCadence.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListCadence.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListCadence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListCadence.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListCadence.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListCadence.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvListCadence.Location = new System.Drawing.Point(12, 128);
            this.dgvListCadence.Name = "dgvListCadence";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListCadence.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListCadence.RowHeadersVisible = false;
            this.dgvListCadence.RowTemplate.Height = 30;
            this.dgvListCadence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListCadence.Size = new System.Drawing.Size(310, 134);
            this.dgvListCadence.StandardTab = true;
            this.dgvListCadence.TabIndex = 12;
            this.dgvListCadence.Click += new System.EventHandler(this.dgvListCadence_Click);
            // 
            // txtCadence
            // 
            // 
            // 
            // 
            this.txtCadence.Border.Class = "TextBoxBorder";
            this.txtCadence.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCadence.Location = new System.Drawing.Point(111, 29);
            this.txtCadence.Name = "txtCadence";
            this.txtCadence.Size = new System.Drawing.Size(176, 32);
            this.txtCadence.TabIndex = 6;
            // 
            // bNew
            // 
            this.bNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bNew.Cursor = System.Windows.Forms.Cursors.Default;
            this.bNew.Image = global::SongManager.Properties.Resources.New;
            this.bNew.Location = new System.Drawing.Point(198, 84);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(69, 27);
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
            this.bUpdate.Location = new System.Drawing.Point(121, 84);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(69, 27);
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
            this.bSave.Location = new System.Drawing.Point(44, 84);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(69, 27);
            this.bSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bSave.TabIndex = 1;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ចង្វាក់";
            // 
            // FormCadance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 274);
            this.Controls.Add(this.dgvListCadence);
            this.Controls.Add(this.txtCadence);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCadance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ចង្វាក់";
            this.Load += new System.EventHandler(this.FormCadance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCadence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvListCadence;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCadence;
        private DevComponents.DotNetBar.ButtonX bNew;
        private DevComponents.DotNetBar.ButtonX bUpdate;
        private DevComponents.DotNetBar.ButtonX bSave;
        private System.Windows.Forms.Label label1;
    }
}