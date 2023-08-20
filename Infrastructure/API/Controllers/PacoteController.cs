using Adapters.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PacoteController : ControllerBase
{
    private readonly Adapters.Interfaces.IPacoteController _pacoteController;
    public PacoteController(Adapters.Interfaces.IPacoteController pacoteController)
    {
        _pacoteController = pacoteController;

    }

    [HttpPost]
    public ActionResult<PacoteResponse> CreatePacote(PacoteRequest pacote)
    {
        return _pacoteController.CreatePacote(pacote);
    }
}
