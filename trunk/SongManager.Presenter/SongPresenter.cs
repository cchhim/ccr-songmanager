using System;
using SongManager.Presenter.ViewInterface;
using SongManager.Core.DataInterface;
using SongManager.Core.Domain;

namespace SongManager.Presenter
{
    public class SongPresenter
    {
        private readonly ISongView _view;
        private readonly ISongDao _songDao;
        public SongPresenter(ISongView view, ISongDao songDao)
        {
            _view = view;
            _songDao = songDao;
        }
        public void InitView()
        {
            _view.Songs = _songDao.GetAll();
        }
        public void Update(Int32 songId)
        {
            var songUpdate = _songDao.GetById(songId);
            _view.UpdateValueOn(songUpdate);
            _songDao.Update(songUpdate);
        }
        public void Insert()
        {
            var song = new Song();
            _view.UpdateValueOn(song);
            _songDao.Save(song);
        }
        public void Delete(Int32 songId) 
        {
            var songDelete = _songDao.GetById(songId);
            _songDao.Delete(songDelete);
        }
    }
}
