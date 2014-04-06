using System;
using System.Collections.Generic;
using System.Linq;
using SongManager.Core.Domain;
using SongManager.Core.DataInterface;
using NHibernate.Linq;
using NHibernate.Criterion;
using SongManager.Core.Model;

namespace SongManager.Data.DataAccess
{
    public class FileTypeDao: NHibernateRepository<FileType,Int32>,IFileTypeDao
    {

        public FileType GetFileTypeByName(string typeName)
        {
            using (var session = GetSession()) 
            {
                var query = (from fileType in session.Query<FileType>()
                             where fileType.FileTypeName == typeName
                             select fileType).ToList().FirstOrDefault();
                return query;
            }
        }

        public List<ComboBoxModel> GetFilesType()
        {
            using (var session = GetSession()) 
            {
                var query = (from fileType in session.Query<FileType>()
                             select new ComboBoxModel
                             {
                                 Id = fileType.Id,
                                 DataField = fileType.FileTypeName
                             }).Distinct();
                return query.ToList();
            }
        }
    }
}
