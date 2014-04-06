using System;
using System.Collections.Generic;
using System.Linq;
using SongManager.Core.Domain;
using SongManager.Core.DataInterface;
using NHibernate;
using NHibernate.Linq;
using NHibernate.Criterion;
using SongManager.Core.Model;

namespace SongManager.Data.DataAccess
{
    public class SingerDao:NHibernateRepository<Singer,Int32>,ISingerDao
    {   
        public IList<ComboBoxModel> GetSingers()
        {
            using (var session = GetSession()) 
            {
                return (from singer in session.Query<Singer>()
                        orderby singer.SingerName ascending
                        select new ComboBoxModel
                        {
                            Id = singer.Id,
                            DataField = singer.SingerName
                        }).ToList();
            }
        }
    }
}
