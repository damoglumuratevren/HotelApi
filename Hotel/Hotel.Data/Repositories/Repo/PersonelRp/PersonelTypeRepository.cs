using Hotel.Data.Repositories.IRepo.IPersonelRp;
using Hotel.Model.Models.PersonelMd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data.Repositories.Repo.PersonelRp
{
    public class PersonelTypeRepository : Repository<PersonelType>, IPersonelTypeRepository
    {
        private ApplicationDbContext _context;

        public PersonelTypeRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;

        }
    }
}
