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

        public Clinics(IClinicService clinicService)
        {
            _clinicService = clinicService;
        }

        [HttpGet]
        public IEnumerable<Clinic> GetAll()
        {
            return _clinicService.GetAll().Include(x=>x.Department);
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
            var clinic = new Clinic(request.Name,request.DepartmentId);
            await _clinicService.AddAsync(clinic);
            await _clinicService.SaveAsync();
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
