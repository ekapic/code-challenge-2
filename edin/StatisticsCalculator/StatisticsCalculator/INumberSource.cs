using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge2
{
    public interface INumberSource
    {
        IEnumerable<int> GetNumbers();
    }
}
