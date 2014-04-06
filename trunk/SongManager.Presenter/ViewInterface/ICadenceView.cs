using System.Collections.Generic;
using SongManager.Core.Domain;

namespace SongManager.Presenter.ViewInterface
{
    public interface ICadenceView
    {
        Cadence Cadence { set; }
        void UpdateValueOn(Cadence cadence);
        IList<Cadence> Cadences { set; }
    }
}
