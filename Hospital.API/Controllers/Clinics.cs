using Hospital.API.Services.Abstract;
using Hospital.Models;
using Hospital.Models.Common;
using Hospital.Models.Hospital.RequestDto.Clinic;
using Hospital.Models.Hospital.ResponseDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital.API.Controllers
{
    [Route("api/clinics")]
    [ApiController]
    public class Clinics : ControllerBase
    {
        private readonly IClinicService _clinicService;
        private readonly IDepartmentService _departmentService;

        public Clinics(IClinicService clinicService , IDepartmentService departmentService)
        {
            _clinicService = clinicService;
            _departmentService = departmentService;
        }

        //[Authorize]
        [HttpGet]
        public IEnumerable<GetClinicResponseDto> GetAll()
        {
                return _clinicService.GetAll()
                    .Include(x => x.Department)
                    .Include(x=>x.Doctors)
                    .Select(x=>new GetClinicResponseDto(x));
        }

        //[Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var clinic = await _clinicService.AsNoTracking().Include(x => x.Doctors).Include(x=>x.Department).FirstOrDefaultAsync(data => data.Id == id);
            return clinic == null ? NotFound() : Ok(new GetClinicResponseDto(clinic));
        }

        //[Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddClinicRequestDto request )
        {
            var department = await _departmentService.GetAsync(request.DepartmentId);
            if(department == null)
            {
                return NotFound("Department is not found");
            }
            var clinic = new Clinic(request.Name,request.DepartmentId);
            await _clinicService.AddAsync(clinic);
            await _clinicService.SaveAsync();
            clinic.Department = department;
            return Ok(clinic);
        }

        //[Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid? id, [FromBody] Clinic updateClinic)
        {
            if (id == null)
            {
                return NotFound();
            }
            var clinic = await _clinicService.GetAsync((Guid)id);
            if (clinic == null)
            {
                return NotFound();
            }
            clinic = updateClinic;
            return Ok(clinic);
        }

        //[Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var clinic = await _clinicService.AsNoTracking().Include(x=>x.Doctors).FirstOrDefaultAsync(data=>data.Id == id) ;
            if(clinic != null)
            {
                if (clinic!.Doctors?.Count > 0)
                {
                    return NotFound("There are doctors working in the clinic. Remove them remove clinic.");
                }
                _clinicService.Remove(clinic);
                await _clinicService.SaveAsync();
                return Ok(new ValueDto(clinic.Id)) ;
            }
            return NotFound();
        }
    }
}
