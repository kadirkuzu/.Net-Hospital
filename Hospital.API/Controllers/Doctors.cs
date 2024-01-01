using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hospital.Models;
using Hospital.API.Services.Abstract;
using Hospital.Models.Hospital.ResponseDto;
using Hospital.Models.Hospital.RequestDto.Doctor;
using Microsoft.IdentityModel.Tokens;
using Hospital.Models.Hospital.RequestDto;
using Microsoft.AspNetCore.Authorization;

namespace Hospital.API.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class Doctors : ControllerBase
    {
        private readonly IDoctorService _doctorService;
        private readonly IClinicService _clinicService;
        private readonly IAppointmentService _appointmentService;
        private readonly IWorkScheduleService _workScheduleService;

        public Doctors(IDoctorService doctorService , IClinicService clinicService , IAppointmentService appointmentService, IWorkScheduleService workScheduleService)
        {
            _doctorService = doctorService ;
            _clinicService = clinicService ;
            _appointmentService = appointmentService ;
            _workScheduleService = workScheduleService ;
        }

        [HttpGet("")]
        public IEnumerable<GetDoctorResponseDto> GetAll()
        {
            return _doctorService.GetAll()
                .Include(x=>x.Clinic)
                .Include(x=>x.WorkSchedules)
                .Select(x=> new GetDoctorResponseDto(x));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var doctor = await _doctorService.AsNoTracking().Include(x => x.Clinic).Include(x=>x.WorkSchedules).FirstOrDefaultAsync(data => data.Id == id);
            return doctor is null ? NotFound() : Ok(new GetDoctorResponseDto(doctor)) ;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddDoctorRequestDto request)
        {
            var clinic = await _clinicService.GetAsync(request.ClinicId);
            if (clinic == null)
            {
                return NotFound("Clinic is not found");
            }
            var workSchedules = _workScheduleService.FindAll(x=>request.WorkSchedules.Select(x=>Guid.Parse(x)).Contains(x.Id)).ToList();
            if (workSchedules.IsNullOrEmpty())
            {
                return NotFound("Work Schedules are not found");
            }
            var doctor = new Doctor(request,workSchedules);
            await _doctorService.AddAsync(doctor);
            await _doctorService.SaveAsync();
            return Ok(doctor);
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] UpdateDoctorRequestDto request)
        {
            var doctor = await _doctorService.GetAll().Include(x => x.WorkSchedules).FirstOrDefaultAsync(data => data.Id == id);
            if (doctor == null)
            {
                return NotFound();
            }
            var workSchedules = _workScheduleService.FindAll(x => request.WorkSchedules.Select(x => Guid.Parse(x)).Contains(x.Id)).ToList();
            if (workSchedules.IsNullOrEmpty())
            {
                return NotFound("Work Schedules are not found");
            }
            doctor.WorkSchedules?.Clear();
            doctor.WorkSchedules = workSchedules;
            doctor.Name = request.Name;
            doctor.Surname = request.Surname;
            doctor.Email = request.Email;
            doctor.Phone = request.Phone;
            await _doctorService.SaveAsync();
            return Ok(doctor);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var doctor = await _doctorService.AsNoTracking().FirstOrDefaultAsync(data => data.Id == id);
            if (doctor == null) return NotFound();
            var anyAppointment = await _appointmentService.GetAll().AnyAsync(x=>x.DoctorId == id);
            if (anyAppointment)
            {
                return NotFound("The doctor have appointments. Remove them to remove doctor.");
            }
            _doctorService.Remove(doctor);
            await _clinicService.SaveAsync();
            return Ok(id);
        }
    }
}
