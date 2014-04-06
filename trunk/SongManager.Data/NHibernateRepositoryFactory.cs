using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SongManager.Core.DataInterface;
using SongManager.Data.DataAccess;

namespace SongManager.Data
{
    public class NHibernateRepositoryFactory : IRepositoryFactory
    {
        private NHibernateHelper helper;
        public NHibernateRepositoryFactory() 
        {
            helper = new NHibernateHelper();
        }
        public IAlbumDao GetAlbumDao()
        {
            return new AlbumDao {SessionFactory = helper.SessionFactory };
        }

        public ICadanceDao GetCadanceDao()
        {
            return new CadenceDao { SessionFactory = helper.SessionFactory };
        }

        public IFileTypeDao GetFileTypeDao()
        {
            return new FileTypeDao { SessionFactory = helper.SessionFactory };
        }

        public IProductionDao GetProductionDao()
        {
            return new ProductionDao { SessionFactory = helper.SessionFactory };
        }

        public ISingerDao GetSingerDao()
        {
            return new SingerDao { SessionFactory = helper.SessionFactory };
        }

        public ISongTypeDao GetSongTypeDao()
        {
            return new SongTypeDao { SessionFactory = helper.SessionFactory };
        }

        public ISongDao GetSongDao()
        {
            return new SongDao { SessionFactory = helper.SessionFactory };
        }
    }
}
