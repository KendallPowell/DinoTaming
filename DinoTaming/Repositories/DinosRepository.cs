namespace DinoTaming.Repositories;
public class DinoRepository
{
  private readonly IDbConnection _db;
  public DinosRepository(IDbConnection db)
  {
    _db = db;
  }

  internal Dino Create(Dino dinoData)
  {
    string sql = @"
    INSERT INTO dinos
    (name, type, level, picture)
    VALUES
    (@name, @type, @level, @picture);
    SELECT LAST_INSERT_ID();
    ";
    int id = _db.ExecuteScalar<int>(sql, dinoData);
    dinoData.id = id;
    return dinoData;
  }
}