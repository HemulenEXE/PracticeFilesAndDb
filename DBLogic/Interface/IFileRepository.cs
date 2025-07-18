using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeFilesAndDB.DBLogic.Entity;

namespace ImportExpornInDB.DBLogic.Interface
{
    internal interface IFileRepository
    {
        void AddFile(EntityFile file);
        EntityFile GetFile(int id);
        List<EntityFile> GetFiles();
        void DeleteFile(int id);
        int NextId();
    }
}
