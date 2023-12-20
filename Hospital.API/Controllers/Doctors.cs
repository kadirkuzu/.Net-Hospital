using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hospital.Models;
using Hospital.API.Repositories.Abstract;
using Hospital.API.Services.Abstract;
using Azure.Core;
using Hospital.API.Services.Concrete;

namespace Hospital.API.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class Doctors : ControllerBase
    {
        private readonly IDoctorService _doctorService;
        private readonly IClinicService _clinicService;

        public Doctors(IDoctorService doctorService , IClinicService clinicService)
        {
            _doctorService = doctorService;
            _clinicService = clinicService ;
        }

        [HttpGet("")]
        public IEnumerable<DoctorDto> GetAll()
        {
            return _doctorService.GetAll()
                .Include(x=>x.Clinic)
                .Include(x=>x.WorkSchedules)
                .Select(x=> new DoctorDto(x));
        }

        [HttpGet("id")]
        public async Task<IActionResult> Get(Guid id)
        {
            var doctor = await _doctorService.GetAsync(id);
            return doctor is null ? NotFound() : Ok(doctor) ;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddDoctorRequest request)
        {
            var clinic = await _clinicService.GetAsync(request.ClinicId);
            if (clinic == null)
            {
                return NotFound("Clinic is not found");
            }
            var doctor = new Doctor(request);
            await _doctorService.AddAsync(doctor);
            await _doctorService.SaveAsync();
            return Ok(doctor);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
