using System.Collections.Generic;
using SongManager.Core.Domain;

namespace SongManager.Presenter.ViewInterface
{
    public interface ISongTypeView
    {
        SongType SongType { set; }
        void UpdateValueOn(SongType songType);
        IList<SongType> SongTypes { set; }
    }
}
