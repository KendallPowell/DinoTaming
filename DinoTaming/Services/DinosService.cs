namespace DinoTaming.Services;

public class DinosService
{
  private readonly DinoRepository _repo;

  public DinosService(DinoRepository repo)
  {
    _repo = repo;
  }

  internal DinosService Create(Dino dinoData)
  {
    Dino dino = _repo.Create(dinoData);
  }
}
