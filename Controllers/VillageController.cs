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
  public class VillageController : ControllerBase
  {

    private DatabaseContext db;

    public VillageController()
    {
      this.db = new DatabaseContext();
    }
    [HttpGet]
    //This here is my GET search (read).
    public ActionResult<List<Village>> GetAllVillages()
    {
      var results = this.db.Village;
      return results.ToList();
    }
    [HttpPost]
    //This here is my POST create.
    public ActionResult<Village> Post([FromBody] Village newVillage)
    {
      this.db.Village.Add(newVillage);
      this.db.SaveChanges();
      return newVillage;
    }
    [HttpPut]
    //This here is my PUT update.
    public ActionResult<Village> Put([FromBody] Village updateVillage)
    {
      this.db.Village.Update(updateVillage);
      this.db.SaveChanges();
      return updateVillage;
    }
    [HttpDelete]
    //This here wil be my DELETE delete.
    public ActionResult<Village> Delete([FromBody] Village deleteVillage)
    {
      this.db.Village.Remove(deleteVillage);
      this.db.SaveChanges();
      return deleteVillage;
    }

  }
}