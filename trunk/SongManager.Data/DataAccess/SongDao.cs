using System;
using System.Collections.Generic;
using System.Linq;
using SongManager.Core.Domain;
using SongManager.Core.DataInterface;
using NHibernate;
using NHibernate.Linq;
using SongManager.Core.Model;

namespace SongManager.Data.DataAccess
{
    public class SongDao : NHibernateRepository<Song, Int32>, ISongDao
    {

        public IList<SongModel> GetListSongCurrentAlbum(int productionId, int typeId, int albumId)
        {
            using (var session = GetSession())
            {
                var query = from song in session.Query<Song>()
                            where song.Album.Production.Id == productionId &&
                            song.Album.SongType.Id == typeId &&
                            song.Album.Id == albumId
                            select new SongModel
                            {
                                Id = song.Id,
                                Title = song.Title,
                                Singer = song.Singer.SingerName,
                                Production = song.Album.Production.ProductionName,
                                SongType = song.Album.SongType.SongTypeName,
                                AlbumNum = song.Album.AlbumNum,
                                Cadence = song.Cadence.CadenceName,
                                FileType = song.FileType.FileTypeName,
                                Path = song.Path
                            };
                return query.ToList();
            }
        }

        public IList<SongModel> GetListSongByProduction(string production)
        {
            using (var session = GetSession())
            {
                var query = from song in session.Query<Song>()
                            where song.Album.Production.ProductionName == production
                            orderby song.Album.AlbumNum descending
                            select new SongModel
                            {
                                Id = song.Id,
                                Title = song.Title,
                                Singer = song.Singer.SingerName,
                                Production = song.Album.Production.ProductionName,
                                SongType = song.Album.SongType.SongTypeName,
                                AlbumNum = song.Album.AlbumNum,
                                Cadence = song.Cadence.CadenceName,
                                FileType = song.FileType.FileTypeName,
                                Path = song.Path
                            };
                return query.ToList<SongModel>();
            }
        }

        public IList<SongModel> GetListSongModel()
        {
            using (ISession session = GetSession())
            {
                var query = from song in session.Query<Song>()
                            from production in session.Query<Production>()
                            from singer in session.Query<Singer>()
                            from songType in session.Query<SongType>()
                            from album in session.Query<Album>()
                            from cadence in session.Query<Cadence>()
                            from filetype in session.Query<FileType>()
                            where song.Album.Production.Id == production.Id
                            && song.Singer.Id == singer.Id
                            && song.Album.SongType.Id == songType.Id
                            && song.Album.Id == album.Id
                            && song.Cadence.Id == cadence.Id
                            && song.FileType.Id == filetype.Id
                            select new SongModel
                            {
                                Id = song.Id,
                                Title = song.Title,
                                Singer = singer.SingerName,
                                Production = production.ProductionName,
                                SongType = songType.SongTypeName,
                                AlbumNum = album.AlbumNum,
                                Cadence = cadence.CadenceName,
                                FileType = filetype.FileTypeName,
                                Path = song.Path
                            };
                return query.ToList<SongModel>();
            }
        }
        public IList<SongModel> GetListSongModelByProSongType(string production, string songTypeName)
        {
            using (ISession session = GetSession())
            {
                var query = from song in session.Query<Song>()
                            from prod in session.Query<Production>()
                            from singer in session.Query<Singer>()
                            from songType in session.Query<SongType>()
                            from album in session.Query<Album>()
                            from cadence in session.Query<Cadence>()
                            from filetype in session.Query<FileType>()
                            where song.Album.Production.Id == prod.Id
                            && song.Singer.Id == singer.Id
                            && song.Album.SongType.Id == songType.Id
                            && song.Album.Id == album.Id
                            && song.Cadence.Id == cadence.Id
                            && song.FileType.Id == filetype.Id
                            && prod.ProductionName == production
                            && songType.SongTypeName == songTypeName
                            orderby song.Album.AlbumNum descending
                            select new SongModel
                            {
                                Id = song.Id,
                                Title = song.Title,
                                Singer = song.Singer.SingerName,
                                Production = song.Album.Production.ProductionName,
                                SongType = song.Album.SongType.SongTypeName,
                                AlbumNum = song.Album.AlbumNum,
                                Cadence = song.Cadence.CadenceName,
                                FileType = song.FileType.FileTypeName,
                                Path = song.Path
                            };
                return query.ToList<SongModel>();
            }
        }
    }
}
