using System;
using SongManager.Presenter.ViewInterface;
using SongManager.Core.DataInterface;
using SongManager.Core.Domain;

namespace SongManager.Presenter
{
    public class SingerPresenter
    {
        private readonly ISingerView _view;
        private readonly ISingerDao _singerDao;

        public SingerPresenter(ISingerView view, ISingerDao singerDao) 
        {
            _view = view;
            _singerDao = singerDao;
        }
        public void InitView() 
        {
            _view.Singers = _singerDao.GetAll();
        }
        public void Delete(Int32 singerId) 
        {
            var singerDelete = _singerDao.GetById(singerId);
            _singerDao.Delete(singerDelete);
        }

        public void Insert() 
        {
            var singer = new Singer();
            _view.UpdateValueOn(singer);
            _singerDao.Save(singer);
        }

        public void Update(Int32 singerId) 
        {
            var singerUpdate = _singerDao.GetById(singerId);
            _view.UpdateValueOn(singerUpdate);
            _singerDao.Update(singerUpdate);
        }
    }
}
