
using Hotel.Data.Repositories.IRepo.IPersonelRp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data.Repositories.IRepo
{
    public interface IUnitOfWork:IDisposable
    {
        IPersonelTypeRepository PersonelType { get; }

        Task SaveAsync();

        void Save();
    }
}
