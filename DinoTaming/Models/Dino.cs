namespace DinoTaming.Models;

public class Dino
{
  public int id { get; set; }
  public string type { get; set; }
  public string picture { get; set; }
  public string name { get; set; }
  public int level { get; set; }
  public string CreatorId { get; set; }
  public Account Creator { get; set; }
}
