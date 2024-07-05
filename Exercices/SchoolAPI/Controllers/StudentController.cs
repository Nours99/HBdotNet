using Dal;
using DomainModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly SchoolContext context;

        public StudentController(SchoolContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(this.context.Students.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent([FromRoute] int id)
        {
            if (id <= 0)
                return BadRequest("id incorrect");

            var student = this.context.Students.Find(id);

            if (student == null)
                return NotFound();

            return Ok(student);
        }

        [HttpPost]
        public IActionResult AddStudent([FromBody] Student student)
        {
            this.context.Students.Add(student);
            this.context.SaveChanges();

            return Created($"student/{student.PersonID}", student);
        }

        [HttpPut("{id}")]
        public IActionResult EditStudent([FromRoute] int id, [FromBody] Student student)
        {
            if (id != student.PersonID)
                return BadRequest();

            this.context.Students.Update(student);
            this.context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveStudent([FromRoute] int id)
        {
            if (id <= 0)
                return BadRequest();

            var student = this.context.Students.Find(id);

            if (student == null)
                return NotFound();

            this.context.Students.Remove(student);
            this.context.SaveChanges();

            return Ok(student);
        }
    }
}
