using Hospital.API.Services.Abstract;
using Hospital.API.Services.Concrete;
using Hospital.Models;
using Hospital.Models.Common;
using Hospital.Models.Hospital.RequestDto.Clinic;
using Hospital.Models.Hospital.RequestDto.WorkSchedules;
using Hospital.Models.Hospital.ResponseDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital.API.Controllers
{
    [Route("api/work-schedules")]
    [ApiController]
    public class WorkSchedules : ControllerBase
    {
        private readonly IWorkScheduleService _workScheduleService;
        public WorkSchedules(IWorkScheduleService workScheduleService)
        {
            _workScheduleService = workScheduleService;
        }

        [Authorize]
        [HttpGet]
        public IEnumerable<GetWorkScheduleResponseDto > GetAll()
        {
            return _workScheduleService.GetAll().Include(x=>x.Doctors).OrderBy(x=>x.Day).ThenBy(x=>x.StartTime).Select(x => new GetWorkScheduleResponseDto(x));
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddWorkScheduleRequestDto request)
        {
            var workScheduleIsAvailable = await _workScheduleService.FindAsync(x => x.Day == request.Day && x.StartTime == request.StartTime && x.EndTime == request.EndTime);
            if (workScheduleIsAvailable != null)
            {
                return BadRequest(new { Message = "Work Schedule already exists." });
            }
            var workSchedule = new WorkSchedule(request);
            await _workScheduleService.AddAsync(workSchedule);
            await _workScheduleService.SaveAsync();
            return Ok(workSchedule);
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var workSchedule = await _workScheduleService.AsNoTracking().Include(x => x.Doctors).FirstOrDefaultAsync(data => data.Id == id);
            if (workSchedule != null)
            {
                if (workSchedule!.Doctors?.Count > 0)
                {
                    return BadRequest(new { Message = "There are doctors working work schedule. Remove them to remove clinic." });
                }
                _workScheduleService.Remove(workSchedule);
                await _workScheduleService.SaveAsync();
                return Ok(new ValueDto(workSchedule.Id));
            }
            return NotFound();
        }
    }
}
