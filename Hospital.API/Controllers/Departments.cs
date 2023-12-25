﻿using Hospital.API.Services.Abstract;
using Hospital.API.Services.Concrete;
using Hospital.Models;
using Hospital.Models.Hospital.RequestDto;
using Hospital.Models.Hospital.ResponseDto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Hospital.API.Controllers
{
    [Route("api/departments")]
    [ApiController]
    public class Departments : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public Departments(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        //[Authorize]
        [HttpGet]
        public IEnumerable<GetDepartmentResponseDto> GetAll()
        {
            return _departmentService.GetAll().Include(x => x.Clinics)!.ThenInclude(x => x.Doctors).Select(x => new GetDepartmentResponseDto(x));
        }

        //[Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var department = await _departmentService.AsNoTracking().Include(x => x.Clinics)!.ThenInclude(x => x.Doctors).FirstOrDefaultAsync(data => data.Id == id);
            return department == null ? NotFound() : Ok(new GetDepartmentResponseDto(department));
        }

        //[Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DepartmentRequestDto departmentRequest)
        {
            var departmentIsAvailable = _departmentService.FindAsync(x=>x.Name == departmentRequest.Name);
            if (departmentIsAvailable != null) {
                return NotFound("Department is available");    
            }
            var department = new Department(departmentRequest.Name);
            await _departmentService.AddAsync(department);
            await _departmentService.SaveAsync();
            return Ok(department);
        }

        //[Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] DepartmentRequestDto departmentRequest)
        {
            var department = await _departmentService.GetAsync(id);
            if (department == null)
            {
                return NotFound();
            }
            department.Name = departmentRequest.Name;
            await _departmentService.SaveAsync();
            return Ok(department);
        }

        //[Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var department = await _departmentService.AsNoTracking().Include(x => x.Clinics).FirstOrDefaultAsync(data => data.Id == id);

            if (department != null)
            {
                if (department!.Clinics?.Count > 0)
                {
                    return NotFound("There are clinics in the department. Remove them remove department.");
                }
                _departmentService.Remove(department);
                await _departmentService.SaveAsync();
                return Ok(department.Id);
            }
            return NotFound();
        }
    }
}
