namespace villagecharacters.Models
{
  public class Characters
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public string Health { get; set; }

    public string Speed { get; set; }

    public string Hitpoints { get; set; }

    //Navigation Properties

    public int VillageId { get; set; }

    public Villages Villages { get; set; }

  }
}