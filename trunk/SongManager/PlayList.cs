using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections;
using SongManager.Properties;

namespace SongManager
{
    public class PlayList
    {
        public bool SongEnded = true;
        private readonly Timer _checkSong;
        private readonly IContainer playComponent;
        readonly ArrayList _songInPlayList = new ArrayList();
        private int _index;
        private readonly DataGridView _dataGidView;
        public AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        public PlayList(IEnumerable<string> songs, AxWMPLib.AxWindowsMediaPlayer player, DataGridView dataGridView)
        {
            AddSong(songs);
            MediaPlayer = player;
            playComponent = new Container();
            _dataGidView = dataGridView;
            _checkSong = new Timer(playComponent);
            _checkSong.Tick += checkSong_Tick;
            MediaPlayer.PlayStateChange += MediaPlayer_PlayStateChange;

            //  Play();
        }

        private void AddSong(IEnumerable<string> songs)
        {
            foreach (var t in songs)
            {
                AddSong(t);
            }
        }

        public void AddSong(string song)
        {
            _songInPlayList.Add(song);
        }
        public void DeleteSong(string song)
        {
            if (song == _songInPlayList[_index].ToString())
            {
                MediaPlayer.Ctlcontrols.stop();
                _index--;
            }
            _songInPlayList.Remove(song);
            MediaPlayer.Ctlcontrols.play();
        }
        public void DeletePlaylist()
        {
            MediaPlayer.Ctlcontrols.stop();
            _songInPlayList.Clear();
            _index = 0;
        }
        public int Volume
        {
            set { MediaPlayer.settings.volume = value; }
            get { return MediaPlayer.settings.volume; }
        }

        public void Play()
        {
            if (_songInPlayList[_index] != null)
            {
                MediaPlayer.URL = _songInPlayList[_index].ToString();
                _dataGidView.Rows[_index].Cells[0].Value = true;
            }
        }
        public void Play(int slot)
        {
            if (_songInPlayList[slot - 1] != null)
                MediaPlayer.URL = _songInPlayList[slot - 1].ToString();
        }
        public void Play(string name)
        {
            int slot = _songInPlayList.BinarySearch(name, null);
            if (slot >= 0 && slot < _songInPlayList.Count)
                MediaPlayer.URL = _songInPlayList[slot].ToString();
        }
        private void checkSong_Tick(object sender, System.EventArgs e)
        {
            if (SongEnded)
            {

                NextSong();
                SongEnded = false;
                _checkSong.Stop();
            }
        }
        public void Pause()
        {
            MediaPlayer.Ctlcontrols.pause();
        }
        public void Stop()
        {
            MediaPlayer.Ctlcontrols.stop();
        }
        public int Count
        {
            get
            {
                return _songInPlayList.Count;
            }
        }
        public void NextSong()
        {
            try
            {
                if (_index != _songInPlayList.Count - 1)
                {

                    _dataGidView.Rows[_songInPlayList.Count - 1].Cells[0].Value = false;
                    _index++;
                    MediaPlayer.Ctlcontrols.stop();
                    MediaPlayer.URL = _songInPlayList[_index].ToString();
                    MediaPlayer.Ctlcontrols.play();
                    if (_index != 0)
                    {
                        _dataGidView.Rows[_index - 1].Cells[0].Value = false;
                        _dataGidView.Rows[_index].Cells[0].Value = true;
                    }
                }
                else
                {
                    _index = 0;
                    MediaPlayer.Ctlcontrols.stop();
                    MediaPlayer.URL = _songInPlayList[0].ToString();
                    MediaPlayer.Ctlcontrols.play();
                    _dataGidView.Rows[_index].Cells[0].Value = true;
                    _dataGidView.Rows[_songInPlayList.Count - 1].Cells[0].Value = false;

                }
            }
            catch 
            {
                MessageBox.Show(Resources.PlayList_NextSong_Error);
            }
        }
        public void PrevSong()
        {
            if (_index != 0)
            {

                _index--;
                _dataGidView.Rows[_index].Cells[0].Value = true;
                _dataGidView.Rows[_index + 1].Cells[0].Value = false;
                MediaPlayer.Ctlcontrols.stop();
                MediaPlayer.URL = _songInPlayList[_index].ToString();
                MediaPlayer.Ctlcontrols.play();

            }
            else
            {
                _dataGidView.Rows[_index].Cells[0].Value = false;
                _index = _songInPlayList.Count - 1;
                MediaPlayer.Ctlcontrols.stop();
                MediaPlayer.URL = _songInPlayList[_index].ToString();
                MediaPlayer.Ctlcontrols.play();
                _dataGidView.Rows[_songInPlayList.Count - 1].Cells[0].Value= true;
            }
        }

        public void MediaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            switch (MediaPlayer.playState)
            {
                case WMPLib.WMPPlayState.wmppsMediaEnded:
                    SongEnded = true;
                    _checkSong.Start();
                    break;
            }
        }
        public void Dispose()
        {
            MediaPlayer.Dispose();
        }
    }
}
