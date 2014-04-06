using System;
using SongManager.Presenter.ViewInterface;
using SongManager.Core.DataInterface;
using SongManager.Core.Domain;

namespace SongManager.Presenter
{
    public class CadencePresenter
    {
        private readonly ICadenceView _view;
        private readonly ICadanceDao _cadenceDao;

        public CadencePresenter(ICadenceView view, ICadanceDao cadenceDao) 
        {
            _view = view;
            _cadenceDao = cadenceDao;
        }
        public void InitView() 
        {
            _view.Cadences = _cadenceDao.GetAll();
        }
        public void Update(Int32 cadenceId) 
        {
            var cadenceUpdate = _cadenceDao.GetById(cadenceId);
            _view.UpdateValueOn(cadenceUpdate);
            _cadenceDao.Update(cadenceUpdate);
        }
        public void Insert() 
        {
            var cadence = new Cadence();
            _view.UpdateValueOn(cadence);
            _cadenceDao.Save(cadence);
        }
        public void Delete(Int32 cadenceId) 
        {
            var cadenceDelete = _cadenceDao.GetById(cadenceId);
            _cadenceDao.Delete(cadenceDelete);
        }

    }
}
