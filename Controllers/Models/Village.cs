using System.Collections.Generic;

namespace villagecharacters.Models
{
  public class Village
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public string VillageLevel { get; set; }

    public string TroopCapacity { get; set; }

    public string NumberOfWalls { get; set; }

    //Navigation Properties
    public List<Character> Character { get; set; } = new List<Character>();
  }
}