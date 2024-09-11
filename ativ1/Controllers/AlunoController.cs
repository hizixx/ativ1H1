using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class AlunoController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateAluno([FromBody] Aluno aluno)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        // Lógica para salvar o aluno

        return Ok(aluno);
    }
}
