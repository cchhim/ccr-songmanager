using System.Collections.Generic;
using SongManager.Core.Domain;

namespace SongManager.Presenter.ViewInterface
{
    public interface ISingerView
    {
        Singer Singer { set; }
        void UpdateValueOn(Singer singer);
        IList<Singer> Singers { set; }
    }
}
