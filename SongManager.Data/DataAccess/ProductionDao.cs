using System;
using System.Collections.Generic;
using System.Linq;
using SongManager.Core.Domain;
using SongManager.Core.DataInterface;
using NHibernate.Linq;
using SongManager.Core.Model;

namespace SongManager.Data.DataAccess
{
    public class ProductionDao :NHibernateRepository<Production,Int32>,IProductionDao
    {
        public IList<ComboBoxModel> GetProductions()
        {
            using (var session = GetSession()) 
            {
                var query = (from p in session.Query<Production>()
                             orderby p.ProductionName ascending
                             select new ComboBoxModel 
                             { 
                                 Id = p.Id,
                                 DataField = p.ProductionName
                             }).ToList();
                return query;
            }
        }
    }
}
