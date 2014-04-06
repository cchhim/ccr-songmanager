using System.Collections.Generic;
using NHibernate.Criterion;
using SongManager.Core.Domain;

namespace SongManager.Core.DataInterface
{
    public interface IRepository<T,IdT>
    {
        T GetById(IdT id);
        List<T> GetAll();
        List<T> GetByCriteria(params ICriterion[] criterion);
        Entity Save(Entity entity); 
        Entity Update(Entity entity);
        void Delete(Entity entity);
    }
}
