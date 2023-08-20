using Adapters.DTOs;
using Database;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PacoteController : ControllerBase
{
    private readonly Adapters.Interfaces.IPacoteController _pacoteController;
    private readonly DataContext _dbContext;
    public PacoteController(Adapters.Interfaces.IPacoteController pacoteController, DataContext dataContext)
    {
        _dbContext = dataContext;
        _pacoteController = pacoteController;

    }

    [HttpPost]
    public ActionResult<PacoteResponse> CreatePacote(PacoteRequest pacote)
    {
        _dbContext.SaveChanges();
        return _pacoteController.CreatePacote(pacote, _dbContext);
    }
}
