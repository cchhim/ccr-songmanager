using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevComponents.DotNetBar;
using SongManager.Core.DataInterface;
using SongManager.Data;
//using Castle.Windsor;
//using Component = Castle.MicroKernel.Registration.Component;

namespace SongManager
{
    public class BaseForm : Office2007Form
    {
        //public IWindsorContainer container;
        private IRepositoryFactory _factory;
        public IRepositoryFactory Factory
        {
            get
            {   
                return _factory ?? (_factory = new NHibernateRepositoryFactory());
            }
        }
        //public IRepositoryFactory Repository
        //{
        //    get
        //    {
        //        container = new WindsorContainer();
        //        container.Register(Component.For<IRepositoryFactory>().ImplementedBy<NHibernateRepositoryFactory>());
        //        return container.Resolve<IRepositoryFactory>();
        //    }

        //}
    }
}
