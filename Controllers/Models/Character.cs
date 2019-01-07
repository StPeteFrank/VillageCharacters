using System.Collections.Generic;

namespace villagecharacters.Models
{
  public class Character
  {
    public int Id { get; set; }

    public string Name { get; set; }

    public string Health { get; set; }

    public string Speed { get; set; }

    public string Hitpoints { get; set; }


    //Navigation Properties


    public int VillageId { get; set; }

    public Village Village { get; set; }


  }
}