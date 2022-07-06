using AutoMapper;
using Hotel.Data.Services.IService.IPersonelSv;
using Hotel.Model.Dtos.PersonelDt;
using Microsoft.AspNetCore.Mvc;

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
    }
}
