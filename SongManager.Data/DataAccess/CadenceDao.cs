using System;
using System.Collections.Generic;
using System.Linq;
using SongManager.Core.Domain;
using SongManager.Core.DataInterface;
using NHibernate;
using  NHibernate.Linq;
using NHibernate.Criterion;
using SongManager.Core.Model;

namespace SongManager.Data.DataAccess
{
    public class CadenceDao: NHibernateRepository<Cadence,Int32>,ICadanceDao
    {
        public IList<ComboBoxModel> GetCadences()
        {
            using (var session = GetSession()) 
            {
                return (from cadence in session.Query<Cadence>()
                        orderby cadence.CadenceName ascending
                        select new ComboBoxModel
                        { 
                            Id = cadence.Id,
                            DataField = cadence.CadenceName
                        }).ToList();
            }
        }
    }
}
