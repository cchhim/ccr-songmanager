using System;
using SongManager.Presenter.ViewInterface;
using SongManager.Core.DataInterface;
using SongManager.Core.Domain;

namespace SongManager.Presenter
{
    public class AlbumPresenter
    {
        private readonly IAlbumView _view;
        private readonly IAlbumDao _albumDao;
        public AlbumPresenter(IAlbumView view, IAlbumDao albumDao)
        {
            _view = view;
            _albumDao = albumDao;
        }
        public void InitView()
        {
            _view.Albums = _albumDao.GetAll();   
        }
        public void Update(Int32 albumId)
        {
            var albumUpdate = _albumDao.GetById(albumId);
            _view.UpdateValueOn(albumUpdate);
            _albumDao.Update(albumUpdate);
        }
        public void Insert()
        {
            var album = new Album();
            _view.UpdateValueOn(album);
            _albumDao.Save(album);
        }
        public void Delete(Int32 albumId)
        {
            var albumDelete = _albumDao.GetById(albumId);
            _albumDao.Delete(albumDelete);
        }
      

    }
}
