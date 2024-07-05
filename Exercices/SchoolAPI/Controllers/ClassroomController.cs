using Dal;
using DomainModel;
using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Filters;

namespace SchoolAPI.Controllers
{
    //[Route("Class")]
    [Route("[controller]")]
    [ApiController]
    public class ClassroomController : ControllerBase
    {
        private readonly SchoolContext context;
        public ClassroomController(SchoolContext schoolContext)
        {
            this.context = schoolContext;
        }

        //private static int counter = 3;
        //private static List<Classroom> classrooms = new()
        //{
        //    new Classroom()
        //    {
        //        ClassroomID = 1,
        //        Name = "Salle Bill Gates",
        //        Floor = 2,
        //        Corridor = "Bleu"
        //    },
        //    new Classroom()
        //    {
        //        ClassroomID = 2,
        //        Name = "Salle Satya Nadella",
        //        Floor = 1,
        //        Corridor = "Rouge"
        //    },
        //    new Classroom()
        //    {
        //        ClassroomID = 3,
        //        Name = "Salle Steve Ballmer",
        //        Floor = 0,
        //        Corridor = "Jaune"
        //    }
        //};

        // GET : /classroom
        [HttpGet]
        public IActionResult GetClassrooms()
        {
            return Ok(context.Classrooms);
        }

        // GET : /classroom/5
        [HttpGet("{id}")]
        public IActionResult GetClassroom([FromRoute] int id)
        {
            if (id <= 0)
                return BadRequest();

            var classroom = context.Classrooms.FirstOrDefault(classroom => classroom.ClassroomID == id);

            if (classroom == null)
                return NotFound();

            return Ok(classroom);
        }

        // POST : /classroom (avec body)
        [HttpPost]
        public IActionResult AddClassroom([FromBody] Classroom classroom)
        {
            context.Classrooms.Add(classroom);
            context.SaveChanges();

            return Created($"classroom/{classroom.ClassroomID}", classroom);
        }

        // PUT : /classroom/5 (avec body)
        [HttpPut("{id}")]
        public IActionResult UpdateClassroom([FromRoute] int id, [FromBody] Classroom classroom)
        {
            var classroomToUpdate = context.Classrooms.Find(classroom.ClassroomID);

            if (id <= 0 || id != classroom.ClassroomID)
                return BadRequest();

            if (classroomToUpdate == null)
                return NotFound();

            // mise à jour
            this.context.Classrooms.Update(classroom);

            context.SaveChanges();

            return NoContent();
        }

        // DELETE : /classroom/5
        [HttpDelete("{id}")]
        public IActionResult RemoveClassroom([FromRoute] int id)
        {
            if (id <= 0)
                return BadRequest();

            var classroom = context.Classrooms.Find(id);

            if (classroom == null)
                return NotFound();

            context.Classrooms.Remove(classroom);

            return Ok(classroom);
        }

        // GET : classroom/customerror
        [CustomExceptionFilter]
        [HttpGet("customerror")]
        public IActionResult CustomError()
        {
            throw new NotImplementedException("Méthode non implementé");
            return Ok();
        }
    }
}
