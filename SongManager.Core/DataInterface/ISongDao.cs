using System;
using System.Collections.Generic;
using SongManager.Core.Domain;
using SongManager.Core.Model;

namespace SongManager.Core.DataInterface
{
    public interface ISongDao:IRepository<Song,Int32>
    {   
        IList<SongModel> GetListSongByProduction(string production);
        IList<SongModel> GetListSongCurrentAlbum(int productionId, int typeId, int albumId);
        IList<SongModel> GetListSongModel();
        IList<SongModel> GetListSongModelByProSongType(string production, string songType);
    }
}
