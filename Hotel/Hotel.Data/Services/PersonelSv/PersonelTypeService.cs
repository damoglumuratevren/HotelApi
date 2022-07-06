using Hotel.Data.Repositories.IRepo;
using Hotel.Data.Services.IService.IPersonelSv;
using Hotel.Model.Models.PersonelMd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data.Services.PersonelSv
{
    public class PersonelTypeService : Services<PersonelType>, IPersonelTypeService
    {
        public PersonelTypeService(IUnitOfWork unitOfWork, IRepository<PersonelType> repository) : base(unitOfWork, repository)
        {
        }
    }
}
