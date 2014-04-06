using System;
using System.Collections.Generic;
using SongManager.Core.DataInterface;
using NHibernate;
using NHibernate.Criterion;

namespace SongManager.Data
{
    public class NHibernateRepository<T, TIdT> : IRepository<T, TIdT>
    {

        private readonly Type _persitentType = typeof(T);
        private NHibernateHelper helper;
        public ISessionFactory SessionFactory { get; set; }
        protected ISession GetSession()
        {   
            helper = new NHibernateHelper();
            return helper.SessionFactory.OpenSession();
        }
        public T GetById(TIdT id)
        {
            using (var session = GetSession()) 
            {
                return (T)session.Load(_persitentType, id, LockMode.Upgrade);
            }
        }

        public List<T> GetAll()
        {
            return GetByCriteria();
        }

        public List<T> GetByCriteria(params ICriterion[] criterion)
        {
            using (var session = GetSession()) 
            {
                ICriteria criteria = session.CreateCriteria(_persitentType);
                foreach (ICriterion criterium in criterion) 
                {
                    criteria.Add(criterium);
                }
                return criteria.List<T>() as List<T>;
            }
        }

        public Core.Domain.Entity Save(Core.Domain.Entity entity)
        {
            using (var session = GetSession()) 
            {
                using (var transaction = session.BeginTransaction()) 
                {
                    session.Save(entity);
                    transaction.Commit();
                }
            }
            return entity;
        }

        public Core.Domain.Entity Update(Core.Domain.Entity entity)
        {
            using (var session = GetSession()) 
            {
                using (var transaction = session.BeginTransaction()) 
                {
                    session.SaveOrUpdate(entity);
                    transaction.Commit();
                }
            }
            return entity;
        }

        public void Delete(Core.Domain.Entity entity)
        {
            using (var session = GetSession()) 
            {
                using (var transaction = session.BeginTransaction()) 
                {
                    session.Delete(entity);
                    transaction.Commit();
                }
            }
        }
    }
}
