using Hotel.Data.Repositories.IRepo;
using Hotel.Data.Repositories.IRepo.IPersonelRp;
using Hotel.Data.Repositories.Repo.PersonelRp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data.Repositories.Repo
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
        public IPersonelTypeRepository PersonelType => new PersonelTypeRepository(_context);

        public void Dispose()
        {
            _context.Dispose(); 
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
          await  _context.SaveChangesAsync();
        }
    }
}
