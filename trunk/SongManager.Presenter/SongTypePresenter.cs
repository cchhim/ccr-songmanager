using System;
using SongManager.Core.DataInterface;
using SongManager.Core.Domain;
using SongManager.Presenter.ViewInterface;

namespace SongManager.Presenter
{
    public class SongTypePresenter
    {
        private readonly ISongTypeDao _songTypeDao;
        private readonly ISongTypeView _view;

        public SongTypePresenter(ISongTypeView view, ISongTypeDao songTypeDao)
        {
            _view = view;
            _songTypeDao = songTypeDao;
        }

        public void InitView()
        {
            _view.SongTypes = _songTypeDao.GetAll();
        }

        public void Update(Int32 songTypeId)
        {
            SongType songTypeUpdate = _songTypeDao.GetById(songTypeId);
            _view.UpdateValueOn(songTypeUpdate);
            _songTypeDao.Update(songTypeUpdate);
        }

        public void Insert()
        {
            var songType = new SongType();
            _view.UpdateValueOn(songType);
            _songTypeDao.Save(songType);
        }

        public void Delete(Int32 songTypeId)
        {
            SongType songTypeDelete = _songTypeDao.GetById(songTypeId);
            _songTypeDao.Delete(songTypeDelete);
        }
    }
}