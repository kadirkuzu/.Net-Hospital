using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hospital.Models;
using Hospital.API.Repositories.Abstract;
using Hospital.API.Services.Abstract;

namespace Hospital.API.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class Doctors : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public Doctors(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        [HttpGet("")]
        public IEnumerable<Doctor> GetAll()
        {
            return _doctorService.GetAll();
        }

        [HttpGet("id")]
        public async Task<IActionResult> Get(Guid id)
        {
            var doctor = await _doctorService.GetAsync(id);
            return doctor is null ? NotFound() : Ok(doctor) ;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Doctor doctor)
        {
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
