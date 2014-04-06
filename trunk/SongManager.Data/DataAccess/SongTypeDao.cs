using System;
using System.Collections.Generic;
using System.Linq;
using SongManager.Core.Domain;
using SongManager.Core.DataInterface;
using NHibernate.Linq;
using SongManager.Core.Model;

namespace SongManager.Data.DataAccess
{
    public class SongTypeDao : NHibernateRepository<SongType, Int32>, ISongTypeDao
    {
        public IList<ComboBoxModel> GetSongTypes()
        {
            using (var session = GetSession())
            {
                var query = (from type in session.Query<SongType>()
                             orderby type.SongTypeName ascending
                             select new ComboBoxModel
                             {
                                 Id = type.Id,
                                 DataField = type.SongTypeName
                             });
                return query.ToList();
            }
        }
    }
}
