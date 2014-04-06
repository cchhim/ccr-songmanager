using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Linq;
using SongManager.Core.Domain;
using SongManager.Core.DataInterface;
using NHibernate;
using NHibernate.Criterion;
using SongManager.Core.Model;

namespace SongManager.Data.DataAccess
{
    public class AlbumDao : NHibernateRepository<Album,Int32>,IAlbumDao
    {   
        public IList<AlbumListModel> GetAlbumsByProductionId(int productionId)
        {
            using (var session = GetSession()) 
            {
                var query = (from album in session.Query<Album>()
                            where album.Production.Id == productionId
                            select new AlbumListModel 
                            { 
                                Id = album.Id,
                                AlbumNum = album.AlbumNum.ToString(),
                                Production = album.Production.ProductionName,
                                Type = album.SongType.SongTypeName
                            });
                return query.ToList();
            }
        }

        public IList<AlbumListModel> GetAlbumsBySongTypeId(int typeId)
        {
            using (var session = GetSession())
            {
                var query = from album in session.Query<Album>()
                            where album.SongType.Id == typeId
                            select new AlbumListModel 
                            { 
                                Id = album.Id,
                                AlbumNum = album.AlbumNum.ToString(),
                                Production = album.Production.ProductionName,
                                Type = album.SongType.SongTypeName
                            };
                return query.ToList();
            }
        }

        public IList<AlbumListModel> GetAlbumsByProductionIdAndSongTypeId(int productionId, int typeId)
        {
            using (var session = GetSession())
            {
                var query = (from album in session.Query<Album>()
                            where album.Production.Id == productionId &&
                            album.SongType.Id == typeId
                            select new AlbumListModel 
                            { 
                                Id = album.Id,
                                AlbumNum = album.AlbumNum.ToString(),
                                Production = album.Production.ProductionName,
                                Type = album.SongType.SongTypeName
                            });
                return query.ToList();                            
            }
        }

        public IList<Album> GetAlbumsBySongTypeName(string type)
        {
            using (var session = GetSession())
            {
                var query = from album in session.Query<Album>()
                            where album.SongType.SongTypeName == type
                            select album;
                return query.ToList();
            }
        }

        public IList<AlbumListModel> GetAlbums()
        {
            using (var session = GetSession()) 
            {
                var query = (from album in session.Query<Album>()
                             select new AlbumListModel 
                             {
                                 Id = album.Id,
                                 AlbumNum = album.AlbumNum.ToString(),
                                 Production = album.Production.ProductionName,
                                 Type = album.SongType.SongTypeName
                             });
                return query.ToList();
            }
        }
    }
}
