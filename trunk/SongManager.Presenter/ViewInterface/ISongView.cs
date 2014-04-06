using System.Collections.Generic;
using SongManager.Core.Domain;

namespace SongManager.Presenter.ViewInterface
{
    public interface ISongView
    {
        Song Song { set; }
        void UpdateValueOn(Song song);
        IList<Song> Songs { set; }
    }
}
