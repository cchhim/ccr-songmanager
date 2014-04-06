using System;
using System.Collections.Generic;
using SongManager.Core.Domain;
using SongManager.Core.Model;

namespace SongManager.Core.DataInterface
{
    public interface IAlbumDao : IRepository<Album,Int32>
    {   
        IList<AlbumListModel> GetAlbumsByProductionId(int productionId);
        IList<AlbumListModel> GetAlbumsBySongTypeId(int typeId);
        IList<Album> GetAlbumsBySongTypeName(string type);
        IList<AlbumListModel> GetAlbumsByProductionIdAndSongTypeId(int productionId, int typeId);
        IList<AlbumListModel> GetAlbums();
    }
}
