namespace SongManager
{
    partial class FormProduction
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtProduction = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.bSave = new DevComponents.DotNetBar.ButtonX();
            this.bUpdate = new DevComponents.DotNetBar.ButtonX();
            this.dgvListProduction = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.bNew = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduction)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ផលិតកម្ម";
            // 
            // txtProduction
            // 
            // 
            // 
            // 
            this.txtProduction.Border.Class = "TextBoxBorder";
            this.txtProduction.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProduction.Location = new System.Drawing.Point(96, 40);
            this.txtProduction.Name = "txtProduction";
            this.txtProduction.Size = new System.Drawing.Size(176, 32);
            this.txtProduction.TabIndex = 6;
            this.txtProduction.Enter += new System.EventHandler(this.txtProduction_Enter);
            // 
            // bSave
            // 
            this.bSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.bSave.Image = global::SongManager.Properties.Resources.Save;
            this.bSave.Location = new System.Drawing.Point(25, 88);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(69, 30);
            this.bSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bSave.TabIndex = 1;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.bUpdate.Image = global::SongManager.Properties.Resources.Edit;
            this.bUpdate.Location = new System.Drawing.Point(102, 88);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(69, 30);
            this.bUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bUpdate.TabIndex = 4;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // dgvListProduction
            // 
            this.dgvListProduction.AllowUserToAddRows = false;
            this.dgvListProduction.AllowUserToDeleteRows = false;
            this.dgvListProduction.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListProduction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListProduction.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListProduction.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListProduction.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvListProduction.Location = new System.Drawing.Point(12, 136);
            this.dgvListProduction.Name = "dgvListProduction";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListProduction.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListProduction.RowHeadersVisible = false;
            this.dgvListProduction.RowTemplate.Height = 30;
            this.dgvListProduction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListProduction.Size = new System.Drawing.Size(257, 161);
            this.dgvListProduction.StandardTab = true;
            this.dgvListProduction.TabIndex = 12;
            this.dgvListProduction.Click += new System.EventHandler(this.dgvListProduction_Click);
            // 
            // bNew
            // 
            this.bNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bNew.Cursor = System.Windows.Forms.Cursors.Default;
            this.bNew.Image = global::SongManager.Properties.Resources.New;
            this.bNew.Location = new System.Drawing.Point(179, 88);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(69, 30);
            this.bNew.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bNew.TabIndex = 5;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // FormProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 309);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProduction);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.dgvListProduction);
            this.Controls.Add(this.bNew);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Khmer OS Battambang", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(292, 338);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(292, 338);
            this.Name = "FormProduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Production";
            this.Load += new System.EventHandler(this.FormProduction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtProduction;
        private DevComponents.DotNetBar.ButtonX bNew;
        private DevComponents.DotNetBar.ButtonX bUpdate;
        private DevComponents.DotNetBar.ButtonX bSave;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvListProduction;
    }
}