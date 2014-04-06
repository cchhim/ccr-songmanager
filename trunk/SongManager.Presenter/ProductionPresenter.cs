using System;
using SongManager.Presenter.ViewInterface;
using SongManager.Core.DataInterface;
using SongManager.Core.Domain;

namespace SongManager.Presenter
{
    public class ProductionPresenter
    {
        private readonly IProductionView _view;
        private readonly IProductionDao _productionDao;
        public ProductionPresenter(IProductionView view, IProductionDao productionDao)
        {
            _view = view;
            _productionDao = productionDao;
        }
        public void InitView()
        {
            _view.Productions = _productionDao.GetAll();
        }
        public void Update(Int32 productionId)
        {
            var prouductionUpdate = _productionDao.GetById(productionId);
            _view.UpdateValueOn(prouductionUpdate);
            _productionDao.Update(prouductionUpdate);
        }
        public void Insert()
        {
            var production = new Production();
            _view.UpdateValueOn(production);
            _productionDao.Save(production);
        }
        public void Delete(Int32 productionId)
        {
            Production productionDelete = _productionDao.GetById(productionId);
            _productionDao.Delete(productionDelete);
        }
    }
}
