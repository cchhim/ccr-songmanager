using FluentNHibernate.Mapping;
using SongManager.Core.Domain;

namespace SongManager.Core.Map
{
    public class SongMap : ClassMap<Song>
    {
        public SongMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Title);
            References(x => x.Singer)
                .Cascade.SaveUpdate()
                .Column("SingerId")
                .Not.LazyLoad();
            //References(x => x.Production)
            //    .Cascade.SaveUpdate()
            //    .Column("ProductionId")
            //    .Not.LazyLoad();
            //References(x => x.SongType)
            //    .Cascade.SaveUpdate()
            //    .Column("SongTypeId")
            //    .Not.LazyLoad();
            References(x => x.Album)
                .Cascade.SaveUpdate()
                .Column("AlbumId")
                .Not.LazyLoad();
            References(x => x.Cadence)
                .Cascade.SaveUpdate()
                .Column("CadenceId")
                .Not.LazyLoad();
            References(x => x.FileType)
                .Cascade.SaveUpdate()
                .Column("FileTypeId")
                .Not.LazyLoad();
            Map(x => x.Path);
            Map(x => x.Created);
            Map(x => x.Modified);
            Table("Song");

        }
    }
}
