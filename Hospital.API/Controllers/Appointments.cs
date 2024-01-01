using Hospital.API.Services.Abstract;
using Hospital.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Hospital.Models.Hospital.RequestDto.Appointment;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Hospital.Models.Hospital.ResponseDto;
using Hospital.API.Services.Concrete;
using Microsoft.EntityFrameworkCore;
using Hospital.Models.Common;

namespace Hospital.API.Controllers
{
    [Route("api/appointments")]
    [ApiController]
    public class Appointments : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IDoctorService _doctorService;

        public Appointments(IAppointmentService appointmentService, IDoctorService doctorService)
        {
            _appointmentService = appointmentService;
            _doctorService = doctorService;
        }

        [Authorize]
        [HttpGet("")]
        public IEnumerable<GetAppointmentResponseDto> GetAll()
        {
            return _appointmentService.GetAll().Include(x=>x.Doctor).Select(x => new GetAppointmentResponseDto(x));
        }
        [Authorize]
        [HttpGet("only-patient")]
        public IEnumerable<GetAppointmentResponseDto> GetAllPatients()
        {
            var patient = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return _appointmentService.GetAll().Where(x=>x.PatientId == Guid.Parse(patient)).Include(x=>x.Doctor).Select(x => new GetAppointmentResponseDto(x));
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var appointment = await _appointmentService.AsNoTracking().Include(x => x.Doctor).FirstOrDefaultAsync(data => data.Id == id);
            return appointment == null ? NotFound() : Ok(new GetAppointmentResponseDto(appointment));
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddAppointmentRequestDto request)
        {
            var patient = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (patient == null)
            {
                return NotFound("Patient is not found");
            }
            var doctor = await _doctorService.GetAsync(request.DoctorId ?? new Guid());
            if (doctor == null)
            {
                return NotFound("Doctor is not found");
            }
            var appointment = new Appointment(request,new Guid(patient));
            await _appointmentService.AddAsync(appointment);
            await _appointmentService.SaveAsync();
            return Ok(appointment);
        }


        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var appointment = await _appointmentService.AsNoTracking().FirstOrDefaultAsync(data => data.Id == id);
            if (appointment != null)
            {
                _appointmentService.Remove(appointment);
                await _appointmentService.SaveAsync();
                return Ok(new ValueDto(appointment.Id));
            }
            return NotFound();
        }
    }
}
