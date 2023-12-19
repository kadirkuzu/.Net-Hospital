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
        public IEnumerable<Clinic> Get()
        {
            return _clinicService.GetAll().Include(x=>x.Department);
        }

        // GET api/<ClinicController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var clinic = await _clinicService.GetAsync(id);
            return clinic == null ? NotFound() : Ok(clinic);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Clinic clinic)
        {
            await _clinicService.AddAsync(clinic);
            await _clinicService.SaveAsync();
            return Ok(clinic);
        }

        // PUT api/<ClinicController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] string value)
        {
        }

        // DELETE api/<ClinicController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
        }
    }
}
