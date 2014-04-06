using System;
using System.Collections.Generic;
using SongManager.Core.Domain;
using SongManager.Core.Model;

namespace SongManager.Core.DataInterface
{
    public interface IFileTypeDao:IRepository<FileType,Int32>
    {   
        FileType GetFileTypeByName(string typeName);
        List<ComboBoxModel> GetFilesType();
    }
}
