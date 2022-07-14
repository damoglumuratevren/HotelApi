using AutoMapper;
using Hotel.Data.Services.IService.IPersonelSv;
using Hotel.Model.Dtos.PersonelDt;
using Hotel.Model.Models.PersonelMd;
using Microsoft.AspNetCore.Mvc;
using NUlid;

namespace Hotel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonelTypeController : ControllerBase
    {
        private readonly IPersonelTypeService _personelTypeService;
        private readonly IMapper _mapper;

        public PersonelTypeController(IPersonelTypeService personelTypeService, IMapper mapper)
        {
            _personelTypeService = personelTypeService;
            _mapper = mapper;   
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var personelType = await _personelTypeService.GetAll(null);
            var personelTypeDto = _mapper.Map<IEnumerable<PersonelTypeDto>>(personelType);
            return Ok(personelTypeDto); 
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get(string id)
        {
            var personeltype= await _personelTypeService.Get(id);
            var personelTypeDto = _mapper.Map<PersonelTypeDto>(personeltype);
            return Ok(personelTypeDto);
        }
        [HttpPost]
        public async Task<IActionResult> PersonelTypeAdd(PersonelTypeDto personelTypeDto)
        {
            //personelTypeDto.Id = Ulid.NewUlid().ToString();

            var personelType = _mapper.Map<PersonelType>(personelTypeDto);
            personelType.Id = Ulid.NewUlid().ToString();
            personelType.CreatedId = "01ASB2XFCZJY7WHZ2FNRTMQJCT";
            personelType.CreatedDtm=DateTime.Now;
            var newPersonelType = await _personelTypeService.Add(personelType);
            return Created(String.Empty, _mapper.Map<PersonelTypeDto>(newPersonelType));
           // return Created(String.Empty,newPersonelType);

        }

    }
}
