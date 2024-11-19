using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP245_Agile_Model
{
    public interface IAgile
    {
        string Name { get; }
    }

    public partial class Project : IAgile { }
    public partial class Student : IAgile
    {
        public string Name => $"{LastName}, {FirstName}";
    }

}
