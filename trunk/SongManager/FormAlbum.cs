using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SongManager.Core.Domain;
using SongManager.Core.Model;
using SongManager.Data.DataAccess;
using SongManager.Presenter;
using SongManager.Presenter.ViewInterface;

namespace SongManager
{
    public partial class FormAlbum : BaseForm, IAlbumView
    {
        public FormAlbum()
        {
            InitializeComponent();
            var presenter = new AlbumPresenter(this, Factory.GetAlbumDao());
            presenter.InitView();
        }
        private void Form1_Load(object sender, EventArgs e)
        {   
            Utils.SetDataToComboBox(cboProduction, Factory.GetProductionDao().GetProductions());
            Utils.SetDataToComboBox(cboSongType, Factory.GetSongTypeDao().GetSongTypes());
            DisplayListAlbum(Factory.GetAlbumDao().GetAlbums());
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            bool isValidAlbum = new Regex(Helper.ValidNumber).IsMatch(txtAlbumNum.Text);
            if (String.IsNullOrEmpty(txtAlbumNum.Text))
            {
                MessageBox.Show(Helper.MessageNotEmpyAlumNum);
                txtAlbumNum.Focus();
            }
            else if (!isValidAlbum)
            {
                MessageBox.Show(Helper.MessageInvalidAlbumNum);
                txtAlbumNum.Clear();
                txtAlbumNum.Focus();
            }
            else if (string.IsNullOrEmpty(cboProduction.Text))
            {
                MessageBox.Show(Helper.MessageNotEmptyProduction);
                cboProduction.Focus();
            }
            else if (string.IsNullOrEmpty(cboSongType.Text))
            {
                MessageBox.Show(Helper.MessageNotEmptySongTypeName);
                cboSongType.Focus();
            }
            else
            {
                var presenter = new AlbumPresenter(this, new AlbumDao());
                presenter.Insert();
                presenter.InitView();
                ClearText();
            }
        }

        public Album Album
        {
            set
            {
                txtAlbumNum.Text = value.AlbumNum.ToString(CultureInfo.InvariantCulture);
                cboProduction.Text = value.Production.ProductionName;
                cboSongType.Text = value.SongType.SongTypeName;
            }
        }

        public void UpdateValueOn(Album album)
        {
            album.AlbumNum = int.Parse(txtAlbumNum.Text);
            album.Production = GetProduction();
            album.SongType = GetSongType();
            album.Modified = DateTime.Now;
            if (album.Created == null || album.Created == DateTime.MinValue)
                album.Created = album.Modified;
        }

        private SongType GetSongType() 
        {
            var songTypeModel = (ComboBoxModel)cboSongType.SelectedItem;
            return Factory.GetSongTypeDao().GetById(songTypeModel.Id);
        }

        private Production GetProduction() 
        {
            var productionModel = (ComboBoxModel) cboProduction.SelectedItem;
            return Factory.GetProductionDao().GetById(productionModel.Id);
        }

        public IList<Album> Albums
        {
            set
            {
             //   var albums = new BindingList<Album>(value);
               // DisplayListAlbum(albums);
            }
        }

        private void DisplayListAlbum(IEnumerable<AlbumListModel> albums)
        {
            if (albums != null)
            {
                var i = 0;
                if (dgvAlbum.RowCount > 0)
                    dgvAlbum.Rows.Clear();

                foreach (var album in albums)
                {
                    var row = new DataGridViewRow();
                    row.CreateCells(dgvAlbum);
                    row.Cells[0].Value = album.Id;
                    row.Cells[1].Value = album.AlbumNum;
                    row.Cells[2].Value = album.Production;
                    row.Cells[3].Value = album.Type;
                    dgvAlbum.Rows.Add(row);
                    dgvAlbum.Rows[i].Height = 30;
                    i++;
                }
            }
        }

        private void dgvAlbum_Click(object sender, EventArgs e)
        {
            if (dgvAlbum.CurrentRow != null && dgvAlbum.CurrentRow.Selected)
            {
                bUpdate.Enabled = true;
                bSave.Enabled = false;
                txtAlbumNum.Text = dgvAlbum.CurrentRow.Cells[1].Value.ToString();
                cboProduction.Text = dgvAlbum.CurrentRow.Cells[2].Value.ToString();
                cboSongType.Text = dgvAlbum.CurrentRow.Cells[3].Value.ToString();
            }
        }
        private void ClearText()
        {
            txtAlbumNum.Clear();
            cboProduction.Text = "";
            cboSongType.Text = "";
            bUpdate.Enabled = false;
            bSave.Enabled = true;
            txtAlbumNum.Focus();
        }
        private Int32 GetAlbumId()
        {
            var id = 0;
            if (dgvAlbum.CurrentRow != null && dgvAlbum.CurrentRow.Selected)
            {
                id = Int32.Parse(dgvAlbum.CurrentRow.Cells[0].Value.ToString());
            }
            return id;
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            var presenter = new AlbumPresenter(this, Factory.GetAlbumDao());
            presenter.Update(GetAlbumId());
            presenter.InitView();
            ClearText();
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            ClearText();
            DisplayListAlbum(Factory.GetAlbumDao().GetAlbums());
        }

        private void cboProduction_SelectedIndexChanged(object sender, EventArgs e)
        {
            IList<AlbumListModel> albums = null;
            ComboBoxModel production;
            if (chkProduction.Checked && chkSongType.Checked == false)
            {
                production = (ComboBoxModel)cboProduction.SelectedItem;
                albums = Factory.GetAlbumDao().GetAlbumsByProductionId(production.Id);
            }
            else if (chkProduction.Checked && chkSongType.Checked && !(String.IsNullOrEmpty(cboSongType.Text)))
            {
                production = (ComboBoxModel)cboProduction.SelectedItem;
                var type = (ComboBoxModel)cboSongType.SelectedItem;
                albums = Factory.GetAlbumDao().GetAlbumsByProductionIdAndSongTypeId(production.Id, type.Id);
            }
            DisplayListAlbum(albums);
        }
        private void cboSongType_SelectedIndexChanged(object sender, EventArgs e)
        {
            IList<AlbumListModel> albums = null;
            ComboBoxModel type = null;
            if (chkSongType.Checked && chkProduction.Checked == false)
            {
                type = (ComboBoxModel)cboSongType.SelectedItem;
                albums = Factory.GetAlbumDao().GetAlbumsBySongTypeId(type.Id);

            }
            else if (chkProduction.Checked && chkSongType.Checked && !(String.IsNullOrEmpty(cboProduction.Text)))
            {
                var production = (ComboBoxModel)cboProduction.SelectedItem;
                type = (ComboBoxModel)cboSongType.SelectedItem;
                albums = Factory.GetAlbumDao().GetAlbumsByProductionIdAndSongTypeId(production.Id, type.Id);
            }
            DisplayListAlbum(albums);
        }

        private void bAddProduction_Click(object sender, EventArgs e)
        {
            new FormProduction().ShowDialog();
            Utils.SetDataToComboBox(cboProduction,Factory.GetProductionDao().GetProductions());
        }

        private void bAddSongType_Click(object sender, EventArgs e)
        {
            new FormSongType().ShowDialog();
            Utils.SetDataToComboBox(cboSongType, Factory.GetSongTypeDao().GetSongTypes());
        }

        private void txtAlbumNum_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = Helper.English();
        }
    }
}
