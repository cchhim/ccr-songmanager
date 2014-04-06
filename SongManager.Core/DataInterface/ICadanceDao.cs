using System;
using System.Collections.Generic;
using SongManager.Core.Domain;
using SongManager.Core.Model;

namespace SongManager.Core.DataInterface
{
    public interface ICadanceDao:IRepository<Cadence,Int32>
    {   
        IList<ComboBoxModel> GetCadences();
    }
}
