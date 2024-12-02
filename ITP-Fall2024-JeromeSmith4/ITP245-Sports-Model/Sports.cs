using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ITP245_Sports_Model
{
    public interface ISports
    {
        string Name { get; }
    }
    [MetadataType(typeof(Game.GameMetadata))]
    public partial class Game
    {
        private sealed class @GameMetadata
        {
            [Display(Name = "HomeTeam")]
            public int HomeTeamID { get; }

            [Display(Name = "VisitorTeam")]

            public int VisitorTeamID { get; }

            [Display(Name = "Status")]
            public int StatusId { get; }
        }
    }

    public partial class Team : ISports { }

    public partial class Player : ISports
    {
        public string Name => $"{LastName}, {FirstName}";

    }
}
