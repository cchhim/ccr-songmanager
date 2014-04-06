using System;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using SongManager.Core.Map;
using NHibernate.Cfg;
using System.IO;
using System.Configuration;


namespace SongManager.Data
{
    public class NHibernateHelper
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        private ISessionFactory _sessionFactory;
        public ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    InitializeSessionFactory();
                return _sessionFactory;
            }
        }

        private void InitializeSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                .ConnectionString(connectionString).ShowSql())
                       .Mappings(m => m.FluentMappings.Add<SingerMap>())
                       .Mappings(m => m.FluentMappings.Add<ProductionMap>())
                       .Mappings(m => m.FluentMappings.Add<CadenceMap>())
                       .Mappings(m => m.FluentMappings.Add<SongTypeMap>())
                       .Mappings(m => m.FluentMappings.Add<AlbumMap>())
                       .Mappings(m => m.FluentMappings.Add<FileTypeMap>())
                       .Mappings(m => m.FluentMappings.Add<SongMap>())
                 .BuildSessionFactory();
        }
        public void Dispose()
        {
            SessionFactory.Dispose();
        }
    }
}
