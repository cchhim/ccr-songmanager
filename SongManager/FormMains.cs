using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using SongManager.Core.Domain;
using SongManager.Core.Model;
using SongManager.Data.DataAccess;
using SongManager.Presenter;
using SongManager.Presenter.ViewInterface;
namespace SongManager
{
    public partial class FormMains : BaseForm, ISongView
    {

        private string separator = ConfigurationManager.AppSettings["Separater"];
        #region Private Variable
        private const string FoundSong = "រកឃើញចំនួន: ";
        private const string SongCount = "ចំនួនបទចំរៀងៈ​​​ ";
        private const string Track = " បទ";
        private PlayList playlist;
        private DataTable table;
        private SongPresenter presenter;
        private readonly List<string> _listSong = new List<string>();
        private readonly List<ToolStripMenuItem> listDrive = new List<ToolStripMenuItem>();
        private DataView dataview;
        private string musicPath = ConfigurationManager.AppSettings["MusicPath"];
        #endregion

        #region Private Method

        private void GetListToGrid()
        {   
            table = ConvertToDataTable(Factory.GetSongDao().GetListSongModel());
            dgListSong.DataSource = table;
            dataview = new DataView(table);
            FormatListSong();
        }

        private DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }

        private void FormatListSong()
        {
            for (var i = 0; i < dgListSong.ColumnCount - 1; i++)
            {
                dgListSong.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                if (i == 0 || i == 5)
                {
                    dgListSong.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            dgListSong.Columns["Path"].Visible = false;
            dgListSong.Columns["Id"].HeaderText = Helper.HeaderId;
            dgListSong.Columns["Title"].HeaderText = Helper.HeaderTitle;
            dgListSong.Columns["Singer"].HeaderText = Helper.HeaderSinger;
            dgListSong.Columns["Production"].HeaderText = Helper.HeaderProduction;
            dgListSong.Columns["SongType"].HeaderText = Helper.HeaderSongType;
            dgListSong.Columns["AlbumNum"].HeaderText = Helper.HeaderAlbum;
            dgListSong.Columns["Cadence"].HeaderText = Helper.HeaderCadence;
            dgListSong.Columns["FileType"].HeaderText = Helper.HeaderFileType;
        }
           
        private void SetAlbumCombo()
        {
            var p = (ComboBoxModel)cboProduction.SelectedItem;
            var type = (ComboBoxModel)cboSongType.SelectedItem;
            var albums = Factory.GetAlbumDao().GetAlbumsByProductionIdAndSongTypeId(p.Id, type.Id);
            cboAlbum.Items.Clear();
            foreach (var album in albums)
            {
                cboAlbum.Items.Add(album);
            }
            cboAlbum.DisplayMember = Album.AlbumNumDisplay;
        }

        public Song Song
        {
            set
            {
                txtTitle.Text = value.Title;
                cboSinger.Text = value.Singer.SingerName;
                cboCadance.Text = value.Cadence.CadenceName;
            }
        }

        public void UpdateValueOn(Song song)
        {
            song.Title = txtTitle.Text;
            song.Singer = GetSinger();
            song.Album = GetAlbum();
            song.Cadence = GetCadence();
            song.FileType = GetFileType();
            song.Path = GetPath();
            song.Modified = DateTime.Now;
            if (song.Created == null || song.Created == DateTime.MinValue)
                song.Created = song.Modified;
        }

        private Singer GetSinger()
        {
            var singerModel = (ComboBoxModel)cboSinger.SelectedItem;
            return Factory.GetSingerDao().GetById(singerModel.Id);
        }

        private Album GetAlbum()
        {
            var albumModel = (AlbumListModel)cboAlbum.SelectedItem;
            return Factory.GetAlbumDao().GetById(albumModel.Id);
        }

        private Cadence GetCadence()
        {
            var cadenceModel = (ComboBoxModel)cboCadance.SelectedItem;
            return Factory.GetCadanceDao().GetById(cadenceModel.Id);
        }

        private FileType GetFileType()
        {
            if (!string.IsNullOrEmpty(txtPath.Text))
            {
                string[] str = txtPath.Text.Split('.');
                return Factory.GetFileTypeDao().GetFileTypeByName(str[1]);
            }
            return null;
        }

        private string GetPath()
        {
            if (!string.IsNullOrEmpty(txtPath.Text))
            {
                var regex = new Regex(separator);
                if (regex.IsMatch(txtPath.Text))
                {
                    string[] str = regex.Split(txtPath.Text);
                    return str[1];
                }
                return txtPath.Text;
            }
            return null;
        }

        private Int32 GetSongId()
        {
            if (dgListSongCurrentAlbum.CurrentRow != null && dgListSongCurrentAlbum.CurrentRow.Selected)
            {
                return Int32.Parse(dgListSongCurrentAlbum.CurrentRow.Cells[0].Value.ToString());
            }
            return 0;
        }

        private void GetListSongCurrentAlbum()
        {
            Cursor = Cursors.WaitCursor;
            var p = (ComboBoxModel)cboProduction.SelectedItem;
            var type = (ComboBoxModel)cboSongType.SelectedItem;
            var album = (AlbumListModel)cboAlbum.SelectedItem;
            var songs = Factory.GetSongDao().GetListSongCurrentAlbum(p.Id, type.Id, album.Id);
            if (dgListSongCurrentAlbum.RowCount > 0) dgListSongCurrentAlbum.Rows.Clear();
            var i = 0;
            foreach (var song in songs)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dgListSongCurrentAlbum);
                row.Cells[0].Value = song.Id;
                row.Cells[1].Value = song.Title;
                row.Cells[2].Value = song.Singer;
                row.Cells[3].Value = song.Production;
                row.Cells[4].Value = song.SongType;
                row.Cells[5].Value = song.AlbumNum;
                row.Cells[6].Value = song.Cadence;
                row.Cells[7].Value = song.FileType;
                row.Cells[8].Value = song.Path;
                dgListSongCurrentAlbum.Rows.Add(row);
                dgListSongCurrentAlbum.Rows[i].Height = 30;
                dgListSongCurrentAlbum.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                i++;
            }
            Cursor = Cursors.Default;
        }

        private void ClearText()
        {
            foreach (var textBox in from Control c in tabPage2.Controls where c is TextBox || c is ComboBox select c)
            {
                textBox.Text = string.Empty;
                textBox.Focus();
            }
        }

        private void CopyFileToDrive(int index)
        {
            for (int i = 0; i < dgListSong.SelectedRows.Count; i++)
            {
                FileSystem.CopyFile(musicPath + dgListSong.SelectedRows[i].Cells[8].Value,
                      listDrive[index].Text + dgListSong.SelectedRows[i].Cells["Id"].Value + " " + dgListSong.SelectedRows[i].Cells["Title"].Value + "."
                      + dgListSong.SelectedRows[i].Cells["FileType"].Value,
                      UIOption.AllDialogs,
                      UICancelOption.DoNothing);
            }
        }

        private void PlaySong()
        {
            if (dgListSong.CurrentRow != null && dgListSong.CurrentRow.Selected)
            {
                var process = new Process
                {
                    StartInfo = new ProcessStartInfo(musicPath + dgListSong.CurrentRow.Cells["Path"].Value)
                };
                process.Start();
            }
        }
        #endregion

        #region Event Mehtod
        public FormMains()
        {
            InitializeComponent();
            presenter = new SongPresenter(this, Factory.GetSongDao());
            table = new DataTable();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {   
            Utils.SetDataToComboBox(cboSinger, Factory.GetSingerDao().GetSingers());
            Utils.SetDataToComboBox(cboSongType,Factory.GetSongTypeDao().GetSongTypes());
            Utils.SetDataToComboBox(cboCadance, Factory.GetCadanceDao().GetCadences());
            Utils.SetDataToComboBox(cboNewAlbum, Factory.GetProductionDao().GetProductions());
            Utils.SetDataToComboBox(cboNewSongType, Factory.GetSongTypeDao().GetSongTypes());
            Utils.SetDataToComboBox(cboProduction, Factory.GetProductionDao().GetProductions());
            GetListToGrid();
            lblSongCountAll.Text = SongCount + dgListSong.RowCount.ToString() + Track;
            playlist = new PlayList(_listSong, winPlayer, dgvPlayList);
        }

        private void AddSingerClick(object sender, EventArgs e)
        {
            var form = new FormSinger();
            bAddSinger.Cursor = Cursors.WaitCursor;
            form.ShowDialog();
            bAddSinger.Cursor = Cursors.Default;
            Utils.SetDataToComboBox(cboSinger, Factory.GetSingerDao().GetSingers());
        }

        private void AddProductionClick(object sender, EventArgs e)
        {
            var form = new FormProduction();
            Cursor = Cursors.WaitCursor;
            Cursor = Cursors.Default;
            form.ShowDialog();
            Cursor = Cursors.Default;
            Utils.SetDataToComboBox(cboProduction, Factory.GetProductionDao().GetProductions());
        }

        private void bAddSongType_Click(object sender, EventArgs e)
        {
            var form = new FormSongType();
            bAddSongType.Cursor = Cursors.WaitCursor;
            form.ShowDialog();
            bAddSongType.Cursor = Cursors.Default;
            Utils.SetDataToComboBox(cboSongType,Factory.GetSongTypeDao().GetSongTypes());
        }

        private void bAddAlbum_Click(object sender, EventArgs e)
        {
            var form = new FormAlbum();
            bAddAlbum.Cursor = Cursors.WaitCursor;
            form.ShowDialog();
            bAddAlbum.Cursor = Cursors.Default;
        }

        private void bAddCadance_Click(object sender, EventArgs e)
        {
            var form = new FormCadance();
            bAddCadance.Cursor = Cursors.WaitCursor;
            form.ShowDialog();
            bAddCadance.Cursor = Cursors.Default;
            Utils.SetDataToComboBox(cboCadance, Factory.GetCadanceDao().GetCadences());

        }

        private void bBrowse_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog { Filter = Helper.FilterFileType };
            openFileDialog.ShowDialog();
            txtPath.Text = openFileDialog.FileName;
        }

        private void cboSongType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(cboProduction.Text)) && (!string.IsNullOrEmpty(cboSongType.Text)))
            {
                Cursor = Cursors.WaitCursor;
                SetAlbumCombo();
                Cursor = Cursors.Default;
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                MessageBox.Show(Helper.MessageNotEmptyTitle);
                txtTitle.Focus();
            }
            else if (string.IsNullOrEmpty(cboSinger.Text))
            {
                MessageBox.Show(Helper.MessageNotEmptySingerName);
                cboSinger.Focus();
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
            else if (string.IsNullOrEmpty(cboAlbum.Text))
            {
                MessageBox.Show(Helper.MessageNotEmpyAlumNum);
                cboAlbum.Focus();
            }
            else if (string.IsNullOrEmpty(cboCadance.Text))
            {
                MessageBox.Show(Helper.MessageNotEmptyCadenceName);
                cboCadance.Focus();
            }
            else if (string.IsNullOrEmpty(txtPath.Text))
            {
                MessageBox.Show(Helper.MessageNotPath);
                bBrowse.Focus();
            }
            else
            {
                Cursor = Cursors.WaitCursor;
                presenter.Insert();
                GetListSongCurrentAlbum();
                Cursor = Cursors.Default;
                ClearText();
            }
        }

        private void txtTitle_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = Helper.Khmer();
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            var presenter = new SongPresenter(this, new SongDao());
            presenter.Update(GetSongId());
            bSave.Enabled = true;
            bUpdate.Enabled = false;
            GetListSongCurrentAlbum();
            ClearText();
        }

        private void cboAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboProduction.Text) && !string.IsNullOrEmpty(cboSongType.Text) && !string.IsNullOrEmpty(cboAlbum.Text))
            {
                GetListSongCurrentAlbum();
            }
        }

        private void dgListSongCurrentAlbum_Click(object sender, EventArgs e)
        {
            if (dgListSongCurrentAlbum.RowCount > 0)
            {
                if (dgListSongCurrentAlbum.CurrentRow != null && dgListSongCurrentAlbum.CurrentRow.Selected)
                {
                    bSave.Enabled = false;
                    bUpdate.Enabled = true;
                    txtTitle.Text = dgListSongCurrentAlbum.CurrentRow.Cells[1].Value.ToString();
                    cboSinger.Text = dgListSongCurrentAlbum.CurrentRow.Cells[2].Value.ToString();
                    cboProduction.Text = dgListSongCurrentAlbum.CurrentRow.Cells[3].Value.ToString();
                    cboSongType.Text = dgListSongCurrentAlbum.CurrentRow.Cells[4].Value.ToString();
                    cboAlbum.Text = dgListSongCurrentAlbum.CurrentRow.Cells[5].Value.ToString();
                    cboCadance.Text = dgListSongCurrentAlbum.CurrentRow.Cells[6].Value.ToString();
                    txtPath.Text = dgListSongCurrentAlbum.CurrentRow.Cells[8].Value.ToString();
                }
            }
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            ClearText();
            bSave.Enabled = true;
            bUpdate.Enabled = false;
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                Cursor = Cursors.WaitCursor;
                GetListToGrid();
                lblSongCountAll.Text = SongCount + dgListSong.RowCount.ToString() + Track;
                Cursor = Cursors.Default;
            }
        }
        private void dgListSong_DoubleClick(object sender, EventArgs e)
        {
            PlaySong();
        }

        private void tsMenuItemPlay_Click(object sender, EventArgs e)
        {
            PlaySong();
        }

        private void tsMenuItemAddPlayList_Click(object sender, EventArgs e)
        {
            if (dgListSong.CurrentRow != null && dgListSong.CurrentRow.Selected)
            {
                foreach (DataGridViewRow dgvRow in dgListSong.SelectedRows)
                {
                    var row = new DataGridViewRow();
                    row.CreateCells(dgvPlayList);
                    row.Cells[0].Value = false;
                    row.Cells[1].Value = dgvRow.Cells[0].Value;
                    row.Cells[2].Value = dgvRow.Cells[1].Value;
                    row.Cells[3].Value = dgvRow.Cells[2].Value;
                    row.Cells[4].Value = dgvRow.Cells[8].Value;
                    dgvPlayList.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvPlayList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvPlayList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvPlayList.Rows.Add(row);
                    for (var j = 0; j < dgvPlayList.RowCount; j++)
                    {
                        dgvPlayList.Rows[j].Height = 30;
                    }
                    playlist.AddSong(musicPath + dgvRow.Cells[8].Value);
                }
                if (dgvPlayList.RowCount > 0)
                {
                    bPlay.Enabled = true;
                    bPause.Enabled = true;
                    bNext.Enabled = true;
                    bPrevious.Enabled = true;
                }
            }
        }

        private void tsMenuItemFileTarget_Click(object sender, EventArgs e)
        {
            if (dgListSong.CurrentRow != null)
            {
                Process.Start("explorer.exe", @"/select," + musicPath + dgListSong.CurrentRow.Cells["Path"].Value);
            }
        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            if (playlist.Count > 0)
            {
                playlist.Play();
            }
        }

        private void bPause_Click(object sender, EventArgs e)
        {
            playlist.Pause();
        }

        private void bPrevious_Click(object sender, EventArgs e)
        {
            playlist.PrevSong();
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            playlist.NextSong();
        }
        private void dgListSong_Click(object sender, EventArgs e)
        {
            tsMenuItemFileTarget.Enabled = dgListSong.SelectedRows.Count <= 1;
            if (listDrive.Count > 0)
                listDrive.Clear();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                var item = new ToolStripMenuItem();
                if (drive.IsReady && drive.DriveType == DriveType.Removable)
                {
                    item.Text = drive.Name;
                    listDrive.Add(item);
                }
            }
            if (listDrive.Count > 0)
            {
                tsMenuItemSendTo.DropDownItems.Clear();
                foreach (var item in listDrive)
                {
                    tsMenuItemSendTo.DropDownItems.Add(item);
                }
                switch (listDrive.Count)
                {
                    case 1:
                        listDrive[0].Click += Click_Drive0;
                        break;
                    case 2:
                        listDrive[0].Click += Click_Drive0;
                        listDrive[1].Click += Click_Drive1;
                        break;
                    case 3:
                        listDrive[0].Click += Click_Drive0;
                        listDrive[1].Click += Click_Drive1;
                        listDrive[2].Click += Click_Drive2;
                        break;
                }

            }
        }
        public void Click_Drive0(object sender, EventArgs e)
        {
            if (dgListSong.SelectedRows.Count > 0)
            {
                Cursor = Cursors.WaitCursor;
                CopyFileToDrive(0);
                Cursor = Cursors.Default;
            }
        }
        public void Click_Drive1(object sender, EventArgs e)
        {
            if (dgListSong.SelectedRows.Count > 0)
            {
                Cursor = Cursors.WaitCursor;
                CopyFileToDrive(1);
                Cursor = Cursors.Default;
            }
        }
        public void Click_Drive2(object sender, EventArgs e)
        {
            if (dgListSong.SelectedRows.Count > 0)
            {
                Cursor = Cursors.WaitCursor;
                CopyFileToDrive(2);
                Cursor = Cursors.Default;
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (String.Equals(txtSearchTitle.Text, String.Empty))
            {
                FormatTextboxItalic(txtSearchTitle,Helper.SearchTitle);

            }
            if (!String.Equals(txtSearchTitle.Text, Helper.SearchTitle))
            {
                dataview.RowFilter = "Title Like '%" + txtSearchTitle.Text + "%'";
                dgListSong.DataSource = dataview;
            }
            if (String.Equals(txtSearchTitle.Text, Helper.SearchTitle))
            {
                dgListSong.DataSource = table;
            }
            lblSearchFound.Text = FoundSong + dgListSong.RowCount.ToString() + Track;
        }

        private void FormatTextboxItalic(TextBox textBox,string title)
        {
            textBox.Text = title;
            textBox.ForeColor = Color.Silver;
            textBox.Font = new Font("Khmer OS Battambang", 10, FontStyle.Italic);
        }

        private void txtSearchTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (String.Equals(txtSearchTitle.Text, Helper.SearchTitle))
            {
                FormatTextBoxNormal(txtSearchTitle);
            }
        }

        private void FormatTextBoxNormal(TextBox textBox) 
        {
            textBox.Clear();
            textBox.Focus();
            textBox.Font = new Font("Khmer OS Battambang", 10, FontStyle.Regular);
            textBox.ForeColor = Color.Black;
        }

        private void txtSearchTitle_Click(object sender, EventArgs e)
        {
            txtSearchTitle.SelectionStart = 0;
        }

        private void txtSearchTitle_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = Helper.Khmer();
        }

        private void txtSearchSinger_KeyUp(object sender, KeyEventArgs e)
        {
            if (String.Equals(txtSearchSinger.Text, String.Empty))
            {
                FormatTextboxItalic(txtSearchSinger, Helper.SearchSinger);
            }
            if (!String.Equals(txtSearchSinger.Text, Helper.SearchSinger))
            {
                dataview.RowFilter = "Singer Like '%" + txtSearchSinger.Text + "%'";
                dgListSong.DataSource = dataview;
            }
            if (String.Equals(txtSearchSinger.Text, Helper.SearchSinger))
            {
                dgListSong.DataSource = table;
            }
            lblSearchFound.Text = FoundSong + dgListSong.RowCount.ToString() + Track;
        }

        private void txtSearchSinger_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (String.Equals(txtSearchSinger.Text, Helper.SearchSinger))
            {
                FormatTextBoxNormal(txtSearchSinger);
            }
        }

        private void txtSearchSinger_Click(object sender, EventArgs e)
        {
            txtSearchSinger.SelectionStart = 0;
        }

        private void txtSearchSinger_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = Helper.Khmer();
        }

        private void txtSearchProduction_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = Helper.English();
        }

        private void txtSearchProduction_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (String.Equals(txtSearchProduction.Text, Helper.SearchProduction))
            {
                FormatTextBoxNormal(txtSearchProduction);
            }
        }

        private void txtSearchProduction_KeyUp(object sender, KeyEventArgs e)
        {
            if (String.Equals(txtSearchProduction.Text, String.Empty))
            {
                FormatTextboxItalic(txtSearchProduction, Helper.SearchProduction);
            }
            if (!String.Equals(txtSearchProduction.Text, Helper.SearchProduction))
            {
                dataview.RowFilter = "Production Like '%" + txtSearchProduction.Text + "%'";
                dgListSong.DataSource = dataview;
            }
            if (String.Equals(txtSearchProduction.Text, Helper.SearchProduction))
            {
                dgListSong.DataSource = table;
            }
            lblSearchFound.Text = FoundSong + dgListSong.RowCount.ToString() + Track;
        }

        private void txtSearchProduction_Click(object sender, EventArgs e)
        {
            txtSearchProduction.SelectionStart = 0;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtSearchCadance.SelectionStart = 0;
        }

        private void txtSearchCadance_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = Helper.Khmer();
        }

        private void txtSearchCadance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (String.Equals(txtSearchCadance.Text, Helper.SearchCadence))
            {
                FormatTextBoxNormal(txtSearchCadance);
            }
        }

        private void txtSearchCadance_KeyUp(object sender, KeyEventArgs e)
        {
            if (String.Equals(txtSearchCadance.Text, String.Empty))
            {
                FormatTextboxItalic(txtSearchCadance, Helper.SearchCadence);
            }
            if (!String.Equals(txtSearchCadance.Text, Helper.SearchCadence))
            {
                dataview.RowFilter = "Cadence Like '%" + txtSearchCadance.Text + "%'";
                dgListSong.DataSource = dataview;
            }
            if (String.Equals(txtSearchCadance.Text, Helper.SearchCadence))
            {
                dgListSong.DataSource = table;
            }
            lblSearchFound.Text = FoundSong + dgListSong.RowCount.ToString() + Track;
        }

        private void txtSearchFileType_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = Helper.English();
        }

        private void txtSearchFileType_Click(object sender, EventArgs e)
        {
            txtSearchFileType.SelectionStart = 0;
        }

        private void txtSearchFileType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (String.Equals(txtSearchFileType.Text, Helper.SearchFileType))
            {
                FormatTextBoxNormal(txtSearchFileType);
            }
        }

        private void txtSearchFileType_KeyUp(object sender, KeyEventArgs e)
        {
            if (String.Equals(txtSearchFileType.Text, String.Empty))
            {
                FormatTextboxItalic(txtSearchFileType, Helper.SearchFileType);
            }
            if (!String.Equals(txtSearchFileType.Text, Helper.SearchFileType))
            {
                dataview.RowFilter = "FileType Like '%" + txtSearchFileType.Text + "%'";
                dgListSong.DataSource = dataview;
            }
            if (String.Equals(txtSearchFileType.Text, Helper.SearchFileType))
            {
                dgListSong.DataSource = table;
            }
            lblSearchFound.Text = FoundSong + dgListSong.RowCount.ToString() + Track;
        }

        private void dgvPlayList_Click(object sender, EventArgs e)
        {
            if (dgvPlayList.RowCount > 0)
            {
                tsMenuItemRemoveItemPlayList.Enabled = true;
            }
            else
            {
                bPause.Enabled = false;
                bNext.Enabled = false;
                bPrevious.Enabled = false;
                bPlay.Enabled = false;
            }
        }

        private void tsMenuItemRemoveItemPlayList_Click(object sender, EventArgs e)
        {
            if (dgvPlayList.RowCount > 0)
            {
                foreach (DataGridViewRow rows in dgvPlayList.SelectedRows)
                {
                    var isSelected = (bool)rows.Cells[0].Value;
                    if (!isSelected)
                    {
                        playlist.DeleteSong(musicPath + rows.Cells[4].Value);
                        dgvPlayList.Rows.RemoveAt(rows.Index);
                    }
                }

            }
        }

        private void cboNewAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            var production = (ComboBoxModel)cboNewAlbum.SelectedItem;
            var songType = (ComboBoxModel)cboNewSongType.SelectedItem;
            if (production != null)
            {
                table = ConvertToDataTable(Factory.GetSongDao().GetListSongByProduction(production.DataField));
                dgListSong.DataSource = table;
                lblSearchFound.Text = FoundSong + dgListSong.RowCount.ToString() + Track;
            }
            if (songType != null && production != null)
            {
                table = ConvertToDataTable(Factory.GetSongDao().GetListSongModelByProSongType(production.DataField, songType.DataField));
                dgListSong.DataSource = table;
                lblSearchFound.Text = FoundSong + dgListSong.RowCount.ToString() + Track;
            }
        }

        private void cboNewSongType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var production = (ComboBoxModel)cboNewAlbum.SelectedItem;
            var songType = (ComboBoxModel)cboNewSongType.SelectedItem;
            if (songType != null && production != null)
            {
                table = ConvertToDataTable(Factory.GetSongDao().GetListSongModelByProSongType(production.DataField, songType.DataField));
                dgListSong.DataSource = table;
                lblSearchFound.Text = FoundSong + dgListSong.RowCount.ToString() + Track;
            }
        }
        #endregion

        #region Implement Method
        public IList<Song> Songs
        {
            set { throw new NotImplementedException(); }
        }
        #endregion
    }
}
