using Hospital.API.Services.Abstract;
using Hospital.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hospital.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Departments : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public Departments(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        public IEnumerable<Department> Get()
        {
            return _departmentService.GetAll();
        }

        // GET api/<Departmens>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var department =  await _departmentService.GetAsync(id);
            return department == null ? NotFound() : Ok(department);
        }

        // POST api/<Departmens>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Department department)
        {
            await _departmentService.AddAsync(department);
            await _departmentService.SaveAsync();
            return Ok(department);
        }

        // PUT api/<Departmens>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Departmens>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
