using Microsoft.AspNetCore.Mvc;
//10.151.168.208

[ApiController]
[Route("student")]
public class StudentController : ControllerBase
{

    [HttpGet]
    public ActionResult GimmeStudent()
    {
        Student student = new Student();
        student.name = "Edvin";
        student.attractiveness = 0;

        return Ok(student);

    }

}
