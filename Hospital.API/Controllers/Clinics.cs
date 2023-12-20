using Hospital.API.Services.Abstract;
using Hospital.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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

        [HttpGet]
        public IEnumerable<ClinicDto> GetAll()
        {
                return _clinicService.GetAll()
                    .Include(x => x.Department)
                    .Include(x=>x.Doctors)
                    .Select(x=>new ClinicDto(x));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var clinic = await _clinicService.AsNoTracking().Include(x => x.Doctors).Include(x=>x.Department).FirstOrDefaultAsync(data => data.Id == id);
            return clinic == null ? NotFound() : Ok(clinic);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddClinicRequest request )
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var clinic = await _clinicService.AsNoTracking().Include(x=>x.Doctors).FirstOrDefaultAsync(data=>data.Id == id) ;
            if(clinic == null) return NotFound();
            if (clinic.Doctors.Count > 0)
            {
                return NotFound("There are doctors working in the clinic. Remove them remove clinic.");
            }
            _clinicService.Remove(clinic);
            await _clinicService.SaveAsync();
            return Ok(clinic.Id);
        }
    }
}
