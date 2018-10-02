using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StatlerWaldorf.TeamService.Models;

namespace StatlerWaldorf.TeamService.Controllers
{
    [Produces("application/json")]
    public class TeamsController : Controller
    {
        public TeamsController()
        {

        }
        [HttpGet]
        [Route("api/Teams/all")]
        public IEnumerable<Team> GetAllTeams()
        {
            return new Team[] { new Team("one"), new Team("two") };
        }
    }
}