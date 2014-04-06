using System.Collections.Generic;
using SongManager.Core.Domain;

namespace SongManager.Presenter.ViewInterface
{
    public interface IProductionView
    {
        Production Production { set; }
        void UpdateValueOn(Production production);
        IList<Production> Productions { set; }
    }
}
