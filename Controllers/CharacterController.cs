using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using villagecharacters.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace villagecharacters.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CharacterController : ControllerBase
  {
    private DatabaseContext db;

    public CharacterController()
    {
      this.db = new DatabaseContext();
    }
    [HttpGet]
    //This here is my GET search (read).
    public ActionResult<List<Character>> GetAllCharacters()
    {
      var results = this.db.Character;
      return results.ToList();
    }
    [HttpPost]
    //This here is my POST create.
    public ActionResult<Character> Post([FromBody] Character newCharacter)
    {
      this.db.Character.Add(newCharacter);
      this.db.SaveChanges();
      return newCharacter;
    }
    [HttpPut]
    //This here is my PUT update.
    public ActionResult<Character> Put([FromBody] Character updateCharacter)
    {
      this.db.Character.Update(updateCharacter);
      this.db.SaveChanges();
      return updateCharacter;
    }
    [HttpDelete]
    //This here wil be my DELETE delete.
    public ActionResult<Character> Delete([FromBody] Character deleteCharacter)
    {
      this.db.Character.Remove(deleteCharacter);
      this.db.SaveChanges();
      return deleteCharacter;
    }
  }
}