using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SongManager.Presenter.ViewInterface;
using SongManager.Data.DataAccess;
using SongManager.Presenter;

namespace SongManager
{
    public partial class FormSongType : BaseForm, ISongTypeView
    {
        private SongTypePresenter presenter;      
        public FormSongType()
        {
            InitializeComponent();
            presenter = new SongTypePresenter(this, Factory.GetSongTypeDao());
            presenter.InitView(); 
        }

        private void ClearText()
        {
            txtSongType.Clear();
            txtSongType.Focus();
        }
        private void bSave_Click(object sender, EventArgs e)
        {
            bool isEmpty = string.IsNullOrEmpty(txtSongType.Text);
            if (isEmpty)
            {
                MessageBox.Show(Helper.MessageNotEmptySongTypeName);
                txtSongType.Focus();
            }
            else
            {
                
                presenter.Insert();
                presenter.InitView();
                ClearText();
            }
        }
        public Core.Domain.SongType SongType
        {
            set { txtSongType.Text = value.SongTypeName; }
        }

        public void UpdateValueOn(Core.Domain.SongType songType)
        {
            songType.SongTypeName = txtSongType.Text.Trim();
            songType.Modified = DateTime.Now;
            if (songType.Created == null || songType.Created == DateTime.MinValue)
                songType.Created = songType.Modified;
        }

        public IList<Core.Domain.SongType> SongTypes
        {
            set 
            {
                dgvListSongType.DataSource = Factory.GetSongTypeDao().GetSongTypes() ; 
            }
        }
        private Int32 GetSongTypeId()
        {
            var id = 0;
            if (dgvListSongType.CurrentRow != null && dgvListSongType.CurrentRow.Selected)
            {
                id = Int32.Parse(dgvListSongType.CurrentRow.Cells["Id"].Value.ToString());
            }
            return id;
        }
        private void FormSongType_Load(object sender, EventArgs e)
        {   
            FormatListSongType();
            bUpdate.Enabled = false;
        }
        private void FormatListSongType()
        {
            dgvListSongType.Columns["Id"].HeaderText = Helper.HeaderId;
            dgvListSongType.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListSongType.Columns["Id"].Width = 70;
            dgvListSongType.Columns["SongType"].HeaderText = Helper.HeaderSongType;
            dgvListSongType.Columns["SongType"].Width = 220;

        }
        private void dgvListSongType_Click(object sender, EventArgs e)
        {
            if (dgvListSongType.CurrentRow != null && dgvListSongType.CurrentRow.Selected)
            {
                bUpdate.Enabled = true;
                bSave.Enabled = false;
                txtSongType.Text = dgvListSongType.CurrentRow.Cells["SongType"].Value.ToString();
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {   
            presenter.Update(GetSongTypeId());
            presenter.InitView();
            txtSongType.Clear();
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            ClearText();
            bSave.Enabled = true;
            bUpdate.Enabled = false;
        }

    }
}
