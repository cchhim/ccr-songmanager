using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SongManager.Presenter.ViewInterface;
using SongManager.Presenter;
using SongManager.Data.DataAccess;

namespace SongManager
{
    public partial class FormCadance : BaseForm, ICadenceView
    {   
        private CadencePresenter presenter;
        public FormCadance()
        {
            InitializeComponent();
            presenter = new CadencePresenter(this,Factory.GetCadanceDao());
            presenter.InitView();
        }

        public Core.Domain.Cadence Cadence
        {
            set { txtCadence.Text = value.CadenceName; }
        }

        public void UpdateValueOn(Core.Domain.Cadence cadence)
        {
            cadence.CadenceName = txtCadence.Text;
            cadence.Modified = DateTime.Now;
            if (cadence.Created == null || cadence.Created == DateTime.MinValue)
                cadence.Created = cadence.Modified;
        }

        public IList<Core.Domain.Cadence> Cadences
        {
            set { dgvListCadence.DataSource = Factory.GetCadanceDao().GetCadences(); }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCadence.Text))
            {
                MessageBox.Show(Helper.MessageNotEmptyCadenceName);
                txtCadence.Focus();
            }
            else
            {   
                presenter.Insert();
                presenter.InitView();
                CleatText();
            }
        }
        private Int32 GetCandenId()
        {
            var id = 0;
            if (dgvListCadence.CurrentRow != null && dgvListCadence.CurrentRow.Selected)
            {
                id = Int32.Parse(dgvListCadence.CurrentRow.Cells["Id"].Value.ToString());
            }
            return id;
        }
        private void CleatText()
        {
            txtCadence.Clear();
            txtCadence.Focus();
        }
        private void FormatListCadence()
        {
            dgvListCadence.Columns["Id"].HeaderText = Helper.HeaderId;
            dgvListCadence.Columns["Id"].Width = 60 ;
            dgvListCadence.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListCadence.Columns["DataField"].HeaderText = Helper.HeaderCadence;
            dgvListCadence.Columns["DataField"].Width = 220;
            
        }
        private void FormCadance_Load(object sender, EventArgs e)
        {
           
            FormatListCadence();
            CleatText();
        }

        private void dgvListCadence_Click(object sender, EventArgs e)
        {
            if (dgvListCadence.CurrentRow == null || !dgvListCadence.CurrentRow.Selected) return;
            txtCadence.Text = dgvListCadence.CurrentRow.Cells[0].Value.ToString();
            bSave.Enabled = false;
            bUpdate.Enabled = true;
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            CleatText();
            bSave.Enabled = true;
            bUpdate.Enabled = false;
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {   
            presenter.Update(GetCandenId());
            presenter.InitView();
            bSave.Enabled = true;
            bUpdate.Enabled = false;
            CleatText();
        }
    }
}
