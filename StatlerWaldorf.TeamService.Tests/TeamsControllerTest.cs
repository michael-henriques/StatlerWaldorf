using StatlerWaldorf.TeamService.Controllers;
using StatlerWaldorf.TeamService.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace StatlerWaldorf.TeamService.Tests
{
    public class TeamsControllerTest
    {
        TeamsController controller = new TeamsController();

        [Fact]
        public void QueryTeamListReturnCorrectTeams()
        {
            List<Team> teams = new List<Team>(controller.GetAllTeams());
        }

        [Fact]
        public void QueryTwoTeamsReturned()
        {
            List<Team> teams= new List<Team>(controller.GetAllTeams());
            Assert.Equal(2,teams.Count);
        }
            
    }
}
