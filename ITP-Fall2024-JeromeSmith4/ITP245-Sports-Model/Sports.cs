using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP245_Sports_Model
{
    public interface ISports
    {
         string Name { get; }
    }

    public partial class Team : ISports { }

    public partial class Player : ISports 
    {
        public string Name => $"{LastName}, {FirstName}";
    }
}
