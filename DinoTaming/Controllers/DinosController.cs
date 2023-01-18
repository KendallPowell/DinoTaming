namespace DinoTaming.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DinosController : ControllerBase
{
  private readonly DinosService _dinosService;
  private readonly Auth0Provider _auth0provider;

  public DinosController(DinosService dinosService, Auth0Provider auth0Provider)
  {
    _dinosService = dinosService;
    _auth0provider = auth0Provider;
  }

  [HttpPost]
  [Authorize]
  public async Task<ActionResult<Dino>> Create([FromBody] Dino dinoData)
  {
    try
    {
      Account userInfo = await _auth0provider.GetUserInfoAsync<Account>(HttpContext);
      dinoData.CreatorId = userInfo.Id;
      Dino dino = _dinosService.Create(dinoData);
      dino.Creator = userInfo;
      return Ok(dino);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}
