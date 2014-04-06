using SongManager.Core.Domain;
using FluentNHibernate.Mapping;

namespace SongManager.Core.Map
{
    public class FileTypeMap : ClassMap<FileType>
    {
        public FileTypeMap() 
        {
            Id(x => x.Id);
            Map(x => x.FileTypeName);
            HasMany(x => x.Songs)
                .Cascade.DeleteOrphan()
                .Inverse().KeyColumn("FileTypeId");
            Map(x => x.Created);
            Map(x => x.Modified);
            Table("FileType");
        }
    }
}
