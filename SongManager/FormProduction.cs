using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SongManager.Presenter.ViewInterface;
using SongManager.Presenter;
using SongManager.Data.DataAccess;

namespace SongManager
{
    public partial class FormProduction : BaseForm, IProductionView
    {
        private ProductionPresenter presenter;
        public FormProduction()
        {
            InitializeComponent();
            presenter = new ProductionPresenter(this, Factory.GetProductionDao());
        }
        private void ClearText()
        {
            txtProduction.Clear();
            txtProduction.Focus();
            bSave.Enabled = true;
            bUpdate.Enabled = false;
        }

        private void FormProduction_Load(object sender, EventArgs e)
        {
            presenter.InitView();
            FormatListProduction();
            bUpdate.Enabled = false;
            ClearText();
        }
        public void FormatListProduction()
        {
            dgvListProduction.Columns["Id"].HeaderText = Helper.HeaderId;
            dgvListProduction.Columns["Id"].Width = 60;
            dgvListProduction.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvListProduction.Columns["DataField"].HeaderText = Helper.HeaderProduction;
            dgvListProduction.Columns["DataField"].Width = 170;
        }
        public Core.Domain.Production Production
        {
            set { txtProduction.Text = value.ProductionName; }
        }

        public void UpdateValueOn(Core.Domain.Production production)
        {
            production.ProductionName = txtProduction.Text;
            production.Modified = DateTime.Now;
            if (production.Created == null || production.Created == DateTime.MinValue)
                production.Created = production.Modified;

        }

        public IList<Core.Domain.Production> Productions
        {
            set
            {
                dgvListProduction.DataSource = Factory.GetProductionDao().GetProductions();
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            bool isEmpty = string.IsNullOrEmpty(txtProduction.Text);
            if (isEmpty)
            {
                MessageBox.Show(Helper.MessageNotEmptyProduction);
                ClearText();
            }
            else
            {
                presenter.Insert();
                presenter.InitView();
                ClearText();
            }
        }
        private Int32 GetPrdouctionId()
        {
            int id = 0;
            if (dgvListProduction.CurrentRow != null && dgvListProduction.CurrentRow.Selected)
            {
                id = Int32.Parse(dgvListProduction.CurrentRow.Cells["Id"].Value.ToString());
            }
            return id;
        }

        private void dgvListProduction_Click(object sender, EventArgs e)
        {
            if (dgvListProduction.CurrentRow != null && dgvListProduction.CurrentRow.Selected)
            {
                bSave.Enabled = false;
                bUpdate.Enabled = true;
                txtProduction.Text = dgvListProduction.CurrentRow.Cells["DataField"].Value.ToString();
            }
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            presenter.Update(GetPrdouctionId());
            presenter.InitView();
            bSave.Enabled = true;
            bUpdate.Enabled = false;
        }

        private void txtProduction_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = Helper.English();
        }
    }
}
