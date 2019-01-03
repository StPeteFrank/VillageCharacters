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

  }
}