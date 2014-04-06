using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SongManager.Presenter.ViewInterface;
using SongManager.Presenter;
using SongManager.Data.DataAccess;

namespace SongManager
{
    public partial class FormSinger : BaseForm,ISingerView
    {
        private SingerPresenter presenter;
        public FormSinger()
        {
            InitializeComponent();
            presenter = new SingerPresenter(this, Factory.GetSingerDao());
        }      

        private void FormSinger_Load(object sender, EventArgs e)
        {   
            presenter.InitView();
            FormatListSinger();
            ClearText();
        }
        private void FormatListSinger() 
        {
            dgvListSinger.Columns["Id"].HeaderText = Helper.HeaderId;
            dgvListSinger.Columns["Id"].Width = 70;
            dgvListSinger.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListSinger.Columns["DataField"].HeaderText = Helper.HeaderSinger;
            dgvListSinger.Columns["DataField"].Width = 250;
        } 

        public Core.Domain.Singer Singer
        {
            set 
            {
                txtSinger.Text = value.SingerName;                
            }
        }

        public void UpdateValueOn(Core.Domain.Singer singer)
        {
            singer.SingerName = txtSinger.Text;
            singer.Modified = DateTime.Now;
            if (singer.Created == null || singer.Created == DateTime.MinValue)
                singer.Created = singer.Modified;
        }

        public IList<Core.Domain.Singer> Singers
        {
            set 
            {   
                dgvListSinger.DataSource = Factory.GetSingerDao().GetSingers();
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSinger.Text))
            {
                MessageBox.Show(Helper.MessageNotEmptySingerName);
                txtSinger.Focus();
            }
            else {
                presenter.Insert();
                presenter.InitView();
                ClearText();
            }
        }
        private void ClearText() 
        {
            txtSinger.Clear();
            txtSinger.Focus();
        }
        private Int32 GetSingerId() {
            var id = 0;
            if (dgvListSinger.CurrentRow != null && dgvListSinger.CurrentRow.Selected) {
                id = Int32.Parse(dgvListSinger.CurrentRow.Cells["Id"].Value.ToString());
            }
            return id;
        }

        private void dgvListSinger_Click(object sender, EventArgs e)
        {
            if (dgvListSinger.CurrentRow != null && dgvListSinger.CurrentRow.Selected) 
            {
                bSave.Enabled = false;
                bUpdate.Enabled = true;
                txtSinger.Text = dgvListSinger.CurrentRow.Cells["DataField"].Value.ToString();                
            }
        }
        private void bNew_Click(object sender, EventArgs e)
        {
            bUpdate.Enabled = false;
            bSave.Enabled = true;
            ClearText();
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            presenter.Update(GetSingerId());
            presenter.InitView();
            bSave.Enabled = true;
            bUpdate.Enabled = false;
            txtSinger.Clear();
            txtSinger.Focus();
        }

        private void txtSinger_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = Helper.Khmer();
        }
    }
} 
