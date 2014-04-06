using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SongManager.Core.DataInterface
{
    public interface IRepositoryFactory
    {
        IAlbumDao GetAlbumDao();
        ICadanceDao GetCadanceDao();
        IFileTypeDao GetFileTypeDao();
        IProductionDao GetProductionDao();
        ISingerDao GetSingerDao();
        ISongTypeDao GetSongTypeDao();
        ISongDao GetSongDao();
    }
}
